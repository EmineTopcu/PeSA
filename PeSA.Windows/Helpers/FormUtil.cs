using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeSA.Windows
{
    public class FormUtil
    {
        public static string SetText(Form form, FileDialog dlg, string deftext)
        {
            if (string.IsNullOrEmpty(dlg.FileName))
            {
                form.Text = deftext;
                return "";
            }
            string filename = dlg.FileName;
            int ind = filename.LastIndexOf('\\');
            try
            {
                if (ind > 0)
                    filename = filename.Substring(ind + 1);
            }
            catch { }
            ind = filename.IndexOf('.');
            if (ind > 0)
                filename = filename.Substring(0, ind);
            form.Text = deftext + " - " + filename;
            return filename;
        }
    }
}
