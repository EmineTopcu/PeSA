using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeSA.Engine
{
    public class OPALArray
    {
        public string Version = "";

        public int RowCount { get; set; }
        public int ColCount { get; set; }
        public bool PermutationXAxis { get; set; }
        public double[,] QuantificationMatrix { get; set; }
        public double[,] NormalizedMatrix { get; set; }
        public double[] NormBy;
        public char[] Permutation;
        public string[] PositionCaptions;
        public bool PositionYAxisTopToBottom { get; set; }

        public double Threshold { get; set; }

        public Dictionary<string, double> PeptideWeights { get; set; }

        private void GenerateMatrices(string[,] values, out string error)
        {
            error = "";
            try
            {
                RowCount = values.GetLength(0) - 1;
                ColCount = values.GetLength(1) - 1;
                QuantificationMatrix = new double[RowCount, ColCount];
                NormalizedMatrix = new double[RowCount, ColCount];

                //Generate Permutation array
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
                    //PositionYAxisTopToBottom is not used in setting the positio captions. What user sees should not change. Use it only during the motif generation
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

                //Generate Matrices and Normalization values
                for (int iRow = 0; iRow < RowCount; iRow++)
                    for (int iCol = 0; iCol < ColCount; iCol++)
                    {
                        double d = 0;
                        if (double.TryParse(values[iRow + 1, iCol + 1], out d))
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
            }
            catch (Exception exc)
            {
                error = "Unhandled exception: " + exc.Message;
            }
        }

        public OPALArray(string[,] values, bool permutationXAxisIn, bool positionYAxisTopToBottom, out string error)
        {
            Version = typeof(Analyzer).Assembly.GetName().Version.ToString();
            error = "";
            try
            {
                PeptideWeights = new Dictionary<string, double>();
                PermutationXAxis = permutationXAxisIn;
                PositionYAxisTopToBottom = positionYAxisTopToBottom;
                GenerateMatrices(values, out error);
                if (error != "") return;
            }
            catch (Exception exc)
            {
                error = "Unhandled exception: " + exc.Message;
            }
        }

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
                if (aaList.Contains(s[0]))
                {
                    yPossible = false;
                    break;
                }
                aaList.Add(s[0]);
            }
        }

        public static OPALArray ReadFromFile(string filename)
        {
            try
            {
                OPALArray OA = null;
                if (File.Exists(filename))
                    OA = JsonConvert.DeserializeObject<OPALArray>(File.ReadAllText(filename));

                return OA;
            }
            catch { return null; }
        }

        public static bool SaveToFile(string filename, OPALArray OA)
        {
            try
            {
                string json = JsonConvert.SerializeObject(OA);
                File.WriteAllText(filename, json);
                return true;
            }
            catch { return false; }
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
                        if (weight> Threshold)
                        {
                            if (PermutationXAxis)
                            {
                                if (this.PositionYAxisTopToBottom)
                                {
                                    weights[rowind].Add(Permutation[colind], weight);
                                    totalWeightsPerPos[rowind] += weight;
                                }
                                else //if Position Matrix is read from bottom to top, rowind should be reversed
                                {
                                    weights[RowCount -  rowind - 1].Add(Permutation[colind], weight);
                                    totalWeightsPerPos[RowCount - rowind - 1] += weight;
                                }
                            }
                            else
                            {
                                weights[colind].Add(Permutation[rowind], weight);
                                totalWeightsPerPos[colind] += weight;
                            }
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

        public Motif CreateMotif()
        {
            Dictionary<int, Dictionary<char, double>> weights = GenerateWeights();
            return new Motif(weights, "", -1);
        }
    }
}
