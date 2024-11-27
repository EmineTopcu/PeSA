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
    public partial class frmSettings : Form
    {
        Settings settings;
        public frmSettings()
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

            if (settings.WildTypeYAxisTopToBottom)
                rbTopToBottom.Checked = true;
            else
                rbBottomToTop.Checked = true;

            eRowNumber.Text = settings.PeptideArrayRows.ToString();
            eColumnNumber.Text = settings.PeptideArrayColumns.ToString();
            if (settings.PeptideArrayRowsFirst)
                rbRowFirst.Checked = true;
            else
                rbColumnsFirst.Checked = true;
            LoadColors();
        }

        private void LoadColors()
        {
            pColors.SuspendLayout();
            if (pColors.Controls.Count < 2)
            {
                int rowind = 1;
                int top = 20;
                int left = 10;
                foreach (char c in settings.AminoAcidMotifColors.Keys.Union(AminoAcids.GetFullAminoAcidList().Select(aa=>aa.Abbrev1)))
                {
                    Label label = new()
                    {
                        Text = c.ToString(),
                        AutoSize = false,
                        Height = 20,
                        Width = 20,
                        //label.Margin = new Padding(0, 5, 0, 0);
                        Top = top + 5,
                        Left = left
                    };
                    left += 20;
                    pColors.Controls.Add(label);
                    Button button = new()
                    {
                        BackColor = settings.GetColorOfAminoAcid(c),
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
                    if (++rowind > 6)
                    {
                        rowind = 1;
                        left += 60;
                        top = 20;
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
            if (!int.TryParse(eMotifHeight.Text, out int h))
                h = 200;
            if (!int.TryParse(eMotifWidth.Text, out int w))
                w = 800;
            if (!int.TryParse(eMaxAAPerColumn.Text, out int m))
                m = 10;

            if (!double.TryParse(eThreshold.Text, out double t))
                t = 0.1;
            settings.MotifHeight = h;
            settings.MotifWidth = w;
            settings.MotifMaxAAPerColumn = m;
            settings.MotifThreshold = t;
            settings.WildTypeYAxisTopToBottom = rbTopToBottom.Checked;

            if (!int.TryParse(eRowNumber.Text, out int r))
                r = 20;
            if (!int.TryParse(eColumnNumber.Text, out int c))
                c = 30;
            settings.PeptideArrayRows = r;
            settings.PeptideArrayColumns = c;
            settings.PeptideArrayRowsFirst = rbRowFirst.Checked;

            if (!settings.Save("default.settings"))
                MessageBox.Show("There was a problem in savings the settings.");
            else
                this.Close();
        }


        private void linkResetColors_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            settings.SetDefaultColors();
            LoadColors();
        }
    }
}
