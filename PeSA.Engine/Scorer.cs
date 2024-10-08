using PeSA.Engine.Data_Structures;

namespace PeSA.Engine
{
    public class Scorer
    {        public Motif Motif { get; set; }
        public List<Protein> ProteinList { get; set; }
        public List<string> PeptideList { get; set; }
        public List<Score> ScoreList { get; set; }
        public bool StopScoringRequested { get; set; } = false;
        public double? UserEnteredPosThreshold { get; set; }
        public double? UserEnteredNegThreshold { get; set; }

        public int PosMatchCutoff { get; set; } = -1;
        public int NegMatchCutoff { get; set; } = 20;

        public char KeyChar { get; set; } = ' ';
        private int keyPosition = -1;
        /// <summary>
        /// Key position and character used in scoring
        /// O-indexed
        /// </summary>
        public int KeyPosition
        {
            get { return keyPosition; }
            set
            {
                if (value >= 0 && value < Motif.PeptideLength)
                {
                    keyPosition = value;
                    KeyChar = Motif.GetKeyChar(keyPosition);
                }
                else
                {
                    keyPosition = -1;
                    KeyChar = ' ';
                }
            }
        }

        private int fullPos = 0;
        private Score GetScore(string peptide, string inputSegment, int startpos = 0)
        {
            try
            {
                Score s = new(peptide, inputSegment, startpos);
                int endpos = Math.Min(inputSegment.Length + startpos - 1, Motif.PeptideLength - 1);
                for (int pos = startpos; pos <= endpos; pos++)
                {
                    char aa = inputSegment[pos - startpos];
                    if (aa == 'x' || aa == 'X') continue;
                    Dictionary<char, double> posWeights = Motif.PositiveColumns?[pos]?? Motif.Frequencies[pos];
                    Dictionary<char, double> negWeights = Motif.NegativeColumns?[pos];
                    if (posWeights.TryGetValue(aa, out double posWeight))
                    {
                        if (UserEnteredPosThreshold != null && posWeight < UserEnteredPosThreshold)
                            continue;
                        s.posMatch++;
                        s.weightedMatch += posWeight;
                        s.priorityMatch += posWeight / posWeights.Count;
                    }
                    else if (negWeights!=null && negWeights.TryGetValue(aa, out double negWeight))
                    {
                        if (UserEnteredNegThreshold != null && negWeight < UserEnteredNegThreshold)
                            continue;
                        s.negMatch++;
                        if (UserEnteredNegThreshold != null && UserEnteredNegThreshold < Motif.NegativeThreshold)
                            negWeight -= (Motif.NegativeThreshold - (double)UserEnteredNegThreshold);
                        s.weightedMatch -= negWeight;
                        s.priorityMatch -= negWeight / negWeights.Count;
                    }
                }
                return s;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        public List<Score> ScoreSequence(string inputSeq, Action<int> progressCallback, string proteinName=null)
        {
            List<Score> scores = new();
            int startInd = 0;
            if (KeyChar == ' ' || KeyPosition < 0) //check for all segments, no target position check
            {
                while (startInd <= inputSeq.Length - Motif.PeptideLength)
                {
                    string segment = inputSeq.Substring(startInd, Motif.PeptideLength);
                    Score s = GetScore(proteinName ?? inputSeq, segment, 0);
                    
                    if (s != null && s.posMatch >= PosMatchCutoff && s.negMatch <= NegMatchCutoff)
                        scores.Add(s);
                    s.StartPos = startInd + 1;
                    startInd++;
                    fullPos++;
                    progressCallback?.Invoke(fullPos);//protein scoring
                }
            }
            else
            {
                while (startInd < inputSeq.Length)
                {
                    int ind = inputSeq.IndexOf(KeyChar, startInd);
                    if (ind < 0)
                    {
                        fullPos += inputSeq.Length - startInd;
                        break;
                    }
                    fullPos += (ind - startInd);
                    int startPos = 0;
                    string segment;
                    int relPos = startInd + 1;
                    if (ind + Motif.PeptideLength - keyPosition <= inputSeq.Length)
                        segment = inputSeq[..(ind + Motif.PeptideLength - keyPosition)];
                    else
                        segment = inputSeq;
                    if (ind < keyPosition)
                        startPos = keyPosition - ind;
                    else if (ind > keyPosition)
                    {
                        relPos = ind - keyPosition;
                        segment = segment[(ind - keyPosition)..];
                    }
                    Score s = GetScore(proteinName ?? inputSeq, segment, startPos);
                    if (s != null && s.posMatch >= PosMatchCutoff && s.negMatch <= NegMatchCutoff)
                        scores.Add(s);
                    startInd = ind + 1;
                    if (progressCallback != null)//protein scoring
                    {
                        s.StartPos = relPos + 1;
                        progressCallback(fullPos);
                    }
                }
            }
            return scores;
        }

        public List<Score> ScorePeptideList(Action progressCallback)
        {
            if (PeptideList == null) return null;
            ScoreList = new List<Score>();
            foreach (string p in PeptideList)
            {
                if (StopScoringRequested) break;
                progressCallback();
                List<Score> scores = ScoreSequence(p, null);
                ScoreList.AddRange(scores);
            }
            return ScoreList;
        }
        public List<Score> ScoreProteinList(Action<int> progressCallback)
        {
            if (ProteinList == null) return null;
            fullPos = 0;
            ScoreList = new List<Score>();
            foreach (Protein p in ProteinList)
            {
                if (StopScoringRequested) break;
                List<Score> scores = ScoreSequence(p.AASequence, progressCallback, p.Caption);
                ScoreList.AddRange(scores);
            }
            return ScoreList;
        }


    }
}
