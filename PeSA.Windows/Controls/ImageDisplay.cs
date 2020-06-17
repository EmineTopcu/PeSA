using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeSA.Windows.Controls
{
    public partial class ImageDisplay : UserControl
    {
        public string Label { set { lReferenceImage.Text = value; } }
        
        public Image Image
        {
            get { return pbReferenceImage.Image; }

            set
            {
                if (value == null)
                {
                    pbReferenceImage.Image = pbReferenceImage.InitialImage;
                    SetHeightAndMode();
                }
                else
                {
                    pbReferenceImage.Image = value;
                    SetHeightAndMode();
                }
            }
        }
        public ImageDisplay()
        {
            InitializeComponent();
        }

        public void SetHeightAndMode()
        {
            if (pbReferenceImage.Image == null) return;
            int imgWidth = pbReferenceImage.Image.Width;
            int imgHeight = pbReferenceImage.Image.Height;
            if (imgWidth <= Width) //set height of the picturebox same as the image height - by setting the ImageDisplay control's height
            {
                Height = imgHeight + pInfoTop.Height;
                pbReferenceImage.SizeMode = PictureBoxSizeMode.Normal;
            }
            else
            {
                Height = imgHeight * Width / imgWidth + pInfoTop.Height;
                pbReferenceImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void linkLoad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult dlg = dlgOpenImage.ShowDialog();
                if (dlg != DialogResult.OK) return;

                string filename = dlgOpenImage.FileName;
                if (System.IO.File.Exists(filename))
                {
                    Image img = Image.FromFile(filename);
                    Image = img;
                }
            }
            catch
            {
                MessageBox.Show("There is a problem with loading the image file.\r\n", Application.ProductName);
            }
        }

        private void linkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Image = pbReferenceImage.InitialImage;
        }
         
    }
}
