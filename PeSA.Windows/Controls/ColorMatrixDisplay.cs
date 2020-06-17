using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeSA.Engine;

namespace PeSA.Windows.Controls
{
    public partial class ColorMatrixDisplay : UserControl
    {
        private Settings settings;
        private ColorMatrixTheme selectedTheme;
        private ColorMatrix ColorMatrix;
        public double PositiveThreshold, NegativeThreshold;
        public ColorMatrixDisplay()
        {
            InitializeComponent();
            settings = Settings.Load("default.settings");
        }
        public void SetColorMatrix(ColorMatrix cm)
        {
            ColorMatrix = cm;
            selectedTheme = settings.GetMatrixTheme(rbColorScale.Checked);
            selectedTheme.Dia = 20;// (int)eCircleDia.Value;
            ColorMatrix.SetTheme(selectedTheme);
            Image = ColorMatrix.CreateVisualMatrix(PositiveThreshold, NegativeThreshold);
        }
        public void SetThreshold(double posThreshold, double negThreshold)
        {
            PositiveThreshold = posThreshold;
            NegativeThreshold = negThreshold;
            Image = ColorMatrix?.CreateVisualMatrix(PositiveThreshold, NegativeThreshold);
        }

        public Image Image 
        {
            get { return pbColorMatrix.Image; }
            set
            {
                pbColorMatrix.Image = value;
            }
        }

        private void rbColorScale_CheckedChanged(object sender, EventArgs e)
        {
            if (ColorMatrix == null)
            {
                Image = null;
                return;
            }

            selectedTheme = settings.GetMatrixTheme(rbColorScale.Checked);
            selectedTheme.Dia = 20;// (int)eCircleDia.Value;
            ColorMatrix.SetTheme(selectedTheme);
            Image = ColorMatrix.CreateVisualMatrix(PositiveThreshold, NegativeThreshold);
        }

        private void linkCopyImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetImage(pbColorMatrix.Image);
        }

        private void linkSaveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult dlg = dlgSaveImage.ShowDialog();
                if (dlg != DialogResult.OK) return;
                string filename = dlgSaveImage.FileName;
                pbColorMatrix.Image.Save(filename);
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is a problem with saving the image file.\r\n" + exc.Message, Analyzer.ProgramName);
            }
        }
       
    }
}
