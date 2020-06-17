using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeSA.Engine;

namespace PeSA.Windows
{
    public partial class MotifDisplay : UserControl
    {
        bool manualChange = false;

        public Image Image
        {
            get { return pbMotif.Image; }
            set
            {
                pbMotif.Image = value;
                ResizeControl();
            }
        }

        public string LabelText
        {
            get => lMotif1.Text;
            set => lMotif1.Text = value;
        }

        public MotifDisplay()
        {
            InitializeComponent();
        }

        private void ResizeControl()
        {
            manualChange = true;
            Image img = pbMotif.Image;
            double ratio = img != null ? (double)img.Height / (double)img.Width : 0.25;
            this.Height = (int)(ratio * this.Width) + pbMotif.Top;
            manualChange = false;
        }

        private void MotifDisplay_SizeChanged(object sender, EventArgs e)
        {
            if (manualChange)
                return;
            ResizeControl();
        }

        private void linkCopyImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetImage(pbMotif.Image);
        }

        private void linkSaveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult dlg = dlgSaveImage.ShowDialog();
                if (dlg != DialogResult.OK) return;
                string filename = dlgSaveImage.FileName;
                pbMotif.Image.Save(filename);
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
            }
            catch (Exception exc)
            {
                MessageBox.Show("There is a problem with saving the image file.\r\n" + exc.Message, Analyzer.ProgramName);
            }
        }
    }
}
