
using PeSA.Engine.Helpers;
using System.Text.Json;

namespace PeSA.Engine
{
    public enum NormalizationMode { Mean, PerRowColumn, Max}
    public class PermutationArray: BaseArray
    {
        public string WildTypePeptide { get; set; }
        /// <summary>
        /// Multiple wildtype values may exist with different values per position
        /// </summary>
        public Dictionary<int, double> NormalizedWildtypeWeights { get; set; }
        public bool WildTypeAxisExists { get; set; }
        public bool PermutationXAxis { get; set; }
        public bool WildTypeYAxisTopToBottom { get; set; }
        public string[,] PeptideMatrix { get; set; }
        public double NormalizedMatrixMax { get; set; }
        public double NormalizedMatrixMin { get; set; }

        public double[] NormBy;
        public char[] Permutation;
        public NormalizationMode NormMode = NormalizationMode.Mean;

        override public void SetPositiveThreshold(double value, out bool negChanged)
        {
            base.SetPositiveThreshold(value, out negChanged);
        }

        override public void SetNegativeThreshold(double value, out bool posChanged)
        {
            base.SetNegativeThreshold(value, out posChanged);
        }

        override protected void Upgrade(string mode)
        {
            base.Upgrade(mode);
            if (mode == "NormalizedPeptideWeights")
            {
                GenerateNormalizedPeptideWeights();
            }
            if (mode == "NormalizedMatrixRange")
            {
                NormalizedMatrixMin = double.MaxValue;
                NormalizedMatrixMax = double.MinValue;
                for (int iRow = 0; iRow < RowCount; iRow++)
                    for (int iCol = 0; iCol < ColCount; iCol++)
                    {
                        if (NormalizedMatrix[iRow, iCol] < NormalizedMatrixMin)
                            NormalizedMatrixMin = NormalizedMatrix[iRow, iCol];
                        if (NormalizedMatrix[iRow, iCol] > NormalizedMatrixMax)
                            NormalizedMatrixMax = NormalizedMatrix[iRow, iCol];
                    }
            }
        }

        private void GenerateNormalizedPeptideWeights()
        {
            NormalizedPeptideWeights.Clear();
            NormalizedWildtypeWeights.Clear();

            NormalizedMatrixMin = double.MaxValue;
            NormalizedMatrixMax = double.MinValue;
            for (int iRow = 0; iRow < RowCount; iRow++)
                for (int iCol = 0; iCol < ColCount; iCol++)
                {
                    int pos = PermutationXAxis ? iRow : iCol;
                    double normby = NormMode == NormalizationMode.Mean ? NormalizationValue :
                        NormBy == null ? 1 : NormBy[pos];
                    if (normby != 0)
                        NormalizedMatrix[iRow, iCol] = QuantificationMatrix[iRow, iCol] / normby;
                    if (NormalizedMatrix[iRow, iCol] < NormalizedMatrixMin)
                        NormalizedMatrixMin = NormalizedMatrix[iRow, iCol];
                    if (NormalizedMatrix[iRow, iCol] > NormalizedMatrixMax)
                        NormalizedMatrixMax = NormalizedMatrix[iRow, iCol];

                    AddNormalizedPeptideWeight(PeptideMatrix[iRow, iCol], pos, NormalizedMatrix[iRow, iCol]);
                }
        }

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
                                PeptideMatrix[iRow, iCol] = (iRow >= 1 ? WildTypePeptide[..iRow] : "") + Permutation[iCol] + (iRow < WildTypePeptide.Length - 1 ? WildTypePeptide[(iRow + 1)..] : "");
                            else  //from bottom to top
                                PeptideMatrix[iRow, iCol] = (iRow < wtl - 1 ? WildTypePeptide[..(wtl - iRow - 1)] : "") + Permutation[iCol] + (iRow > 0 ? WildTypePeptide[(wtl - iRow)..] : "");
                           }
                        else
                            PeptideMatrix[iRow, iCol] = (iCol >= 1 ? WildTypePeptide[..iCol] : "") + Permutation[iRow] + (iCol < WildTypePeptide.Length - 1 ? WildTypePeptide[(iCol + 1)..] : "");
       
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
                NormalizationValue = totalNorm / counter;
                GenerateNormalizedPeptideWeights();
            }
            catch (Exception exc)
            {
                error = "Unhandled exception: " + exc.Message;
            }
        }

        public void Renormalize()
        {
            GenerateNormalizedPeptideWeights();
        }

        public PermutationArray(string[,] values, bool permutationXAxisIn, bool wildtypeYAxisTopToBottom, ref List<string> warnings, out string error)
        {
            error = "";
            try
            {
                NormalizedPeptideWeights = new Dictionary<string, double>();
                NormalizedWildtypeWeights = new Dictionary<int, double>();

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
            List<char> aaList = new();
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

        private void AddNormalizedPeptideWeight(string peptide, int pos, double weight)
        {
            if (string.IsNullOrEmpty(peptide))
                return;
            if (peptide == WildTypePeptide)
            {
                NormalizedWildtypeWeights.Add(pos, weight);
                return;
            }
            if (!NormalizedPeptideWeights.ContainsKey(peptide))
                NormalizedPeptideWeights.Add(peptide, weight);
        }

        public static PermutationArray ReadFromFile(string filename)
        {
            try
            {
                PermutationArray PA = null;
                if (File.Exists(filename))
                {
                    PA = (PermutationArray)JsonUtil.ReadFromJson(File.ReadAllText(filename), typeof(PermutationArray));
                    if (PA.Version == "")
                    {
                        PA.Version = "Old version";
                        PA.Upgrade("NormalizedPeptideWeights");
                        PA.Upgrade("PositiveThreshold");
                    }
                    if (PA.NormalizedMatrixMin == PA.NormalizedMatrixMax)
                        PA.Upgrade("NormalizedMatrixRange");
                }
                return PA;
            }
            catch { return null; }
        }
    

        public static bool SaveToFile(string filename, PermutationArray PA)
        {
            try
            {
                PA.Version = typeof(Analyzer).Assembly.GetName().Version.ToString();
                string json = JsonUtil.ToJson(PA);
                File.WriteAllText(filename, json);
                return true;
            }
            catch { return false; }
        }

    }

}
