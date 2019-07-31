using PeSA.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeSA.Windows
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();

            Version versionUI = Assembly.GetExecutingAssembly().GetName().Version;
            DateTime dateUI = new DateTime(2000, 1, 1)
                .AddDays(versionUI.Build)
                .AddSeconds(versionUI.Revision * 2);
            lVersionWindows.Text = string.Format("UI version: {0}.{1}, built on {2}", versionUI.Major, versionUI.Minor, dateUI.ToString("d"));

            Version versionEngine = typeof(Analyzer).Assembly.GetName().Version;
            DateTime dateEngine = new DateTime(2000, 1, 1)
                .AddDays(versionEngine.Build)
                .AddSeconds(versionEngine.Revision * 2);
            lVersionEngine.Text = string.Format("Engine version: {0}.{1}, built on {2}", versionEngine.Major, versionEngine.Minor, dateEngine.ToString("d"));

        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/EmineTopcu/PeSA");
        }
    }
}
