using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;

namespace PeSA.Engine
{
    public partial class Motif
    {
        public string Version = "";

        private double positiveThreshold = 1;
        private double negativeThreshold = 0;
        private double freqThreshold = 0;

        public double FreqThreshold
        {
            get { return freqThreshold; }
            set
            {
                freqThreshold = value;
                GenerateFrequencies();
            }
        }

        public double PositiveThreshold
        {
            get { return positiveThreshold; }
            set
            {
                positiveThreshold = value;
                GenerateColumns();
            }
        }

        public double NegativeThreshold
        {
            get { return negativeThreshold; }
            set
            {
                negativeThreshold = value;
                GenerateColumns();
            }
        }
        /// <summary>
        /// *** in OPAL Arrays, wildtype sequence needs to be XXXXXX, 
        ///     and the peptides needs to be reformatted as XXAXXX, so that the modified aa can be distinguished
        /// *** If no wildtype sequence, frequency based motif is created //TODO
        /// *** If there is wildtype sequence, negative motif is possible
        /// </summary>
        public string WildTypePeptide { get; set; }
        public int PeptideLength { get; set; }

        private string[] PosCaptions;
        private Dictionary<string, double> PeptideWeights;
        /// <summary>
        /// wildtype weight per position
        /// </summary>
        private Dictionary<int, double> WildtypeWeights;
        private bool columnsGenerated = false;

        public Dictionary<int, Dictionary<char, double>> PositiveColumns { get; set; }
        public Dictionary<int, Dictionary<char, double>> NegativeColumns { get; set; }
        public Dictionary<int, Dictionary<char, double>> Frequencies { get; set; }
        public List<char> AminoAcidsUsed;

        public double MaxPosWeight
        {
            get {
                if (PositiveColumns == null) return 1;
                double dmax = 0;
                foreach (Dictionary<char, double> perpos in PositiveColumns.Values)
                {
                    foreach (double d in perpos.Values)
                    {
                        if (d > dmax)
                            dmax = d;
                    }
                }
                return dmax;
            }
        }
        public Motif() { }

        public Motif(PermutationArray PA)
            : this(PA.NormalizedPeptideWeights, PA.NormalizedWildtypeWeights, PA.WildTypePeptide, PA.GetPositiveThreshold(), PA.GetNegativeThreshold())
        {
        }
        public Motif(OPALArray OA)
            : this(OA.NormalizedPeptideWeights, null, OA.WildTypePeptide, OA.PositiveThreshold, OA.NegativeThreshold)
        {
        }

        public Motif(Dictionary<string, double> peptideWeights, Dictionary<int, double> wildtypeWeights, string wildTypePeptide, double posThreshold, double negThreshold)
        {
            Settings settings = Settings.Load("default.settings");
            settings.GenerateImageResources();
            PeptideWeights = peptideWeights;
            WildtypeWeights = wildtypeWeights;
            WildTypePeptide = wildTypePeptide;
            PosCaptions = null;
            positiveThreshold = posThreshold;
            negativeThreshold = negThreshold;
            GenerateColumns();
        }
        public Motif(Dictionary<string, double> _PeptideWeights, string[] _PosCaptions, double _posThreshold, double _negThreshold)
        {
            Settings settings = Settings.Load("default.settings");
            settings.GenerateImageResources();
            PeptideWeights = _PeptideWeights;
            WildTypePeptide = "";
            PosCaptions = _PosCaptions;
            positiveThreshold = _posThreshold;
            negativeThreshold = _negThreshold;
            GenerateColumns();
        }
        public Motif(List<string> _Peptides, int peptideLength)
        {
            Settings settings = Settings.Load("default.settings");
            settings.GenerateImageResources();
            PeptideWeights = new Dictionary<string, double>();
            foreach (string s in _Peptides.Distinct())
                PeptideWeights.Add(s, 1);
            PeptideLength = peptideLength;
            GenerateFrequencies();
        }

        private void AddColumnValue(Dictionary<int, Dictionary<char, List<double>>> _Columns, int pos, char c, double weight)
        {
            if (_Columns == null || !_Columns.ContainsKey(pos)) return;
            Dictionary<char, List<double>> column = _Columns[pos];
            if (!column.ContainsKey(c))
                column.Add(c, new List<double>());
            column[c].Add(weight);
        }

