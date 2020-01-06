using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeSA.Engine;
using System.Windows.Input;

namespace PeSA.Windows
{
    public partial class frmAnalyzePeptideArray : Form
    {
        PeptideArray PA;
        string Title = "Peptide Array Analysis";
        string ProjectName = "";

        bool peptidesLoaded = false;
        bool quantificationLoaded = false;

        double _normalizeBy = 1;
        double threshold = 0.50;
        int colCount;
        int rowCount;
        bool rowsFirst;
        int peptidelength = 0;

        bool skipSetThreshold = false;
        int searchLastRow = 0, searchLastCol = 0;
        string searchString = "";

        public double normalizeBy
        {
            get => _normalizeBy;
            set
            {
                _normalizeBy = value;
                eNormalizeBy.Text = _normalizeBy.ToString();
            }
        }

        public frmAnalyzePeptideArray()
        {
            InitializeComponent();
        }

        private void frmPeptideArray_Load(object sender, EventArgs e)
        {
            ResetSettings();
            eThreshold.Text = threshold.ToString();
            UpdateArrayInfo();
            GridUtil.FormatGrid(dgPeptides);
            GridUtil.FormatGrid(dgQuantification);
            GridUtil.FormatGrid(dgNormalized);
        }

        private void ResetSettings()
        {
            Settings settings = (ParentForm as MainForm).DefaultSettings;
            colCount = settings?.PeptideArrayColumns ?? 30;
            rowCount = settings?.PeptideArrayRows ?? 20;
            rowsFirst = settings?.PeptideArrayRowsFirst ?? true;
        }

        private void UpdateArrayInfo()
        {
            lArrayInfo.Text = rowCount.ToString() + "x" + colCount.ToString() + " matrix - " + (rowsFirst ? "Rows first" : "Columns first");
        }

        private void SetRowColumnCount()
        {
            dgPeptides.ColumnCount = dgQuantification.ColumnCount = dgNormalized.ColumnCount = 0;//first set to 0 to clear
            dgPeptides.RowCount = dgQuantification.RowCount = dgNormalized.RowCount = 0;//first set to 0 to clear

            dgPeptides.ColumnCount = dgQuantification.ColumnCount = dgNormalized.ColumnCount = colCount;
            dgPeptides.RowCount = dgQuantification.RowCount = dgNormalized.RowCount = rowCount;
            /*for (int rowind = 0; rowind < rowCount; rowind++)
            {
                dgPeptides.Rows[rowind].HeaderCell.Value = "R" + rowind.ToString();
                dgQuantification.Rows[rowind].HeaderCell.Value = "R" + rowind.ToString();
                dgNormalized.Rows[rowind].HeaderCell.Value = "R" + rowind.ToString();
            }*/
            for (int colind = 0; colind < colCount; colind++)
            {
                dgPeptides.Columns[colind].HeaderText = "C" + (colind + 1).ToString();
                dgPeptides.Columns[colind].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgQuantification.Columns[colind].HeaderText = "C" + (colind + 1).ToString();
                dgQuantification.Columns[colind].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgNormalized.Columns[colind].HeaderText = "C" + (colind + 1).ToString();
                dgNormalized.Columns[colind].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            UpdateArrayInfo();
        }

        private void btnLoadPeptideList_Click(object sender, EventArgs e)
        {
            cmsLoadPeptide.Show(btnLoadPeptideList, (int)(btnLoadPeptideList.Width / 2), (int)(btnLoadPeptideList.Height / 2));
        }

        private void LoadPeptidesFromPeptideArrayToGrid()
        {
            GridUtil.LoadStringMatrixToGrid(dgPeptides, PA.PeptideMatrix);
            peptidesLoaded = true;
        }

        private void btnLoadQuantification_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlg = dlgOpenQuantification.ShowDialog();
                if (dlg != DialogResult.OK) return;
                SetText(dlgOpenQuantification);
                string filename = dlgOpenQuantification.FileName;
                if (System.IO.File.Exists(filename) &&
                    FileUtil.ReadQuantificationData(filename, PA, headersExist: true))
                {
                    LoadQuantificationFromPeptideArrayToGrid();
                    normalizeBy = PA.MaxValue;
                    Renormalize();
                }
            }
            catch
            {
                MessageBox.Show("There is a problem with loading the quantification file.\r\nPlease make sure the quantification data is the only data in the loaded file.\r\n", Application.ProductName);
            }
        }
        private void LoadQuantificationFromPeptideArrayToGrid()
        {
            GridUtil.LoadNumericMatrixToGrid(dgQuantification, PA.QuantificationMatrix);
            quantificationLoaded = true;
        }

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

