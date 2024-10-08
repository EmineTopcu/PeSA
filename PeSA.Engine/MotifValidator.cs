namespace PeSA.Engine
{
    public class MotifValidator
    {
        public Motif Motif;
        public int PositiveSpecificity { get; set; }
        public int NegativeSpecificity { get; set; }

        public string FullTemplate { get; set; }
        public string PositiveTemplate { get; set; }

        List<string> FullSequenceList;
        public List<string> PositiveSequenceList { get; set; }
        public List<string> NegativeSequenceList { get; set; }
        public int Count
        {
            get { return FullSequenceList?.Count ?? 0; }
        }
        public MotifValidator()
        {
        }

        public bool GenerateTemplate()
        {
            if (Motif == null) return false;
            FullTemplate = "";
            PositiveTemplate = "";
            for (int pos = 0; pos < Motif.PeptideLength; pos++)
            {
                string substr = "";
                if (Motif.PositiveColumns != null && Motif.PositiveColumns[pos].Count <= PositiveSpecificity)
                    substr = string.Concat(Motif.PositiveColumns[pos].Keys);
                else if (Motif.Frequencies != null && Motif.Frequencies[pos].Count <= PositiveSpecificity)
                    substr = string.Concat(Motif.Frequencies[pos].Keys);
                if (substr == "" && Motif.WildTypePeptide != null)
                    substr = Motif.WildTypePeptide[pos].ToString();
                if (substr.Length > 1)
                    PositiveTemplate += "[" + substr + "]";
                else
                    PositiveTemplate += substr;
                if (Motif.NegativeColumns != null && Motif.NegativeColumns[pos].Count <= NegativeSpecificity)
                    substr = string.Concat(Motif.NegativeColumns[pos].Keys);
                if (substr.Length > 1)
                    substr = "[" + substr + "]";
                FullTemplate += substr;
            }
            return true;
        }

        public bool Run(Motif motif, int posSpec, int negSpec)
        {
            if (motif == null) return false;
            Motif = motif;
            PositiveSpecificity = posSpec;
            NegativeSpecificity = negSpec;
            if (!GenerateTemplate()) return false;
            FullSequenceList = SequenceGenerator.Combinations(FullTemplate);
            PositiveSequenceList = SequenceGenerator.Combinations(PositiveTemplate);
            NegativeSequenceList = FullSequenceList.Except(PositiveSequenceList).ToList();
            return true;
        }
    }
}