        public Dictionary<int, Dictionary<char, double>> GetScaledColumns(Dictionary<int, Dictionary<char, double>> _Columns)
        {
            Dictionary<int, Dictionary<char, double>> scaled = new Dictionary<int, Dictionary<char, double>>();
            Dictionary<int, double> totalWeightsPerPos = new Dictionary<int, double>();
            foreach (int pos in _Columns.Keys)
            {
                totalWeightsPerPos.Add(pos, 0);
                Dictionary<char, double> perpos = _Columns[pos];
                foreach (char c in perpos.Keys)
                {
                    double avr = perpos[c];
                    totalWeightsPerPos[pos] += perpos[c];
                }
            }

            foreach (int pos in _Columns.Keys)
            {
                scaled.Add(pos, new Dictionary<char, double>());
                Dictionary<char, double> perpos = _Columns[pos];
                foreach (char c in perpos.Keys)
                {
                    double val = perpos[c];
                    val /= totalWeightsPerPos[pos];

                    scaled[pos].Add(c, val);
                }
            }
            return scaled;
        }

        private bool GenerateColumns()
        {
            try
            {
                if (columnsGenerated) return true;
                if (string.IsNullOrEmpty(WildTypePeptide) && (PeptideWeights == null || PeptideWeights.Count == 0))
                    return false;

                PeptideLength = string.IsNullOrEmpty(WildTypePeptide) ? PeptideWeights.Keys.Select(p => p.Length).Max() : WildTypePeptide.Length;

                //Initialize
                Dictionary<int, Dictionary<char, List<double>>> _PositiveColumns = new Dictionary<int, Dictionary<char, List<double>>>();
                Dictionary<int, Dictionary<char, List<double>>> _NegativeColumns = new Dictionary<int, Dictionary<char, List<double>>>();
                PositiveColumns = new Dictionary<int, Dictionary<char, double>>();
                NegativeColumns = new Dictionary<int, Dictionary<char, double>>();
                AminoAcidsUsed = new List<char>();
                for (int i = 0; i < PeptideLength; i++)
                {
                    _PositiveColumns.Add(i, new Dictionary<char, List<double>>());
                    _NegativeColumns.Add(i, new Dictionary<char, List<double>>());
                }

                if (!string.IsNullOrEmpty(WildTypePeptide))
                {
                    for (int i = 0; i < PeptideLength; i++)
                    {
                        char c = WildTypePeptide[i];
                        if (c != 'X')
                        {
                            double weight = WildtypeWeights.ContainsKey(i) ? WildtypeWeights[i] : 1;
                            AddColumnValue(_PositiveColumns, i, c, weight);
                            if (!AminoAcidsUsed.Contains(c))
                                AminoAcidsUsed.Add(c);
                        }
                    }
                }


                //Positive columns have to be generated first to set MaxPosWeight to be used for negative distance calculations
                double negReference = 0;
                foreach (string s in PeptideWeights.Keys.Where(ps => ps != WildTypePeptide))
                {
                    for (int i = 0; i < PeptideLength; i++)
                    {
                        char c = s[i];
                        //WildTypePeptide is blank/null for OPALs
                        if ((string.IsNullOrEmpty(WildTypePeptide) && c != 'X') || (!string.IsNullOrEmpty(WildTypePeptide) && c != WildTypePeptide[i]))
                        {
                            double weight = PeptideWeights[s];
                            if (weight > negReference)
                                negReference = weight;
                            if (weight >= positiveThreshold)
                            {
                                AddColumnValue(_PositiveColumns, i, c, weight);
                            }
                            if (!AminoAcidsUsed.Contains(c))
                                AminoAcidsUsed.Add(c);
                        }
                    }
                }

                //Negative columns
                foreach (string s in PeptideWeights.Keys.Where(ps => ps != WildTypePeptide))
                {
                    for (int i = 0; i < PeptideLength; i++)
                    {
                        char c = s[i];
                        //WildTypePeptide is blank/null for OPALs
                        if ((string.IsNullOrEmpty(WildTypePeptide) && c != 'X') || (!string.IsNullOrEmpty(WildTypePeptide) && c != WildTypePeptide[i]))
                        {
                            double weight = PeptideWeights[s];
                            if (weight < negativeThreshold)
                            {
                                AddColumnValue(_NegativeColumns, i, c, negReference - weight);
                            }
                            //TODO optimize - there can be a mode // break;//there can be one aa change per peptide 
                            if (!AminoAcidsUsed.Contains(c))
                                AminoAcidsUsed.Add(c);
                        }
                    }
                }

                for (int i = 0; i < PeptideLength; i++)
                {
                    PositiveColumns.Add(i, new Dictionary<char, double>());
                    NegativeColumns.Add(i, new Dictionary<char, double>());
                    Dictionary<char, List<double>> tobeaveraged = _PositiveColumns[i];
                    foreach (char c in tobeaveraged.Keys)
                    {
                        PositiveColumns[i].Add(c, tobeaveraged[c].Average());
                    }
                    tobeaveraged = _NegativeColumns[i];
                    foreach (char c in tobeaveraged.Keys)
                    {
                        NegativeColumns[i].Add(c, tobeaveraged[c].Average());
                    }
                }

                columnsGenerated = true;
                return true;
            }
            catch
            {
                return false;
            }
        }

