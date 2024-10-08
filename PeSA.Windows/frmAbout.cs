using PeSA.Engine;
using System.Reflection;

namespace PeSA.Windows
{
    public partial class frmAbout : Form
    {
        static DateTime dateUI = new(2024, 10, 8);
        static DateTime dateEngine = new(2024, 10, 8);
        public frmAbout()
        {
            InitializeComponent();

            Version versionUI = Assembly.GetExecutingAssembly().GetName().Version;
            lVersionWindows.Text = string.Format("UI version: {0}.{1}.{2}, built on {3}", 
                versionUI.Major, versionUI.Minor, versionUI.Build, dateUI.ToString("d"));

            Version versionEngine = typeof(Analyzer).Assembly.GetName().Version;
            lVersionEngine.Text = string.Format("Engine version: {0}.{1}.{2}, built on {3}",
                versionEngine.Major, versionEngine.Minor, versionEngine.Build, dateEngine.ToString("d"));

        }

        private void linkGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer", "https://github.com/EmineTopcu/PeSA");
        }
    }
}
