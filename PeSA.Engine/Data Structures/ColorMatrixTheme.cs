using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeSA.Engine
{
    public class ColorMatrixTheme
    {
        public string ThemeName { get; set; }
        public Color StartColor { get; set; }
        public Color EndColor { get; set; }
        public Color FontColor { get; set; }
        public Color BackgroundColor { get; set; }
        public bool Flip { get; set; }
        public int Dia { get; set; }
        public ColorMatrixTheme()
        {
            ThemeName = "Custom";
            StartColor = Color.White;
            EndColor = Color.Black;
            FontColor = Color.Black;
            BackgroundColor = Color.White;
            Dia = 20;
            Flip = false;
        }
    }
}
