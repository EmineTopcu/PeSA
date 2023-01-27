﻿using PeSA.Engine.Helpers;
using System.Text.Json;

namespace PeSA.Engine
{
    public class PeptideArray: BaseArray
    {
        public int PeptideLength { get; set; }
        public bool RowsFirst { get; set; }
        public List<string> PeptideList { get; set; }
        public string[,] PeptideMatrix { get; set; }

        public double MaxValue { get; private set; }

        public double FrequencyThreshold { get; set; }
        public int? KeyPosition { get; set; }
        public char KeyAA { get; set; }

        public List<string> ModifiedPeptides { get; set; }
        
        public PeptideArray(int nRow, int nCol, bool rowsFirst)
        {
            RowCount = nRow;
            ColCount = nCol;
            RowsFirst = rowsFirst;
            PeptideMatrix = new string[nRow, nCol];
            QuantificationMatrix = new double[nRow, nCol];
            NormalizedMatrix = new double[nRow, nCol];
            ModifiedPeptides = new List<string>();
            NormalizedPeptideWeights = new Dictionary<string, double>();
        }

        public void SetPeptideList(List<string> list)
        {

            if (list == null) return;
            PeptideList = list;
            if (list.Count > 0)
                PeptideLength = list[0].Length;
            int rowind = 0;
            int colind = 0;
            if (RowsFirst)
            {
                foreach (string s in PeptideList)
                {
                    PeptideMatrix[rowind, colind++] = s;
                    if (colind == ColCount)
                    {
                        rowind++;
                        colind = 0;
                    }
                    if (rowind == RowCount) break;
                }
            }
            else
            {
                foreach (string s in PeptideList)
                {
                    PeptideMatrix[rowind++, colind] = s;
                    if (rowind == RowCount)
                    {
                        colind++;
                        rowind = 0;
                    }
                    if (colind == ColCount) break;
                }
            }
        }

        public void SetPeptideMatrix(string[,] matrix)
        {
            PeptideList = new List<string>();
            PeptideMatrix = matrix;
            if (matrix == null) return;

            if (matrix.Length > 0)
                for (int rowind = 0; rowind < matrix.GetLength(0); rowind++)
                {
                    for (int colind = 0; colind < matrix.GetLength(1); colind++)
                    {
                        PeptideLength = matrix[rowind, colind]?.Length ?? 0;
                        if (PeptideLength > 0) break;
                    }
                    if (PeptideLength > 0) break;
                }
            if (RowsFirst)
            {
                for (int rowind = 0; rowind < matrix.GetLength(0); rowind++)
                    for (int colind = 0; colind < matrix.GetLength(1); colind++)
                        PeptideList.Add(PeptideMatrix[rowind, colind]);
            }
            else
            {
                for (int colind = 0; colind < matrix.GetLength(1); colind++)
                    for (int rowind = 0; rowind < matrix.GetLength(0); rowind++)
                        PeptideList.Add(PeptideMatrix[rowind, colind]);
            }
        }

        public void SetQuantificationMatrix(string[,] values, bool headersExist)
        {
            int rowind = 0, colind = 0;
            if (headersExist) rowind = colind = 1;
            int maxRow = RowCount, maxCol = ColCount;
            if (values.GetLength(0) - rowind < RowCount)
                maxRow = values.GetLength(0) - rowind;
            if (values.GetLength(1) - colind < ColCount)
                maxCol = values.GetLength(1) - colind;

            MaxValue = 0;
            for (int i = 0; i < maxRow; i++)
                for (int j = 0; j < maxCol; j++)
                {
                    double val = -1;
                    Double.TryParse(values[rowind + i, colind + j], out val);
                    if (val > MaxValue) MaxValue = val;
                    QuantificationMatrix[i, j] = val;
                }
            NormalizationValue = MaxValue;
        }

        private void AddModifiedPeptide(string s)
        {
            if (!ModifiedPeptides.Contains(s))
                ModifiedPeptides.Add(s);
        }

        private void AddNormalizedPeptideWeight(string peptide, double weight)
        {
            if (string.IsNullOrEmpty(peptide))
                return;
            if (NormalizedPeptideWeights.ContainsKey(peptide))
                return;
            NormalizedPeptideWeights.Add(peptide, weight);
        }

        override public void SetPositiveThreshold(double value, out bool negChanged)
        {
            base.SetPositiveThreshold(value, out negChanged);
            GenerateModifiedPeptideList();
        }

        private void GenerateModifiedPeptideList()
        {
            ModifiedPeptides.Clear();
            foreach (string s in NormalizedPeptideWeights.Keys)
            {
                if (NormalizedPeptideWeights[s] >= PositiveThreshold)
                    AddModifiedPeptide(s);
            }
        }

        public void Normalize(double normBy)
        {
            NormalizedPeptideWeights.Clear();
            if (normBy == 0) return;
            NormalizationValue = normBy;
            for (int i = 0; i < RowCount; i++)
                for (int j = 0; j < ColCount; j++)
                {
                    NormalizedMatrix[i, j] = QuantificationMatrix[i, j] / normBy;
                    AddNormalizedPeptideWeight(PeptideMatrix[i, j], NormalizedMatrix[i, j]);
                }
            GenerateModifiedPeptideList();
        }
        public int[,] BinaryMatrix {
            get
            {
                int[,] _BinaryMatrix = new int[RowCount, ColCount];
                for (int i = 0; i < RowCount; i++)
                    for (int j = 0; j < ColCount; j++)
                    {
                        _BinaryMatrix[i, j] = NormalizedMatrix[i, j] <= PositiveThreshold ? 0 : 1;
                    }
                return _BinaryMatrix;
            }
        }
        public static PeptideArray ReadFromFile(string filename)
        {
            try
            {
                PeptideArray PA = null;
                if (File.Exists(filename))
                {
                    PA = (PeptideArray)JsonUtil.ReadFromJson(File.ReadAllText(filename), typeof(PeptideArray));
                    if (PA.Version == "")
                    {
                        PA.Version = "Old version";
                        PA.Upgrade("PositiveThreshold");
                    }
                }
                return PA;
            }
            catch { return null; }
        }

        public static bool SaveToFile(string filename, PeptideArray PA)
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
