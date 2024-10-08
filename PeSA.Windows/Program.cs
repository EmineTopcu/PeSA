using OfficeOpenXml;

namespace PeSA.Windows
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           //new Cybele.Thinfinity.VirtualUI().Start();

            Application.ThreadException += (s, e) => MessageBox.Show(e.Exception.Message, "PeSA");
            AppDomain.CurrentDomain.UnhandledException += (s, e) => MessageBox.Show((e.ExceptionObject as Exception)?.Message ?? "An exception occured.", "PeSA");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            Application.Run(new MainForm());
        }
        
    }
}
