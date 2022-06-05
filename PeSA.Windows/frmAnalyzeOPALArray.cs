using PeSA.Engine;

namespace PeSA.Windows
{
    public partial class frmAnalyzeOPALArray : Form
    {
        OPALArray OA;
        string Title = "OPAL Array Analysis";
        string ProjectName = "";

        bool quantificationLoaded = false;
        bool PermutationXAxis = false;
        Motif Motif;

        public frmAnalyzeOPALArray()
        {
            InitializeComponent();
        }

        private void frmOPALArray_Load(object sender, EventArgs e)
        {
            thresholdEntry.SetInitialValues(0.5, 0.5);
            ResetSettings();
            GridUtil.FormatGrid(dgQuantification);
            GridUtil.FormatGrid(dgNormalized);
        }

        private void ResetSettings()
        {
            Settings settings = (ParentForm as MainForm).DefaultSettings;
            cbYAxisTopToBottom.Checked = settings?.WildTypeYAxisTopToBottom ?? false;
        }
        private void ClearMotifs()
        {
            mdPositive.Image = mdNegative.Image = mdChart.Image = null;
        }

        private bool CreateMotif()
        {
            if (OA == null) return false;
            Motif = new Motif(OA.NormalizedPeptideWeights, OA.PositionCaptions, OA.PositiveThreshold, OA.NegativeThreshold);
            return (Motif != null);
        }
        private bool DrawMotifs()
        {
            try
            {
                ClearMotifs();
                if (OA == null) return true;
                Settings settings = Settings.Load("default.settings");
                int heightImage = 200;
                int widthImage = 800;
                if (settings != null)
                {
                    heightImage = settings.MotifHeight;
                    widthImage = settings.MotifWidth;
                }
                if (!CreateMotif()) return false;

                mdPositive.Image = Motif.GetPositiveMotif(widthImage, heightImage);

                mdNegative.Image = Motif.GetNegativeMotif(widthImage, heightImage);

                mdChart.Image = Motif.GetBarChart(pMotif.Width - 6);
                return true;
            }
            catch { return false; }
        }

        /*private void FillDecisionGrid()
        {
            dgDecision.Rows.Clear();
            dgDecision.RowCount = OA.NormalizedPeptideWeights.Count;
            int rowind = 0;
            foreach (string key in OA.NormalizedPeptideWeights.Keys.OrderBy(k => k))
            {
                dgDecision[0, rowind].Value = key;
                double val = OA.NormalizedPeptideWeights[key];
                dgDecision[1, rowind].Value = val;
                dgDecision[2, rowind++].Value = val >= OA.PositiveThreshold ? "Pos" : val < OA.NegativeThreshold ? "Neg" : "";
            }
        }*/

        private bool ColorGridsandDrawMotifs()
        {
            try
            {
                if (OA == null)
                    return true;
                for (int i = 1; i < dgQuantification.RowCount; i++)
                {
                    for (int j = 1; j < dgQuantification.ColumnCount; j++)
                    {
                        double weight = OA.NormalizedMatrix[i - 1, j - 1];
                        if (weight >= OA.PositiveThreshold)
                        {
                            dgQuantification[j, i].Style.BackColor = Common.ColorPositive;
                            dgNormalized[j, i].Style.BackColor = Common.ColorPositive;
                        }
                        else if (weight < OA.NegativeThreshold)
                        {
                            dgQuantification[j, i].Style.BackColor = Common.ColorNegative;
                            dgNormalized[j, i].Style.BackColor = Common.ColorNegative;
                        }
                        else
                        {
                            dgQuantification[j, i].Style.BackColor = Common.ColorNeutral;
                            dgNormalized[j, i].Style.BackColor = Common.ColorNeutral;
                        }
                    }
                }
                if (!thresholdEntry.trackThresholdMouseDown && !thresholdEntry.trackNegThresholdMouseDown)
                {
                    //FillDecisionGrid();
                    if (!DrawMotifs())
                        return false;
                }
                return true;
            }
            catch { return false; }
        }

