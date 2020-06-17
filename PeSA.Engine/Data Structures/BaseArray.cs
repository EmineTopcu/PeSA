using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeSA.Engine
{
    public class BaseArray
    {
        public string Version = "";

        public Dictionary<string, double> NormalizedPeptideWeights { get; set; }
        public double[,] QuantificationMatrix { get; set; }
        public double[,] NormalizedMatrix { get; set; }
        public double NormalizationValue { get; set; }

        public int RowCount { get; set; }
        public int ColCount { get; set; }

        public string ImageStr { get; set; }
        public string Notes { get; set; }

        /// <summary>
        /// keeping for backward compatibility
        /// </summary>
        public double Threshold;

        /// <summary>
        /// Use SetPositiveThreshold to set the value
        /// </summary>
        public double PositiveThreshold = 0.5;
        public double GetPositiveThreshold()
        {
            return PositiveThreshold;
        }

        virtual public void SetPositiveThreshold(double value, out bool negChanged)
        {
            negChanged = false;
            PositiveThreshold = value;
            if (NegativeThreshold > value)
            {
                NegativeThreshold = value;
                negChanged = true;
            }
        }

        virtual protected void Upgrade(string mode)
        {
            if (mode == "PositiveThreshold")
                PositiveThreshold = Threshold;
        }


        /// <summary>
        /// Use SetNegativeThreshold to set the value
        /// </summary>
        public double NegativeThreshold = 0.5;
        public double GetNegativeThreshold()
        {
            return NegativeThreshold;
        }

        virtual public void SetNegativeThreshold(double value, out bool posChanged)
        {
            posChanged = false;
            NegativeThreshold = value;
            if (PositiveThreshold < value)
            {
                PositiveThreshold = value;
                posChanged = true;
            }
        }
    }
}
