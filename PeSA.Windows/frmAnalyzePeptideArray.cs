using System.Data;
using PeSA.Engine;
using PeSA.Engine.Helpers;

namespace PeSA.Windows
{
    public partial class frmAnalyzePeptideArray : Form
    {
        PeptideArray PA;
        string Title = "Peptide Array Analysis";
        string ProjectName = "";

        bool peptidesLoaded = false;
        bool quantificationLoaded = false;

        int colCount;
        int rowCount;
        bool rowsFirst;
        int peptidelength = 0;
        
        GridUtil dgPeptideHelper;
        Motif MotifMain, MotifShifted;

        public frmAnalyzePeptideArray()
        {
            InitializeComponent();
            dgPeptideHelper = new GridUtil(dgPeptides);
        }

        private void frmPeptideArray_Load(object sender, EventArgs e)
        {
            ResetSettings();
            UpdateArrayInfo();
            GridUtil.FormatGrid(dgPeptides);
            GridUtil.FormatGrid(dgQuantification);
            GridUtil.FormatGrid(dgNormalized);
        }

        private void FillPAValues()
        {
            if (PA == null) return;
            PA.SetPositiveThreshold(thresholdEntry.PositiveThreshold, out bool negChanged);
            PA.SetNegativeThreshold(thresholdEntry.NegativeThreshold, out bool posChanged2);
            if (double.TryParse(eFreqThreshold.Text, out double d))
                PA.FrequencyThreshold = d;
            if (char.TryParse(eAminoAcid.Text, out char c))
                PA.KeyAA = c;
            if (int.TryParse(eKeyPosition.Text, out int i))
                PA.KeyPosition = i;
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

        private void LoadPeptidesFromPeptideArrayToGrid()
        {
            GridUtil.LoadStringMatrixToGrid(dgPeptides, PA.PeptideMatrix);
            peptidesLoaded = true;
        }

        private void btnLoadQuantification_Click(object sender, EventArgs e)
        {
        }
        private void LoadQuantificationFromPeptideArrayToGrid()
        {
            GridUtil.LoadNumericMatrixToGrid(dgQuantification, PA.QuantificationMatrix);
            quantificationLoaded = true;
        }

        private void eNormalizeBy_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(eNormalizeBy.Text, out double d))
            {
                Normalize(d);
            }
        }

        private void Renormalize()
        {
            if (quantificationLoaded && peptidesLoaded)
            {
                if (double.TryParse(eNormalizeBy.Text, out double d))
                {
                    Normalize(d);
                }
            }
        }
        private void Normalize(double val)
        {
            PA.Normalize(val);
            LoadNormalizedMatrixFromPeptideArrayToGrid();
            ColorGrids();
        }

