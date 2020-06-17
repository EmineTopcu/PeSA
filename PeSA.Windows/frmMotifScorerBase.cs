using PeSA.Engine;
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
        public frmMotifScorerBase()
        {
            InitializeComponent();
        }

        private void SetText(FileDialog dlg)
        {
            ProjectName = FormUtil.SetText(this, dlg, Title);
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
            Settings settings = Settings.Load("default.settings");
            int heightImage = 200;
            int widthImage = 800;
            if (settings != null)
            {
                heightImage = settings.MotifHeight;
                widthImage = settings.MotifWidth;
            }
            mdPositive.Image = Motif.GetPositiveMotif(widthImage, heightImage);
            mdNegative.Image = Motif.GetNegativeMotif(widthImage, heightImage);
            mdChart.Image = Motif.GetBarChart(pMotif.Width - 6);
            ePositiveThreshold.Text = Motif.PositiveThreshold.ToString();
            toolTip1.SetToolTip(eScorerPosThreshold, string.Format("Range: [{0:N2}, {1:N2}]", Motif.PositiveThreshold, Motif.MaxPosWeight));
            eNegativeThreshold.Text = Motif.NegativeThreshold.ToString();
            toolTip1.SetToolTip(eScorerNegThreshold, string.Format("Range: [{0:N2}, {1:N2}]", 0, Motif.NegativeThreshold));
            eWildtype.Text = Motif.WildTypePeptide;
            eTarget.Text = "";
        }
        private void btnLoadMotif_Click(object sender, EventArgs e)
        {
            LoadMotif();
        }
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
    }
}
