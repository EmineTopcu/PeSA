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
    public partial class frmMotifScorer : Form
    {
        Motif Motif;
        string Title = "Motif Based Scoring";
        string ProjectName = "";
        List<string> Peptides;
        Scorer Scorer = null;
        public frmMotifScorer()
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

        private void lLoadPeptides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dlg = dlgOpenPeptides.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgOpenPeptides.FileName;
            Peptides = FileUtil.ReadPeptideList(filename);
            ePeptides.Text = String.Join("\r\n", Peptides);
        }

        private void AddScoreToGrid(int rowind, Score score)
        {
            dgScores[colPeptide.Index, rowind].Value = score.Peptide;
            dgScores[colSegment.Index, rowind].Value = score.Segment;
            dgScores[colPosMatch.Index, rowind].Value = score.posMatch;
            dgScores[colNegMatch.Index, rowind].Value = score.negMatch;
            dgScores[colMatchScore.Index, rowind].Value = score.posMatch - score.negMatch;
            dgScores[colWeightScore.Index, rowind].Value = score.weightedMatch.ToString("#.###");
            dgScores[colPriorityScore.Index, rowind].Value = score.priorityMatch.ToString("#.###");
        }

        private void AddScoresToGrid(List<Score> scores)
        {
            dgScores.Rows.Clear();
            if (scores != null)
            {
                dgScores.RowCount = scores.Count;
                int rowind = 0;
                foreach (Score s in scores)
                    AddScoreToGrid(rowind++, s);
            }
        }

        private void Score()
        {
            Peptides = ePeptides.Text
                .Split('\n')
                .Select(p => p.Trim())
                .Where(p => !string.IsNullOrEmpty(p))
                .ToList();
            if (Peptides.Count == 0)
            {
                MessageBox.Show("Please load a peptide list to score.");
                return;
            }
            if (Motif == null)
            {
                MessageBox.Show("Please load a motif.");
                return;
            }
            Scorer = new Scorer
            {
                Motif = Motif,
                PeptideList = Peptides
            };
            if (double.TryParse(eScorerPosThreshold.Text, out double posthres))
                Scorer.UserEnteredPosThreshold = posthres;
            else
                Scorer.UserEnteredPosThreshold = null;
            if (double.TryParse(eScorerNegThreshold.Text, out double negthres))
                Scorer.UserEnteredNegThreshold = negthres;
            else
                Scorer.UserEnteredNegThreshold = null;
            if (int.TryParse(ePosCutoff.Text, out int poscutoff))
                Scorer.PosMatchCutoff = poscutoff;
            if (int.TryParse(eNegCutoff.Text, out int negcutoff))
                Scorer.NegMatchCutoff = negcutoff;

            if (!Int32.TryParse(eTarget.Text, out int keyPosition))
                keyPosition = 0;
            Scorer.KeyPosition = keyPosition - 1;
            if (Scorer.KeyPosition < 0)
            {
                if (MessageBox.Show("It is recommended to have a key position. Do you want to continue?",
                    "Warning", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    eTarget.Focus();
                    return;
                }
            }
            dgScores.Rows.Clear();
            Scorer.StopScoringRequested = false;
            frmProgressDialog prdlg = new()
            {
                ProgressMax = Peptides.Count
            };

            Task maintask = Task.Run(() =>
            {
                Scorer.ScorePeptideList(() => Invoke(new Action(() => prdlg.ProgressValue++)));
                Thread.Sleep(200);
                Invoke(new Action(() => prdlg.Close()));
            });

            if (prdlg.ShowDialog() == DialogResult.Cancel)
            {
                Scorer.StopScoringRequested = true;
            }
            maintask.Wait();
            AddScoresToGrid(Scorer.ScoreList);
        }

        private void btnScore_Click(object sender, EventArgs e)
        {
            Score();
        }

        private void lSaveScores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Motif == null || Scorer == null || Scorer.ScoreList.Count == 0)
                return;
            dlgExcelExport.FileName = ProjectName;
            DialogResult dlg = dlgExcelExport.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgExcelExport.FileName;
            if (FileUtil.ExportScoresToExcel(filename, Scorer, true, out string errormsg))
                MessageBox.Show("Project is exported as an excel file:" + filename, Analyzer.ProgramName);
            else if (errormsg != "")
                MessageBox.Show(errormsg, Analyzer.ProgramName);
        }
    }
}
