using System.Data;
using PeSA.Engine;

namespace PeSA.Windows
{
    public partial class frmAnalyzePermutationArray : Form
    {
        PermutationArray PA;
        string Title = "Permutation Array Analysis";
        string ProjectName = "";
        bool quantificationLoaded = false;
        int colCount;
        int rowCount;

        GridUtil dgPeptideHelper;
        Motif Motif = null;
        public frmAnalyzePermutationArray()
        {
            InitializeComponent();
            dgPeptideHelper = new GridUtil(dgPeptides);            
        }

        private void frmPeptideArray_Load(object sender, EventArgs e)
        {
            thresholdEntry.SetInitialValues(0.5, 0.5);
            ResetSettings();
            GridUtil.FormatGrid(dgPeptides);
            GridUtil.FormatGrid(dgNormalized);
            GridUtil.FormatGrid(dgQuantification);
        }

        private void ResetSettings()
        {
            Settings settings = (ParentForm as MainForm).DefaultSettings;
            cbYAxisTopToBottom.Checked = settings?.WildTypeYAxisTopToBottom ?? false;
        }

        private bool ColorGrids()
        {
            try
            {
                if (dgQuantification.RowCount < 2 || dgQuantification.ColumnCount < 2)
                    return true;
                for (int i = 1; i < dgQuantification.RowCount; i++)
                {
                    for (int j = 1; j < dgQuantification.ColumnCount; j++)
                    {
                        string peptide = dgPeptides[j, i].Value.ToString();
                        double weight = PA.NormalizedMatrix[i - 1, j - 1];
                        if (weight >= PA.PositiveThreshold)
                        {
                            if (dgPeptides.ColumnCount > 1) //generated
                            {
                                dgPeptides[j, i].Style.BackColor = Common.ColorPositive;
                                dgNormalized[j, i].Style.BackColor = Common.ColorPositive;
                            }
                            dgQuantification[j, i].Style.BackColor = Common.ColorPositive;
                        }
                        else if (weight < PA.NegativeThreshold)
                        {
                            if (dgPeptides.ColumnCount > 1) //generated
                            {
                                dgPeptides[j, i].Style.BackColor = Common.ColorNegative;
                                dgNormalized[j, i].Style.BackColor = Common.ColorNegative;
                            }
                            dgQuantification[j, i].Style.BackColor = Common.ColorNegative;
                        }
                        else
                        {
                            if (dgPeptides.ColumnCount > 1) //generated
                            {
                                dgPeptides[j, i].Style.BackColor = Common.ColorNeutral;
                                dgNormalized[j, i].Style.BackColor = Common.ColorNeutral;
                            }
                            dgQuantification[j, i].Style.BackColor = Common.ColorNeutral;
                        }
                    }
                }
                if (!thresholdEntry.trackThresholdMouseDown && !thresholdEntry.trackNegThresholdMouseDown)
                {
                    FillDecisionGrid();
                    if (!DrawMotifs()) return false;
                }
                return true;
            }
            catch { return false; }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dlgSaveProject.FileName = ProjectName;
            DialogResult dlg = dlgSaveProject.ShowDialog();
            if (dlg != DialogResult.OK) return;
            PA.Notes = eNotes.Text;
            PA.ImageStr = FileUtil.ImageToBase64(imageReference.Image);
            SetText(dlgSaveProject);
            string filename = dlgSaveProject.FileName;
            if (PermutationArray.SaveToFile(filename, PA))
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
        }
        private void SetText(FileDialog dlg)
        {
            ProjectName = FormUtil.SetText(this, dlg, Title);
        }

