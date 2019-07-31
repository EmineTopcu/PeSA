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
    public partial class frmPeptideArraySettings : Form
    {
        Settings settings;
        public frmPeptideArraySettings()
        {
            InitializeComponent();
        }

        private void frmPeptideArraySettings_Load(object sender, EventArgs e)
        {
            try
            {
                settings = (ParentForm as MainForm).DefaultSettings;
                eRowNumber.Text = settings.PeptideArrayRows.ToString();
                eColumnNumber.Text = settings.PeptideArrayColumns.ToString();
                if (settings.PeptideArrayRowsFirst)
                    rbRowFirst.Checked = true;
                else
                    rbColumnsFirst.Checked = true;
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Int32.TryParse(eRowNumber.Text, out int r))
                    r = 20;
                if (!Int32.TryParse(eColumnNumber.Text, out int c))
                    c = 30;
                settings.PeptideArrayRows = r;
                settings.PeptideArrayColumns = c;
                settings.PeptideArrayRowsFirst = rbRowFirst.Checked;
                if (!settings.Save("default.settings"))
                    MessageBox.Show("There was a problem in savings the settings.");
                else
                    this.Close();
                this.Close();
            }
            catch { }
        }
    }
}
