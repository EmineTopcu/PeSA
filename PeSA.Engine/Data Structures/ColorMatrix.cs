using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeSA.Engine
{
    public class ColorMatrix
    {
        private double hueStart = 1, hueEnd = 1;
        private double saturationStart = 1, saturationEnd = 1;
        private double brightnessStart = 1, brightnessEnd = 1;
        private ColorMatrixTheme Theme;
        private double[,] NumericMatrix;
        private char[] ColumnHeader;
        private char[] RowHeader;
        private double minValue, maxValue;
        private int scalaWidth = 50;
        private int scalaLabelWidth = 50;
        private int imgWidth, imgHeight;
        Font textfont = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        public void SetTheme(ColorMatrixTheme theme)
        {
            Theme = theme;
            ColorToHSV(theme.StartColor, out hueStart, out saturationStart, out brightnessStart);
            ColorToHSV(theme.EndColor, out hueEnd, out saturationEnd, out brightnessEnd);
        }

        public void SetData(double[,] matrix, char[] colHeader = null, char[] rowHeader = null)
        {
            NumericMatrix = matrix;
            if (colHeader != null)
                ColumnHeader = colHeader;
            if (rowHeader != null)
                RowHeader = rowHeader;
        }

        public ColorMatrix()
        {
        }

        public static void ColorToHSV(Color color, out double hue, out double saturation, out double value)
        {
            //https://stackoverflow.com/questions/1335426/is-there-a-built-in-c-net-system-api-for-hsv-to-rgb
            int max = Math.Max(color.R, Math.Max(color.G, color.B));
            int min = Math.Min(color.R, Math.Min(color.G, color.B));

            hue = color.GetHue();
            saturation = (max == 0) ? 0 : 1d - (1d * min / max);
            value = max / 255d;
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)
        {
            //https://stackoverflow.com/questions/1335426/is-there-a-built-in-c-net-system-api-for-hsv-to-rgb
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);

            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0)
                return Color.FromArgb(255, v, t, p);
            else if (hi == 1)
                return Color.FromArgb(255, q, v, p);
            else if (hi == 2)
                return Color.FromArgb(255, p, v, t);
            else if (hi == 3)
                return Color.FromArgb(255, p, q, v);
            else if (hi == 4)
                return Color.FromArgb(255, t, p, v);
            else
                return Color.FromArgb(255, v, p, q);
        }

        /// <summary>
        /// Returns the color within the scale between ColorStart and ColorEnd
        /// </summary>
        /// <param name="dist">between 0 and 1</param>
        /// <returns></returns>
        public Color GetColor(double dist, bool flip = false)
        {
            if (dist < 0 || dist > 1) return Color.Black;
            double hueScale = hueEnd - hueStart;
            if (hueEnd < hueStart)
                hueScale += 360;
            int mult = 1;
            if (flip)
                hueScale = hueScale - 360;
            double hue = hueStart + dist * hueScale * mult;
            if (hue < 0) hue += 360;
            else if (hue > 360) hue -= 360;
            double saturation = saturationStart + dist * (saturationEnd - saturationStart);
            double brightness = brightnessStart + dist * (brightnessEnd - brightnessStart);

            return ColorFromHSV(hue, saturation, brightness);
        }

        public Bitmap CreateVisualMatrix(double posThreshold, double negThreshold)
        {
            if (Theme == null) return null;
            minValue = double.MaxValue;
            maxValue = double.MinValue;
            int numCols = NumericMatrix.GetLength(1);
            int numRows = NumericMatrix.GetLength(0);
            for (int i = 0; i < numRows; i++)
                for (int j = 0; j < numCols; j++)
                {
                    if (NumericMatrix[i, j] > maxValue)
                        maxValue = NumericMatrix[i, j];
                    if (NumericMatrix[i, j] < minValue)
                        minValue = NumericMatrix[i, j];
                }

            int poswidth = (int)(Theme.Dia * 1.5);

            Brush fontBrush = new SolidBrush(Theme.FontColor);
            Brush bgBrush = new SolidBrush(Theme.BackgroundColor);

            int left = scalaLabelWidth + scalaWidth;
            int width = (numCols + 1) * poswidth;
            imgHeight = (numRows + 1) * poswidth;
            imgWidth = width + left;

            Bitmap bmp = new Bitmap(imgWidth, imgHeight);
            List<Pen> usedPens = new List<Pen>();
            List<Brush> usedBrushes = new List<Brush>();

            int fontsize = Theme.Dia >= 200 ? Theme.Dia - 12 : Math.Max(Theme.Dia - 4, 6);
            Font font = new Font("Microsoft Sans Serif", fontsize, FontStyle.Regular);
            float buffer = Theme.Dia / 10;
            float ycoor = buffer;
            using (var g = Graphics.FromImage(bmp))
            {
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;

                //Fill the background
                g.FillRectangle(Brushes.Transparent, 0, 0, left, imgHeight);
                g.FillRectangle(bgBrush, left, 0, width , imgHeight);
                float xcoor;
                //Draw the visual matrix
                for (int pos = 0; pos < numCols; pos++)
                {
                    xcoor = (pos + 1) * poswidth + left;
                    g.DrawString(ColumnHeader[pos].ToString(), font, fontBrush, xcoor - buffer, ycoor);
                }
                xcoor = buffer + left;
                ycoor = buffer + poswidth;
                double dist;
                for (int i = 0; i < numRows; i++)
                {
                    g.DrawString(RowHeader[i].ToString(), font, fontBrush, xcoor - buffer, ycoor - buffer);
                    xcoor += poswidth;
                    for (int j = 0; j < numCols; j++)
                    {
                        dist = (NumericMatrix[i, j] - minValue) / (maxValue - minValue);
                        Color col = GetColor(dist, Theme.Flip);
                        Brush brush = new SolidBrush(col);
                        usedBrushes.Add(brush);
                        Pen p = new Pen(brush);
                        usedPens.Add(p);
                        g.FillEllipse(brush, xcoor, ycoor, Theme.Dia, Theme.Dia);
                        xcoor += poswidth;
                    }
                    ycoor += poswidth;
                    xcoor = buffer + left;
                }

                //Draw the scala
                dist = 1;
                ycoor = 0;
                double inc = 10;
                while (dist >= 0)
                {
                    Color col = GetColor(dist, Theme.Flip);
                    Pen p = new Pen(col);
                    usedPens.Add(p);
                    g.DrawRectangle(p, scalaLabelWidth, ycoor, scalaWidth, (int)inc);
                    g.FillRectangle(new SolidBrush(col), scalaLabelWidth, ycoor, scalaWidth, (int)inc);
                    //g.DrawString(col.GetHue().ToString("0"), font, Brushes.Black, xcoor, 0);
                    col = GetColor(dist, true);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    dist -= inc / imgHeight;
                    ycoor += (int)inc;
                }
                DrawBar(g, posThreshold);
                DrawBar(g, negThreshold);
                g.DrawString(maxValue.ToString("0.###"), textfont, Brushes.Black, 5, 0);
                g.DrawString(minValue.ToString("0.###"), textfont, Brushes.Black, 5, imgHeight - 2 * textfont.Size);
            }
            foreach (Pen p in usedPens)
                p.Dispose();
            foreach (Brush b in usedBrushes)
                b.Dispose();
            font.Dispose();
            return bmp;
        }

        private void DrawBar(Graphics g, double threshold)
        {
            if (threshold < minValue || threshold > maxValue)
                return;
            double fromtop = (maxValue - threshold) / (maxValue - minValue);
            Pen p = Pens.Black;
            if (Theme.ThemeName == "Grayscale")
                p = Pens.Red;
            int ycoor = (int)(fromtop * imgHeight);
            g.DrawLine(p, scalaLabelWidth, ycoor, scalaLabelWidth + scalaWidth, ycoor);
            g.DrawString(threshold.ToString("0.###"), textfont, Brushes.Black, 5, ycoor - textfont.Size);
        }
    }
}