        private Dictionary<int, Dictionary<char, double>> GenerateFrequencies()
        {
            try
            {
                List<string> peptides = PeptideWeights.Select(kvp => kvp.Key).ToList();
                Dictionary<int, Dictionary<char, int>> frequencies;
                if (PeptideLength == 0)
                    PeptideLength = peptides[0].Length;
                int setsize = peptides.Count();
                frequencies = new Dictionary<int, Dictionary<char, int>>();
                Frequencies = new Dictionary<int, Dictionary<char, double>>();
                for (int i = 0; i < PeptideLength; i++)
                {
                    frequencies.Add(i, new Dictionary<char, int>());
                    Frequencies.Add(i, new Dictionary<char, double>());
                }

                foreach (string s in peptides)
                {
                    int len = Math.Min(PeptideLength, s.Length);
                    for (int i = 0; i < len; i++)
                    {
                        char c = s[i];
                        if (frequencies[i].ContainsKey(c))
                            frequencies[i][c] += 1;
                        else frequencies[i].Add(c, 1);
                    }
                }
                for (int i = 0; i < PeptideLength; i++)
                {
                    foreach (char c in frequencies[i].Keys)
                        Frequencies[i].Add(c, (double)frequencies[i][c] / setsize);
                }
                return Frequencies;
            }
            catch
            {
                return null;
            }
        }


        #region Bitmap functions
        private bool IsVerticallyEmpty(Bitmap img, int x)
        {
            var white = Color.White.ToArgb();
            for (var y = 0; y < img.Height; y += 3)
                if (img.GetPixel(x, y).ToArgb() != white)
                    return false;
            return true;
        }

        private bool IsHorizontallyEmpty(Bitmap img, int y)
        {
            var white = Color.White.ToArgb();
            for (var x = 0; x < img.Width; x += 3)
                if (img.GetPixel(x, y).ToArgb() != white)
                    return false;
            return true;
        }

        private RectangleF SelectFilledPixels(Bitmap img)
        {
            var left = 0;
            var top = 0;
            var right = img.Width - 1;
            var bottom = img.Height - 1;

            while (left < img.Width)
            {
                if (!IsVerticallyEmpty(img, left))
                    break;
                left++;
            }

            while (right > 0)
            {
                if (!IsVerticallyEmpty(img, right))
                    break;
                right--;
            }

            while (top < img.Height)
            {
                if (!IsHorizontallyEmpty(img, top))
                    break;
                top++;
            }

            while (bottom > 0)
            {
                if (!IsHorizontallyEmpty(img, bottom))
                    break;
                bottom--;
            }

            return new RectangleF(left, top, right - left, bottom - top);
        }
        private Bitmap GetLetterImage(Char c, int width, int height, Color color)
        {
            if (width <= 0 || height <= 0) return null;

            var scaledBitmap = new Bitmap(width, height);

            Bitmap bmp = Settings.GetAminoAcidImage(c, color != Common.ColorNegative);

            if (bmp != null)
            {
                try
                {
                    var sourceRectangle = SelectFilledPixels(bmp);
                    RectangleF destinationRectangle = new RectangleF(0, 0, width, height);

                    using (var destination = Graphics.FromImage(scaledBitmap))
                    {
                        destination.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        destination.DrawImage(bmp, destinationRectangle, sourceRectangle, GraphicsUnit.Pixel);
                    }
                    return scaledBitmap;
                }
                catch (Exception exc) { }
            }
            var initialFontSize = (int)(Math.Max(width, height) / 1.5);

            var fullSizeBitmap = new Bitmap(initialFontSize * 2, initialFontSize * 2);
            
            using (var source = Graphics.FromImage(fullSizeBitmap))
            using (var destination = Graphics.FromImage(scaledBitmap))
            using (var font = new Font("Arial", initialFontSize, FontStyle.Bold))
            using (var brush = new SolidBrush(color))
            {
                source.FillRectangle(Brushes.White, 0, 0, fullSizeBitmap.Width, fullSizeBitmap.Height);
                AminoAcid aa = AminoAcids.GetAminoAcid(c); //aa?.MolecularWeight.ToString() ?? 
                //source.DrawString(c=='X'?"X":aa?.pI.ToString(), font, brush, 0, 0);
                source.DrawString(c.ToString(), font, brush, 0, 0);

                var sourceRectangle = SelectFilledPixels(fullSizeBitmap);
                RectangleF destinationRectangle;
                if (c == 'I')
                {
                    double newwidth = 5 * sourceRectangle.Width * height / sourceRectangle.Height;
                    if (newwidth > width / 3)
                        newwidth = width / 3;
                    destinationRectangle = new RectangleF((int)(width - newwidth) / 2, 0, (int)newwidth, height);
                }
                else
                    destinationRectangle = new RectangleF(0, 0, width, height);

                destination.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                destination.DrawImage(fullSizeBitmap, destinationRectangle, sourceRectangle, GraphicsUnit.Pixel);
            }

            return scaledBitmap;
        }

