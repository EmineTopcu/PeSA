using PeSA.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PeSA.Windows
{

    public partial class MainForm : Form
    {
        public static Form MainFormPointer;
        public Settings DefaultSettings;
        public MainForm()
        {
            InitializeComponent();
            MainFormPointer = this;
            DefaultSettings = Settings.Load("default.settings");
        }

        private int sepIndex = -1;
        public void AddWindowMenuItem(Form frm)
        {
            frm.FormClosed += MdiChildClosed;
            if (sepIndex == -1)
            {
                ToolStripItem si = mWindow.DropDownItems.Add("-");
                sepIndex = mWindow.DropDownItems.Count;
            }
            ToolStripItem mi = mWindow.DropDownItems.Add(frm.Text);
            mi.Tag = frm;
            mi.Click += WindowsMenuItemClick;
        }

        public void UpdateWindowMenuItem(Form frm)
        {
            try
            {
                foreach (ToolStripItem mi in mWindow.DropDownItems)
                    if (mi.Tag == frm)
                    {
                        mi.Text = frm.Text;
                        break;
                    }
            }
            catch { }
        }

        private void WindowsMenuItemClick(object sender, EventArgs e)
        {
            ToolStripItem mi = sender as ToolStripItem;
            if (mi.Tag != null)
            {
                Form frm = mi.Tag as Form;
                frm.Activate();
            }
        }

        private void MdiChildClosed(object sender, FormClosedEventArgs e)
        {
            foreach (ToolStripItem mi in mWindow.DropDownItems)
                if (mi.Tag == sender)
                {
                    mWindow.DropDownItems.Remove(mi);
                    break;
                }
            if (sepIndex == mWindow.DropDownItems.Count)
            {
                mWindow.DropDownItems.RemoveAt(sepIndex - 1);
                sepIndex = -1;
            }
        }


        private void AnalyzePeptideList()
        {
            frmMotifCreator frm = new frmMotifCreator
            {
                MdiParent = this
            };
            frm.Show();
            AddWindowMenuItem(frm);
        }
        private void AnalyzePeptideArray()
        {
            frmAnalyzePeptideArray frm = new frmAnalyzePeptideArray();
            frm.MdiParent = this;
            frm.Show();
            AddWindowMenuItem(frm);
        }
        private void AnalyzePermutationArray()
        {
            frmAnalyzePermutationArray frm = new frmAnalyzePermutationArray
            {
                MdiParent = this
            };
            frm.Show();
            AddWindowMenuItem(frm);
        }
        private void AnalyzeOPALArray()
        {
            frmAnalyzeOPALArray frm = new frmAnalyzeOPALArray();
            frm.MdiParent = this;
            frm.Show();
            AddWindowMenuItem(frm);
        }
        private void RunSequenceGenerator()
        {
            frmSequenceGenerator frm = new frmSequenceGenerator();
            frm.MdiParent = this;
            frm.Show();
            AddWindowMenuItem(frm);
        }

        private void RunMotifScorer(bool protein)
        {
            frmMotifScorerBase frm;
            if (!protein)
                frm = new frmMotifScorerPeptide();
            else
                frm = new frmMotifScorerProtein();
            frm.MdiParent = this;
            frm.Show();
            AddWindowMenuItem(frm);
        }

        private void RunMotifValidationDesigner()
        {
            frmMotifValidationDesigner frm = new frmMotifValidationDesigner();
            frm.MdiParent = this;
            frm.Show();
            AddWindowMenuItem(frm);
        }

        private void mAnalyzePeptideList_Click(object sender, EventArgs e)
        {
            AnalyzePeptideArray();
        }

        private void mAnalyzePeptideArray_Click(object sender, EventArgs e)
        {
            AnalyzePeptideArray();
        }

        private void mAnalyzePermutationArray_Click(object sender, EventArgs e)
        {
            AnalyzePermutationArray();
        }

        private void mAnalyzeOPALArray_Click(object sender, EventArgs e)
        {
            AnalyzeOPALArray();
        }

        private void mToolsSequenceGenerator_Click(object sender, EventArgs e)
        {
            RunSequenceGenerator();
        }
        private void mToolsMotifBasedPeptideScorer_Click(object sender, EventArgs e)
        {
            RunMotifScorer(false);
        } 
       private void mToolsMotifValidationDesigner_Click(object sender, EventArgs e)
        {
            RunMotifValidationDesigner();
        }
        private void btnPeptideList_Click(object sender, EventArgs e)
        {
            AnalyzePeptideList();
        }

        private void btnPeptideArray_Click(object sender, EventArgs e)
        {
            AnalyzePeptideArray();
        }

        private void btnPermutationArray_Click(object sender, EventArgs e)
        {
            AnalyzePermutationArray();
        }


        private void btnOPALArray_Click(object sender, EventArgs e)
        {
            AnalyzeOPALArray();
        }

        private void btnSequenceGenerator_Click(object sender, EventArgs e)
        {
            RunSequenceGenerator();
        }

        private void btnMotifBasedScorer_Click(object sender, EventArgs e)
        {
            RunMotifScorer(false);
        }
        private void mToolsMotifBasedProteinScorer_Click(object sender, EventArgs e)
        {
            RunMotifScorer(true);
        }
        private void btnMotifValidationDesigner_Click(object sender, EventArgs e)
        {
            RunMotifValidationDesigner();
        }
        
        private void mWindowCascadeAll_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void mWindowTileAll_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mWindowCloseAll_Click(object sender, EventArgs e)
        {
            this.MdiChildren.OfType<Form>().ToList().ForEach(x => x.Close());
        }

        private void mSettingsMotif_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.MdiParent = this;
            frm.Show();
            AddWindowMenuItem(frm);
        }
        private void mSettingsAminoAcidList_Click(object sender, EventArgs e)
        {
            frmAminoAcids frm = new frmAminoAcids();
            frm.MdiParent = this;
            frm.Show();
            AddWindowMenuItem(frm);
        }

        private void mAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

        private void DeactivateButtons()
        {
            try {
                btnMotifBasedScorer.BackColor =
                    btnOPALArray.BackColor =
                    btnPeptideArray.BackColor =
                    btnPeptideList.BackColor =
                    btnPermutationArray.BackColor =
                    btnSequenceGenerator.BackColor = Color.White;
            }
            catch { }
        }
    
        private void ActivateButton(ToolStripButton btn)
        {
            try
            {
                DeactivateButtons();
                btn.BackColor = SystemColors.ActiveCaption;
            }
            catch { }
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            Type type = ActiveMdiChild?.GetType();
            if (type == typeof(frmMotifCreator))
                ActivateButton(btnPeptideList);
            else if (type == typeof(frmAnalyzePeptideArray))
                ActivateButton(btnPeptideArray);
            else if (type == typeof(frmAnalyzePermutationArray))
                ActivateButton(btnPermutationArray);
            else if (type == typeof(frmAnalyzeOPALArray))
                ActivateButton(btnOPALArray);
            else if (type == typeof(frmSequenceGenerator))
                ActivateButton(btnSequenceGenerator);
            else if (type == typeof(frmMotifScorerPeptide))
                ActivateButton(btnMotifBasedScorer);
            else
                DeactivateButtons();

        }
    }
}
