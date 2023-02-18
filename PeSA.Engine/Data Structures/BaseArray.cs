using PeSA.Engine.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PeSA.Engine
{
    public class BaseArray
    {
        public string Version { get; set; } = "";        
        public Dictionary<string, double> NormalizedPeptideWeights { get; set; }
        [JsonConverter(typeof(MatrixJsonConverter<double>))]
        public double[,] QuantificationMatrix { get; set; }
        [JsonConverter(typeof(MatrixJsonConverter<double>))]
        public double[,] NormalizedMatrix { get; set; }
        
        public double NormalizationValue { get; set; }

        
        public int RowCount { get; set; }
        
        public int ColCount { get; set; }

        
        public string ImageStr { get; set; }
        
        public string Notes { get; set; }

        /// <summary>
        /// keeping for backward compatibility
        /// </summary>
        
        public double Threshold { get; set; }

        /// <summary>
        /// Use SetPositiveThreshold to set the value
        /// </summary>
        
        public double PositiveThreshold { get; set; } = 0.5;
        /// <summary>
        /// Use SetNegativeThreshold to set the value
        /// </summary>
        
        public double NegativeThreshold { get; set; } = 0.5;
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