        private void linkLoadFromFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                    thresholdEntry.SetInitialValues(PA.GetPositiveThreshold(), PA.GetNegativeThreshold());
                    Run();
                }
            }
            catch
            {
                MessageBox.Show("There is a problem with loading the quantification file.\r\nPlease make sure the quantification data is the only data in the loaded file.\r\n", Application.ProductName);
            }
        }

        private void LoadProject()
        {
            try
            {
                DialogResult dlg = dlgOpenProject.ShowDialog();
                if (dlg != DialogResult.OK) return;
                SetText(dlgOpenProject);
                string filename = dlgOpenProject.FileName;
                PA = PermutationArray.ReadFromFile(filename);

                thresholdEntry.SetInitialValues(PA.GetPositiveThreshold(), PA.GetNegativeThreshold());

                cbWildTypeXAxis.Checked = !PA.PermutationXAxis;
                cbYAxisTopToBottom.Checked = PA.WildTypeYAxisTopToBottom;
                colCount = PA.ColCount;
                rowCount = PA.RowCount;

                SetRowColumnCount();
                rbMeanValue.Checked = PA.NormMode == NormalizationMode.Mean;
                rbPerRowColumn.Checked = PA.NormMode != NormalizationMode.Mean;
                if (PA.PeptideMatrix != null)
                    LoadPeptidesFromPermutationArrayToGrid();
                if (PA.QuantificationMatrix != null)
                    LoadQuantificationFromPermutationArrayToGrid();
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
                DrawColorMatrix();
                if (!gridsOK)
                    MessageBox.Show("There is a problem in loading the file. It is highly recommended to re-run the analysis.", Analyzer.ProgramName);
            }
            catch
            {
                MessageBox.Show("There is a problem in loading the file. It is highly recommended to re-run the analysis.", Analyzer.ProgramName);
            }
            linkRun.Visible = true;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProject();
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
        private void LoadNormalizedMatrixFromPeptideArrayToGrid()
        {
            GridUtil.LoadNumericMatrixToGrid(dgNormalized, PA.NormalizedMatrix, 1, 1);
            FillGridHeaders(dgNormalized);
        }
        private void SetRowColumnCount()
        {
            dgPeptides.ColumnCount = dgQuantification.ColumnCount = dgNormalized.ColumnCount = 0;//first set to 0 to clear
            dgPeptides.RowCount = dgQuantification.RowCount = dgNormalized.RowCount = 0;//first set to 0 to clear

            dgPeptides.ColumnCount = dgQuantification.ColumnCount = dgNormalized.ColumnCount = colCount;
            dgPeptides.RowCount = dgQuantification.RowCount = dgNormalized.RowCount = rowCount;
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
            if (PA == null) return;
            dlgExcelExport.FileName = ProjectName;
            DialogResult dlg = dlgExcelExport.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgExcelExport.FileName;
            if (FileUtil.ExportPermutationArrayToExcel(filename, PA, true, out string errormsg))
                MessageBox.Show("Project is exported as an excel file:" + filename, Analyzer.ProgramName);
            else if (errormsg != "")
                MessageBox.Show(errormsg, Analyzer.ProgramName);

        }

        private void ClearMotifs()
        {
            Motif = null;
            mdPositive.Image = mdNegative.Image = mdChart.Image = null;
        }

        private bool DrawMotifs()
        {
            try
            {
                ClearMotifs();
                if (PA == null) return true;
                Settings settings = Settings.Load("default.settings");
                int heightImage = 200;
                int widthImage = 800;
                if (settings != null)
                {
                    heightImage = settings.MotifHeight;
                    widthImage = settings.MotifWidth;
                }
                Motif = new Motif(PA.NormalizedPeptideWeights, PA.NormalizedWildtypeWeights, PA.WildTypePeptide, PA.PositiveThreshold, PA.NegativeThreshold);

                mdPositive.Image = Motif.GetPositiveMotif(widthImage, heightImage);

                mdNegative.Image = Motif.GetNegativeMotif(widthImage, heightImage);

                mdChart.Image = Motif.GetBarChart(pMotif.Width - 6);
                return true;
            }
            catch { return false; }
        }

        private void FillDecisionGrid()
        {
            dgDecision.Rows.Clear();
            dgDecision.RowCount = PA.NormalizedPeptideWeights.Count;
            int rowind = 0;
            foreach (string key in PA.NormalizedPeptideWeights.Keys.OrderBy(k=>k))
            {
                dgDecision[0, rowind].Value = key;
                double val = PA.NormalizedPeptideWeights[key];
                dgDecision[1, rowind].Value = val;
                dgDecision[2, rowind++].Value = val >= PA.PositiveThreshold ? "Pos" : val < PA.NegativeThreshold ? "Neg" : "";
            }
        }

        private void cmiPaste_Click(object sender, EventArgs e)
        {
            GridUtil.PasteClipboard(dgQuantification);
            quantificationLoaded = true;
            dgPeptides.RowCount = dgPeptides.ColumnCount = 0;
            dgNormalized.RowCount = dgNormalized.ColumnCount = 0;
            ResetSettings();
            Run();
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
            PA.SetPositiveThreshold(thresholdEntry.PositiveThreshold, out bool negChanged);
            PA.SetNegativeThreshold(thresholdEntry.NegativeThreshold, out bool posChanged2);
            LoadPeptidesFromPermutationArrayToGrid();
            LoadNormalizedMatrixFromPeptideArrayToGrid();

            dgPeptides.Rows[0].DefaultCellStyle = dgPeptides.ColumnHeadersDefaultCellStyle;
            dgPeptides.Columns[0].DefaultCellStyle = dgPeptides.ColumnHeadersDefaultCellStyle;
            dgNormalized.Rows[0].DefaultCellStyle = dgPeptides.ColumnHeadersDefaultCellStyle;
            dgNormalized.Columns[0].DefaultCellStyle = dgPeptides.ColumnHeadersDefaultCellStyle;
            ColorGrids();
            DrawColorMatrix();
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

        private void flowpanelReference_ClientSizeChanged(object sender, EventArgs e)
        {
            imageReference.Width = flowpanelReference.ClientSize.Width - 8;
            imageReference.SetHeightAndMode();
            eNotes.Width = flowpanelReference.ClientSize.Width - 8;
            eNotes.Height = Math.Max(flowpanelReference.ClientSize.Height - imageReference.Height - lNotes.Height - 16, 40);

        }

        private void DrawColorMatrix()
        {
            try
            {
                char[] colHeader, rowHeader;
                if (PA.PermutationXAxis)
                {
                    colHeader = PA.Permutation;
                    char[] charArray = PA.WildTypePeptide.ToCharArray();
                    if (!PA.WildTypeYAxisTopToBottom)
                        Array.Reverse(charArray);
                    rowHeader = charArray;
                }
                else
                {
                    colHeader = PA.WildTypePeptide.ToCharArray();
                    rowHeader = PA.Permutation;
                }

                ColorMatrix cm = new ColorMatrix();
                cm.SetData(PA.NormalizedMatrix, colHeader, rowHeader);
                mdMatrix.SetThreshold(PA.PositiveThreshold, PA.NegativeThreshold);
                mdMatrix.SetColorMatrix(cm);
            }
            catch { }
        }

        /// <summary>
        /// may be required if an old project is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkRun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Run();
        }

        private void thresholdEntry_ThresholdChanged(object sender, EventArgs e)
        {
            if (PA == null)
                return;
            PA.SetPositiveThreshold(thresholdEntry.PositiveThreshold, out bool negChanged);
            PA.SetNegativeThreshold(thresholdEntry.NegativeThreshold, out bool posChanged2);
            ColorGrids();
            mdMatrix.SetThreshold(PA.PositiveThreshold, PA.NegativeThreshold);
        }

        private void lQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Normalization value is calculated as the average of quantification values corresponding to wildtype sequence", Analyzer.ProgramName);
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

        private void rbMeanValue_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbMeanValue.Focused && !rbPerRowColumn.Focused) return;
            if (rbMeanValue.Checked && PA != null)
            {
                PA.NormMode = NormalizationMode.Mean;
                PA.Renormalize();
                LoadNormalizedMatrixFromPeptideArrayToGrid();
                ColorGrids();
                DrawColorMatrix();
            }
        }

        private void rbPerRowColumn_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbMeanValue.Focused && !rbPerRowColumn.Focused) return;
            if (rbPerRowColumn.Checked && PA != null)
            {
                PA.NormMode = NormalizationMode.PerRowColumn;
                PA.Renormalize();
                LoadNormalizedMatrixFromPeptideArrayToGrid();
                ColorGrids();
                DrawColorMatrix();
            }
        }

        private void btnSaveMotif_Click(object sender, EventArgs e)
        {
            if (PA == null) return;
            dlgSaveMotif.FileName = ProjectName;
            DialogResult dlg = dlgSaveMotif.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgSaveMotif.FileName;
            if (Motif == null)
                Motif = new Motif(PA.NormalizedPeptideWeights, PA.NormalizedWildtypeWeights, PA.WildTypePeptide, PA.PositiveThreshold, PA.NegativeThreshold);

            if (Motif.SaveToFile(filename, Motif))
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
        }


        private void cmiPeptideScorer_Click(object sender, EventArgs e)
        {
            if (Motif == null) return;
            MainForm frm = (MainForm)MainForm.MainFormPointer;
            frm.RunMotifScorer(false, Motif);
        }

        private void cmiProteinScorer_Click(object sender, EventArgs e)
        {
            if (Motif == null) return;
            MainForm frm = (MainForm)MainForm.MainFormPointer;
            frm.RunMotifScorer(true, Motif);
        }

        private void btnRunScorer_Click(object sender, EventArgs e)
        {
            cmsRunScorer.Show(btnRunScorer, 0, 0);
        }
    }
}