        private void DrawColorMatrix()
        {
            try
            {
                char[] colHeader, rowHeader;
                if (OA.PermutationXAxis)
                {
                    colHeader = OA.Permutation;
                    char[] charArray = OA.WildTypePeptide.ToCharArray();
                    if (!OA.PositionYAxisTopToBottom)
                        Array.Reverse(charArray);
                    rowHeader = charArray;
                }
                else
                {
                    colHeader = OA.WildTypePeptide.ToCharArray();
                    rowHeader = OA.Permutation;
                }

                ColorMatrix cm = new ColorMatrix();
                cm.SetData(OA.NormalizedMatrix, colHeader, rowHeader);
                mdMatrix.SetThreshold(OA.PositiveThreshold, OA.NegativeThreshold);
                mdMatrix.SetColorMatrix(cm);
            }
            catch { }
        }
        private void SetText(FileDialog dlg)
        {
            ProjectName = FormUtil.SetText(this, dlg, Title);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dlgSaveProject.FileName = ProjectName;
            DialogResult dlg = dlgSaveProject.ShowDialog();
            if (dlg != DialogResult.OK) return;
            SetText(dlgSaveProject);
            OA.Notes = eNotes.Text;
            OA.ImageStr = FileUtil.ImageToBase64(imageReference.Image);
            string filename = dlgSaveProject.FileName;
            if (OPALArray.SaveToFile(filename, OA))
                MessageBox.Show(filename + " is saved", Analyzer.ProgramName);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadProject();
        }

