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
        private static void UpdateMenuText(Form form)
        {
            if (form.MdiParent != null)
            {
                try
                {
                    MainForm mainform = form.MdiParent as MainForm;
                    mainform.UpdateWindowMenuItem(form);
                }
                catch { }
            }
        }
        public static string SetText(Form form, FileDialog dlg, string deftext)
        {
            if (string.IsNullOrEmpty(dlg.FileName))
            {
                form.Text = deftext;
                UpdateMenuText(form);
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
            UpdateMenuText(form);
            return filename;
        }

        public static void SetTrackBarValue(TrackBar trackbar, int d)
        {
            if (d <= trackbar.Minimum)
                trackbar.Value = trackbar.Minimum;
            else if (d >= trackbar.Maximum)
                trackbar.Value = trackbar.Maximum;
            else
                trackbar.Value = d;
        }

    }
}