        private Bitmap Render(Dictionary<int, Dictionary<char, double>> Columns,
            int width, int height, int positionSpacing = 10, int letterSpacing = 3, 
            Color? defColor = null)
        {
            Settings settings = Settings.Load("default.settings");

            int maxAAperCol = settings.MotifMaxAAPerColumn;
            int letterWidth = (width - positionSpacing * (Columns.Count - 1)) / Columns.Count;

            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillRectangle(Brushes.White, 0, 0, width, height);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                var x = 0;
                for (int i = 0; i < Columns.Count; i++)
                {
                    int lettercount = Columns[i].Count(kvp => kvp.Key != 'X' && kvp.Value > FreqThreshold);
                    if (lettercount > maxAAperCol)
                    {
                        var letterHeight = height;
                        Color color = defColor ?? settings.AminoAcidMotifColors['X'];
                        if (color == null)
                            color = Color.Black;
                        var letterImage = GetLetterImage('X', letterWidth, letterHeight, color);
                        if (letterImage != null)
                        {
                            g.DrawImage(letterImage, x, 0);
                        }
                    }
                    else
                    {
                        if (Columns[i].Count == 0) //no amino acid: leave blank
                        {
                            /*var letterImage = GetLetterImage('X', letterWidth, height, Color.Gray);
                            if (letterImage != null)
                            {
                                g.DrawImage(letterImage, x, 0);
                            }*/
                        }
                        else
                        {
                            if (lettercount < Columns[i].Count()) lettercount++;
                            int usableHeight = height - letterSpacing * (lettercount - 1);
                            var y = 0;
                            bool drawX = false;
                            foreach (KeyValuePair<char, double> kvp in Columns[i].OrderByDescending(kvp => kvp.Value))
                            {
                                if (!Char.IsLetter(kvp.Key))
                                    continue;
                                if (kvp.Key == 'X')
                                {
                                    drawX = true;
                                    continue;
                                }
                                if (kvp.Value < FreqThreshold)
                                {
                                    drawX = true;
                                    break;
                                }
                                var letterHeight = (int)Math.Round(usableHeight * kvp.Value);
                                Color color = defColor ?? (settings.AminoAcidMotifColors.ContainsKey(kvp.Key) ? settings.AminoAcidMotifColors[kvp.Key] : Color.Black);
                                var letterImage = GetLetterImage(kvp.Key, letterWidth, letterHeight, color);
                                if (letterImage != null)
                                {
                                    g.DrawImage(letterImage, x, y);
                                    y += letterHeight + letterSpacing;
                                }
                            }
                            if (drawX)
                            {
                                //draw X for the remainder
                                var letterHeight = height - y - letterSpacing;
                                Color color = defColor ?? (settings.AminoAcidMotifColors.ContainsKey('x') ? settings.AminoAcidMotifColors['X'] : Color.Black);
                                var letterImage = GetLetterImage('X', letterWidth, letterHeight, color);
                                if (letterImage != null)
                                {
                                    g.DrawImage(letterImage, x, y);
                                    y += letterHeight + letterSpacing;
                                }
                            }
                        }
                    }
                    x += letterWidth + positionSpacing;
                }
            }

            return bitmap;
        }

        #endregion

        public static Motif ReadFromFile(string filename)
        {
            try
            {
                Motif motif = null;
                if (File.Exists(filename))
                {
                    motif = JsonConvert.DeserializeObject<Motif>(File.ReadAllText(filename));
                    if (motif.Version == "")
                        motif.Version = "Old version";
                }
                return motif;
            }
            catch (Exception exc) { return null; }
        }

