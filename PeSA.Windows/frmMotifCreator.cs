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
        int peptidelength = 0;
        char keyAA = ' ';
        int keyPos;
        double threshold;

        public frmMotifCreator()
        {
            InitializeComponent();
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
            if (!Int32.TryParse(ePeptideLength.Text, out peptidelength) || peptidelength <= 0)
            {
                peptidelength = Peptides[0].Length;
                ePeptideLength.Text = peptidelength.ToString();
            }

            int midpoint = peptidelength / 2;
            if (Int32.TryParse(eKeyPosition.Text, out keyPos) && keyPos <= peptidelength && keyPos > 0)
                midpoint = keyPos - 1;
            else
            {
                keyPos = midpoint + 1;
                eKeyPosition.Text = keyPos.ToString();
            }

            if (!Double.TryParse(eFreqThreshold.Text, out threshold))
            {
                threshold = 0.05;
                eFreqThreshold.Text = threshold.ToString();
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

            if (!Int32.TryParse(ePeptideLength.Text, out peptidelength) || peptidelength <= 0)
            {
                peptidelength = Peptides[0].Length;
                ePeptideLength.Text = peptidelength.ToString();
            }
            List<string> errors, warnings;
            Analyzer.CheckPeptideList(Peptides, peptidelength, out warnings, out errors);
            Peptides = Peptides.Select(s => s.Substring(0, Math.Min(s.Length, peptidelength))).ToList();
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

        private void ePeptides_TextChanged(object sender, EventArgs e)
        {
            LoadAndCheckPeptides();
            LoadSettings();
            DrawMotifs();
        }

        private void ePeptideLength_Leave(object sender, EventArgs e)
        {
            if (ePeptideLength.Text != peptidelength.ToString())
            {
                LoadSettings();
                DrawMotifs();
            }
        }
        private void eAminoAcid_Leave(object sender, EventArgs e)
        {
            if (eAminoAcid.Text != keyAA.ToString())
            {
                LoadSettings();
                DrawMotifs();
            }
        }

        private void eKeyPosition_Leave(object sender, EventArgs e)
        {
            if (eKeyPosition.Text != keyPos.ToString())
            {
                LoadSettings();
                DrawMotifs();
            }
        }

        private void eFreqThreshold_Leave(object sender, EventArgs e)
        {
            if (eFreqThreshold.Text != threshold.ToString())
            {
                LoadSettings();
                DrawMotifs();
            }
        }

        private void DrawMotifs()
        {
            Settings settings = Settings.Load("default.settings");
            int heightImage = 200;
            int widthImage = 800;
            if (settings != null)
            {
                heightImage = settings.MotifHeight;
                widthImage = settings.MotifWidth;
            }

            int midpoint = peptidelength / 2;
            if (Int32.TryParse(eKeyPosition.Text, out keyPos) && keyPos <= peptidelength && keyPos > 0)
                midpoint = keyPos - 1;
            else
            {
                keyPos = midpoint + 1;
                eKeyPosition.Text = keyPos.ToString();
            }

            if (!Char.TryParse(eAminoAcid.Text.Trim(), out keyAA))
            {
                keyAA = ' ';
                eAminoAcid.Text = keyAA.ToString();
            }
            else if (Char.IsLower(keyAA))
                keyAA = Char.ToUpper(keyAA);

            if (keyAA != ' ')
            {
                List<string> mainList = Peptides.Where(s => s[keyPos - 1] == keyAA).ToList();

                List<string> shiftedList = Analyzer.ShiftPeptides(Peptides.Where(s => s[keyPos - 1] != keyAA).ToList(), keyAA, peptidelength, keyPos - 1, out List<string> replacements);
                Motif motif = new Motif(mainList, peptidelength);
                motif.FreqThreshold = threshold;
                Bitmap bm = motif.GetFrequencyMotif(widthImage, heightImage);
                mdMain.Image = bm;

                motif = new Motif(shiftedList, peptidelength);
                motif.FreqThreshold = threshold;
                bm = motif.GetFrequencyMotif(widthImage, heightImage);
                mdShifted.Image = bm;
                mdShifted.Visible = true;
                eOutput.Text += String.Join("\r\nInfo: ", replacements) + "\r\n";
                eOutput.Text += "Motifs are created succesfully.\r\n";
            }
            else
            {
                Motif motif = new Motif(Peptides, peptidelength);
                motif.FreqThreshold = threshold;
                Bitmap bm = motif.GetFrequencyMotif(widthImage, heightImage);
                mdMain.Image = bm;
                mdShifted.Visible = false;
                eOutput.Text += "Motif is created succesfully.\r\n";
            }
        }

        private void lLoadPeptides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dlg = dlgOpenPeptides.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgOpenPeptides.FileName;
            Peptides = FileUtil.ReadPeptideList(filename);
            ePeptides.Text = String.Join("\r\n", Peptides);
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
