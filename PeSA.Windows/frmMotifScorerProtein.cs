using PeSA.Engine;
using PeSA.Engine.Data_Structures;
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
    public partial class frmMotifScorerProtein : PeSA.Windows.frmMotifScorerBase
    {
        List<Protein> Proteins;
        public frmMotifScorerProtein()
        {
            InitializeComponent();
        }
        public frmMotifScorerProtein(Motif motif) : base(motif)
        {
            InitializeComponent();
        }

        private void lLoadProteinSeq_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult dlg = dlgOpenProtein.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgOpenProtein.FileName;
            Proteins = FileUtil.ReadProtein(filename);
            eProtein.Text = "";
            foreach (Protein p in Proteins)
                eProtein.Text += p.RawSequence + "\r\n\r\n";
        }

        private void lSaveScores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SaveScoresToExcel();
        }


        private string lastproteinstring = "";
        private void eProtein_Enter(object sender, EventArgs e)
        {
            lastproteinstring = eProtein.Text;
        }

        private void eProtein_Leave(object sender, EventArgs e)
        {
            if (eProtein.Text != lastproteinstring)
                Proteins = Protein.GenerateProteins(eProtein.Text);
        }

        private void AddScoreToGrid(int rowind, Score score)
        {
            dgScores[colProtein.Index, rowind].Value = score.Peptide;
            dgScores[colPosition.Index, rowind].Value = score.StartPos;
            dgScores[colSegment.Index, rowind].Value = score.Segment;
            dgScores[colPosMatch.Index, rowind].Value = score.posMatch;
            dgScores[colNegMatch.Index, rowind].Value = score.negMatch;
            dgScores[colMatchScore.Index, rowind].Value = score.posMatch - score.negMatch;
            dgScores[colWeightScore.Index, rowind].Value = score.weightedMatch.ToString("#.###");
            dgScores[colPriorityScore.Index, rowind].Value = score.priorityMatch.ToString("#.###");
        }

        private void AddScoresToGrid(List<Score> scores)
        {
            colProtein.Visible = Proteins.Count > 1;
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
            if (Proteins.Count == 0)
            {
                MessageBox.Show("Please load a protein sequence to score.");
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
                ProteinList = Proteins
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

            if (!int.TryParse(eTargetPosition.Text, out int keyPosition))
                keyPosition = 0;
            Scorer.KeyPosition = keyPosition - 1;
            if (Scorer.KeyPosition < 0)
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
            frmProgressDialog prdlg = new()
            {
                ProgressMax = (int) Proteins.Sum(p=>Math.Ceiling((double)(p.AASequence.Length - Motif.PeptideLength + 1)))
            };

            Task maintask = Task.Run(() =>
            {
                Scorer.ScoreProteinList(progress => Invoke(new Action(() => prdlg.ProgressValue = progress))); 
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
        protected override void ClearResults()
        {
            base.ClearResults();
            dgScores.Rows.Clear();
        }
    }
}


