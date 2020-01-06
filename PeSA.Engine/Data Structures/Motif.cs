using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace PeSA.Engine
{
    public partial class Motif
    {
        public int ClassVersion = 0;

        public Dictionary<int, Dictionary<char, double>> Columns { get; set; }
        private Settings settings;
        public string WildTypePeptide { get; set; }
        public int KeyPosition { get; set; }

        public Motif(Dictionary<int, Dictionary<char, double>> _Columns, string _WildTypePeptide, int _KeyPosition)
        {
            ClassVersion = typeof(Analyzer).Assembly.GetName().Version.Build;
            Columns = _Columns;
            KeyPosition = _KeyPosition;
            WildTypePeptide = _WildTypePeptide;
            settings = Settings.Load("default.settings");
        }

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
            var initialFontSize = (int)(Math.Max(width, height) / 1.5);

            var fullSizeBitmap = new Bitmap(initialFontSize * 2, initialFontSize * 2);
            var scaledBitmap = new Bitmap(width, height);

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

        public Bitmap Render(int width, int height, int positionSpacing = 10, int letterSpacing = 3, double threshold = 0.1, int maxAAperCol = 20)
        {
            int letterWidth = (width - positionSpacing * (Columns.Count - 1)) / Columns.Count;

            Bitmap bitmap = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                g.FillRectangle(Brushes.White, 0, 0, width, height);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                var x = 0;
                for (int i = 0; i < Columns.Count; i++)
                {
                    int lettercount = Columns[i].Count(kvp => kvp.Key != 'X' && kvp.Value > threshold);
                    if (lettercount > maxAAperCol)
                    {
                        var letterHeight = height;
                        Color color = settings.AminoAcidMotifColors['X'];
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
                        if (Columns[i].Count == 0) //no amino acid: draw gray X
                        {
                            var letterImage = GetLetterImage('X', letterWidth, height, Color.Gray);
                            if (letterImage != null)
                            {
                                g.DrawImage(letterImage, x, 0);
                            }
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
                                if (kvp.Value < threshold)
                                {
                                    drawX = true;
                                    break;
                                }
                                var letterHeight = (int)Math.Round(usableHeight * kvp.Value);
                                Color color = settings.AminoAcidMotifColors.ContainsKey(kvp.Key) ? settings.AminoAcidMotifColors[kvp.Key] : Color.Black;
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
                                Color color = settings.AminoAcidMotifColors.ContainsKey('x') ? settings.AminoAcidMotifColors['X'] : Color.Black;
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

        public static Motif ReadFromFile(string filename)
        {
            try
            {
                Motif motif = null;
                if (File.Exists(filename))
                    motif = JsonConvert.DeserializeObject<Motif>(File.ReadAllText(filename));

                return motif;
            }
            catch { return null; }
        }

        public static bool SaveToFile(string filename, Motif motif)
        {
            try
            {
                string json = JsonConvert.SerializeObject(motif);
                File.WriteAllText(filename, json);
                return true;
            }
            catch { return false; }
        }
    }
}