        private void ClearMotifs()
        {
            MotifMain = MotifShifted = null;
            mdMain.Image = null;
            mdShifted.Image = null;
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

        private bool ColorGrids()
        {
            try
            {
                for (int i = 0; i < rowCount; i++)
                    for (int j = 0; j < colCount; j++)
                    {
                        double weight = Convert.ToDouble(dgNormalized[j, i].Value);
                        Color col;
                        if (weight >= PA.PositiveThreshold)
                            col = Common.ColorPositive;
                        else if (weight < PA.NegativeThreshold)
                            col = Common.ColorNegative;
                        else
                            col = Common.ColorNeutral;
                        dgPeptides[j, i].Style.BackColor = col;
                        dgQuantification[j, i].Style.BackColor = col;
                        dgNormalized[j, i].Style.BackColor = col;
                    }
                if (!thresholdEntry.trackThresholdMouseDown && !thresholdEntry.trackNegThresholdMouseDown)
                {
                    FillDecisionGrid();
                    if (!DrawMotifs())
                        return false;
                }
                return true;
            }
            catch { return false; }
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
            PA.Notes = eNotes.Text;
            PA.ImageStr = FileUtil.ImageToBase64(imageReference.Image);
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
                try
                {
                    PA = PeptideArray.ReadFromFile(filename);
                }
                catch
                {
                    MessageBox.Show("The file may be corrupted or not a valid PeSA project file.", Analyzer.ProgramName);
                }
                peptidelength = PA.PeptideLength;
                ePeptideLength.Text = peptidelength.ToString();
                rowsFirst = PA.RowsFirst;
                colCount = PA.ColCount;
                rowCount = PA.RowCount;
                UpdateArrayInfo();

                eNormalizeBy.Text = PA.NormalizationValue.ToString();

                thresholdEntry.SetInitialValues(PA.GetPositiveThreshold(), PA.GetNegativeThreshold());

                eFreqThreshold.Text = PA.FrequencyThreshold.ToString();
                eAminoAcid.Text = PA.KeyAA.ToString();
                eKeyPosition.Text = PA.KeyPosition?.ToString() ?? "";
                SetRowColumnCount();
                if (PA.PeptideMatrix != null)
                    LoadPeptidesFromPeptideArrayToGrid();
                if (PA.QuantificationMatrix != null)
                    LoadQuantificationFromPeptideArrayToGrid();
                if (PA.NormalizedMatrix != null)
                    LoadNormalizedMatrixFromPeptideArrayToGrid();
                bool gridsOK = ColorGrids();
                eNotes.Text = PA.Notes;
                imageReference.Image = null;
                try
                {
                    Image img = FileUtil.Base64ToImage(PA.ImageStr);
                    imageReference.Image = img;
                }
                catch { }
                if (!gridsOK)
                    MessageBox.Show("There is a problem in loading the file. It is highly recommended to re-run the analysis.", Analyzer.ProgramName);
            }
            catch
            {
                MessageBox.Show("There is a problem in loading the file. It is highly recommended to re-run the analysis.", Analyzer.ProgramName);
            }
            linkRun.Visible = true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (PA == null) return;
            dlgExcelExport.FileName = ProjectName;
            DialogResult dlg = dlgExcelExport.ShowDialog();
            if (dlg != DialogResult.OK) return;
            string filename = dlgExcelExport.FileName;
            if (FileUtil.ExportPeptideArrayToExcel(filename, PA, true, out string errormsg))
                MessageBox.Show("Project is exported as an excel file:" + filename);
            else if (errormsg != "")
                MessageBox.Show(errormsg, Analyzer.ProgramName);
        }

        private bool DrawMotifs()
        {
            try
            {
                ClearMotifs();
                if (PA == null)
                    return true;
                Settings settings = Settings.Load("default.settings");
                int heightImage = 200;
                int widthImage = 800;
                if (settings != null)
                {
                    heightImage = settings.MotifHeight;
                    widthImage = settings.MotifWidth;
                }

                int midpoint = peptidelength / 2;
                if (Int32.TryParse(eKeyPosition.Text, out int keyPos) && keyPos <= peptidelength && keyPos > 0)
                    midpoint = keyPos - 1;
                else
                {
                    keyPos = midpoint + 1;
                    eKeyPosition.Text = keyPos.ToString();
                }
                PA.KeyPosition = keyPos;

                if (!Char.TryParse(eAminoAcid.Text.Trim(), out char keyAA))
                {
                    keyAA = ' ';
                    eAminoAcid.Text = keyAA.ToString();
                }
                else if (Char.IsLower(keyAA))
                    keyAA = Char.ToUpper(keyAA);

                PA.KeyAA = keyAA;
                if (keyAA != ' ')
                {
                    List<string> mainList = PA.ModifiedPeptides.Where(s => s[keyPos - 1] == keyAA).ToList();

                    List<string> shiftedList = Analyzer.ShiftPeptides(PA.ModifiedPeptides.Where(s => s[keyPos - 1] != keyAA).ToList(), keyAA, peptidelength, keyPos - 1, out List<string> replacements);
                    MotifMain = new Motif(mainList, peptidelength)
                    {
                        FreqThreshold = PA.FrequencyThreshold
                    };
                    Bitmap bm = MotifMain.GetFrequencyMotif(widthImage, heightImage);
                    mdMain.Image = bm;

                    MotifShifted = new Motif(shiftedList, peptidelength)
                    {
                        FreqThreshold = PA.FrequencyThreshold
                    };
                    bm = MotifShifted.GetFrequencyMotif(widthImage, heightImage);
                    mdShifted.Image = bm;
                    mdShifted.Visible = true;
                }
                else
                {
                    MotifMain = new Motif(PA.ModifiedPeptides, peptidelength)
                    {
                        FreqThreshold = PA.FrequencyThreshold
                    };
                    Bitmap bm = MotifMain.GetFrequencyMotif(widthImage, heightImage);
                    mdMain.Image = bm;
                    mdShifted.Visible = false;
                }
                return true;
            }
            catch { return false; }
        }

