namespace PeSA.Windows
{
    partial class frmAnalyzePeptideArray
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyzePeptideArray));
            this.cmsLoadPeptide = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiLoadPeptideList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiLoadPeptideMatrix = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOpenPeptideList = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenQuantification = new System.Windows.Forms.OpenFileDialog();
            this.splitLeftTop = new System.Windows.Forms.SplitContainer();
            this.dgPeptides = new System.Windows.Forms.DataGridView();
            this.cmsPeptide = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPastePeptide = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiFindPeptide = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.pPeptidesTop = new System.Windows.Forms.Panel();
            this.linkRun = new System.Windows.Forms.LinkLabel();
            this.lLoadPeptides = new System.Windows.Forms.LinkLabel();
            this.lArrayInfo = new System.Windows.Forms.Label();
            this.lPeptides = new System.Windows.Forms.Label();
            this.dgQuantification = new System.Windows.Forms.DataGridView();
            this.cmsQuantification = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPasteQuantification = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLoadQuantification = new System.Windows.Forms.LinkLabel();
            this.lQuantification = new System.Windows.Forms.Label();
            this.ePeptideLength = new System.Windows.Forms.TextBox();
            this.lPeptideLength = new System.Windows.Forms.Label();
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.dgNormalized = new System.Windows.Forms.DataGridView();
            this.pBottom = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.thresholdEntry = new PeSA.Windows.Controls.ThresholdEntry();
            this.eNormalizeBy = new System.Windows.Forms.TextBox();
            this.lNormalizeBy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgOpenProject = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveProject = new System.Windows.Forms.SaveFileDialog();
            this.dlgExcelExport = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dlgOpenPeptideMatrix = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveMotif = new System.Windows.Forms.SaveFileDialog();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.tabImages = new System.Windows.Forms.TabControl();
            this.tMotif = new System.Windows.Forms.TabPage();
            this.pMotif = new System.Windows.Forms.Panel();
            this.mdShifted = new PeSA.Windows.MotifDisplay();
            this.mdMain = new PeSA.Windows.MotifDisplay();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lQuestion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eKeyPosition = new System.Windows.Forms.TextBox();
            this.lAminoAcid = new System.Windows.Forms.Label();
            this.eAminoAcid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eFreqThreshold = new System.Windows.Forms.TextBox();
            this.tInfo = new System.Windows.Forms.TabPage();
            this.flowpanelReference = new System.Windows.Forms.FlowLayoutPanel();
            this.imageReference = new PeSA.Windows.Controls.ImageDisplay();
            this.lNotes = new System.Windows.Forms.Label();
            this.eNotes = new System.Windows.Forms.TextBox();
            this.tDecisionList = new System.Windows.Forms.TabPage();
            this.dgDecision = new System.Windows.Forms.DataGridView();
            this.colPeptide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDecision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.cmsLoadPeptide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftTop)).BeginInit();
            this.splitLeftTop.Panel1.SuspendLayout();
            this.splitLeftTop.Panel2.SuspendLayout();
            this.splitLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeptides)).BeginInit();
            this.cmsPeptide.SuspendLayout();
            this.pPeptidesTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).BeginInit();
            this.cmsQuantification.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNormalized)).BeginInit();
            this.pBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.tabImages.SuspendLayout();
            this.tMotif.SuspendLayout();
            this.pMotif.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tInfo.SuspendLayout();
            this.flowpanelReference.SuspendLayout();
            this.tDecisionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDecision)).BeginInit();
            this.SuspendLayout();
            // 
            // cmsLoadPeptide
            // 
            this.cmsLoadPeptide.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsLoadPeptide.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiLoadPeptideList,
            this.cmiLoadPeptideMatrix});
            this.cmsLoadPeptide.Name = "cmsLoadPeptide";
            this.cmsLoadPeptide.Size = new System.Drawing.Size(181, 48);
            // 
            // cmiLoadPeptideList
            // 
            this.cmiLoadPeptideList.Name = "cmiLoadPeptideList";
            this.cmiLoadPeptideList.Size = new System.Drawing.Size(180, 22);
            this.cmiLoadPeptideList.Text = "Load Peptide List";
            this.cmiLoadPeptideList.Click += new System.EventHandler(this.cmiLoadPeptideList_Click);
            // 
            // cmiLoadPeptideMatrix
            // 
            this.cmiLoadPeptideMatrix.Name = "cmiLoadPeptideMatrix";
            this.cmiLoadPeptideMatrix.Size = new System.Drawing.Size(180, 22);
            this.cmiLoadPeptideMatrix.Text = "Load Peptide Matrix";
            this.cmiLoadPeptideMatrix.Click += new System.EventHandler(this.cmiLoadPeptideMatrix_Click);
            // 
            // dlgOpenPeptideList
            // 
            this.dlgOpenPeptideList.FileName = "Peptides.txt";
            this.dlgOpenPeptideList.Filter = "Text files|*.txt";
            // 
            // dlgOpenQuantification
            // 
            this.dlgOpenQuantification.FileName = "GridMeasurementsTable.xls";
            this.dlgOpenQuantification.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|Comma Delimited|*.csv";
            // 
            // splitLeftTop
            // 
            this.splitLeftTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeftTop.Location = new System.Drawing.Point(0, 0);
            this.splitLeftTop.Margin = new System.Windows.Forms.Padding(2);
            this.splitLeftTop.Name = "splitLeftTop";
            this.splitLeftTop.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeftTop.Panel1
            // 
            this.splitLeftTop.Panel1.Controls.Add(this.dgPeptides);
            this.splitLeftTop.Panel1.Controls.Add(this.pPeptidesTop);
            this.splitLeftTop.Panel1MinSize = 32;
            // 
            // splitLeftTop.Panel2
            // 
            this.splitLeftTop.Panel2.Controls.Add(this.dgQuantification);
            this.splitLeftTop.Panel2.Controls.Add(this.panel2);
            this.splitLeftTop.Panel2MinSize = 32;
            this.splitLeftTop.Size = new System.Drawing.Size(580, 537);
            this.splitLeftTop.SplitterDistance = 182;
            this.splitLeftTop.SplitterWidth = 3;
            this.splitLeftTop.TabIndex = 4;
            // 
            // dgPeptides
            // 
            this.dgPeptides.AllowUserToAddRows = false;
            this.dgPeptides.AllowUserToDeleteRows = false;
            this.dgPeptides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeptides.ContextMenuStrip = this.cmsPeptide;
            this.dgPeptides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPeptides.Location = new System.Drawing.Point(0, 30);
            this.dgPeptides.Margin = new System.Windows.Forms.Padding(2);
            this.dgPeptides.Name = "dgPeptides";
            this.dgPeptides.ReadOnly = true;
            this.dgPeptides.RowTemplate.Height = 28;
            this.dgPeptides.Size = new System.Drawing.Size(580, 152);
            this.dgPeptides.TabIndex = 2;
            // 
            // cmsPeptide
            // 
            this.cmsPeptide.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsPeptide.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiPastePeptide,
            this.cmiFindPeptide,
            this.cmiFindNext});
            this.cmsPeptide.Name = "cmsClipBoard";
            this.cmsPeptide.Size = new System.Drawing.Size(203, 70);
            // 
            // cmiPastePeptide
            // 
            this.cmiPastePeptide.Name = "cmiPastePeptide";
            this.cmiPastePeptide.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.cmiPastePeptide.Size = new System.Drawing.Size(202, 22);
            this.cmiPastePeptide.Text = "Paste from Excel";
            this.cmiPastePeptide.Click += new System.EventHandler(this.cmiPastePeptide_Click);
            // 
            // cmiFindPeptide
            // 
            this.cmiFindPeptide.Name = "cmiFindPeptide";
            this.cmiFindPeptide.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.cmiFindPeptide.Size = new System.Drawing.Size(202, 22);
            this.cmiFindPeptide.Text = "Find Peptide";
            this.cmiFindPeptide.Click += new System.EventHandler(this.cmiFindPeptide_Click);
            // 
            // cmiFindNext
            // 
            this.cmiFindNext.Name = "cmiFindNext";
            this.cmiFindNext.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.cmiFindNext.Size = new System.Drawing.Size(202, 22);
            this.cmiFindNext.Text = "Find Next";
            this.cmiFindNext.Click += new System.EventHandler(this.cmiFindNext_Click);
            // 
            // pPeptidesTop
            // 
            this.pPeptidesTop.Controls.Add(this.linkRun);
            this.pPeptidesTop.Controls.Add(this.lLoadPeptides);
            this.pPeptidesTop.Controls.Add(this.lArrayInfo);
            this.pPeptidesTop.Controls.Add(this.lPeptides);
            this.pPeptidesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPeptidesTop.Location = new System.Drawing.Point(0, 0);
            this.pPeptidesTop.Name = "pPeptidesTop";
            this.pPeptidesTop.Size = new System.Drawing.Size(580, 30);
            this.pPeptidesTop.TabIndex = 1;
            // 
            // linkRun
            // 
            this.linkRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkRun.AutoSize = true;
            this.linkRun.Location = new System.Drawing.Point(448, 9);
            this.linkRun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkRun.Name = "linkRun";
            this.linkRun.Size = new System.Drawing.Size(27, 13);
            this.linkRun.TabIndex = 22;
            this.linkRun.TabStop = true;
            this.linkRun.Text = "Run";
            this.linkRun.Visible = false;
            this.linkRun.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRun_LinkClicked);
            // 
            // lLoadPeptides
            // 
            this.lLoadPeptides.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lLoadPeptides.AutoSize = true;
            this.lLoadPeptides.ContextMenuStrip = this.cmsLoadPeptide;
            this.lLoadPeptides.Location = new System.Drawing.Point(479, 9);
            this.lLoadPeptides.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLoadPeptides.Name = "lLoadPeptides";
            this.lLoadPeptides.Size = new System.Drawing.Size(73, 13);
            this.lLoadPeptides.TabIndex = 21;
            this.lLoadPeptides.TabStop = true;
            this.lLoadPeptides.Text = "Load from File";
            this.lLoadPeptides.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLoadPeptides_LinkClicked);
            // 
            // lArrayInfo
            // 
            this.lArrayInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lArrayInfo.Location = new System.Drawing.Point(303, 9);
            this.lArrayInfo.MinimumSize = new System.Drawing.Size(20, 0);
            this.lArrayInfo.Name = "lArrayInfo";
            this.lArrayInfo.Size = new System.Drawing.Size(130, 13);
            this.lArrayInfo.TabIndex = 3;
            this.lArrayInfo.Text = "20x30 matrix - Rows first";
            // 
            // lPeptides
            // 
            this.lPeptides.AutoSize = true;
            this.lPeptides.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPeptides.Location = new System.Drawing.Point(6, 6);
            this.lPeptides.Name = "lPeptides";
            this.lPeptides.Size = new System.Drawing.Size(63, 17);
            this.lPeptides.TabIndex = 2;
            this.lPeptides.Text = "Peptides";
            // 
            // dgQuantification
            // 
            this.dgQuantification.AllowUserToAddRows = false;
            this.dgQuantification.AllowUserToDeleteRows = false;
            this.dgQuantification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuantification.ContextMenuStrip = this.cmsQuantification;
            this.dgQuantification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgQuantification.Location = new System.Drawing.Point(0, 30);
            this.dgQuantification.Margin = new System.Windows.Forms.Padding(2);
            this.dgQuantification.Name = "dgQuantification";
            this.dgQuantification.ReadOnly = true;
            this.dgQuantification.RowTemplate.Height = 28;
            this.dgQuantification.Size = new System.Drawing.Size(580, 322);
            this.dgQuantification.TabIndex = 0;
            // 
            // cmsQuantification
            // 
            this.cmsQuantification.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsQuantification.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiPasteQuantification});
            this.cmsQuantification.Name = "cmsClipBoard";
            this.cmsQuantification.Size = new System.Drawing.Size(203, 26);
            // 
            // cmiPasteQuantification
            // 
            this.cmiPasteQuantification.Name = "cmiPasteQuantification";
            this.cmiPasteQuantification.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.cmiPasteQuantification.Size = new System.Drawing.Size(202, 22);
            this.cmiPasteQuantification.Text = "Paste from Excel";
            this.cmiPasteQuantification.Click += new System.EventHandler(this.cmiPasteQuantification_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLoadQuantification);
            this.panel2.Controls.Add(this.lQuantification);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(580, 30);
            this.panel2.TabIndex = 3;
            // 
            // linkLoadQuantification
            // 
            this.linkLoadQuantification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLoadQuantification.AutoSize = true;
            this.linkLoadQuantification.Location = new System.Drawing.Point(479, 8);
            this.linkLoadQuantification.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLoadQuantification.Name = "linkLoadQuantification";
            this.linkLoadQuantification.Size = new System.Drawing.Size(73, 13);
            this.linkLoadQuantification.TabIndex = 3;
            this.linkLoadQuantification.TabStop = true;
            this.linkLoadQuantification.Text = "Load from File";
            this.linkLoadQuantification.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLoadQuantification_LinkClicked);
            // 
            // lQuantification
            // 
            this.lQuantification.AutoSize = true;
            this.lQuantification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuantification.Location = new System.Drawing.Point(6, 6);
            this.lQuantification.Name = "lQuantification";
            this.lQuantification.Size = new System.Drawing.Size(258, 17);
            this.lQuantification.TabIndex = 2;
            this.lQuantification.Text = "Quantification (Background normalized)";
            // 
            // ePeptideLength
            // 
            this.ePeptideLength.Location = new System.Drawing.Point(122, 10);
            this.ePeptideLength.Name = "ePeptideLength";
            this.ePeptideLength.Size = new System.Drawing.Size(55, 20);
            this.ePeptideLength.TabIndex = 6;
            this.ePeptideLength.Leave += new System.EventHandler(this.ePeptideLength_Leave);
            // 
            // lPeptideLength
            // 
            this.lPeptideLength.AutoSize = true;
            this.lPeptideLength.Location = new System.Drawing.Point(12, 14);
            this.lPeptideLength.Name = "lPeptideLength";
            this.lPeptideLength.Size = new System.Drawing.Size(79, 13);
            this.lPeptideLength.TabIndex = 4;
            this.lPeptideLength.Text = "Peptide Length";
            // 
            // splitLeft
            // 
            this.splitLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitLeft.Location = new System.Drawing.Point(0, 0);
            this.splitLeft.Name = "splitLeft";
            this.splitLeft.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitLeft.Panel1
            // 
            this.splitLeft.Panel1.Controls.Add(this.splitLeftTop);
            this.splitLeft.Panel1MinSize = 64;
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.Controls.Add(this.dgNormalized);
            this.splitLeft.Panel2.Controls.Add(this.pBottom);
            this.splitLeft.Panel2.Controls.Add(this.panel1);
            this.splitLeft.Panel2MinSize = 115;
            this.splitLeft.Size = new System.Drawing.Size(580, 830);
            this.splitLeft.SplitterDistance = 537;
            this.splitLeft.TabIndex = 5;
            // 
            // dgNormalized
            // 
            this.dgNormalized.AllowUserToAddRows = false;
            this.dgNormalized.AllowUserToDeleteRows = false;
            this.dgNormalized.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Format = "N3";
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNormalized.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgNormalized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgNormalized.Location = new System.Drawing.Point(0, 74);
            this.dgNormalized.Name = "dgNormalized";
            this.dgNormalized.ReadOnly = true;
            this.dgNormalized.Size = new System.Drawing.Size(580, 179);
            this.dgNormalized.TabIndex = 3;
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnExport);
            this.pBottom.Controls.Add(this.btnLoad);
            this.pBottom.Controls.Add(this.btnSave);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 253);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(580, 36);
            this.pBottom.TabIndex = 4;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(231, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 23);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.thresholdEntry);
            this.panel1.Controls.Add(this.eNormalizeBy);
            this.panel1.Controls.Add(this.lNormalizeBy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 74);
            this.panel1.TabIndex = 2;
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
            this.thresholdEntry.TabIndex = 12;
            this.thresholdEntry.ThresholdChanged += new System.EventHandler(this.thresholdEntry_ThresholdChanged);
            // 
            // eNormalizeBy
            // 
            this.eNormalizeBy.Location = new System.Drawing.Point(81, 43);
            this.eNormalizeBy.Name = "eNormalizeBy";
            this.eNormalizeBy.Size = new System.Drawing.Size(78, 20);
            this.eNormalizeBy.TabIndex = 5;
            this.eNormalizeBy.Leave += new System.EventHandler(this.eNormalizeBy_Leave);
            // 
            // lNormalizeBy
            // 
            this.lNormalizeBy.AutoSize = true;
            this.lNormalizeBy.Location = new System.Drawing.Point(6, 47);
            this.lNormalizeBy.Name = "lNormalizeBy";
            this.lNormalizeBy.Size = new System.Drawing.Size(68, 13);
            this.lNormalizeBy.TabIndex = 4;
            this.lNormalizeBy.Text = "Normalize By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Normalized";
            // 
            // dlgOpenProject
            // 
            this.dlgOpenProject.FileName = "Open Project";
            this.dlgOpenProject.Filter = "PeSA Peptide Array Project File|*.ppep";
            // 
            // dlgSaveProject
            // 
            this.dlgSaveProject.Filter = "PeSA Peptide Array Project File|*.ppep";
            this.dlgSaveProject.OverwritePrompt = false;
            // 
            // dlgExcelExport
            // 
            this.dlgExcelExport.Filter = "Excel Files|*.xlsx;*.xlsm";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dlgOpenPeptideMatrix
            // 
            this.dlgOpenPeptideMatrix.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|Comma Delimited|*.csv";
            // 
            // dlgSaveMotif
            // 
            this.dlgSaveMotif.Filter = "PeSA Motif File|*.pmtf";
            this.dlgSaveMotif.Title = "Save Motif File";
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.splitLeft);
            this.splitMain.Panel1MinSize = 580;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.tabImages);
            this.splitMain.Panel2MinSize = 315;
            this.splitMain.Size = new System.Drawing.Size(1197, 830);
            this.splitMain.SplitterDistance = 580;
            this.splitMain.TabIndex = 6;
            // 
            // tabImages
            // 
            this.tabImages.Controls.Add(this.tMotif);
            this.tabImages.Controls.Add(this.tInfo);
            this.tabImages.Controls.Add(this.tDecisionList);
            this.tabImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabImages.Location = new System.Drawing.Point(0, 0);
            this.tabImages.Name = "tabImages";
            this.tabImages.SelectedIndex = 0;
            this.tabImages.Size = new System.Drawing.Size(613, 830);
            this.tabImages.TabIndex = 6;
            // 
            // tMotif
            // 
            this.tMotif.Controls.Add(this.pMotif);
            this.tMotif.Location = new System.Drawing.Point(4, 25);
            this.tMotif.Name = "tMotif";
            this.tMotif.Padding = new System.Windows.Forms.Padding(3);
            this.tMotif.Size = new System.Drawing.Size(605, 801);
            this.tMotif.TabIndex = 0;
            this.tMotif.Text = "Motif";
            this.tMotif.UseVisualStyleBackColor = true;
            // 
            // pMotif
            // 
            this.pMotif.AutoScroll = true;
            this.pMotif.Controls.Add(this.mdShifted);
            this.pMotif.Controls.Add(this.mdMain);
            this.pMotif.Controls.Add(this.panel3);
            this.pMotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMotif.Location = new System.Drawing.Point(3, 3);
            this.pMotif.Name = "pMotif";
            this.pMotif.Size = new System.Drawing.Size(599, 795);
            this.pMotif.TabIndex = 0;
            // 
            // mdShifted
            // 
            this.mdShifted.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdShifted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdShifted.Image = null;
            this.mdShifted.LabelText = "Shifted Motif";
            this.mdShifted.Location = new System.Drawing.Point(0, 304);
            this.mdShifted.Margin = new System.Windows.Forms.Padding(4);
            this.mdShifted.Name = "mdShifted";
            this.mdShifted.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.mdShifted.Size = new System.Drawing.Size(599, 189);
            this.mdShifted.TabIndex = 1;
            this.mdShifted.Visible = false;
            // 
            // mdMain
            // 
            this.mdMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdMain.Image = null;
            this.mdMain.LabelText = "Motif";
            this.mdMain.Location = new System.Drawing.Point(0, 115);
            this.mdMain.Margin = new System.Windows.Forms.Padding(4);
            this.mdMain.Name = "mdMain";
            this.mdMain.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.mdMain.Size = new System.Drawing.Size(599, 189);
            this.mdMain.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lQuestion);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ePeptideLength);
            this.panel3.Controls.Add(this.eKeyPosition);
            this.panel3.Controls.Add(this.lPeptideLength);
            this.panel3.Controls.Add(this.lAminoAcid);
            this.panel3.Controls.Add(this.eAminoAcid);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.eFreqThreshold);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 115);
            this.panel3.TabIndex = 2;
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(183, 60);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(13, 13);
            this.lQuestion.TabIndex = 43;
            this.lQuestion.Text = "?";
            this.lQuestion.Click += new System.EventHandler(this.lQuestion_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Key position";
            // 
            // eKeyPosition
            // 
            this.eKeyPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eKeyPosition.Location = new System.Drawing.Point(122, 34);
            this.eKeyPosition.Name = "eKeyPosition";
            this.eKeyPosition.Size = new System.Drawing.Size(55, 20);
            this.eKeyPosition.TabIndex = 37;
            this.eKeyPosition.Leave += new System.EventHandler(this.eKeyPosition_Leave);
            // 
            // lAminoAcid
            // 
            this.lAminoAcid.AutoSize = true;
            this.lAminoAcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAminoAcid.Location = new System.Drawing.Point(12, 62);
            this.lAminoAcid.Name = "lAminoAcid";
            this.lAminoAcid.Size = new System.Drawing.Size(94, 13);
            this.lAminoAcid.TabIndex = 41;
            this.lAminoAcid.Text = "Target Amino Acid";
            // 
            // eAminoAcid
            // 
            this.eAminoAcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eAminoAcid.Location = new System.Drawing.Point(122, 58);
            this.eAminoAcid.Name = "eAminoAcid";
            this.eAminoAcid.Size = new System.Drawing.Size(55, 20);
            this.eAminoAcid.TabIndex = 38;
            this.eAminoAcid.Leave += new System.EventHandler(this.eAminoAcid_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Frequency Threshold";
            // 
            // eFreqThreshold
            // 
            this.eFreqThreshold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eFreqThreshold.Location = new System.Drawing.Point(122, 82);
            this.eFreqThreshold.Name = "eFreqThreshold";
            this.eFreqThreshold.Size = new System.Drawing.Size(55, 20);
            this.eFreqThreshold.TabIndex = 39;
            this.eFreqThreshold.Text = "0.1";
            this.eFreqThreshold.Leave += new System.EventHandler(this.eFreqThreshold_Leave);
            // 
            // tInfo
            // 
            this.tInfo.Controls.Add(this.flowpanelReference);
            this.tInfo.Location = new System.Drawing.Point(4, 25);
            this.tInfo.Name = "tInfo";
            this.tInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tInfo.Size = new System.Drawing.Size(492, 801);
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
            this.flowpanelReference.Size = new System.Drawing.Size(486, 795);
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
            this.imageReference.Size = new System.Drawing.Size(400, 200);
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
            this.eNotes.BackColor = System.Drawing.Color.White;
            this.eNotes.Location = new System.Drawing.Point(3, 234);
            this.eNotes.Multiline = true;
            this.eNotes.Name = "eNotes";
            this.eNotes.Size = new System.Drawing.Size(478, 578);
            this.eNotes.TabIndex = 2;
            // 
            // tDecisionList
            // 
            this.tDecisionList.Controls.Add(this.dgDecision);
            this.tDecisionList.Location = new System.Drawing.Point(4, 25);
            this.tDecisionList.Name = "tDecisionList";
            this.tDecisionList.Padding = new System.Windows.Forms.Padding(3);
            this.tDecisionList.Size = new System.Drawing.Size(492, 801);
            this.tDecisionList.TabIndex = 2;
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
            this.dgDecision.Size = new System.Drawing.Size(486, 795);
            this.dgDecision.TabIndex = 1;
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
            // dlgOpenImage
            // 
            this.dlgOpenImage.FileName = "Open Image";
            this.dlgOpenImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png\"";
            // 
            // frmAnalyzePeptideArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 830);
            this.Controls.Add(this.splitMain);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(506, 291);
            this.Name = "frmAnalyzePeptideArray";
            this.Text = "Peptide Array Analysis";
            this.Load += new System.EventHandler(this.frmPeptideArray_Load);
            this.cmsLoadPeptide.ResumeLayout(false);
            this.splitLeftTop.Panel1.ResumeLayout(false);
            this.splitLeftTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeftTop)).EndInit();
            this.splitLeftTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeptides)).EndInit();
            this.cmsPeptide.ResumeLayout(false);
            this.pPeptidesTop.ResumeLayout(false);
            this.pPeptidesTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).EndInit();
            this.cmsQuantification.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNormalized)).EndInit();
            this.pBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.tabImages.ResumeLayout(false);
            this.tMotif.ResumeLayout(false);
            this.pMotif.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tInfo.ResumeLayout(false);
            this.flowpanelReference.ResumeLayout(false);
            this.flowpanelReference.PerformLayout();
            this.tDecisionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDecision)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog dlgOpenPeptideList;
        private System.Windows.Forms.OpenFileDialog dlgOpenQuantification;
        private System.Windows.Forms.SplitContainer splitLeftTop;
        private System.Windows.Forms.DataGridView dgQuantification;
        private System.Windows.Forms.Panel pPeptidesTop;
        private System.Windows.Forms.Label lPeptides;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lQuantification;
        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.DataGridView dgNormalized;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox eNormalizeBy;
        private System.Windows.Forms.Label lNormalizeBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog dlgOpenProject;
        private System.Windows.Forms.SaveFileDialog dlgSaveProject;
        private System.Windows.Forms.SaveFileDialog dlgExcelExport;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgPeptides;
        private System.Windows.Forms.Label lArrayInfo;
        private System.Windows.Forms.Label lPeptideLength;
        private System.Windows.Forms.TextBox ePeptideLength;
        private System.Windows.Forms.ContextMenuStrip cmsPeptide;
        private System.Windows.Forms.ToolStripMenuItem cmiPastePeptide;
        private System.Windows.Forms.ToolStripMenuItem cmiFindPeptide;
        private System.Windows.Forms.ContextMenuStrip cmsQuantification;
        private System.Windows.Forms.ToolStripMenuItem cmiPasteQuantification;
        private System.Windows.Forms.ContextMenuStrip cmsLoadPeptide;
        private System.Windows.Forms.ToolStripMenuItem cmiLoadPeptideList;
        private System.Windows.Forms.ToolStripMenuItem cmiLoadPeptideMatrix;
        private System.Windows.Forms.OpenFileDialog dlgOpenPeptideMatrix;
        private System.Windows.Forms.ToolStripMenuItem cmiFindNext;
        private System.Windows.Forms.SaveFileDialog dlgSaveMotif;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TabControl tabImages;
        private System.Windows.Forms.TabPage tMotif;
        private System.Windows.Forms.TabPage tInfo;
        private System.Windows.Forms.OpenFileDialog dlgOpenImage;
        private System.Windows.Forms.FlowLayoutPanel flowpanelReference;
        private System.Windows.Forms.Label lNotes;
        private System.Windows.Forms.TextBox eNotes;
        private System.Windows.Forms.Panel pMotif;
        private MotifDisplay mdShifted;
        private MotifDisplay mdMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eKeyPosition;
        private System.Windows.Forms.Label lAminoAcid;
        private System.Windows.Forms.TextBox eAminoAcid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eFreqThreshold;
        private System.Windows.Forms.LinkLabel lLoadPeptides;
        private System.Windows.Forms.LinkLabel linkLoadQuantification;
        private Controls.ImageDisplay imageReference;
        private System.Windows.Forms.TabPage tDecisionList;
        private System.Windows.Forms.DataGridView dgDecision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeptide;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDecision;
        private Controls.ThresholdEntry thresholdEntry;
        private System.Windows.Forms.LinkLabel linkRun;
    }
}