        public static bool SaveToFile(string filename, Motif motif)
        {
            try
            {
                motif.Version = typeof(Analyzer).Assembly.GetName().Version.ToString();
                string json = JsonConvert.SerializeObject(motif);
                File.WriteAllText(filename, json);
                return true;
            }
            catch { return false; }
        }
        public Bitmap GetPositiveMotif(int widthImage, int heightImage)
        {
            return Render(GetScaledColumns(PositiveColumns), widthImage, heightImage, defColor:null);
        }

        public Bitmap GetNegativeMotif(int widthImage, int heightImage)
        {
            return Render(GetScaledColumns(NegativeColumns), widthImage, heightImage, defColor: Common.ColorNegative);
        }

        public Bitmap GetFrequencyMotif(int widthImage, int heightImage)
        {
            if (Frequencies == null || Frequencies.Count() == 0)
                return null;
            return Render(Frequencies, widthImage, heightImage, defColor: null);
        }

        public Bitmap GetBarChart(int width)
        {
            int pepsize = 0;
            if (string.IsNullOrEmpty(WildTypePeptide))
                pepsize = PosCaptions?.Count() ?? 0;
            else
                pepsize = WildTypePeptide.Length;

            //Calculate size for each position
            float maxRange = 0;
            for (int pos = 0; pos < pepsize; pos++)
            {
                Dictionary<char, double> positive = PositiveColumns[pos];
                Dictionary<char, double> negative = NegativeColumns[pos];
                float posrange = positive != null && positive.Count() > 0 ? (float)positive.Values.Max() : 0;
                float negrange = negative != null && negative.Count() > 0 ? (float)negative.Values.Max() : 0;
                float rangeperpos = (float)Math.Max(posrange, negrange);
                if (rangeperpos > maxRange)
                    maxRange = rangeperpos;
            }

            int fontsize = 8;

            //Double the size for better text output
            fontsize *= 2;
            width *= 2;
            int ycoorinc = 50;
            int boxheight = 35;
            float gap = 10;
            int height = (AminoAcidsUsed.Count + 1) * ycoorinc;
            float poswidth = (width - 50) / pepsize;
            float ratio = (poswidth - gap) / (2 * maxRange);

            Settings settings = Settings.Load("default.settings");

            Bitmap bmp = new Bitmap(width, height);
            Dictionary<char, Pen> aaPens = new Dictionary<char, Pen>();
            Brush brush = new SolidBrush(Common.ColorNegative);
            Pen negPen = new Pen(brush);
            foreach (char aachar in AminoAcidsUsed)
            {
                Color col = settings.AminoAcidMotifColors.ContainsKey(aachar) ?
                    settings.AminoAcidMotifColors[aachar] : Color.Black;
                brush = new SolidBrush(col);
                Pen p = new Pen(brush);
                aaPens.Add(aachar, p);
            }

            Font font = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular);
            float xcoor = 5, ycoor = 5;
            using (var g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(Brushes.White, 0, 0, width, height);
                int lineheight = AminoAcidsUsed.Count * ycoorinc + 25;
                for (int pos = 0; pos < pepsize; pos++)
                {
                    xcoor = 50 + (pos * poswidth) + poswidth / 2 + (pos > 0 ? gap : 0);
                    g.DrawLine(Pens.Silver, xcoor, ycoorinc - 5, xcoor, ycoor + lineheight);
                    g.DrawString((pos + 1).ToString(), font, Brushes.Black, xcoor - 5, ycoor);
                }
                xcoor = 5;
                ycoor = ycoorinc;
                foreach (char aachar in AminoAcidsUsed)
                {
                    g.DrawString(aachar.ToString(), font, Brushes.Black, 5, ycoor);
                    for (int pos = 0; pos < pepsize; pos++)
                    {
                        xcoor = 50 + (pos * poswidth) + poswidth / 2 + (pos > 0 ? gap : 0);
                        Dictionary<char, double> positive = PositiveColumns[pos];
                        Dictionary<char, double> negative = NegativeColumns[pos];
                        double? val = null;
                        if (positive.Keys.Contains(aachar))
                            val = positive[aachar];
                        if (negative.Keys.Contains(aachar))
                            val = negative[aachar] * -1;
                        if (val != null)
                        {
                            float f = (float)val;
                            float w = Math.Abs(f) * ratio;
                            if (val > 0)
                                g.FillRectangle(aaPens[aachar].Brush, xcoor + 1, ycoor - 5, w, boxheight);
                            else
                                g.FillRectangle(negPen.Brush, xcoor - w - 1, ycoor - 5, w, boxheight);
                        }
                    }
                    ycoor += ycoorinc;

                }
            }
            foreach (Pen p in aaPens.Values)
                p.Dispose();
            font.Dispose();
            return bmp;
        }

    }
}
