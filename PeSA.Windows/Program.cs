using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.ThreadException += (s, e) => MessageBox.Show(e.Exception.Message, "PeSA");
            AppDomain.CurrentDomain.UnhandledException += (s, e) => MessageBox.Show((e.ExceptionObject as Exception)?.Message ?? "An exception occured.", "PeSA");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        
    }
}
