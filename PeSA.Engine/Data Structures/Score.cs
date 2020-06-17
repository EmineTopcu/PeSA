using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace PeSA.Engine
{
    public class Score
    {
        public string Peptide;
        /// <summary>
        /// Zero indexed
        /// </summary>
        public int StartPos;
        public string Segment;
        public int posMatch, negMatch;
        public double weightedMatch;
        public double priorityMatch;
        public Score(string peptide, string segment, int startPos)
        {
            Peptide = peptide;
            Segment = segment;
            StartPos = startPos;
        }
    }

}

