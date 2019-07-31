using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;
using PeSA.Engine;

namespace PeSA.Windows
{
    public partial class frmAnalyzeOPALArray : Form
    {
        OPALArray OA;

        bool quantificationLoaded = false;
        bool PermutationXAxis = false;

        double threshold = 0.50;

        public frmAnalyzeOPALArray()
        {
            InitializeComponent();
        }

        private void frmOPALArray_Load(object sender, EventArgs e)
        {
            eThreshold.Text = threshold.ToString();
            GridUtil.FormatGrid(dgQuantification);
            GridUtil.FormatGrid(dgNormalized);
        }

        bool skipSetThreshold = false;
        private void eThreshold_Leave(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(eThreshold.Text, out d))
            {
                SetThreshold(d);
                skipSetThreshold = true;
                trackThreshold.Value = Math.Max(0, Math.Min(100, (int)(d * 100)));
                skipSetThreshold = false;
            }
        }

        private void trackThreshold_ValueChanged(object sender, EventArgs e)
        {

            if (skipSetThreshold) return;
            if (sender == trackThreshold)
            {
                double d = (double)trackThreshold.Value / 100;
                eThreshold.Text = d.ToString();
                SetThreshold(d);
            }
        }

        private void SetThreshold(double val)
        {
            OA.Threshold = val;
            threshold = val;
            ColorGrids();
        }

        private void ColorGrids()
        {
            for (int i = 1; i < dgQuantification.RowCount; i++)
            {
                for (int j = 1; j < dgQuantification.ColumnCount; j++)
                {
                    double weight = OA.NormalizedMatrix[i - 1, j - 1];
                    if (weight >= threshold)
                    {
                        dgQuantification[j, i].Style.BackColor = Color.Gray;
                        dgNormalized[j, i].Style.BackColor = Color.Gray;
                    }
                    else
                    {
                        dgQuantification[j, i].Style.BackColor = Color.White;
                        dgNormalized[j, i].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dlgSaveProject.ShowDialog();
            string filename = dlgSaveProject.FileName;
            if (OPALArray.SaveToFile(filename, OA))
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                dlgOpenProject.ShowDialog();
                string filename = dlgOpenProject.FileName;
                OA = OPALArray.ReadFromFile(filename);
                threshold = OA.Threshold;
                skipSetThreshold = true;
                eThreshold.Text = OA.Threshold.ToString();
                trackThreshold.Value = Math.Max(0, Math.Min(100, (int)(OA.Threshold * 100)));
                skipSetThreshold = false;
                cbPermutationXAxis.Checked = PermutationXAxis;

                if (OA.QuantificationMatrix != null)
                    LoadQuantificationFromOPALArrayToGrid();
                GridUtil.LoadNumericMatrixToGrid(dgNormalized, OA.NormalizedMatrix, 1, 1);
                FillGridHeaders(dgNormalized);

                ColorGrids();
            }
            catch
            {
                MessageBox.Show("The file may be corrupted or not a valid PeSA project file.", Analyzer.ProgramName);
            }
        }

        private void LoadQuantificationFromOPALArrayToGrid()
        {
            GridUtil.LoadNumericMatrixToGrid(dgQuantification, OA.QuantificationMatrix, 1, 1);
            PermutationXAxis = cbPermutationXAxis.Checked = OA.PermutationXAxis;
            FillGridHeaders(dgQuantification);
            quantificationLoaded = true;
        }

        private void FillGridHeaders(DataGridView dg)
        {
            if (PermutationXAxis)
            {
                for (int colind = 1; colind < dg.ColumnCount; colind++)
                    dg[colind, 0].Value = OA.Permutation[colind - 1].ToString();
                for (int rowind = 1; rowind < dg.RowCount; rowind++)
                    dg[0, rowind].Value = OA.PositionCaptions[rowind - 1].ToString();
            }
            else
            {
                for (int rowind = 1; rowind < dg.RowCount; rowind++)
                    dg[0, rowind].Value = OA.Permutation[rowind - 1].ToString();
                for (int colind = 1; colind < dg.ColumnCount; colind++)
                    dg[colind, 0].Value = OA.PositionCaptions[colind - 1].ToString();
            }
        }

        private void btnCreateMotif_Click(object sender, EventArgs e)
        {
            Bitmap bm = Analyzer.CreateMotif(OA);
            frmMotifImage frmImage = new frmMotifImage(bm, "Main motif", null, "Shifted motif")
            {
                MdiParent = MainForm.MainFormPointer,
                WindowState = FormWindowState.Normal
            };
            frmImage.Show();
            frmImage.WindowState = FormWindowState.Normal;
        }

        private void cmiPaste_Click(object sender, EventArgs e)
        {
            GridUtil.PasteClipboard(dgQuantification);
            quantificationLoaded = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!quantificationLoaded)
            {
                MessageBox.Show("Please load the quantification array first.", Analyzer.ProgramName);
                return;
            }
            string[,] values = new string[dgQuantification.RowCount, dgQuantification.ColumnCount];
            for (int iRow = 0; iRow < dgQuantification.RowCount; iRow++)
                for (int iCol = 0; iCol < dgQuantification.ColumnCount; iCol++)
                    values[iRow, iCol] = dgQuantification[iCol, iRow].Value?.ToString() ?? "";

            string error = "";
            bool xPossible = true, yPossible = true;
            OPALArray.CheckPermutationAxis(values, ref xPossible, ref yPossible);
            if (xPossible && yPossible)
                PermutationXAxis = cbPermutationXAxis.Checked;
            else if (xPossible)
            {
                PermutationXAxis = true;
                cbPermutationXAxis.Checked = true;
            }
            else if (yPossible)
            {
                PermutationXAxis = false;
                cbPermutationXAxis.Checked = false;
            }
            if (!xPossible && !yPossible)
            {
                MessageBox.Show("Please make sure one the axes have OPAL array (each amino acid has to exist at most once)", Analyzer.ProgramName);
                return;
            };
            OA = new OPALArray(values, PermutationXAxis, out error);
            if (error != "")
            {
                MessageBox.Show(error, Analyzer.ProgramName);
                return;
            }
            GridUtil.LoadNumericMatrixToGrid(dgNormalized, OA.NormalizedMatrix, 1, 1);
            FillGridHeaders(dgNormalized);
            SetThreshold(threshold);
        }

        private void btnLoadQuantification_Click(object sender, EventArgs e)
        {
            try
            {
                dlgOpenQuantification.ShowDialog();
                string filename = dlgOpenQuantification.FileName;
                if (System.IO.File.Exists(filename))
                {
                    OA = FileUtil.ReadOPALArrayQuantificationData(filename);
                    LoadQuantificationFromOPALArrayToGrid();
                }
            }
            catch
            {
                MessageBox.Show("There is a problem with loading the quantification file.\r\nPlease make sure the quantification data is the only data in the loaded file.\r\n", Application.ProductName);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            DialogResult dlg = dlgExcelExport.ShowDialog();

            if (dlg != DialogResult.OK) return;
            string filename = dlgExcelExport.FileName;
            string errormsg = "";
            if (FileUtil.ExportOPALArrayToExcel(filename, OA, true, out errormsg))
                MessageBox.Show("Project is exported as an excel file:" + filename, Analyzer.ProgramName);
            else if (errormsg != "")
                MessageBox.Show(errormsg, Analyzer.ProgramName);
        }
    }
}
