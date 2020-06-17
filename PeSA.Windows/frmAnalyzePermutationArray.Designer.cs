namespace PeSA.Windows
{
    partial class frmAnalyzePermutationArray
    {


        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyzePermutationArray));
            this.dlgOpenQuantification = new System.Windows.Forms.OpenFileDialog();
            this.splitGrids = new System.Windows.Forms.SplitContainer();
            this.dgQuantification = new System.Windows.Forms.DataGridView();
            this.cmsClipBoard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.pPeptidesTop = new System.Windows.Forms.Panel();
            this.linkRun = new System.Windows.Forms.LinkLabel();
            this.linkLoadFromFile = new System.Windows.Forms.LinkLabel();
            this.cbYAxisTopToBottom = new System.Windows.Forms.CheckBox();
            this.cbWildTypeXAxis = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.splitLeftBottom = new System.Windows.Forms.SplitContainer();
            this.dgNormalized = new System.Windows.Forms.DataGridView();
            this.pPeptidesBottom = new System.Windows.Forms.Panel();
            this.rbPerRowColumn = new System.Windows.Forms.RadioButton();
            this.rbMeanValue = new System.Windows.Forms.RadioButton();
            this.thresholdEntry = new PeSA.Windows.Controls.ThresholdEntry();
            this.lNormalized = new System.Windows.Forms.Label();
            this.dgPeptides = new System.Windows.Forms.DataGridView();
            this.cmsPeptide = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiFindPeptide = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pBottom = new System.Windows.Forms.Panel();
            this.btnSaveMotif = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dlgOpenProject = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveProject = new System.Windows.Forms.SaveFileDialog();
            this.dlgExcelExport = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dlgSaveMotif = new System.Windows.Forms.SaveFileDialog();
            this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tabImages = new System.Windows.Forms.TabControl();
            this.tMotif = new System.Windows.Forms.TabPage();
            this.pMotif = new System.Windows.Forms.Panel();
            this.mdChart = new PeSA.Windows.MotifDisplay();
            this.mdNegative = new PeSA.Windows.MotifDisplay();
            this.mdPositive = new PeSA.Windows.MotifDisplay();
            this.tInfo = new System.Windows.Forms.TabPage();
            this.flowpanelReference = new System.Windows.Forms.FlowLayoutPanel();
            this.imageReference = new PeSA.Windows.Controls.ImageDisplay();
            this.lNotes = new System.Windows.Forms.Label();
            this.eNotes = new System.Windows.Forms.TextBox();
            this.tVisualMatrix = new System.Windows.Forms.TabPage();
            this.mdMatrix = new PeSA.Windows.Controls.ColorMatrixDisplay();
            this.tDecisionList = new System.Windows.Forms.TabPage();
            this.dgDecision = new System.Windows.Forms.DataGridView();
            this.colPeptide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDecision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitGrids)).BeginInit();
            this.splitGrids.Panel1.SuspendLayout();
            this.splitGrids.Panel2.SuspendLayout();
            this.splitGrids.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).BeginInit();
            this.cmsClipBoard.SuspendLayout();
            this.pPeptidesTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftBottom)).BeginInit();
            this.splitLeftBottom.Panel1.SuspendLayout();
            this.splitLeftBottom.Panel2.SuspendLayout();
            this.splitLeftBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNormalized)).BeginInit();
            this.pPeptidesBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeptides)).BeginInit();
            this.cmsPeptide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tabImages.SuspendLayout();
            this.tMotif.SuspendLayout();
            this.pMotif.SuspendLayout();
            this.tInfo.SuspendLayout();
            this.flowpanelReference.SuspendLayout();
            this.tVisualMatrix.SuspendLayout();
            this.tDecisionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDecision)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgOpenQuantification
            // 
            this.dlgOpenQuantification.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|Comma Delimited|*.csv";
            this.dlgOpenQuantification.Title = "Open Quantification Matrix";
            // 
            // splitGrids
            // 
            this.splitGrids.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitGrids.Location = new System.Drawing.Point(0, 0);
            this.splitGrids.Margin = new System.Windows.Forms.Padding(2);
            this.splitGrids.Name = "splitGrids";
            this.splitGrids.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitGrids.Panel1
            // 
            this.splitGrids.Panel1.Controls.Add(this.dgQuantification);
            this.splitGrids.Panel1.Controls.Add(this.pPeptidesTop);
            this.splitGrids.Panel1MinSize = 32;
            // 
            // splitGrids.Panel2
            // 
            this.splitGrids.Panel2.Controls.Add(this.splitLeftBottom);
            this.splitGrids.Panel2MinSize = 108;
            this.splitGrids.Size = new System.Drawing.Size(646, 651);
            this.splitGrids.SplitterDistance = 195;
            this.splitGrids.SplitterWidth = 3;
            this.splitGrids.TabIndex = 4;
            // 
            // dgQuantification
            // 
            this.dgQuantification.AllowUserToAddRows = false;
            this.dgQuantification.AllowUserToDeleteRows = false;
            this.dgQuantification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuantification.ColumnHeadersVisible = false;
            this.dgQuantification.ContextMenuStrip = this.cmsClipBoard;
            this.dgQuantification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgQuantification.Location = new System.Drawing.Point(0, 30);
            this.dgQuantification.Margin = new System.Windows.Forms.Padding(2);
            this.dgQuantification.Name = "dgQuantification";
            this.dgQuantification.ReadOnly = true;
            this.dgQuantification.RowHeadersVisible = false;
            this.dgQuantification.RowTemplate.Height = 28;
            this.dgQuantification.Size = new System.Drawing.Size(646, 165);
            this.dgQuantification.TabIndex = 0;
            // 
            // cmsClipBoard
            // 
            this.cmsClipBoard.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsClipBoard.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiPaste});
            this.cmsClipBoard.Name = "cmsClipBoard";
            this.cmsClipBoard.Size = new System.Drawing.Size(203, 26);
            // 
            // cmiPaste
            // 
            this.cmiPaste.Name = "cmiPaste";
            this.cmiPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.cmiPaste.Size = new System.Drawing.Size(202, 22);
            this.cmiPaste.Text = "Paste from Excel";
            this.cmiPaste.Click += new System.EventHandler(this.cmiPaste_Click);
            // 
            // pPeptidesTop
            // 
            this.pPeptidesTop.Controls.Add(this.linkRun);
            this.pPeptidesTop.Controls.Add(this.linkLoadFromFile);
            this.pPeptidesTop.Controls.Add(this.cbYAxisTopToBottom);
            this.pPeptidesTop.Controls.Add(this.cbWildTypeXAxis);
            this.pPeptidesTop.Controls.Add(this.label3);
            this.pPeptidesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPeptidesTop.Location = new System.Drawing.Point(0, 0);
            this.pPeptidesTop.Name = "pPeptidesTop";
            this.pPeptidesTop.Size = new System.Drawing.Size(646, 30);
            this.pPeptidesTop.TabIndex = 1;
            // 
            // linkRun
            // 
            this.linkRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkRun.AutoSize = true;
            this.linkRun.Location = new System.Drawing.Point(532, 8);
            this.linkRun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkRun.Name = "linkRun";
            this.linkRun.Size = new System.Drawing.Size(27, 13);
            this.linkRun.TabIndex = 8;
            this.linkRun.TabStop = true;
            this.linkRun.Text = "Run";
            this.linkRun.Visible = false;
            this.linkRun.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRun_LinkClicked);
            // 
            // linkLoadFromFile
            // 
            this.linkLoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLoadFromFile.AutoSize = true;
            this.linkLoadFromFile.Location = new System.Drawing.Point(563, 8);
            this.linkLoadFromFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLoadFromFile.Name = "linkLoadFromFile";
            this.linkLoadFromFile.Size = new System.Drawing.Size(73, 13);
            this.linkLoadFromFile.TabIndex = 7;
            this.linkLoadFromFile.TabStop = true;
            this.linkLoadFromFile.Text = "Load from File";
            this.linkLoadFromFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLoadFromFile_LinkClicked);
            // 
            // cbYAxisTopToBottom
            // 
            this.cbYAxisTopToBottom.AutoSize = true;
            this.cbYAxisTopToBottom.Location = new System.Drawing.Point(269, 8);
            this.cbYAxisTopToBottom.Margin = new System.Windows.Forms.Padding(2);
            this.cbYAxisTopToBottom.Name = "cbYAxisTopToBottom";
            this.cbYAxisTopToBottom.Size = new System.Drawing.Size(128, 17);
            this.cbYAxisTopToBottom.TabIndex = 6;
            this.cbYAxisTopToBottom.Text = "Y Axis: Top to Bottom";
            this.cbYAxisTopToBottom.UseVisualStyleBackColor = true;
            this.cbYAxisTopToBottom.CheckedChanged += new System.EventHandler(this.cbYAxisTopToBottom_CheckedChanged);
            // 
            // cbWildTypeXAxis
            // 
            this.cbWildTypeXAxis.AutoSize = true;
            this.cbWildTypeXAxis.Location = new System.Drawing.Point(156, 9);
            this.cbWildTypeXAxis.Margin = new System.Windows.Forms.Padding(2);
            this.cbWildTypeXAxis.Name = "cbWildTypeXAxis";
            this.cbWildTypeXAxis.Size = new System.Drawing.Size(109, 17);
            this.cbWildTypeXAxis.TabIndex = 5;
            this.cbWildTypeXAxis.Text = "X Axis: Wild Type";
            this.cbWildTypeXAxis.UseVisualStyleBackColor = true;
            this.cbWildTypeXAxis.CheckedChanged += new System.EventHandler(this.cbWildTypeXAxis_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantification";
            // 
            // splitLeftBottom
            // 
            this.splitLeftBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeftBottom.Location = new System.Drawing.Point(0, 0);
            this.splitLeftBottom.Margin = new System.Windows.Forms.Padding(2);
            this.splitLeftBottom.Name = "splitLeftBottom";
            this.splitLeftBottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeftBottom.Panel1
            // 
            this.splitLeftBottom.Panel1.Controls.Add(this.dgNormalized);
            this.splitLeftBottom.Panel1.Controls.Add(this.pPeptidesBottom);
            this.splitLeftBottom.Panel1MinSize = 45;
            // 
            // splitLeftBottom.Panel2
            // 
            this.splitLeftBottom.Panel2.Controls.Add(this.dgPeptides);
            this.splitLeftBottom.Panel2.Controls.Add(this.panel1);
            this.splitLeftBottom.Panel2MinSize = 32;
            this.splitLeftBottom.Size = new System.Drawing.Size(646, 453);
            this.splitLeftBottom.SplitterDistance = 274;
            this.splitLeftBottom.SplitterWidth = 3;
            this.splitLeftBottom.TabIndex = 4;
            // 
            // dgNormalized
            // 
            this.dgNormalized.AllowUserToAddRows = false;
            this.dgNormalized.AllowUserToDeleteRows = false;
            this.dgNormalized.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNormalized.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNormalized.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgNormalized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgNormalized.Location = new System.Drawing.Point(0, 74);
            this.dgNormalized.Name = "dgNormalized";
            this.dgNormalized.ReadOnly = true;
            this.dgNormalized.RowHeadersVisible = false;
            this.dgNormalized.Size = new System.Drawing.Size(646, 200);
            this.dgNormalized.TabIndex = 4;
            // 
            // pPeptidesBottom
            // 
            this.pPeptidesBottom.Controls.Add(this.rbPerRowColumn);
            this.pPeptidesBottom.Controls.Add(this.rbMeanValue);
            this.pPeptidesBottom.Controls.Add(this.thresholdEntry);
            this.pPeptidesBottom.Controls.Add(this.lNormalized);
            this.pPeptidesBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPeptidesBottom.Location = new System.Drawing.Point(0, 0);
            this.pPeptidesBottom.Name = "pPeptidesBottom";
            this.pPeptidesBottom.Size = new System.Drawing.Size(646, 74);
            this.pPeptidesBottom.TabIndex = 3;
            // 
            // rbPerRowColumn
            // 
            this.rbPerRowColumn.AutoSize = true;
            this.rbPerRowColumn.Location = new System.Drawing.Point(94, 46);
            this.rbPerRowColumn.Margin = new System.Windows.Forms.Padding(2);
            this.rbPerRowColumn.Name = "rbPerRowColumn";
            this.rbPerRowColumn.Size = new System.Drawing.Size(106, 17);
            this.rbPerRowColumn.TabIndex = 46;
            this.rbPerRowColumn.Text = "Per Row/Column";
            this.rbPerRowColumn.UseVisualStyleBackColor = true;
            this.rbPerRowColumn.CheckedChanged += new System.EventHandler(this.rbPerRowColumn_CheckedChanged);
            // 
            // rbMeanValue
            // 
            this.rbMeanValue.AutoSize = true;
            this.rbMeanValue.Checked = true;
            this.rbMeanValue.Location = new System.Drawing.Point(9, 46);
            this.rbMeanValue.Margin = new System.Windows.Forms.Padding(2);
            this.rbMeanValue.Name = "rbMeanValue";
            this.rbMeanValue.Size = new System.Drawing.Size(82, 17);
            this.rbMeanValue.TabIndex = 45;
            this.rbMeanValue.TabStop = true;
            this.rbMeanValue.Text = "Mean Value";
            this.rbMeanValue.UseVisualStyleBackColor = true;
            this.rbMeanValue.CheckedChanged += new System.EventHandler(this.rbMeanValue_CheckedChanged);
            // 
            // thresholdEntry
            // 
            this.thresholdEntry.Location = new System.Drawing.Point(200, 2);
            this.thresholdEntry.Margin = new System.Windows.Forms.Padding(4);
            this.thresholdEntry.MinimumSize = new System.Drawing.Size(400, 70);
            this.thresholdEntry.Name = "thresholdEntry";
            this.thresholdEntry.NegativeThreshold = 0.5D;
            this.thresholdEntry.PositiveThreshold = 0.5D;
            this.thresholdEntry.Size = new System.Drawing.Size(400, 70);
            this.thresholdEntry.TabIndex = 11;
            this.thresholdEntry.ThresholdChanged += new System.EventHandler(this.thresholdEntry_ThresholdChanged);
            // 
            // lNormalized
            // 
            this.lNormalized.AutoSize = true;
            this.lNormalized.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNormalized.Location = new System.Drawing.Point(6, 6);
            this.lNormalized.Name = "lNormalized";
            this.lNormalized.Size = new System.Drawing.Size(79, 17);
            this.lNormalized.TabIndex = 2;
            this.lNormalized.Text = "Normalized";
            // 
            // dgPeptides
            // 
            this.dgPeptides.AllowUserToAddRows = false;
            this.dgPeptides.AllowUserToDeleteRows = false;
            this.dgPeptides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeptides.ColumnHeadersVisible = false;
            this.dgPeptides.ContextMenuStrip = this.cmsPeptide;
            this.dgPeptides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPeptides.Location = new System.Drawing.Point(0, 31);
            this.dgPeptides.Margin = new System.Windows.Forms.Padding(2);
            this.dgPeptides.Name = "dgPeptides";
            this.dgPeptides.ReadOnly = true;
            this.dgPeptides.RowHeadersVisible = false;
            this.dgPeptides.RowTemplate.Height = 28;
            this.dgPeptides.Size = new System.Drawing.Size(646, 145);
            this.dgPeptides.TabIndex = 2;
            // 
            // cmsPeptide
            // 
            this.cmsPeptide.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsPeptide.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiFindPeptide,
            this.cmiFindNext});
            this.cmsPeptide.Name = "cmsClipBoard";
            this.cmsPeptide.Size = new System.Drawing.Size(181, 48);
            // 
            // cmiFindPeptide
            // 
            this.cmiFindPeptide.Name = "cmiFindPeptide";
            this.cmiFindPeptide.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.cmiFindPeptide.Size = new System.Drawing.Size(180, 22);
            this.cmiFindPeptide.Text = "Find Peptide";
            this.cmiFindPeptide.Click += new System.EventHandler(this.cmiFindPeptide_Click);
            // 
            // cmiFindNext
            // 
            this.cmiFindNext.Name = "cmiFindNext";
            this.cmiFindNext.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.cmiFindNext.Size = new System.Drawing.Size(180, 22);
            this.cmiFindNext.Text = "Find Next";
            this.cmiFindNext.Click += new System.EventHandler(this.cmiFindNext_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 31);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Peptides";
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnSaveMotif);
            this.pBottom.Controls.Add(this.btnExport);
            this.pBottom.Controls.Add(this.btnLoad);
            this.pBottom.Controls.Add(this.btnSave);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 651);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(1155, 36);
            this.pBottom.TabIndex = 4;
            // 
            // btnSaveMotif
            // 
            this.btnSaveMotif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMotif.Location = new System.Drawing.Point(1038, 6);
            this.btnSaveMotif.Name = "btnSaveMotif";
            this.btnSaveMotif.Size = new System.Drawing.Size(105, 23);
            this.btnSaveMotif.TabIndex = 3;
            this.btnSaveMotif.Text = "Save Motif";
            this.btnSaveMotif.UseVisualStyleBackColor = true;
            this.btnSaveMotif.Click += new System.EventHandler(this.btnSaveMotif_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(231, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(120, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(105, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Project";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Project";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dlgOpenProject
            // 
            this.dlgOpenProject.FileName = "Open Project";
            this.dlgOpenProject.Filter = "PeSA Permutation Array Project File|*.pprm";
            this.dlgOpenProject.Title = "Open Project";
            // 
            // dlgSaveProject
            // 
            this.dlgSaveProject.Filter = "PeSA Permutation Array Project File|*.pprm";
            this.dlgSaveProject.Title = "Save Project";
            // 
            // dlgExcelExport
            // 
            this.dlgExcelExport.Filter = "Excel Files|*.xlsx;*.xlsm";
            this.dlgExcelExport.Title = "Export to Excel";
            // 
            // dlgSaveMotif
            // 
            this.dlgSaveMotif.Filter = "PeSA Motif File|*.pmtf";
            this.dlgSaveMotif.Title = "Save Motif File";
            // 
            // dlgOpenImage
            // 
            this.dlgOpenImage.FileName = "Open Image";
            this.dlgOpenImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png\"";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitGrids);
            this.splitMain.Panel1MinSize = 580;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tabImages);
            this.splitMain.Panel2MinSize = 325;
            this.splitMain.Size = new System.Drawing.Size(1155, 651);
            this.splitMain.SplitterDistance = 646;
            this.splitMain.TabIndex = 7;
            // 
            // tabImages
            // 
            this.tabImages.Controls.Add(this.tMotif);
            this.tabImages.Controls.Add(this.tInfo);
            this.tabImages.Controls.Add(this.tVisualMatrix);
            this.tabImages.Controls.Add(this.tDecisionList);
            this.tabImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabImages.Location = new System.Drawing.Point(0, 0);
            this.tabImages.Name = "tabImages";
            this.tabImages.SelectedIndex = 0;
            this.tabImages.Size = new System.Drawing.Size(505, 651);
            this.tabImages.TabIndex = 7;
            // 
            // tMotif
            // 
            this.tMotif.Controls.Add(this.pMotif);
            this.tMotif.Location = new System.Drawing.Point(4, 25);
            this.tMotif.Name = "tMotif";
            this.tMotif.Padding = new System.Windows.Forms.Padding(3);
            this.tMotif.Size = new System.Drawing.Size(497, 622);
            this.tMotif.TabIndex = 0;
            this.tMotif.Text = "Motif";
            this.tMotif.UseVisualStyleBackColor = true;
            // 
            // pMotif
            // 
            this.pMotif.AutoScroll = true;
            this.pMotif.Controls.Add(this.mdChart);
            this.pMotif.Controls.Add(this.mdNegative);
            this.pMotif.Controls.Add(this.mdPositive);
            this.pMotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMotif.Location = new System.Drawing.Point(3, 3);
            this.pMotif.Name = "pMotif";
            this.pMotif.Size = new System.Drawing.Size(491, 616);
            this.pMotif.TabIndex = 0;
            // 
            // mdChart
            // 
            this.mdChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdChart.Image = null;
            this.mdChart.LabelText = "Chart";
            this.mdChart.Location = new System.Drawing.Point(0, 316);
            this.mdChart.Margin = new System.Windows.Forms.Padding(4);
            this.mdChart.Name = "mdChart";
            this.mdChart.Size = new System.Drawing.Size(491, 158);
            this.mdChart.TabIndex = 5;
            // 
            // mdNegative
            // 
            this.mdNegative.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdNegative.Image = null;
            this.mdNegative.LabelText = "Negative Motif";
            this.mdNegative.Location = new System.Drawing.Point(0, 158);
            this.mdNegative.Margin = new System.Windows.Forms.Padding(4);
            this.mdNegative.Name = "mdNegative";
            this.mdNegative.Size = new System.Drawing.Size(491, 158);
            this.mdNegative.TabIndex = 4;
            // 
            // mdPositive
            // 
            this.mdPositive.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdPositive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdPositive.Image = null;
            this.mdPositive.LabelText = "Positive Motif";
            this.mdPositive.Location = new System.Drawing.Point(0, 0);
            this.mdPositive.Margin = new System.Windows.Forms.Padding(4);
            this.mdPositive.Name = "mdPositive";
            this.mdPositive.Size = new System.Drawing.Size(491, 158);
            this.mdPositive.TabIndex = 3;
            // 
            // tInfo
            // 
            this.tInfo.Controls.Add(this.flowpanelReference);
            this.tInfo.Location = new System.Drawing.Point(4, 25);
            this.tInfo.Name = "tInfo";
            this.tInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tInfo.Size = new System.Drawing.Size(497, 622);
            this.tInfo.TabIndex = 1;
            this.tInfo.Text = "Info";
            this.tInfo.UseVisualStyleBackColor = true;
            // 
            // flowpanelReference
            // 
            this.flowpanelReference.AutoScroll = true;
            this.flowpanelReference.BackColor = System.Drawing.SystemColors.Control;
            this.flowpanelReference.Controls.Add(this.imageReference);
            this.flowpanelReference.Controls.Add(this.lNotes);
            this.flowpanelReference.Controls.Add(this.eNotes);
            this.flowpanelReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelReference.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowpanelReference.Location = new System.Drawing.Point(3, 3);
            this.flowpanelReference.Name = "flowpanelReference";
            this.flowpanelReference.Size = new System.Drawing.Size(491, 616);
            this.flowpanelReference.TabIndex = 1;
            this.flowpanelReference.WrapContents = false;
            this.flowpanelReference.ClientSizeChanged += new System.EventHandler(this.flowpanelReference_ClientSizeChanged);
            // 
            // imageReference
            // 
            this.imageReference.Image = ((System.Drawing.Image)(resources.GetObject("imageReference.Image")));
            this.imageReference.Location = new System.Drawing.Point(4, 4);
            this.imageReference.Margin = new System.Windows.Forms.Padding(4);
            this.imageReference.Name = "imageReference";
            this.imageReference.Size = new System.Drawing.Size(483, 200);
            this.imageReference.TabIndex = 5;
            // 
            // lNotes
            // 
            this.lNotes.AutoSize = true;
            this.lNotes.Location = new System.Drawing.Point(3, 208);
            this.lNotes.Name = "lNotes";
            this.lNotes.Padding = new System.Windows.Forms.Padding(3);
            this.lNotes.Size = new System.Drawing.Size(51, 23);
            this.lNotes.TabIndex = 1;
            this.lNotes.Text = "Notes";
            // 
            // eNotes
            // 
            this.eNotes.Location = new System.Drawing.Point(3, 234);
            this.eNotes.Multiline = true;
            this.eNotes.Name = "eNotes";
            this.eNotes.Size = new System.Drawing.Size(497, 554);
            this.eNotes.TabIndex = 2;
            // 
            // tVisualMatrix
            // 
            this.tVisualMatrix.AutoScroll = true;
            this.tVisualMatrix.Controls.Add(this.mdMatrix);
            this.tVisualMatrix.Location = new System.Drawing.Point(4, 25);
            this.tVisualMatrix.Name = "tVisualMatrix";
            this.tVisualMatrix.Padding = new System.Windows.Forms.Padding(3);
            this.tVisualMatrix.Size = new System.Drawing.Size(497, 622);
            this.tVisualMatrix.TabIndex = 2;
            this.tVisualMatrix.Text = "Visual Matrix";
            this.tVisualMatrix.UseVisualStyleBackColor = true;
            // 
            // mdMatrix
            // 
            this.mdMatrix.AutoScroll = true;
            this.mdMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mdMatrix.Image = null;
            this.mdMatrix.Location = new System.Drawing.Point(3, 3);
            this.mdMatrix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mdMatrix.Name = "mdMatrix";
            this.mdMatrix.Size = new System.Drawing.Size(491, 616);
            this.mdMatrix.TabIndex = 0;
            // 
            // tDecisionList
            // 
            this.tDecisionList.Controls.Add(this.dgDecision);
            this.tDecisionList.Location = new System.Drawing.Point(4, 25);
            this.tDecisionList.Name = "tDecisionList";
            this.tDecisionList.Padding = new System.Windows.Forms.Padding(3);
            this.tDecisionList.Size = new System.Drawing.Size(497, 622);
            this.tDecisionList.TabIndex = 3;
            this.tDecisionList.Text = "Decision List";
            this.tDecisionList.UseVisualStyleBackColor = true;
            // 
            // dgDecision
            // 
            this.dgDecision.AllowUserToAddRows = false;
            this.dgDecision.AllowUserToDeleteRows = false;
            this.dgDecision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDecision.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPeptide,
            this.colWeight,
            this.colDecision});
            this.dgDecision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDecision.Location = new System.Drawing.Point(3, 3);
            this.dgDecision.Name = "dgDecision";
            this.dgDecision.RowHeadersVisible = false;
            this.dgDecision.Size = new System.Drawing.Size(491, 616);
            this.dgDecision.TabIndex = 0;
            // 
            // colPeptide
            // 
            this.colPeptide.HeaderText = "Peptide";
            this.colPeptide.Name = "colPeptide";
            this.colPeptide.ReadOnly = true;
            // 
            // colWeight
            // 
            this.colWeight.HeaderText = "Weight";
            this.colWeight.Name = "colWeight";
            this.colWeight.ReadOnly = true;
            // 
            // colDecision
            // 
            this.colDecision.HeaderText = "Decision";
            this.colDecision.Name = "colDecision";
            this.colDecision.ReadOnly = true;
            // 
            // frmAnalyzePermutationArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pBottom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAnalyzePermutationArray";
            this.Text = "Permutation Array Analysis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPeptideArray_Load);
            this.splitGrids.Panel1.ResumeLayout(false);
            this.splitGrids.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitGrids)).EndInit();
            this.splitGrids.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).EndInit();
            this.cmsClipBoard.ResumeLayout(false);
            this.pPeptidesTop.ResumeLayout(false);
            this.pPeptidesTop.PerformLayout();
            this.splitLeftBottom.Panel1.ResumeLayout(false);
            this.splitLeftBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftBottom)).EndInit();
            this.splitLeftBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNormalized)).EndInit();
            this.pPeptidesBottom.ResumeLayout(false);
            this.pPeptidesBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeptides)).EndInit();
            this.cmsPeptide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tabImages.ResumeLayout(false);
            this.tMotif.ResumeLayout(false);
            this.pMotif.ResumeLayout(false);
            this.tInfo.ResumeLayout(false);
            this.flowpanelReference.ResumeLayout(false);
            this.flowpanelReference.PerformLayout();
            this.tVisualMatrix.ResumeLayout(false);
            this.tDecisionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDecision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog dlgOpenQuantification;
        private System.Windows.Forms.SplitContainer splitGrids;
        private System.Windows.Forms.DataGridView dgQuantification;
        private System.Windows.Forms.ContextMenuStrip cmsClipBoard;
        private System.ComponentModel.IContainer components;
        private System.Windows.Forms.Panel pPeptidesTop;
        private System.Windows.Forms.DataGridView dgPeptides;
        private System.Windows.Forms.Panel pPeptidesBottom;
        private System.Windows.Forms.ToolStripMenuItem cmiPaste;
        private System.Windows.Forms.CheckBox cbYAxisTopToBottom;
        private System.Windows.Forms.CheckBox cbWildTypeXAxis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lNormalized;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog dlgOpenProject;
        private System.Windows.Forms.SaveFileDialog dlgSaveProject;
        private System.Windows.Forms.SaveFileDialog dlgExcelExport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SaveFileDialog dlgSaveMotif;
        private System.Windows.Forms.OpenFileDialog dlgOpenImage;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TabControl tabImages;
        private System.Windows.Forms.TabPage tMotif;
        private System.Windows.Forms.TabPage tInfo;
        private Controls.ColorMatrixDisplay mdMatrix;
        private System.Windows.Forms.Panel pMotif;
        private System.Windows.Forms.FlowLayoutPanel flowpanelReference;
        private System.Windows.Forms.Label lNotes;
        private System.Windows.Forms.TextBox eNotes;
        private MotifDisplay mdChart;
        private MotifDisplay mdNegative;
        private MotifDisplay mdPositive;
        private System.Windows.Forms.LinkLabel linkLoadFromFile;
        private Controls.ImageDisplay imageReference;
        private System.Windows.Forms.TabPage tVisualMatrix;
        private System.Windows.Forms.TabPage tDecisionList;
        private System.Windows.Forms.DataGridView dgDecision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeptide;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDecision;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSaveMotif;
        private System.Windows.Forms.LinkLabel linkRun;
        private Controls.ThresholdEntry thresholdEntry;
        private System.Windows.Forms.ContextMenuStrip cmsPeptide;
        private System.Windows.Forms.ToolStripMenuItem cmiFindPeptide;
        private System.Windows.Forms.ToolStripMenuItem cmiFindNext;
        private System.Windows.Forms.SplitContainer splitLeftBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgNormalized;
        private System.Windows.Forms.RadioButton rbPerRowColumn;
        private System.Windows.Forms.RadioButton rbMeanValue;
    }
}