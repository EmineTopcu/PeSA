using PeSA.Engine.Helpers;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PeSA.Engine
{
    public class OPALArray: BaseArray
    {
        public bool PermutationXAxis { get; set; }

        public double NormalizedMatrixMax { get; set; }
        public double NormalizedMatrixMin { get; set; }

        public double[] NormBy { get; set; }

        [JsonIgnore]
        public NormalizationMode NormMode { get; set; } = NormalizationMode.Max;

        public char[] Permutation { get; set; }
        public string[] PositionCaptions { get; set; }
        public bool PositionYAxisTopToBottom { get; set; }

        /// <summary>
        /// In OPAL arrays, wild type array is set as XXXXXXXX to be used by the motif class
        /// </summary>
        public string WildTypePeptide { get; set; }

        #region Private methods
 
        private void GenerateNormalizedPeptideWeights()
        {
            NormalizedPeptideWeights.Clear();
            NormalizedMatrixMin = double.MaxValue;
            NormalizedMatrixMax = double.MinValue;
            for (int iRow = 0; iRow < RowCount; iRow++)
                for (int iCol = 0; iCol < ColCount; iCol++)
                {
                    int pos = PermutationXAxis ? iRow : iCol;
                    double normby = NormMode == NormalizationMode.Max ? NormalizationValue :
                        NormBy == null ? 1 : NormBy[pos];

                    if (normby != 0)
                        NormalizedMatrix[iRow, iCol] = QuantificationMatrix[iRow, iCol] / normby;
                    if (NormalizedMatrix[iRow, iCol] < NormalizedMatrixMin)
                        NormalizedMatrixMin = NormalizedMatrix[iRow, iCol];
                    if (NormalizedMatrix[iRow, iCol] > NormalizedMatrixMax)
                        NormalizedMatrixMax = NormalizedMatrix[iRow, iCol];

                    double weight = NormalizedMatrix[iRow, iCol];
                    if (PermutationXAxis)
                    {
                        if (this.PositionYAxisTopToBottom)
                            AddNormalizedPeptideWeight(weight, iRow, Permutation[iCol]);
                        else //if Position Matrix is read from bottom to top, rowind should be reversed
                            AddNormalizedPeptideWeight(weight, RowCount - iRow - 1, Permutation[iCol]);
                     }
                    else
                    {
                        AddNormalizedPeptideWeight(weight, iCol, Permutation[iRow]);
                    }
                }
        }

        private void GenerateMatrices(string[,] values, out string error)
        {
            error = "";
            try
            {
                if (values == null) return;
                RowCount = values.GetLength(0) - 1;
                ColCount = values.GetLength(1) - 1;
                QuantificationMatrix = new double[RowCount, ColCount];
                NormalizedMatrix = new double[RowCount, ColCount];

                WildTypePeptide = new string('X', PermutationXAxis ? RowCount : ColCount);

                #region Generate permutation, position, and NormBy arrays
                if (PermutationXAxis)
                {
                    NormBy = new double[RowCount];
                    for (int iRow = 1; iRow <= RowCount; iRow++)
                        NormBy[iRow - 1] = 0;
                    Permutation = new char[ColCount];
                    PositionCaptions = new string[RowCount];
                    for (int iCol = 1; iCol <= ColCount; iCol++)
                    {
                        string s = values[0, iCol].Trim();
                        if (AminoAcids.GetAminoAcid(s[0]) == null)
                        {
                            error = "Not a valid permutation string";
                            return;
                        }
                        Permutation[iCol - 1] = s[0];
                    }
                    //PositionYAxisTopToBottom is not used in setting the position captions. What user sees should not change. Use it only during the motif generation
                    for (int iRow = 1; iRow <= RowCount; iRow++)
                    {
                        string s = values[iRow, 0].Trim();
                        PositionCaptions[iRow - 1] = s;
                    }

                }
                else //if(PermutationYAxis)
                {
                    NormBy = new double[ColCount];
                    for (int iCol = 1; iCol <= ColCount; iCol++)
                        NormBy[iCol - 1] = 0;
                    Permutation = new char[RowCount];
                    PositionCaptions = new string[ColCount];
                    for (int iRow = 1; iRow <= RowCount; iRow++)
                    {
                        string s = values[iRow, 0].Trim();
                        if (AminoAcids.GetAminoAcid(s[0]) == null)
                        {
                            error = "Not a valid permutation string";
                            return;
                        }
                        Permutation[iRow - 1] = s[0];
                    }
                    for (int iCol = 1; iCol <= ColCount; iCol++)
                    {
                        string s = values[0, iCol].Trim();
                        PositionCaptions[iCol - 1] = s;
                    }
                }
                #endregion

                //Generate Matrices and Normalization values
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

                        if (PermutationXAxis)
                            NormBy[iRow] = Math.Max(d, NormBy[iRow]);
                        else
                            NormBy[iCol] = Math.Max(d, NormBy[iCol]);
                    }

                for (int iRow = 0; iRow < RowCount; iRow++)
                    for (int iCol = 0; iCol < ColCount; iCol++)
                    {
                        double normby = PermutationXAxis ? NormBy[iRow] : NormBy[iCol];
                        if (normby != 0)
                            NormalizedMatrix[iRow, iCol] = QuantificationMatrix[iRow, iCol] / normby;
                    }
                NormalizationValue = NormBy.Max();
                GenerateNormalizedPeptideWeights();
            }
            catch (Exception exc)
            {
                error = "Unhandled exception: " + exc.Message;
            }
        }       
         private void AddNormalizedPeptideWeight(double weight, int pos, char replaceBy)
        {
            if (string.IsNullOrEmpty(WildTypePeptide))
                return;
            string s = "", e = "";
            if (pos > 0)
                s = WildTypePeptide[..pos];
            if (pos < WildTypePeptide.Length - 1)
                e = WildTypePeptide[(pos + 1)..];
            string peptide = s + replaceBy + e;
            if (/*peptide == WildTypePeptide && */NormalizedPeptideWeights.ContainsKey(peptide))
                return;
            NormalizedPeptideWeights.Add(peptide, weight);
        }

        #endregion

        #region Static methods
        public static void CheckPermutationAxis(string[,] values, ref bool xPossible, ref bool yPossible)
        {
            xPossible = yPossible = true;
            if (values == null) return;
            int rowCount = values.GetLength(0) - 1;
            int colCount = values.GetLength(1) - 1;
            List<char> aaList = new List<char>();
            for (int iCol = 1; iCol <= colCount; iCol++)
            {
                string s = values[0, iCol].Trim();
                if (aaList.Contains(s[0]))
                {
                    xPossible = false;
                    break;
                }
                aaList.Add(s[0]);
            }
            aaList.Clear();
            for (int iRow = 1; iRow <= rowCount; iRow++)
            {
                string s = values[iRow, 0].Trim();
                char aa = s.Length > 0 ? s[0] : ' ';
                if (aaList.Contains(aa))
                {
                    yPossible = false;
                    break;
                }
                aaList.Add(aa);
            }
        }

        public static OPALArray ReadFromFile(string filename)
        {
            try
            {
                OPALArray OA = null;
                if (File.Exists(filename))
                {
                    string json = File.ReadAllText(filename);
                    OA = (OPALArray)JsonUtil.ReadFromJson(json, typeof(OPALArray));
                    if (OA.Version == "")
                    {
                        OA.Version = "Old version";
                        OA.Upgrade("PositiveThreshold");
                        OA.Upgrade("NormalizedMatrixRange");
                    }
                }
                return OA;
            }
            catch { return null; }
        }

        public static bool SaveToFile(string filename, OPALArray OA)
        {
            try
            {
                OA.Version = typeof(Analyzer).Assembly.GetName().Version.ToString();
                string json = JsonUtil.ToJson(OA);
                File.WriteAllText(filename, json);
                return true;
            }
            catch { return false; }
        }

        #endregion
        public OPALArray()
        { }
        public OPALArray(string[,] values, bool permutationXAxisIn, bool positionYAxisTopToBottom, out string error)
        {
            error = "";
            try
            {
                PermutationXAxis = permutationXAxisIn;
                PositionYAxisTopToBottom = positionYAxisTopToBottom;
                NormalizedPeptideWeights = new Dictionary<string, double>();
                GenerateMatrices(values, out error);
                if (error != "") return;
            }
            catch (Exception exc)
            {
                error = "Unhandled exception: " + exc.Message;
            }
        }

        override protected void Upgrade(string mode)
        {
            base.Upgrade(mode);
            if (mode == "NormalizedMatrixRange")
            {
                if (NormalizedPeptideWeights == null || NormalizedPeptideWeights.Count == 0)
                    GenerateNormalizedPeptideWeights();
                else
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
        }
        public void Renormalize()
        {
            GenerateNormalizedPeptideWeights();
        }

        /// <summary>
        /// Dictionary of weight for each char at every position
        /// </summary>
        /// <param name="PA"></param>
        /// <returns></returns>
        public Dictionary<int, Dictionary<char, double>> GenerateWeights()
        {
            try
            {
                int motifsize = PermutationXAxis ? RowCount : ColCount;
                WildTypePeptide = new string('X', motifsize);
                NormalizedPeptideWeights.Clear();
                
                Dictionary<int, Dictionary<char, double>> weights;
                Dictionary<int, double> totalWeightsPerPos;
                weights = new Dictionary<int, Dictionary<char, double>>();
                totalWeightsPerPos = new Dictionary<int, double>();
                for (int i = 0; i < motifsize; i++)
                {
                    totalWeightsPerPos.Add(i, 0);
                    weights.Add(i, new Dictionary<char, double>());
                }

                for (int rowind = 0; rowind < RowCount; rowind++)
                {
                    for (int colind = 0; colind < ColCount; colind++)
                    {
                        double weight = NormalizedMatrix[rowind, colind];
                            if (PermutationXAxis)
                            {
                                if (this.PositionYAxisTopToBottom)
                                {
                                    if (weight > PositiveThreshold)
                                    {
                                        weights[rowind].Add(Permutation[colind], weight);
                                        totalWeightsPerPos[rowind] += weight;
                                    }
                                    AddNormalizedPeptideWeight(weight, rowind, Permutation[colind]);
                                }
                                else //if Position Matrix is read from bottom to top, rowind should be reversed
                                {
                                    if (weight > PositiveThreshold)
                                    {
                                        weights[RowCount - rowind - 1].Add(Permutation[colind], weight);
                                        totalWeightsPerPos[RowCount - rowind - 1] += weight;
                                    }
                                    AddNormalizedPeptideWeight(weight, RowCount - rowind - 1, Permutation[colind]);
                                }
                            }
                            else
                            {
                                if (weight > PositiveThreshold)
                                {
                                    weights[colind].Add(Permutation[rowind], weight);
                                    totalWeightsPerPos[colind] += weight;
                                }
                                AddNormalizedPeptideWeight(weight, colind, Permutation[rowind]);
                            }
                        
                    }
                }
                for (int i = 0; i < motifsize; i++)
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
