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
        string ProjectName = "";
        string Title = "Create Motif from Peptide List";
        Motif MainMotif, ShiftedMotif;
        public frmMotifCreator()
        {
            InitializeComponent();
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

        private void Run(bool loadpeptides = false)
        {
            if (loadpeptides)
                if (!LoadAndCheckPeptides())
                    return;

            LoadSettings();
            DrawMotifs();
        }
        private void linkRun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Run(true);
        }

        private void lQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If not blank, only peptides with the target amino acid at the key position will be used to create the motif.\r\n" +
                "For others, second motif will be created by bringing another target amino acid to key position if possible.", Analyzer.ProgramName);
        }

        private void ePeptides_TextChanged(object sender, EventArgs e)
        {
            Run(true);
        }

        private void ePeptideLength_Leave(object sender, EventArgs e)
        {
            if (ePeptideLength.Text != peptidelength.ToString())
                Run();
        }
        private void eAminoAcid_Leave(object sender, EventArgs e)
        {
            if (eAminoAcid.Text != keyAA.ToString())
                Run();
        }

        private void eKeyPosition_Leave(object sender, EventArgs e)
        {
            if (eKeyPosition.Text != keyPos.ToString())
            {
                Run();
            }
        }

        private void eFreqThreshold_Leave(object sender, EventArgs e)
        {
            if (eFreqThreshold.Text != threshold.ToString())
                Run();
        }

        private void ClearMotifs()
        {
            MainMotif = ShiftedMotif = null; 
            mdMain.Image = mdShifted.Image = null;
        }

        private void DrawMotifs()
        {
            ClearMotifs();
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
                MainMotif = new Motif(mainList, peptidelength);
                MainMotif.FreqThreshold = threshold;
                Bitmap bm = MainMotif.GetFrequencyMotif(widthImage, heightImage);
                mdMain.Image = bm;

                ShiftedMotif = new Motif(shiftedList, peptidelength);
                ShiftedMotif.FreqThreshold = threshold;
                bm = ShiftedMotif.GetFrequencyMotif(widthImage, heightImage);
                mdShifted.Image = bm;
                mdShifted.Visible = true;
                eOutput.Text += String.Join("\r\nInfo: ", replacements) + "\r\n";
                eOutput.Text += "Motifs are created succesfully.\r\n";
            }
            else
            {
                MainMotif = new Motif(Peptides, peptidelength);
                MainMotif.FreqThreshold = threshold;
                Bitmap bm = MainMotif.GetFrequencyMotif(widthImage, heightImage);
                mdMain.Image = bm;
                mdShifted.Visible = false;
                eOutput.Text += "Motif is created succesfully.\r\n";
            }
        }

        private void lLoadPeptides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dlg = dlgOpenPeptides.ShowDialog();
            if (dlg != DialogResult.OK) return;
            ClearMotifs();
            SetText(dlgOpenPeptides);
            string filename = dlgOpenPeptides.FileName;
            Peptides = FileUtil.ReadPeptideList(filename);
            ePeptides.Text = String.Join("\r\n", Peptides);
        }

        private void SetText(FileDialog dlg)
        {
            ProjectName = FormUtil.SetText(this, dlg, Title);
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Peptides == null || Peptides.Count() == 0) return;
            dlgExcelExport.FileName = "";
            DialogResult dlg = dlgExcelExport.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgExcelExport.FileName;
           /*TODO
                if (FileUtil.Export___(filename, PA, true, out string errormsg))
                MessageBox.Show("Project is exported as an excel file:" + filename, Analyzer.ProgramName);
            else if (errormsg != "")
                MessageBox.Show(errormsg, Analyzer.ProgramName);
           */
        }

        private void btnSaveMotif_Click(object sender, EventArgs e)
        {
            if (MainMotif == null) return;
            dlgSaveMotif.FileName = ProjectName;
            DialogResult dlg = dlgSaveMotif.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgSaveMotif.FileName;

            if (Motif.SaveToFile(filename, MainMotif))
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
        }


        private void cmiPeptideScorer_Click(object sender, EventArgs e)
        {
            if (MainMotif == null) return;
            MainForm frm = (MainForm)MainForm.MainFormPointer;
            frm.RunMotifScorer(false, MainMotif);
        }

        private void cmiProteinScorer_Click(object sender, EventArgs e)
        {
            if (MainMotif == null) return;
            MainForm frm = (MainForm)MainForm.MainFormPointer;
            frm.RunMotifScorer(true, MainMotif);
        }

        private void btnRunScorer_Click(object sender, EventArgs e)
        {
            cmsRunScorer.Show(btnRunScorer, 0, 0);
        }
    }
}
