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
    public partial class frmAnalyzePermutationArray : Form
    {
        PermutationArray PA;
        string Title = "Permutation Array Analysis";
        string ProjectName = "";
        bool quantificationLoaded = false;
        double threshold = 0.50;
        bool skipSetThreshold = false;
        int colCount;
        int rowCount;


        public frmAnalyzePermutationArray()
        {
            InitializeComponent();
        }

        private void frmPeptideArray_Load(object sender, EventArgs e)
        {
            eThreshold.Text = threshold.ToString();
            ResetSettings();
            GridUtil.FormatGrid(dgPeptides);
            GridUtil.FormatGrid(dgQuantification);
        }

        private void ResetSettings()
        {
            Settings settings = (ParentForm as MainForm).DefaultSettings;
            cbYAxisTopToBottom.Checked = settings?.WildTypeYAxisTopToBottom ?? false;
        }
        private void eThreshold_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(eThreshold.Text, out double d))
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
            PA.Threshold = val;
            threshold = val;
            ColorGrids(true);
        }

        private void ColorGrids(bool updateModifiedPeptideList)
        {
            if (updateModifiedPeptideList)
                PA.ClearModifiedPeptides();
            if (dgQuantification.RowCount < 2 || dgQuantification.ColumnCount < 2)
                return;
            for (int i = 1; i < dgQuantification.RowCount; i++)
            {
                for (int j = 1; j < dgQuantification.ColumnCount; j++)
                {
                    double weight = PA.NormalizedMatrix[i - 1, j - 1];
                    if (weight >= threshold)
                    {
                        if (dgPeptides.ColumnCount > 1) //generated
                        {
                            dgPeptides[j, i].Style.BackColor = Color.Gray;
                            if (updateModifiedPeptideList)
                                PA.AddModifiedPeptide(dgPeptides[j, i].Value.ToString(), weight);
                        }
                        dgQuantification[j, i].Style.BackColor = Color.Gray;
                    }
                    else
                    {
                        if (dgPeptides.ColumnCount > 1) //generated
                            dgPeptides[j, i].Style.BackColor = Color.White;
                        dgQuantification[j, i].Style.BackColor = Color.White;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dlgSaveProject.FileName = ProjectName;
            DialogResult dlg = dlgSaveProject.ShowDialog();
            if (dlg != DialogResult.OK) return;
            SetText(dlgSaveProject);
            string filename = dlgSaveProject.FileName;
            if (PermutationArray.SaveToFile(filename, PA))
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
        }
        private void SetText(FileDialog dlg)
        {
            ProjectName = FormUtil.SetText(this, dlg, Title);
        }

       private void btnLoadQuantification_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlg = dlgOpenQuantification.ShowDialog();
                if (dlg != DialogResult.OK) return;
                SetText(dlgOpenQuantification);
                string filename = dlgOpenQuantification.FileName;
                if (System.IO.File.Exists(filename))
                {
                    PA = FileUtil.ReadPermutationArrayQuantificationData(filename);
                    LoadQuantificationFromPermutationArrayToGrid();
                    dgPeptides.RowCount = dgPeptides.ColumnCount = 0;
                }
            }
            catch
            {
                MessageBox.Show("There is a problem with loading the quantification file.\r\nPlease make sure the quantification data is the only data in the loaded file.\r\n", Application.ProductName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlg = dlgOpenProject.ShowDialog();
                if (dlg != DialogResult.OK) return;
                SetText(dlgOpenProject);
                string filename = dlgOpenProject.FileName;
                PA = PermutationArray.ReadFromFile(filename);
                threshold = PA.Threshold;
                skipSetThreshold = true;
                eThreshold.Text = PA.Threshold.ToString();
                trackThreshold.Value = Math.Max(0, Math.Min(100, (int)(PA.Threshold * 100)));
                skipSetThreshold = false;
                cbWildTypeXAxis.Checked = !PA.PermutationXAxis;
                cbYAxisTopToBottom.Checked = PA.WildTypeYAxisTopToBottom;
                colCount = PA.ColCount;
                rowCount = PA.RowCount;

                SetRowColumnCount();
                if (PA.PeptideMatrix != null)
                    LoadPeptidesFromPermutationArrayToGrid();
                if (PA.QuantificationMatrix != null)
                    LoadQuantificationFromPermutationArrayToGrid();
                ColorGrids(false);
            }
            catch
            {
                MessageBox.Show("The file may be corrupted or not a valid PeSA project file.", Analyzer.ProgramName);
            }
        }
        private void LoadPeptidesFromPermutationArrayToGrid()
        {

            GridUtil.LoadStringMatrixToGrid(dgPeptides, PA.PeptideMatrix, 1, 1);
            FillGridHeaders(dgPeptides);

        }
        private void LoadQuantificationFromPermutationArrayToGrid()
        {

            GridUtil.LoadNumericMatrixToGrid(dgQuantification, PA.QuantificationMatrix, 1, 1);
            cbWildTypeXAxis.Checked = !PA.PermutationXAxis;
            FillGridHeaders(dgQuantification);

            quantificationLoaded = true;

        }

        private void SetRowColumnCount()
        {
            dgPeptides.ColumnCount = dgQuantification.ColumnCount = 0;//first set to 0 to clear
            dgPeptides.RowCount = dgQuantification.RowCount = 0;//first set to 0 to clear

            dgPeptides.ColumnCount = dgQuantification.ColumnCount = colCount;
            dgPeptides.RowCount = dgQuantification.RowCount = rowCount;
            
        }
        private void FillGridHeaders(DataGridView dg)
        {
            if (cbWildTypeXAxis.Checked)
            {
                for (int rowind = 1; rowind < dg.RowCount; rowind++)
                    dg[0, rowind].Value = PA.Permutation[rowind - 1].ToString();
                for (int colind = 1; colind < dg.ColumnCount; colind++)
                    dg[colind, 0].Value = PA.WildTypePeptide[colind - 1].ToString();
            }
            else
            {
                if (cbYAxisTopToBottom.Checked)
                    for (int rowind = 1; rowind < dg.RowCount; rowind++)
                        dg[0, rowind].Value = PA.WildTypePeptide[rowind - 1].ToString();
                else
                {
                    int len = PA.WildTypePeptide.Length;
                    for (int rowind = 1; rowind < dg.RowCount; rowind++)
                        dg[0, rowind].Value = PA.WildTypePeptide[len - rowind].ToString();
                }

                for (int colind = 1; colind < dg.ColumnCount; colind++)
                    dg[colind, 0].Value = PA.Permutation[colind - 1].ToString();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            DialogResult dlg = dlgExcelExport.ShowDialog();

            if (dlg != DialogResult.OK) return;
            string filename = dlgExcelExport.FileName;
            if (FileUtil.ExportPermutationArrayToExcel(filename, PA, true, out string errormsg))
                MessageBox.Show("Project is exported as an excel file:" + filename, Analyzer.ProgramName);
            else if (errormsg != "")
                MessageBox.Show(errormsg, Analyzer.ProgramName);

        }

        private void btnCreateMotif_Click(object sender, EventArgs e)
        {

            Bitmap bm = Analyzer.CreateMotifImage(PA);
            frmMotifImage frmImage = new frmMotifImage(bm, "Main motif", null, "Shifted motif")
            {
                MdiParent = MainForm.MainFormPointer,
                WindowState = FormWindowState.Normal
            };
            frmImage.Show();
            frmImage.WindowState = FormWindowState.Normal;

        }

        private void btnSaveMotif_Click(object sender, EventArgs e)
        {
            if (PA == null) return;
            dlgSaveMotif.FileName = ProjectName;
            DialogResult dlg = dlgSaveMotif.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgSaveMotif.FileName;
            Motif motif = PA.CreateMotif();

            if (Motif.SaveToFile(filename, motif))
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
        }

        private void cmiPaste_Click(object sender, EventArgs e)
        {

            GridUtil.PasteClipboard(dgQuantification);
            quantificationLoaded = true;
            dgPeptides.RowCount = dgPeptides.ColumnCount = 0;
            ResetSettings();

        }

        private void Run()
        {
            string[,] values = new string[dgQuantification.RowCount, dgQuantification.ColumnCount];
            for (int iRow = 0; iRow < dgQuantification.RowCount; iRow++)
                for (int iCol = 0; iCol < dgQuantification.ColumnCount; iCol++)
                    values[iRow, iCol] = dgQuantification[iCol, iRow].Value?.ToString() ?? "";

            bool xPossible = true, yPossible = true;
            PermutationArray.CheckPermutationAxis(values, ref xPossible, ref yPossible);
            if (xPossible && !yPossible)
            {
                cbWildTypeXAxis.Checked = false;
            }
            else if (yPossible && !xPossible)
            {
                cbWildTypeXAxis.Checked = true;
            }
            else if (!xPossible && !yPossible)
            {
                MessageBox.Show("Please make sure one the axes have permutation array (each amino acid has to exist at most once)", Analyzer.ProgramName);
                return;
            };
            PA = new PermutationArray(values, !cbWildTypeXAxis.Checked, cbYAxisTopToBottom.Checked, out List<string> warnings, out string error);
            if (error != "")
            {
                MessageBox.Show(error, Analyzer.ProgramName);
                return;
            }
            if (warnings.Count > 0)
            {
                warnings.Insert(0, "Warning:");
                MessageBox.Show(String.Join("\r\n", warnings), Analyzer.ProgramName);
            }

            dgPeptides.ColumnCount = dgQuantification.ColumnCount;
            dgPeptides.RowCount = dgQuantification.RowCount;
            for (int iCol = 1; iCol < dgPeptides.ColumnCount; iCol++)
                dgPeptides[iCol, 0].Value = dgQuantification[iCol, 0].Value;
            for (int iRow = 1; iRow < dgPeptides.RowCount; iRow++)
            {
                dgPeptides[0, iRow].Value = dgQuantification[0, iRow].Value;
                for (int iCol = 1; iCol < dgPeptides.ColumnCount; iCol++)
                {
                    dgPeptides[iCol, iRow].Value = PA.PeptideMatrix[iRow - 1, iCol - 1];
                }
            }
            dgPeptides.Rows[0].DefaultCellStyle = dgPeptides.ColumnHeadersDefaultCellStyle;
            dgPeptides.Columns[0].DefaultCellStyle = dgPeptides.ColumnHeadersDefaultCellStyle;

            SetThreshold(threshold);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (!quantificationLoaded)
            {
                MessageBox.Show("Please load the quantification array first.", Analyzer.ProgramName);
                return;
            }
            Run();
        }

 
        private void cbWildTypeXAxis_CheckedChanged(object sender, EventArgs e)
        {
            cbYAxisTopToBottom.Visible = !cbWildTypeXAxis.Checked;
        }

        private void cbYAxisTopToBottom_CheckedChanged(object sender, EventArgs e)
        {
            //Rerun
            if (quantificationLoaded)
                Run();
        }
    }
}