        private void LoadProject()
        { 
            try
            {
                DialogResult dlg = dlgOpenProject.ShowDialog();
                if (dlg != DialogResult.OK) return;
                SetText(dlgOpenProject);
                string filename = dlgOpenProject.FileName;
                try
                {
                    OA = OPALArray.ReadFromFile(filename);
                }
                catch
                {
                    MessageBox.Show("The file may be corrupted or not a valid PeSA project file.", Analyzer.ProgramName);
                }
                thresholdEntry.SetInitialValues(OA.GetPositiveThreshold(), OA.GetNegativeThreshold());
                rbMaxValue.Checked = OA.NormMode == NormalizationMode.Max;
                rbPerRowColumn.Checked = OA.NormMode != NormalizationMode.Max;

                cbPermutationXAxis.Checked = PermutationXAxis;
                cbYAxisTopToBottom.Checked = OA.PositionYAxisTopToBottom;

                if (OA.QuantificationMatrix != null)
                    LoadQuantificationFromOPALArrayToGrid();
                GridUtil.LoadNumericMatrixToGrid(dgNormalized, OA.NormalizedMatrix, 1, 1);
                FillGridHeaders(dgNormalized);
                
                bool gridOK = ColorGridsandDrawMotifs();//also creates/draws the motif

                eNotes.Text = OA.Notes;
                imageReference.Image = null;
                try
                {
                    Image img = FileUtil.Base64ToImage(OA.ImageStr);
                    imageReference.Image = img;
                }
                catch { }

                DrawColorMatrix();
                if (!gridOK)
                    MessageBox.Show("There is a problem in loading the file. It is highly recommended to re-run the analysis.", Analyzer.ProgramName);
            }
            catch
            {
                MessageBox.Show("There is a problem in loading the file. It is highly recommended to re-run the analysis.", Analyzer.ProgramName);
            }
            linkRun.Visible = true;
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

        private void cmiPaste_Click(object sender, EventArgs e)
        {
            GridUtil.PasteClipboard(dgQuantification);
            quantificationLoaded = true;
            ResetSettings();
            Run();
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

        private void Run()
        { 
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
            OA = new OPALArray(values, PermutationXAxis, cbYAxisTopToBottom.Checked, out error);
            OA.SetPositiveThreshold(thresholdEntry.PositiveThreshold, out bool negChanged);
            OA.SetNegativeThreshold(thresholdEntry.NegativeThreshold, out bool posChanged2);
            if (error != "")
            {
                MessageBox.Show(error, Analyzer.ProgramName);
                return;
            }
            GridUtil.LoadNumericMatrixToGrid(dgNormalized, OA.NormalizedMatrix, 1, 1);
            FillGridHeaders(dgNormalized);
            ColorGridsandDrawMotifs();
            DrawColorMatrix();
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
            if (OA == null) return;
            dlgExcelExport.FileName = ProjectName;
            DialogResult dlg = dlgExcelExport.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgExcelExport.FileName;
            string errormsg = "";
            if (FileUtil.ExportOPALArrayToExcel(filename, OA, true, out errormsg))
                MessageBox.Show("Project is exported as an excel file:" + filename, Analyzer.ProgramName);
            else if (errormsg != "")
                MessageBox.Show(errormsg, Analyzer.ProgramName);
        }

        private void cbYAxisTopToBottom_CheckedChanged(object sender, EventArgs e)
        {
            //Rerun
            if (quantificationLoaded)
                Run();
        }

        private void thresholdEntry_ThresholdChanged(object sender, EventArgs e)
        {
            if (OA == null)
                return;
            OA.SetPositiveThreshold(thresholdEntry.PositiveThreshold, out bool negChanged);
            OA.SetNegativeThreshold(thresholdEntry.NegativeThreshold, out bool posChanged2);
            ColorGridsandDrawMotifs();
            mdMatrix.SetThreshold(OA.PositiveThreshold, OA.NegativeThreshold);
        }

        private void cbPermutationXAxis_CheckedChanged(object sender, EventArgs e)
        {
            cbYAxisTopToBottom.Visible = cbPermutationXAxis.Checked;
        }

        private void linkLoadFromFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                DialogResult dlg = dlgOpenQuantification.ShowDialog();
                if (dlg != DialogResult.OK) return;
                SetText(dlgOpenProject);
                string filename = dlgOpenQuantification.FileName;

                if (System.IO.File.Exists(filename))
                {
                    OA = FileUtil.ReadOPALArrayQuantificationData(filename);
                    thresholdEntry.SetInitialValues(OA.GetPositiveThreshold(), OA.GetNegativeThreshold());
                    
                    cbPermutationXAxis.Checked = PermutationXAxis;
                    cbYAxisTopToBottom.Checked = OA.PositionYAxisTopToBottom;

                    if (OA.QuantificationMatrix != null)
                        LoadQuantificationFromOPALArrayToGrid();
                    GridUtil.LoadNumericMatrixToGrid(dgNormalized, OA.NormalizedMatrix, 1, 1);
                    FillGridHeaders(dgNormalized);
                    Run();
                    ColorGridsandDrawMotifs();
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

        private void linkRun_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Run();
        }

        private void rbMaxValue_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbMaxValue.Focused && !rbPerRowColumn.Focused) return;
            if (rbMaxValue.Checked && OA != null)
            {
                OA.NormMode = NormalizationMode.Max;
                OA.Renormalize();
                GridUtil.LoadNumericMatrixToGrid(dgNormalized, OA.NormalizedMatrix, 1, 1);
                ColorGridsandDrawMotifs();
                DrawColorMatrix();
            }
        }

        private void rbPerRowColumn_CheckedChanged(object sender, EventArgs e)
        {
            if (!rbMaxValue.Focused && !rbPerRowColumn.Focused) return;
            if (rbPerRowColumn.Checked && OA != null)
            {
                OA.NormMode = NormalizationMode.PerRowColumn;
                OA.Renormalize();
                GridUtil.LoadNumericMatrixToGrid(dgNormalized, OA.NormalizedMatrix, 1, 1);
                ColorGridsandDrawMotifs();
                DrawColorMatrix();
            }
        }

        private void btnSaveMotif_Click(object sender, EventArgs e)
        {
            if (OA == null) return;
            dlgSaveMotif.FileName = ProjectName;
            DialogResult dlg = dlgSaveMotif.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgSaveMotif.FileName;
            if (Motif == null)
                Motif = new Motif(OA.NormalizedPeptideWeights, OA.PositionCaptions, OA.PositiveThreshold, OA.NegativeThreshold);

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
