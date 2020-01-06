using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeSA.Engine;
using static PeSA.Engine.Settings;

namespace PeSA.Windows
{
    
    public partial class frmMotifCreator : Form
    {
        List<string> Peptides;
        int PepSize = 0;
        char keyAA = ' ';
        int keyPos, widthImage, heightImage;
        double threshold;

        public frmMotifCreator()
        {
            InitializeComponent();
            Settings settings = Settings.Load("default.settings");
            if (settings != null)
            {
                eMotifHeight.Text = settings.MotifHeight.ToString();
                eMotifWidth.Text = settings.MotifWidth.ToString();
            }
        }

        public frmMotifCreator(List<string> peptides)
        {
            InitializeComponent();
            Settings settings = Settings.Load("default.settings");
            if (settings != null)
            {
                eMotifHeight.Text = settings.MotifHeight.ToString();
                eMotifWidth.Text = settings.MotifWidth.ToString();
                eThreshold.Text = settings.MotifThreshold.ToString();
            }
            Peptides = peptides;
            ePeptides.Text = String.Join("\r\n", Peptides);
        }

        private void btnLoadPeptideList_Click(object sender, EventArgs e)
        {
            DialogResult dlg = dlgOpenPeptides.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgOpenPeptides.FileName;
            Peptides = FileUtil.ReadPeptideList(filename);
            ePeptides.Text = String.Join("\r\n", Peptides);
        }

        private void LoadSettings()
        {
            int midpoint = PepSize / 2;
            if (Int32.TryParse(eKeyPosition.Text, out keyPos) && keyPos <= PepSize && keyPos > 0)
                midpoint = keyPos - 1;
            else
            {
                keyPos = midpoint + 1;
                eKeyPosition.Text = keyPos.ToString();
            }

            if (!Int32.TryParse(eMotifWidth.Text, out widthImage) || widthImage<=0)
            {
                widthImage = 800;
                eMotifWidth.Text = widthImage.ToString();
            }
            if (!Int32.TryParse(eMotifHeight.Text, out heightImage) | heightImage <= 0)
            {
                heightImage = 200;
                eMotifHeight.Text = heightImage.ToString();
            }
            if (!Double.TryParse(eThreshold.Text, out threshold))
            {
                threshold = 0.05;
                eThreshold.Text = threshold.ToString();
            }
            if (!Char.TryParse(eAminoAcid.Text.Trim(), out keyAA))
            {
                keyAA = ' ';
                eAminoAcid.Text = keyAA.ToString();
            }
            else if (Char.IsLower(keyAA))
                keyAA = Char.ToUpper(keyAA);
        }

        private bool LoadAndCheckPeptides()
        {
            if (string.IsNullOrEmpty(ePeptides.Text))
                return false;
            Peptides = ePeptides.Text.Split('\n').ToList();
            Peptides = Peptides.Select(s => s.Replace("\t", "").Replace("\r", "").Replace("\n", "")).ToList();
            Peptides = Peptides.Where(s => s.Length > 0).ToList();

            if (!Int32.TryParse(ePeptideLength.Text, out PepSize) || PepSize <= 0)
            {
                PepSize = Peptides[0].Length;
            }
            List<string> errors, warnings;
            Analyzer.CheckPeptideList(Peptides, PepSize, out warnings, out errors);
            Peptides = Peptides.Select(s => s.Substring(0, Math.Min(s.Length, PepSize))).ToList();
            if (errors.Count > 0)
                eOutput.Text += String.Join("\r\nError: ", errors) + "\r\n";
            if (warnings.Count > 0)
                eOutput.Text += String.Join("\r\nWarning: ", warnings) + "\r\n";
            if (errors.Count > 0)
            {
                MessageBox.Show("Please check the peptide list for accuracy before proceeding. Details are listed in the output window.", Analyzer.ProgramName);
                return false;
            }
            if (warnings.Count > 0)
            {
                MessageBox.Show("Please check the peptide list for accuracy. Details are listed in the output window.", Analyzer.ProgramName);
            }
            return true;
        }

        private void lQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If not blank, only peptides with the target amino acid at the key position will be used to create the motif.\r\n" +
                "For others, second motif will be created by bringing another target amino acid to key position if possible.", Analyzer.ProgramName);
        }

        private void btnCreateMotif_Click(object sender, EventArgs e)
        {
            eOutput.Text = "";
            if (!LoadAndCheckPeptides())
                return;
            LoadSettings();

            if (keyAA != ' ')
            {
                Bitmap bm1 = null;
                Bitmap bm2 = null;
                bm1 = Analyzer.CreateMotif(Peptides.Where(s => s[keyPos - 1] == keyAA).ToList(), PepSize, keyPos, threshold, widthImage, heightImage);
                if (Peptides.Count(s => s[keyPos - 1] != keyAA) > 0)
                {
                    List<string> replacements;
                    List<string> peptidesShifted = Analyzer.ShiftPeptides(Peptides.Where(s => s[keyPos - 1] != keyAA).ToList(), keyAA, PepSize, keyPos - 1, out replacements);
                    eOutput.Text += String.Join("\r\nInfo: ", replacements) + "\r\n";
                    bm2 = Analyzer.CreateMotif(peptidesShifted.Where(s => s[keyPos - 1] == keyAA).ToList(), PepSize, keyPos, threshold, widthImage, heightImage);
                }
                frmMotifImage frmImage = new frmMotifImage(bm1, "Main motif", bm2, "Shifted motif");
                frmImage.MdiParent = MainForm.MainFormPointer;
                frmImage.WindowState = FormWindowState.Normal;
                frmImage.Show();
                frmImage.WindowState = FormWindowState.Normal;
                eOutput.Text += "Motifs are created succesfully.\r\n";
            }
            else
            {
                Bitmap bm1 = null;
                bm1 = Analyzer.CreateMotif(Peptides, PepSize, keyPos, threshold, widthImage, heightImage);
                if (bm1 != null)
                {
                    frmMotifImage frmImage = new frmMotifImage(bm1, "Main motif", null, "");
                    frmImage.MdiParent = MainForm.MainFormPointer;
                    frmImage.WindowState = FormWindowState.Normal;
                    frmImage.Show();
                    frmImage.WindowState = FormWindowState.Normal;
                    eOutput.Text += "Motif is created succesfully.\r\n";
                }
                else
                {

                }
            }
        }

        private void ePeptides_FontChanged(object sender, EventArgs e)
        {
            try
            {
                ePeptides.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            catch 
            {
            }
        }
    }
}
