using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeSA.Engine
{
    public class PermutationArray
    {
        public string WildTypePeptide { get; set; }
        public int RowCount { get; set; }
        public int ColCount { get; set; }
        public bool WildTypeAxisExists { get; set; }
        public bool PermutationXAxis { get; set; }
        public bool WildTypeYAxisTopToBottom { get; set; }
        public string[,] PeptideMatrix { get; set; }
        public double[,] QuantificationMatrix { get; set; }
        public double[,] NormalizedMatrix { get; set; }
        public double[] NormBy;
        public char[] Permutation;

        public double Threshold { get; set; }

        public List<string> ModifiedPeptides { get; set; }
        public Dictionary<string, double> PeptideWeights { get; set; }

        private void GenerateMatrices(string[,] values, out List<string> warnings, out string error)
        {
            error = "";
            warnings = new List<string>();
            if (values == null) return;
            try
            {
                RowCount = values.GetLength(0) - 1;
                ColCount = values.GetLength(1) - 1;
                PeptideMatrix = new string[RowCount, ColCount];
                QuantificationMatrix = new double[RowCount, ColCount];
                NormalizedMatrix = new double[RowCount, ColCount];

                bool nswwarning = false;
                bool nspwarning = false;
                //Generate Permutation and Wildtype arrays
                if (PermutationXAxis)
                {
                    NormBy = new double[RowCount];
                    for (int iRow = 1; iRow <= RowCount; iRow++)
                    {
                        string s = values[iRow, 0].Trim();
                        if (AminoAcids.GetAminoAcid(s[0]) == null)
                        {
                            if (s.Length == 1)
                            {
                                if (!nswwarning)
                                    warnings.Add("Non-standard amino acid in wildtype peptide.");
                                nswwarning = true;
                            }
                            else
                            {
                                error = "Not a valid wildtype peptide";
                                return;
                            }
                        }
                        if (WildTypeYAxisTopToBottom)
                            WildTypePeptide += s[0];
                        else
                            WildTypePeptide = s[0] + WildTypePeptide; //read from bottom to top

                    }
                    Permutation = new char[ColCount];
                    for (int iCol = 1; iCol <= ColCount; iCol++)
                    {
                        string s = values[0, iCol].Trim();
                        if (AminoAcids.GetAminoAcid(s[0]) == null)
                        {
                            if (s.Length == 1)
                            {
                                if (!nspwarning)
                                    warnings.Add("Non-standard amino acid in permutation string.");
                                nspwarning = true;
                            }
                            else
                            {
                                error = "Not a valid permutation string";
                                return;
                            }
                        }
                        Permutation[iCol - 1] = s[0];
                    }
                }
                else //if(PermutationYAxis)
                {
                    NormBy = new double[ColCount];
                    for (int iCol = 1; iCol <= ColCount; iCol++)
                    {
                        string s = values[0, iCol].Trim();
                        if (AminoAcids.GetAminoAcid(s[0]) == null)
                        {
                            if (s.Length == 1)
                            {
                                if (!nswwarning)
                                    warnings.Add("Non-standard amino acid in wildtype peptide.");
                                nswwarning = true;
                            }
                            else
                            {
                                error = "Not a valid wildtype peptide";
                                return;
                            }
                        }
                        WildTypePeptide += s[0];
                    }

                    Permutation = new char[RowCount];
                    for (int iRow = 1; iRow <= RowCount; iRow++)
                    {
                        string s = values[iRow, 0].Trim();
                        if (AminoAcids.GetAminoAcid(s[0]) == null)
                        {
                            if (s.Length == 1)
                            {
                                if (!nspwarning)
                                    warnings.Add("Non-standard amino acid in permutation string.");
                                nspwarning = true;
                            }
                            else
                            {
                                error = "Not a valid permutation string";
                                return;
                            }
                        }
                        Permutation[iRow - 1] = s[0];
                    }
                }


                //Generate Matrices and Normalization values
                int wtl = WildTypePeptide.Length;

                int counter = 0;
                double totalNorm = 0;
                for (int iRow = 0; iRow < RowCount; iRow++)
                    for (int iCol = 0; iCol < ColCount; iCol++)
                    {
                        if (double.TryParse(values[iRow + 1, iCol + 1], out double d))
                            QuantificationMatrix[iRow, iCol] = d;
                        else if (string.IsNullOrEmpty(values[iRow + 1, iCol + 1]))
                            d = 0;
                        else
                        {
                            error = "Wrongly formatted data.";
                            return;
                        }

                        if (PermutationXAxis) //wildTypeYAxis
                        {
                            if (WildTypeYAxisTopToBottom)
                                PeptideMatrix[iRow, iCol] = (iRow >= 1 ? WildTypePeptide.Substring(0, iRow) : "") + Permutation[iCol] + (iRow < WildTypePeptide.Length - 1 ? WildTypePeptide.Substring(iRow + 1) : "");
                            else  //from bottom to top
                                PeptideMatrix[iRow, iCol] = (iRow < wtl - 1 ? WildTypePeptide.Substring(0, wtl - iRow - 1) : "") + Permutation[iCol] + (iRow > 0 ? WildTypePeptide.Substring(wtl - iRow) : "");
                           }
                        else
                            PeptideMatrix[iRow, iCol] = (iCol >= 1 ? WildTypePeptide.Substring(0, iCol) : "") + Permutation[iRow] + (iCol < WildTypePeptide.Length - 1 ? WildTypePeptide.Substring(iCol + 1) : "");
       
                        if (PeptideMatrix[iRow, iCol] == WildTypePeptide)
                        {
                            if (d > 0)
                            {
                                counter++;
                                totalNorm += d;
                            }
                            if (PermutationXAxis)
                                NormBy[iRow] = d;
                            else
                                NormBy[iCol] = d;
                        }
                    }
                if (counter > 0 && counter < NormBy.GetLength(0)) //fill the blanks with average
                {
                    for (int i = 0; i < NormBy.GetLength(0); i++)
                    {
                        if (NormBy[i] < 0.0001)
                            NormBy[i] = totalNorm / counter;
                    }
                }
                for (int iRow = 0; iRow < RowCount; iRow++)
                    for (int iCol = 0; iCol < ColCount; iCol++)
                    {
                        double normby = PermutationXAxis ? NormBy[iRow] : NormBy[iCol];
                        if (normby != 0)
                            NormalizedMatrix[iRow, iCol] = QuantificationMatrix[iRow, iCol] / normby;
                    }
            }
            catch (Exception exc)
            {
                error = "Unhandled exception: " + exc.Message;
            }
        }

         public PermutationArray(string[,] values, bool permutationXAxisIn, bool wildtypeYAxisTopToBottom, out List<string> warnings, out string error)
        {
            error = "";
            warnings = new List<string>();
            try
            {
                ModifiedPeptides = new List<string>();
                PeptideWeights = new Dictionary<string, double>();
                PermutationXAxis = permutationXAxisIn;
                WildTypeYAxisTopToBottom = wildtypeYAxisTopToBottom;

                GenerateMatrices(values, out warnings, out error);
                if (error != "") return;
            }
            catch (Exception exc)
            {
                error = "Unhandled exception: " + exc.Message;
            }
        }

        public static void CheckPermutationAxis(string[,] values, ref bool xPossible, ref bool yPossible)
        {
            if (values == null) return;
            xPossible = yPossible = true;
            int rowCount = values.GetLength(0) - 1;
            int colCount = values.GetLength(1) - 1;
            List<char> aaList = new List<char>();
            for (int iCol = 1; iCol <= colCount; iCol++)
            {
                string s = values[0, iCol]?.Trim() ?? "";
                if (string.IsNullOrEmpty(s) || aaList.Contains(s[0]))
                {
                    xPossible = false;
                    break;
                }
                aaList.Add(s[0]);
            }
            aaList.Clear();
            for (int iRow = 1; iRow <= rowCount; iRow++)
            {
                string s = values[iRow, 0]?.Trim() ?? "";
                if (string.IsNullOrEmpty(s) || aaList.Contains(s[0]))
                {
                    yPossible = false;
                    break;
                }
                aaList.Add(s[0]);
            }
        }

        public void ClearModifiedPeptides()
        {
            ModifiedPeptides?.Clear();
            PeptideWeights?.Clear();
        }
        public void AddModifiedPeptide(string peptide, double weight)
        {
            if (string.IsNullOrEmpty(peptide))
                return;
            if (peptide == WildTypePeptide && ModifiedPeptides.Contains(peptide))
                return;
            ModifiedPeptides.Add(peptide);
            PeptideWeights.Add(peptide, weight);
        }

        public static PermutationArray ReadFromFile(string filename)
        {
            try
            {
                PermutationArray PA = null;
                if (File.Exists(filename))
                    PA = JsonConvert.DeserializeObject<PermutationArray>(File.ReadAllText(filename));

                return PA;
            }
            catch { return null; }
        }

        public static bool SaveToFile(string filename, PermutationArray PA)
        {
            try
            {
                string json = JsonConvert.SerializeObject(PA);
                File.WriteAllText(filename, json);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// Dictionary of weight for each char at every position, setting the value of 1 to wildtype aminoacid
        /// </summary>
        /// <param name="PA"></param>
        /// <returns></returns>
        public Dictionary<int, Dictionary<char, double>> GenerateWeights()
        {
            try
            {
                Dictionary<int, double> totalWeightsPerPos;
                Dictionary<int, Dictionary<char, double>> weights;
                int pepsize = ModifiedPeptides[0].Length;

                totalWeightsPerPos = new Dictionary<int, double>();
                weights = new Dictionary<int, Dictionary<char, double>>();
                for (int i = 0; i < pepsize; i++)
                {
                    totalWeightsPerPos.Add(i, 0);
                    weights.Add(i, new Dictionary<char, double>());
                }

                double weight = PeptideWeights[WildTypePeptide];
                for (int i = 0; i < pepsize; i++)
                {
                    char c = WildTypePeptide[i];
                    totalWeightsPerPos[i] += weight;
                    weights[i].Add(c, weight);
                }

                foreach (string s in ModifiedPeptides.Where(ps => ps != WildTypePeptide))
                {
                    for (int i = 0; i < pepsize; i++)
                    {
                        char c = s[i];
                        if (c != WildTypePeptide[i])
                        {
                            weight = PeptideWeights[s];
                            totalWeightsPerPos[i] += weight;
                            weights[i].Add(c, weight);
                            break;//there can be one aa change per peptide 
                        }
                    }
                }
                for (int i = 0; i < pepsize; i++)
                {
                    List<char> charlist = weights[i].Keys.ToList();
                    foreach (char c in charlist)
                        weights[i][c] /= totalWeightsPerPos[i];
                }
                return weights;
            }
            catch 
            {
                return null;
            }
        }

    }

}
