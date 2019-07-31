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
    public partial class frmMotifSettings : Form
    {
        Settings settings;
        public frmMotifSettings()
        {
            InitializeComponent();
        }

        private void frmMotifSettings_Load(object sender, EventArgs e)
        {
                settings = (ParentForm as MainForm).DefaultSettings;
                eMotifHeight.Text = settings.MotifHeight.ToString();
                eMotifWidth.Text = settings.MotifWidth.ToString();
                eMaxAAPerColumn.Text = settings.MotifMaxAAPerColumn.ToString();
                eThreshold.Text = settings.MotifThreshold.ToString();

                LoadColors();
        }

        private void LoadColors()
        {
            pColors.SuspendLayout();
            if (pColors.Controls.Count == 0)
            {
                int rowind = 1;
                int top = 8;
                int left = 10;
                foreach (char c in settings.AminoAcidMotifColors.Keys)
                {
                    Label label = new Label();
                    label.Text = c.ToString();
                    label.AutoSize = false;
                    label.Height = 20;
                    label.Width = 20;
                    //label.Margin = new Padding(0, 5, 0, 0);
                    label.Top = top + 5;
                    label.Left = left;
                    left += 20;
                    pColors.Controls.Add(label);
                    Button button = new Button
                    {
                        BackColor = settings.AminoAcidMotifColors[c],
                        Tag = c
                    };
                    button.Click += Button_Click;
                    button.AutoSize = false;
                    button.Height = 20;
                    button.Width = 20;
                    button.Top = top;
                    button.Left = left;
                    left -= 20;
                    top += 25;
                    pColors.Controls.Add(button);
                    if (++rowind > 7)
                    {
                        rowind = 1;
                        left += 60;
                        top = 8;
                    }
                }
            }
            else
            {
                foreach (Control control in pColors.Controls)
                {
                    if (control.GetType() == typeof(Button))
                    {
                        char c = (char)control.Tag;
                        control.BackColor = settings.AminoAcidMotifColors[c];
                    }
                }
            }
            pColors.ResumeLayout();

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            colorDialog1.Color = button.BackColor;
            colorDialog1.ShowDialog();
            button.BackColor = colorDialog1.Color;
            char c = (char)button.Tag;
            settings.AminoAcidMotifColors[c] = colorDialog1.Color;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int w, h, m;
            if (!Int32.TryParse(eMotifHeight.Text, out h))
                h = 200;
            if (!Int32.TryParse(eMotifWidth.Text, out w))
                w = 800;
            if (!Int32.TryParse(eMaxAAPerColumn.Text, out m))
                m = 10;

            double t;
            if (!Double.TryParse(eThreshold.Text, out t))
                t = 0.1;
            settings.MotifHeight = h;
            settings.MotifWidth = w;
            settings.MotifMaxAAPerColumn = m;
            settings.MotifThreshold = t;
            if (!settings.Save("default.settings"))
                MessageBox.Show("There was a problem in savings the settings.");
            else
                this.Close();
        }

        private void btnDefaultColors_Click(object sender, EventArgs e)
        {
            settings.SetDefaultColors();
            LoadColors();
        }
    }
}
