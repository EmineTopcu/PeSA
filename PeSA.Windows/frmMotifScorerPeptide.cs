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
    public partial class frmMotifScorerPeptide : PeSA.Windows.frmMotifScorerBase
    {
        List<string> Peptides;

        public frmMotifScorerPeptide()
        {
            InitializeComponent();
        }

        public frmMotifScorerPeptide(Motif motif): base(motif)
        {
            InitializeComponent();
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

        protected override void Score()
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
            Scorer = new Scorer();
            Scorer.Motif = Motif;
            Scorer.PeptideList = Peptides;
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

            if (!Int32.TryParse(eTargetPosition.Text, out int keyPosition))
                keyPosition = 0;
            Scorer.KeyPosition = keyPosition - 1;
            if (Scorer.KeyPosition < 0 && !string.IsNullOrEmpty(Motif.WildTypePeptide))
            {
                if (MessageBox.Show("It is recommended to have a key position. Do you want to continue?",
                    "Warning", MessageBoxButtons.OKCancel) != DialogResult.OK)
                {
                    eTargetPosition.Focus();
                    return;
                }
            }
            ClearResults();
            Scorer.StopScoringRequested = false;
            frmProgressDialog prdlg = new frmProgressDialog
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
        private void lSaveScores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveScoresToExcel();
        }

        protected override void ClearResults()
        {
            base.ClearResults();
            dgScores.Rows.Clear();
        }
    }
}
