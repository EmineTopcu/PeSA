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

        private void AnalyzePeptideList()
        {
            frmMotifCreator frm = new frmMotifCreator
            {
                MdiParent = this
            };
            frm.Show();
        }
        private void AnalyzePeptideArray()
        {
            frmAnalyzePeptideArray frm = new frmAnalyzePeptideArray();
            frm.MdiParent = this;
            frm.Show();
        }
        private void AnalyzePermutationArray()
        {
            frmAnalyzePermutationArray frm = new frmAnalyzePermutationArray
            {
                MdiParent = this
            };
            frm.Show();
        }
        private void AnalyzeOPALArray()
        {
            frmAnalyzeOPALArray frm = new frmAnalyzeOPALArray();
            frm.MdiParent = this;
            frm.Show();
        }
        private void RunSequenceGenerator()
        {
            frmSequenceGenerator frm = new frmSequenceGenerator();
            frm.MdiParent = this;
            frm.Show();
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
            frmMotifSettings frm = new frmMotifSettings();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mSettingsPeptideArray_Click(object sender, EventArgs e)
        {
            frmPeptideArraySettings frm = new frmPeptideArraySettings();
            frm.MdiParent = this;
            frm.Show();
        }

        private void mSettingsPermutationArray_Click(object sender, EventArgs e)
        {
            frmPermutationArraySettings frm = new frmPermutationArraySettings();
            frm.MdiParent = this;
            frm.Show();

        }

        private void mAbout_Click(object sender, EventArgs e)
        {
            frmAbout frm = new frmAbout();
            frm.ShowDialog();
        }

    }
}