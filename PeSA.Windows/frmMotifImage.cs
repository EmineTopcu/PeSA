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
    public partial class frmMotifImage : Form
    {
        public frmMotifImage(Bitmap bm1, string label1, Bitmap bm2, string label2)
        {
            InitializeComponent();
            pictureBox1.Image = bm1;
            lMotif1.Text = label1;
            lMotif2.Text = label2;
            if (bm2 == null)
            {
                splitContainer1.Panel2Collapsed = true;
                this.Height = bm1.Height + 80;
            }
            else
            {
                pictureBox2.Image = bm2;
                this.Height = bm1.Height + bm2.Height + 120;
            }
            splitContainer1.SplitterDistance = bm1.Height + 36;
            this.Width = bm1.Width + 30;
        }

        private void btnCopyToClipboard1_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox1.Image);
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlg = dlgSaveImage.ShowDialog();
                if (dlg != DialogResult.OK) return;
                string filename = dlgSaveImage.FileName;
                pictureBox1.Image.Save(filename);
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is a problem with saving the image file.\r\n" + exc.Message, Analyzer.ProgramName);
            }
        }

        private void btnCopyToClipboard2_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(pictureBox2.Image);
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            DialogResult dlg = dlgSaveImage.ShowDialog();
            if (dlg != DialogResult.OK) return;
            string filename = dlgSaveImage.FileName;
            pictureBox2.Image.Save(filename);
            MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
        }
    }
}