        private void FillDecisionGrid()
        {
            dgDecision.Rows.Clear();
            dgDecision.RowCount = PA.NormalizedPeptideWeights.Count;
            int rowind = 0;
            foreach (string key in PA.NormalizedPeptideWeights.Keys.OrderBy(k => k))
            {
                dgDecision[0, rowind].Value = key;
                double val = PA.NormalizedPeptideWeights[key];
                dgDecision[1, rowind].Value = val;
                dgDecision[2, rowind++].Value = val >= PA.PositiveThreshold ? "Pos" : val < PA.NegativeThreshold ? "Neg" : "";
            }
        }

        private void cmiFindPeptide_Click(object sender, EventArgs e)
        {
            dgPeptideHelper.SearchPeptide(false);
            if (dgPeptideHelper.StringFound)
            {
                try { dgQuantification.CurrentCell = dgQuantification[dgPeptideHelper.searchLastCol, dgPeptideHelper.searchLastRow]; } catch { }
                try { dgNormalized.CurrentCell = dgNormalized[dgPeptideHelper.searchLastCol, dgPeptideHelper.searchLastRow]; } catch { }
            }
        }

        private void cmiFindNext_Click(object sender, EventArgs e)
        {
            dgPeptideHelper.SearchPeptide(true);
            if (dgPeptideHelper.StringFound)
            {
                try { dgQuantification.CurrentCell = dgQuantification[dgPeptideHelper.searchLastCol, dgPeptideHelper.searchLastRow]; } catch { }
                try { dgNormalized.CurrentCell = dgNormalized[dgPeptideHelper.searchLastCol, dgPeptideHelper.searchLastRow]; } catch { }
            }
        }

