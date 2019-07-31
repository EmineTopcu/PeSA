using PTMAnalysisEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PTMAnalysis
{
    public partial class frmChart : Form
    {
        public frmChart(string wildTypePeptide, List<char> usedAminoAcids, Dictionary<int, Dictionary<char, double>> weights)
        {
            InitializeComponent();

            Settings settings = Settings.Load("default.settings");

            chart.Series.Clear();
            chart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;
            List<AminoAcid> sortedAminoAcids = AminoAcids.GetSortedAminoAcidList();
            foreach (AminoAcid aminoacid in sortedAminoAcids)
            {
                char aa = aminoacid.Abbrev1;
                if (!usedAminoAcids.Contains(aa)) continue;
                if (aa == 'X') continue;
                Series s = chart.Series.Add(aa.ToString());
                s.Label = aa.ToString();
                s.BorderWidth = 1;
                s.BorderColor = Color.Black;
                s.BorderDashStyle = ChartDashStyle.Solid;
                s.ChartType = SeriesChartType.StackedColumn;
                s.Color = settings.GetColorOfAminoAcid(aa);
                if (s.Color == Color.Black)
                {
                    s.LabelForeColor = Color.White;
                    s.BorderColor = Color.Red;
                }
            }
            foreach (int position in weights.Keys)
            {
                CustomLabel cl = new CustomLabel();
                cl.FromPosition = position - 0.5;
                cl.ToPosition = position + 0.5;
                cl.Text = wildTypePeptide[position].ToString();
                chart.ChartAreas[0].AxisX.CustomLabels.Add(cl);
                Dictionary<char, double> weightedList = weights[position];
                foreach (char aa in usedAminoAcids)
                {
                    double weight = weightedList.ContainsKey(aa) ? weightedList[aa] : 0;
                    DataPoint dp = new DataPoint(position, weight);
                    if (weight < 0.001) dp.Label = "";
                    chart.Series[aa.ToString()].Points.Add(dp);//.AddXY(position, weight);
                }
            }

            chart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart.ChartAreas[0].AxisX.MinorGrid.LineWidth = 0;

        }

        private void btnCopyToClipboard1_Click(object sender, EventArgs e)
        {
           // Clipboard.SetImage(pictureBox1.Image);
        }

        private void btnSave1_Click(object sender, EventArgs e)
        {
            try
            {
                dlgSaveImage.ShowDialog();
                string filename = dlgSaveImage.FileName;
                //pictureBox1.Image.Save(filename);
                MessageBox.Show(filename + " is saved", Analyser.ProgramName);
            }
            catch (Exception exc)
            {
            }
        }

    }
}

/*Dictionary<int, Dictionary<char, double>> relativeweights = Analyser.GenerateDiscriminationFactors(PA, out List<char> usedAminoAcids);
frmChart frmChart = new frmChart(PA.WildTypePeptide, usedAminoAcids, relativeweights)
{
    MdiParent = MainForm.MainFormPointer,
    WindowState = FormWindowState.Normal
};
frmChart.Show();*/