        private void eNormalizeBy_Leave(object sender, EventArgs e)
        {
            double d;
            if (double.TryParse(eNormalizeBy.Text, out d))
            {
                Normalize(d);
            }
        }

        private void Renormalize()
        {
            if (quantificationLoaded && peptidesLoaded)
            {
                double d;
                if (double.TryParse(eNormalizeBy.Text, out d))
                {
                    Normalize(d);
                }
            }
        }
        private void Normalize(double val)
        {
            PA.Normalize(val);
            LoadNormalizedMatrixFromPeptideArrayToGrid();
            SetThreshold(threshold);
        }
        private void LoadNormalizedMatrixFromPeptideArrayToGrid()
        {
            if (dgNormalized.RowCount < PA.NormalizedMatrix.GetLength(0))
                dgNormalized.RowCount = PA.NormalizedMatrix.GetLength(0);
            if (dgNormalized.ColumnCount < PA.NormalizedMatrix.GetLength(1))
                dgNormalized.ColumnCount = PA.NormalizedMatrix.GetLength(1);

            for (int rowind = 0; rowind < rowCount; rowind++)
                for (int colind = 0; colind < colCount; colind++)
                    dgNormalized[colind, rowind].Value = PA.NormalizedMatrix[rowind, colind];
        }

        private void ColorGrids(bool updateModifiedPeptideList)
        {
            if (updateModifiedPeptideList)
                PA.ModifiedPeptides.Clear();
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                {
                    if (Convert.ToDouble(dgNormalized[j, i].Value) >= threshold)
                    {
                        dgPeptides[j, i].Style.BackColor = Color.Gray;
                        dgQuantification[j, i].Style.BackColor = Color.Gray;
                        dgNormalized[j, i].Style.BackColor = Color.Gray;
                        if (updateModifiedPeptideList)
                        {
                            string s = dgPeptides[j, i].Value.ToString();
                            if (peptidelength > 0 && s.Length > peptidelength)
                                s = s.Substring(0, peptidelength);
                            PA.ModifiedPeptides.Add(s);
                        }
                    }
                    else
                    {
                        dgPeptides[j, i].Style.BackColor = Color.White;
                        dgQuantification[j, i].Style.BackColor = Color.White;
                        dgNormalized[j, i].Style.BackColor = Color.White;
                    }
                }
        }

        private void SetThreshold(double val)
        {
            PA.Threshold = val;
            threshold = val;
            ColorGrids(true);
        }

        private void SetText(FileDialog dlg)
        {
            ProjectName = FormUtil.SetText(this, dlg, Title);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PA == null) return;
            dlgSaveProject.FileName = ProjectName;
            DialogResult dlg = dlgSaveProject.ShowDialog();
            if (dlg != DialogResult.OK) return;
            SetText(dlgSaveProject);
            string filename = dlgSaveProject.FileName;
            if (PeptideArray.SaveToFile(filename, PA))
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlg = dlgOpenProject.ShowDialog();
                if (dlg != DialogResult.OK) return;
                SetText(dlgOpenProject);
                string filename = dlgOpenProject.FileName;
                PA = PeptideArray.ReadFromFile(filename);
                peptidelength = PA.PeptideLength;
                ePeptideLength.Text = peptidelength.ToString();
                rowsFirst = PA.RowsFirst;
                colCount = PA.ColCount;
                rowCount = PA.RowCount;
                UpdateArrayInfo();

                normalizeBy = PA.NormalizationValue;
                skipSetThreshold = true;
                threshold = PA.Threshold;
                eThreshold.Text = PA.Threshold.ToString();
                trackThreshold.Value = Math.Max(0, Math.Min(100, (int)(PA.Threshold * 100)));
                skipSetThreshold = false;

