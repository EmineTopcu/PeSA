using PeSA.Engine;
using System.Globalization;
using System.Reflection;

namespace PeSA.Windows
{
    public partial class frmAbout : Form
    {
        static DateTime dateUI = new(2022, 6, 5);
        static DateTime dateEngine = new(2022, 6, 5);
        public frmAbout()
        {
            InitializeComponent();

            Version versionUI = Assembly.GetExecutingAssembly().GetName().Version;
            lVersionWindows.Text = string.Format("UI version: {0}.{1}, built on {2}", versionUI.Major, versionUI.Minor, dateUI.ToString("d"));

            Version versionEngine = typeof(Analyzer).Assembly.GetName().Version;
            lVersionEngine.Text = string.Format("Engine version: {0}.{1}, built on {2}", versionEngine.Major, versionEngine.Minor, dateEngine.ToString("d"));

        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "https://github.com/EmineTopcu/PeSA");
        }
    }
}
