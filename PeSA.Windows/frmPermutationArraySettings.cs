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
    public partial class frmPermutationArraySettings : Form
    {
        Settings settings;
        public frmPermutationArraySettings()
        {
            InitializeComponent();
        }

        private void frmPermutationArraySettings_Load(object sender, EventArgs e)
        {
            try
            {
                settings = (ParentForm as MainForm).DefaultSettings;
                if (settings.WildTypeYAxisTopToBottom)
                    rbTopToBottom.Checked = true;
                else
                    rbBottomToTop.Checked = true;
            }
            catch { }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                settings.WildTypeYAxisTopToBottom = rbTopToBottom.Checked;
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