        private void cmiPastePeptide_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms = Clipboard.GetDataObject().GetData("XML Spreadsheet") as MemoryStream;
                string[,] matrix = MatrixUtil.ClipboardToMatrix(ms);
                matrix = MatrixUtil.StripHeaderRowColumns(matrix, false);
                rowCount = matrix.GetLength(0);
                colCount = matrix.GetLength(1);
                PA = new PeptideArray(rowCount, colCount, rowsFirst);
                PA.SetPeptideMatrix(matrix);
                peptidelength = PA.PeptideLength;
                ePeptideLength.Text = peptidelength.ToString();
                dgQuantification.RowCount = dgQuantification.ColumnCount = 0;
                dgNormalized.RowCount = dgNormalized.ColumnCount = 0;
                SetRowColumnCount();
                GridUtil.LoadStringMatrixToGrid(dgPeptides, matrix);
                peptidesLoaded = true;
                quantificationLoaded = false;
                FillPAValues();
                ClearMotifs();
            }
            catch
            {
            }
        }

        private void cmiPasteQuantification_Click(object sender, EventArgs e)
        {
            try
            {
                if (PA == null)
                {
                    MessageBox.Show("The peptide array needs to be loaded before the quantification array.", Analyzer.ProgramName);
                    return;
                }
                MemoryStream ms = Clipboard.GetDataObject().GetData("XML Spreadsheet") as MemoryStream;
                string[,] matrix = MatrixUtil.ClipboardToMatrix(ms);
                matrix = MatrixUtil.StripHeaderRowColumns(matrix, true);
                if (matrix == null || rowCount != matrix.GetLength(0) || colCount != matrix.GetLength(1))
                {
                    MessageBox.Show("The dimensions of the quantification data does not match the peptide matrix.", Analyzer.ProgramName);
                    return;
                }
                double[,] dMatrix = MatrixUtil.ConvertToNumericMatrix(matrix);
                PA.SetQuantificationMatrix(matrix, false);
                GridUtil.LoadNumericMatrixToGrid(dgQuantification, dMatrix);
                PA.NormalizationValue = MatrixUtil.GetMaxValue(dMatrix);
                eNormalizeBy.Text = PA.NormalizationValue.ToString();
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
                    quantificationLoaded = false;
                    FillPAValues();
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
            if (int.TryParse(ePeptideLength.Text, out int i) && i > 0 && peptidelength != i)
            {
                peptidelength = i;
                if (PA != null)
                {
                    PA.PeptideLength = peptidelength;
                    Renormalize();
                }
            }
        }

        private void thresholdEntry_ThresholdChanged(object sender, EventArgs e)
        {
            if (PA == null)
                return;
            PA.SetPositiveThreshold(thresholdEntry.PositiveThreshold, out bool negChanged);
            PA.SetNegativeThreshold(thresholdEntry.NegativeThreshold, out bool posChanged2);
            ColorGrids();
        }

        private void lQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If not blank, only peptides with the target amino acid at the key position will be used to create the motif.\r\n" +
            "For others, second motif will be created by bringing another target amino acid to key position if possible.", Analyzer.ProgramName);
        }

        private void eAminoAcid_Leave(object sender, EventArgs e)
        {
            if (char.TryParse(eAminoAcid.Text.Trim(), out char c) && PA.KeyAA != c)
            {
                PA.KeyAA = c;
                DrawMotifs();
            }
            else if (string.IsNullOrWhiteSpace(eAminoAcid.Text))
            {
                PA.KeyAA = ' ';
                DrawMotifs();
            }
        }

        private void eKeyPosition_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(eKeyPosition.Text, out int i) && PA.KeyPosition != i)
            {
                PA.KeyPosition = i;
                DrawMotifs();
            }
        }

        private void eFreqThreshold_Leave(object sender, EventArgs e)
        {
            if (double.TryParse(eFreqThreshold.Text, out double d) && PA.FrequencyThreshold != d)
            {
                PA.FrequencyThreshold = d;
                DrawMotifs();
            }
        }

        private void lLoadPeptides_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cmsLoadPeptide.Show(lLoadPeptides, (int)(lLoadPeptides.Width / 2), (int)(lLoadPeptides.Height / 2));
        }

        private void linkLoadQuantification_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                    eNormalizeBy.Text = PA.MaxValue.ToString();
                    Renormalize();
                }
            }
            catch
            {
                MessageBox.Show("There is a problem with loading the quantification file.\r\nPlease make sure the quantification data is the only data in the loaded file.\r\n", Application.ProductName);
            }
        }

        private void flowpanelReference_ClientSizeChanged(object sender, EventArgs e)
        {
            imageReference.Width = flowpanelReference.ClientSize.Width - 8;
            imageReference.SetHeightAndMode();
            eNotes.Width = flowpanelReference.ClientSize.Width - 8;
            eNotes.Height = Math.Max(flowpanelReference.ClientSize.Height - imageReference.Height - lNotes.Height - 16, 40);

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
                    quantificationLoaded = false;
                    FillPAValues();
                    Renormalize();
                }
            }
            catch
            {
                MessageBox.Show("There is a problem with loading the peptide matrix file.\r\nPlease make sure the peptide matrix is the only data in the loaded file.\r\n", Application.ProductName);
            }
        }

        private void linkRun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Renormalize();
        }

        private void btnSaveMotif_Click(object sender, EventArgs e)
        {
            if (PA == null) return;
            if (MotifMain == null) DrawMotifs();
            if (MotifMain == null) return;
            dlgSaveMotif.FileName = ProjectName;
            DialogResult dlg = dlgSaveMotif.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgSaveMotif.FileName;

            if (Motif.SaveToFile(filename, MotifMain))
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
        }

        private void cmiPeptideScorer_Click(object sender, EventArgs e)
        {
            if (MotifMain == null) return;
            MainForm frm = (MainForm)MainForm.MainFormPointer;
            frm.RunMotifScorer(false, MotifMain);
        }

        private void cmiProteinScorer_Click(object sender, EventArgs e)
        {
            if (MotifMain == null) return;
            MainForm frm = (MainForm)MainForm.MainFormPointer;
            frm.RunMotifScorer(true, MotifMain);
        }

        private void btnRunScorer_Click(object sender, EventArgs e)
        {
            cmsRunScorer.Show(btnRunScorer, 0, 0);
        }
    }
}
