using PeSA.Engine;
using PeSA.Engine.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeSA.Windows
{
    public partial class frmMotifScorerBase : Form
    {
        protected Motif Motif;
        string Title = "Motif Based Scoring";
        string ProjectName = "";
        protected Scorer Scorer = null;
        protected int keyPosition;
        protected char keyAA;
        public frmMotifScorerBase()
        {
            InitializeComponent();
        }

        public frmMotifScorerBase(Motif motif)
        {
            InitializeComponent();
            Motif = motif;
            DisplayMotif();
        }
        private void SetText(FileDialog dlg)
        {
            ProjectName = FormUtil.SetText(this, dlg, Title);
        }

        private void DisplayMotif()
        {
            if (Motif == null) return;

            Settings settings = Settings.Load("default.settings");
            int heightImage = 200;
            int widthImage = 800;
            if (settings != null)
            {
                heightImage = settings.MotifHeight;
                widthImage = settings.MotifWidth;
            }
            if (Motif.PositiveColumns != null)
                mdPositive.Image = Motif.GetPositiveMotif(widthImage, heightImage);
            else if (Motif.Frequencies != null)
                mdPositive.Image = Motif.GetFrequencyMotif(widthImage, heightImage);
            else mdPositive.Image = null;
            if (Motif.NegativeColumns != null)
                mdNegative.Image = Motif.GetNegativeMotif(widthImage, heightImage);
            else
            {
                mdNegative.Visible = false;
                mdNegative.Image = null;
            }
            if (Motif.PositiveColumns != null)
                mdChart.Image = Motif.GetBarChart(pMotif.Width - 6);
            else
                mdChart.Visible = false;

            ePositiveThreshold.Text = Motif.PositiveThreshold.ToString();
            toolTip1.SetToolTip(eScorerPosThreshold, string.Format("Range: [{0:N2}, {1:N2}]", Motif.PositiveThreshold, Motif.MaxPosWeight));
            eNegativeThreshold.Text = Motif.NegativeThreshold.ToString();
            toolTip1.SetToolTip(eScorerNegThreshold, string.Format("Range: [{0:N2}, {1:N2}]", 0, Motif.NegativeThreshold));
            eWildtype.Text = Motif.WildTypePeptide;
            eTargetPosition.Text = "";
            eTargetAminoAcid.Text = "";
        }
        private void LoadMotif()
        {
            DialogResult dlg = dlgOpenMotif.ShowDialog();
            if (dlg != DialogResult.OK) return;
            SetText(dlgOpenMotif);
            string filename = dlgOpenMotif.FileName;
            try
            {
                Motif = Motif.ReadFromFile(filename);
            }
            catch
            {
                MessageBox.Show("The file may be corrupted or not a valid PeSA motif file.", Analyzer.ProgramName);
            }
            DisplayMotif();
            ClearResults();
        }
        private void btnLoadMotif_Click(object sender, EventArgs e)
        {
            LoadMotif();
        }
        protected virtual void ClearResults()
        { }

        protected virtual void Score()
        { }
        private void btnScore_Click(object sender, EventArgs e)
        {
            Score();
        }
        protected void SaveScoresToExcel()
        {
            if (Motif == null || Scorer == null || Scorer.ScoreList.Count == 0)
                return;
            dlgExcelExport.FileName = ProjectName;
            DialogResult dlg = dlgExcelExport.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgExcelExport.FileName;
            string errormsg = "";
            if (FileUtil.ExportScoresToExcel(filename, Scorer, true, out errormsg))
                MessageBox.Show("Project is exported as an excel file:" + filename, Analyzer.ProgramName);
            else if (errormsg != "")
                MessageBox.Show(errormsg, Analyzer.ProgramName);
        }

        private void eTargetPosition_Leave(object sender, EventArgs e)
        {
            if (Motif == null)
            {
                eTargetAminoAcid.Text = "";
                return;
            }
            keyPosition = 0;
            keyAA = ' ';
            if (Int32.TryParse(eTargetPosition.Text, out keyPosition))
            {
                if (keyPosition <= 0 || keyPosition > Motif.PeptideLength)
                {
                    MessageBox.Show("The target position should be within the length of the motif.", Analyzer.ProgramName);
                }
                if (keyPosition > 0)
                    keyAA = Motif.GetKeyChar(keyPosition - 1);
            }
            eTargetAminoAcid.Text = keyAA.ToString().Trim();          

        }

        private void lQuestion_Click(object sender, EventArgs e)
        {
            string keyaaDesc = "If wildtype peptide exists, the target amino acid is set using the wildtype peptide. Otherwise, the highest frequency/weighed amino acid from the selected position of the motif is selected.";
            MessageBox.Show(keyaaDesc, Analyzer.ProgramName);
        }
    }
}