                SetRowColumnCount();
                if (PA.PeptideMatrix != null)
                    LoadPeptidesFromPeptideArrayToGrid();
                if (PA.QuantificationMatrix != null)
                    LoadQuantificationFromPeptideArrayToGrid();
                if (PA.NormalizedMatrix != null)
                    LoadNormalizedMatrixFromPeptideArrayToGrid();
                ColorGrids(false);
            }
            catch 
            {
                MessageBox.Show("The file may be corrupted or not a valid PeSA project file.", Analyzer.ProgramName);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (PA == null) return;
            DialogResult dlg = dlgExcelExport.ShowDialog();
            if (dlg != DialogResult.OK) return;
            string filename = dlgExcelExport.FileName;
            string errormsg = "";
            if (FileUtil.ExportPeptideArrayToExcel(filename, PA, true, out errormsg))
                MessageBox.Show("Project is exported as an excel file:" + filename);
            else if (errormsg != "")
                MessageBox.Show(errormsg, Analyzer.ProgramName);
        }

        private void btnMotifGenerator_Click(object sender, EventArgs e)
        {
            if (PA == null) return;
            frmMotifCreator frm = new frmMotifCreator(PA.ModifiedPeptides);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void SearchPeptide(bool next)
        {
            try
            {
                bool found = false;
                if (searchString.Length > 0)
                {
                    int startrow = next ? searchLastRow : 0;
                    int startcol = next ? searchLastCol+1 : 0;
                    if (startcol >= dgPeptides.ColumnCount)
                    {
                        startrow++;
                        startcol = 0;
                        if (startcol >= dgPeptides.RowCount)
                            startcol = 0;
                    }
                    for (int rowind = startrow; rowind < dgPeptides.RowCount; rowind++)
                    {
                        for (int colind = startcol; colind < dgPeptides.ColumnCount; colind++)
                        {
                            if (dgPeptides[colind, rowind].Value == null) continue;
                            if (dgPeptides[colind, rowind].Value.ToString().Contains(searchString))
                            {
                                found = true;
                                dgPeptides.CurrentCell = dgPeptides[colind, rowind];
                                searchLastRow = rowind;
                                searchLastCol = colind;
                                try { dgQuantification.CurrentCell = dgQuantification[colind, rowind]; } catch { }
                                try { dgNormalized.CurrentCell = dgNormalized[colind, rowind]; } catch { }
                                break;
                            }
                        }
                        startcol = startrow = 0;
                    }
                    if (next && !found && searchLastRow + searchLastCol > 0) //start from the top
                    {
                        for (int rowind = 0; rowind <= searchLastRow; rowind++)
                        {
                            for (int colind = 0; colind < dgPeptides.ColumnCount; colind++)
                            {
                                if (dgPeptides[colind, rowind].Value == null) continue;
                                if (rowind == searchLastRow && colind == searchLastCol) break;
                                if (dgPeptides[colind, rowind].Value.ToString().Contains(searchString))
                                {
                                    found = true;
                                    dgPeptides.CurrentCell = dgPeptides[colind, rowind];
                                    searchLastRow = rowind;
                                    searchLastCol = colind;
                                    try { dgQuantification.CurrentCell = dgQuantification[colind, rowind]; } catch { }
                                    try { dgNormalized.CurrentCell = dgNormalized[colind, rowind]; } catch { }
                                    break;
                                }
                            }
                        }
                    }
                    if (!found)
                        MessageBox.Show("Peptide sequence not found.", Analyzer.ProgramName);
                }
            }
            catch 
            {
            }
        }

        private void cmiSearchPeptide_Click(object sender, EventArgs e)
        {
                searchString = Microsoft.VisualBasic.Interaction.InputBox("Search", DefaultResponse:searchString);
                SearchPeptide(false);
            
        }

        private void cmiFindNext_Click(object sender, EventArgs e)
        {
                SearchPeptide(true);
        }

        private void cmiPastePeptide_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] matrix = MatrixUtil.ClipboardToMatrix();
                matrix = MatrixUtil.StripHeaderRowColumns(matrix);
                rowCount = matrix.GetLength(0);
                colCount = matrix.GetLength(1);
                PA = new PeptideArray(rowCount, colCount, rowsFirst);
                PA.SetPeptideMatrix(matrix);
                dgQuantification.RowCount = dgQuantification.ColumnCount = 0;
                dgNormalized.RowCount = dgNormalized.ColumnCount = 0;
                SetRowColumnCount();
                GridUtil.LoadStringMatrixToGrid(dgPeptides, matrix);
                peptidesLoaded = true;
                quantificationLoaded = false;
            }
            catch
            {
            }
        }


        private void cmiPasteQuantification_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] matrix = MatrixUtil.ClipboardToMatrix();
                matrix = MatrixUtil.StripHeaderRowColumns(matrix);
                if (matrix == null || rowCount != matrix.GetLength(0) || colCount != matrix.GetLength(1))
                {
                    MessageBox.Show("The dimensions of the quantification data does not match the peptide matrix.", Analyzer.ProgramName);
                    return;
                }
                double[,] dMatrix = MatrixUtil.ConvertToNumericMatrix(matrix);
                PA.SetQuantificationMatrix(matrix, false);
                GridUtil.LoadNumericMatrixToGrid(dgQuantification, dMatrix);
                normalizeBy= MatrixUtil.GetMaxValue(dMatrix);
                quantificationLoaded = true;
                Renormalize();
            }
            catch
            {
            }
        }

        private void cmiLoadPeptideList_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlg = dlgOpenPeptideList.ShowDialog();
                if (dlg != DialogResult.OK) return;
                
                string filename = dlgOpenPeptideList.FileName;
                List<string> peptides = FileUtil.ReadPeptideList(filename);
                if (peptides != null)
                {
                    ResetSettings();
                    PA = new PeptideArray(rowCount, colCount, rowsFirst);
                    SetRowColumnCount();
                    PA.SetPeptideList(peptides);
                    peptidelength = PA.PeptideLength;
                    ePeptideLength.Text = peptidelength.ToString();
                    LoadPeptidesFromPeptideArrayToGrid();
                    peptidesLoaded = true;
                    Renormalize();
                }
            }
            catch
            {
                MessageBox.Show("There is a problem with loading the peptide list.\r\nPlease make sure the peptide list is the only data in the loaded file.\r\n", Application.ProductName);
            }
        }

        private void ePeptideLength_Leave(object sender, EventArgs e)
        {
            int i = 0;
            if (int.TryParse(ePeptideLength.Text, out i) && i > 0)
            {
                peptidelength = i;
                if (PA != null)
                {
                    PA.PeptideLength = peptidelength;
                    Renormalize();
                }
            }
        }

        private void btnSaveMotif_Click(object sender, EventArgs e)
        {
            if (PA == null) return;
            dlgSaveMotif.FileName = ProjectName;
            DialogResult dlg = dlgSaveMotif.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgSaveMotif.FileName;
            Motif motif = Analyzer.CreateMotif(PA.PeptideList, PA.PeptideLength, -1);

            if (Motif.SaveToFile(filename, motif))
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
        }

        private void cmiLoadPeptideMatrix_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlg = dlgOpenPeptideMatrix.ShowDialog();
                if (dlg != DialogResult.OK) return;

                string filename = dlgOpenPeptideMatrix.FileName;
                string[,] peptides = FileUtil.ReadPeptideMatrix(filename);
                rowCount = peptides.GetLength(0);
                colCount = peptides.GetLength(1);
                SetRowColumnCount();
                UpdateArrayInfo();
                if (peptides != null)
                {
                    PA = new PeptideArray(rowCount, colCount, rowsFirst);
                    PA.SetPeptideMatrix(peptides);
                    peptidelength = PA.PeptideLength;
                    ePeptideLength.Text = peptidelength.ToString();
                    LoadPeptidesFromPeptideArrayToGrid();
                    peptidesLoaded = true;
                    Renormalize();
                }
            }
            catch
            {
                MessageBox.Show("There is a problem with loading the peptide matrix file.\r\nPlease make sure the peptide matrix is the only data in the loaded file.\r\n", Application.ProductName);
            }
        }


    }
}
