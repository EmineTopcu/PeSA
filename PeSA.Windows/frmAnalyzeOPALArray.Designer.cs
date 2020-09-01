namespace PeSA.Windows
{
    partial class frmAnalyzeOPALArray
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyzeOPALArray));
            this.dlgOpenQuantification = new System.Windows.Forms.OpenFileDialog();
            this.dgQuantification = new System.Windows.Forms.DataGridView();
            this.cmsClipBoard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.pQuantificationTop = new System.Windows.Forms.Panel();
            this.linkRun = new System.Windows.Forms.LinkLabel();
            this.linkLoadFromFile = new System.Windows.Forms.LinkLabel();
            this.cbYAxisTopToBottom = new System.Windows.Forms.CheckBox();
            this.cbPermutationXAxis = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pBottom = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dlgOpenProject = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveProject = new System.Windows.Forms.SaveFileDialog();
            this.dlgExcelExport = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitLeft = new System.Windows.Forms.SplitContainer();
            this.dgNormalized = new System.Windows.Forms.DataGridView();
            this.pNormalizedTop = new System.Windows.Forms.Panel();
            this.rbPerRowColumn = new System.Windows.Forms.RadioButton();
            this.rbMaxValue = new System.Windows.Forms.RadioButton();
            this.thresholdEntry = new PeSA.Windows.Controls.ThresholdEntry();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgSaveMotif = new System.Windows.Forms.SaveFileDialog();
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
            this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.btnSaveMotif = new System.Windows.Forms.Button();
            this.btnRunScorer = new System.Windows.Forms.Button();
            this.cmsRunScorer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPeptideScorer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiProteinScorer = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).BeginInit();
            this.cmsClipBoard.SuspendLayout();
            this.pQuantificationTop.SuspendLayout();
            this.pBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).BeginInit();
            this.splitLeft.Panel1.SuspendLayout();
            this.splitLeft.Panel2.SuspendLayout();
            this.splitLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNormalized)).BeginInit();
            this.pNormalizedTop.SuspendLayout();
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
            this.cmsRunScorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // dlgOpenQuantification
            // 
            this.dlgOpenQuantification.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|Comma Delimited|*.csv";
            this.dlgOpenQuantification.Title = "Open Quantification Matrix";
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
            this.dgQuantification.Size = new System.Drawing.Size(618, 302);
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
            // pQuantificationTop
            // 
            this.pQuantificationTop.Controls.Add(this.linkRun);
            this.pQuantificationTop.Controls.Add(this.linkLoadFromFile);
            this.pQuantificationTop.Controls.Add(this.cbYAxisTopToBottom);
            this.pQuantificationTop.Controls.Add(this.cbPermutationXAxis);
            this.pQuantificationTop.Controls.Add(this.label3);
            this.pQuantificationTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pQuantificationTop.Location = new System.Drawing.Point(0, 0);
            this.pQuantificationTop.Name = "pQuantificationTop";
            this.pQuantificationTop.Size = new System.Drawing.Size(618, 30);
            this.pQuantificationTop.TabIndex = 1;
            // 
            // linkRun
            // 
            this.linkRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkRun.AutoSize = true;
            this.linkRun.Location = new System.Drawing.Point(489, 10);
            this.linkRun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkRun.Name = "linkRun";
            this.linkRun.Size = new System.Drawing.Size(27, 13);
            this.linkRun.TabIndex = 9;
            this.linkRun.TabStop = true;
            this.linkRun.Text = "Run";
            this.linkRun.Visible = false;
            this.linkRun.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRun_LinkClicked);
            // 
            // linkLoadFromFile
            // 
            this.linkLoadFromFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLoadFromFile.AutoSize = true;
            this.linkLoadFromFile.Location = new System.Drawing.Point(530, 10);
            this.linkLoadFromFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLoadFromFile.Name = "linkLoadFromFile";
            this.linkLoadFromFile.Size = new System.Drawing.Size(73, 13);
            this.linkLoadFromFile.TabIndex = 5;
            this.linkLoadFromFile.TabStop = true;
            this.linkLoadFromFile.Text = "Load from File";
            this.linkLoadFromFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLoadFromFile_LinkClicked);
            // 
            // cbYAxisTopToBottom
            // 
            this.cbYAxisTopToBottom.AutoSize = true;
            this.cbYAxisTopToBottom.Location = new System.Drawing.Point(253, 6);
            this.cbYAxisTopToBottom.Margin = new System.Windows.Forms.Padding(2);
            this.cbYAxisTopToBottom.Name = "cbYAxisTopToBottom";
            this.cbYAxisTopToBottom.Size = new System.Drawing.Size(128, 17);
            this.cbYAxisTopToBottom.TabIndex = 3;
            this.cbYAxisTopToBottom.Text = "Y Axis: Top to Bottom";
            this.cbYAxisTopToBottom.UseVisualStyleBackColor = true;
            this.cbYAxisTopToBottom.CheckedChanged += new System.EventHandler(this.cbYAxisTopToBottom_CheckedChanged);
            // 
            // cbPermutationXAxis
            // 
            this.cbPermutationXAxis.AutoSize = true;
            this.cbPermutationXAxis.Location = new System.Drawing.Point(131, 6);
            this.cbPermutationXAxis.Margin = new System.Windows.Forms.Padding(2);
            this.cbPermutationXAxis.Name = "cbPermutationXAxis";
            this.cbPermutationXAxis.Size = new System.Drawing.Size(117, 17);
            this.cbPermutationXAxis.TabIndex = 2;
            this.cbPermutationXAxis.Text = "X Axis: Permutation";
            this.cbPermutationXAxis.UseVisualStyleBackColor = true;
            this.cbPermutationXAxis.CheckedChanged += new System.EventHandler(this.cbPermutationXAxis_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantification";
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnSaveMotif);
            this.pBottom.Controls.Add(this.btnRunScorer);
            this.pBottom.Controls.Add(this.btnExport);
            this.pBottom.Controls.Add(this.btnLoad);
            this.pBottom.Controls.Add(this.btnSave);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 722);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(1210, 36);
            this.pBottom.TabIndex = 4;
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
            this.dlgOpenProject.Filter = "PeSA OPAL Array Project File|*.popa";
            this.dlgOpenProject.Title = "Open Project";
            // 
            // dlgSaveProject
            // 
            this.dlgSaveProject.Filter = "PeSA OPAL Array Project File|*.popa";
            this.dlgSaveProject.Title = "Save Project";
            // 
            // dlgExcelExport
            // 
            this.dlgExcelExport.Filter = "Excel Files|*.xlsx;*.xlsm";
            this.dlgExcelExport.Title = "Export to Excel";
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
            this.splitLeft.Panel1.Controls.Add(this.dgQuantification);
            this.splitLeft.Panel1.Controls.Add(this.pQuantificationTop);
            this.splitLeft.Panel1MinSize = 35;
            // 
            // splitLeft.Panel2
            // 
            this.splitLeft.Panel2.Controls.Add(this.dgNormalized);
            this.splitLeft.Panel2.Controls.Add(this.pNormalizedTop);
            this.splitLeft.Panel2MinSize = 115;
            this.splitLeft.Size = new System.Drawing.Size(618, 722);
            this.splitLeft.SplitterDistance = 332;
            this.splitLeft.TabIndex = 5;
            // 
            // dgNormalized
            // 
            this.dgNormalized.AllowUserToAddRows = false;
            this.dgNormalized.AllowUserToDeleteRows = false;
            this.dgNormalized.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNormalized.ColumnHeadersVisible = false;
            this.dgNormalized.ContextMenuStrip = this.cmsClipBoard;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNormalized.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgNormalized.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgNormalized.Location = new System.Drawing.Point(0, 74);
            this.dgNormalized.Margin = new System.Windows.Forms.Padding(2);
            this.dgNormalized.Name = "dgNormalized";
            this.dgNormalized.ReadOnly = true;
            this.dgNormalized.RowHeadersVisible = false;
            this.dgNormalized.RowTemplate.Height = 28;
            this.dgNormalized.Size = new System.Drawing.Size(618, 312);
            this.dgNormalized.TabIndex = 1;
            // 
            // pNormalizedTop
            // 
            this.pNormalizedTop.Controls.Add(this.rbPerRowColumn);
            this.pNormalizedTop.Controls.Add(this.rbMaxValue);
            this.pNormalizedTop.Controls.Add(this.thresholdEntry);
            this.pNormalizedTop.Controls.Add(this.label2);
            this.pNormalizedTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNormalizedTop.Location = new System.Drawing.Point(0, 0);
            this.pNormalizedTop.Name = "pNormalizedTop";
            this.pNormalizedTop.Size = new System.Drawing.Size(618, 74);
            this.pNormalizedTop.TabIndex = 0;
            // 
            // rbPerRowColumn
            // 
            this.rbPerRowColumn.AutoSize = true;
            this.rbPerRowColumn.Location = new System.Drawing.Point(92, 47);
            this.rbPerRowColumn.Margin = new System.Windows.Forms.Padding(2);
            this.rbPerRowColumn.Name = "rbPerRowColumn";
            this.rbPerRowColumn.Size = new System.Drawing.Size(106, 17);
            this.rbPerRowColumn.TabIndex = 48;
            this.rbPerRowColumn.Text = "Per Row/Column";
            this.rbPerRowColumn.UseVisualStyleBackColor = true;
            this.rbPerRowColumn.CheckedChanged += new System.EventHandler(this.rbPerRowColumn_CheckedChanged);
            // 
            // rbMaxValue
            // 
            this.rbMaxValue.AutoSize = true;
            this.rbMaxValue.Checked = true;
            this.rbMaxValue.Location = new System.Drawing.Point(7, 47);
            this.rbMaxValue.Margin = new System.Windows.Forms.Padding(2);
            this.rbMaxValue.Name = "rbMaxValue";
            this.rbMaxValue.Size = new System.Drawing.Size(75, 17);
            this.rbMaxValue.TabIndex = 47;
            this.rbMaxValue.TabStop = true;
            this.rbMaxValue.Text = "Max Value";
            this.rbMaxValue.UseVisualStyleBackColor = true;
            this.rbMaxValue.CheckedChanged += new System.EventHandler(this.rbMaxValue_CheckedChanged);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Normalized";
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
            this.splitMain.Margin = new System.Windows.Forms.Padding(2);
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
            this.splitMain.Panel2MinSize = 325;
            this.splitMain.Size = new System.Drawing.Size(1210, 722);
            this.splitMain.SplitterDistance = 618;
            this.splitMain.SplitterWidth = 3;
            this.splitMain.TabIndex = 6;
            // 
            // tabImages
            // 
            this.tabImages.Controls.Add(this.tMotif);
            this.tabImages.Controls.Add(this.tInfo);
            this.tabImages.Controls.Add(this.tVisualMatrix);
            this.tabImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabImages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabImages.Location = new System.Drawing.Point(0, 0);
            this.tabImages.Name = "tabImages";
            this.tabImages.SelectedIndex = 0;
            this.tabImages.Size = new System.Drawing.Size(589, 722);
            this.tabImages.TabIndex = 8;
            // 
            // tMotif
            // 
            this.tMotif.Controls.Add(this.pMotif);
            this.tMotif.Location = new System.Drawing.Point(4, 25);
            this.tMotif.Name = "tMotif";
            this.tMotif.Padding = new System.Windows.Forms.Padding(3);
            this.tMotif.Size = new System.Drawing.Size(581, 693);
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
            this.pMotif.Size = new System.Drawing.Size(575, 687);
            this.pMotif.TabIndex = 0;
            // 
            // mdChart
            // 
            this.mdChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdChart.Image = null;
            this.mdChart.LabelText = "Chart";
            this.mdChart.Location = new System.Drawing.Point(0, 358);
            this.mdChart.Margin = new System.Windows.Forms.Padding(4);
            this.mdChart.Name = "mdChart";
            this.mdChart.Size = new System.Drawing.Size(575, 179);
            this.mdChart.TabIndex = 5;
            // 
            // mdNegative
            // 
            this.mdNegative.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdNegative.Image = null;
            this.mdNegative.LabelText = "Negative Motif";
            this.mdNegative.Location = new System.Drawing.Point(0, 179);
            this.mdNegative.Margin = new System.Windows.Forms.Padding(4);
            this.mdNegative.Name = "mdNegative";
            this.mdNegative.Size = new System.Drawing.Size(575, 179);
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
            this.mdPositive.Size = new System.Drawing.Size(575, 179);
            this.mdPositive.TabIndex = 3;
            // 
            // tInfo
            // 
            this.tInfo.Controls.Add(this.flowpanelReference);
            this.tInfo.Location = new System.Drawing.Point(4, 25);
            this.tInfo.Name = "tInfo";
            this.tInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tInfo.Size = new System.Drawing.Size(581, 693);
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
            this.flowpanelReference.Size = new System.Drawing.Size(575, 687);
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
            this.imageReference.Size = new System.Drawing.Size(348, 212);
            this.imageReference.TabIndex = 3;
            // 
            // lNotes
            // 
            this.lNotes.AutoSize = true;
            this.lNotes.Location = new System.Drawing.Point(3, 220);
            this.lNotes.Name = "lNotes";
            this.lNotes.Padding = new System.Windows.Forms.Padding(3);
            this.lNotes.Size = new System.Drawing.Size(51, 23);
            this.lNotes.TabIndex = 1;
            this.lNotes.Text = "Notes";
            // 
            // eNotes
            // 
            this.eNotes.Location = new System.Drawing.Point(3, 246);
            this.eNotes.Multiline = true;
            this.eNotes.Name = "eNotes";
            this.eNotes.Size = new System.Drawing.Size(360, 465);
            this.eNotes.TabIndex = 2;
            // 
            // tVisualMatrix
            // 
            this.tVisualMatrix.Controls.Add(this.mdMatrix);
            this.tVisualMatrix.Location = new System.Drawing.Point(4, 25);
            this.tVisualMatrix.Name = "tVisualMatrix";
            this.tVisualMatrix.Padding = new System.Windows.Forms.Padding(3);
            this.tVisualMatrix.Size = new System.Drawing.Size(581, 693);
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
            this.mdMatrix.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.mdMatrix.Name = "mdMatrix";
            this.mdMatrix.Size = new System.Drawing.Size(575, 687);
            this.mdMatrix.TabIndex = 1;
            // 
            // dlgOpenImage
            // 
            this.dlgOpenImage.FileName = "Open Image";
            this.dlgOpenImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png\"";
            // 
            // btnSaveMotif
            // 
            this.btnSaveMotif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMotif.Location = new System.Drawing.Point(1093, 6);
            this.btnSaveMotif.Name = "btnSaveMotif";
            this.btnSaveMotif.Size = new System.Drawing.Size(105, 23);
            this.btnSaveMotif.TabIndex = 10;
            this.btnSaveMotif.Text = "Save Motif";
            this.btnSaveMotif.UseVisualStyleBackColor = true;
            this.btnSaveMotif.Click += new System.EventHandler(this.btnSaveMotif_Click);
            // 
            // btnRunScorer
            // 
            this.btnRunScorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunScorer.Location = new System.Drawing.Point(982, 6);
            this.btnRunScorer.Name = "btnRunScorer";
            this.btnRunScorer.Size = new System.Drawing.Size(105, 23);
            this.btnRunScorer.TabIndex = 11;
            this.btnRunScorer.Text = "Run Scorer";
            this.btnRunScorer.UseVisualStyleBackColor = true;
            this.btnRunScorer.Click += new System.EventHandler(this.btnRunScorer_Click);
            // 
            // cmsRunScorer
            // 
            this.cmsRunScorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiPeptideScorer,
            this.cmiProteinScorer});
            this.cmsRunScorer.Name = "cmsRunScorer";
            this.cmsRunScorer.Size = new System.Drawing.Size(181, 70);
            // 
            // cmiPeptideScorer
            // 
            this.cmiPeptideScorer.Name = "cmiPeptideScorer";
            this.cmiPeptideScorer.Size = new System.Drawing.Size(180, 22);
            this.cmiPeptideScorer.Text = "Peptide Scorer";
            this.cmiPeptideScorer.Click += new System.EventHandler(this.cmiPeptideScorer_Click);
            // 
            // cmiProteinScorer
            // 
            this.cmiProteinScorer.Name = "cmiProteinScorer";
            this.cmiProteinScorer.Size = new System.Drawing.Size(180, 22);
            this.cmiProteinScorer.Text = "Protein Scorer";
            this.cmiProteinScorer.Click += new System.EventHandler(this.cmiProteinScorer_Click);
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "PeSA Motif File|*.pmtf";
            this.saveFileDialog2.Title = "Save Motif File";
            // 
            // frmAnalyzeOPALArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 758);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pBottom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAnalyzeOPALArray";
            this.Text = "OPAL Array Analysis";
            this.Load += new System.EventHandler(this.frmOPALArray_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).EndInit();
            this.cmsClipBoard.ResumeLayout(false);
            this.pQuantificationTop.ResumeLayout(false);
            this.pQuantificationTop.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.splitLeft.Panel1.ResumeLayout(false);
            this.splitLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitLeft)).EndInit();
            this.splitLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNormalized)).EndInit();
            this.pNormalizedTop.ResumeLayout(false);
            this.pNormalizedTop.PerformLayout();
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
            this.cmsRunScorer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog dlgOpenQuantification;
        private System.Windows.Forms.DataGridView dgQuantification;
        private System.Windows.Forms.Panel pQuantificationTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog dlgOpenProject;
        private System.Windows.Forms.SaveFileDialog dlgSaveProject;
        private System.Windows.Forms.SaveFileDialog dlgExcelExport;
        private System.Windows.Forms.ContextMenuStrip cmsClipBoard;
        private System.Windows.Forms.ToolStripMenuItem cmiPaste;
        private System.Windows.Forms.CheckBox cbPermutationXAxis;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitLeft;
        private System.Windows.Forms.DataGridView dgNormalized;
        private System.Windows.Forms.Panel pNormalizedTop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbYAxisTopToBottom;
        private System.Windows.Forms.SaveFileDialog dlgSaveMotif;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.TabControl tabImages;
        private System.Windows.Forms.TabPage tMotif;
        private System.Windows.Forms.Panel pMotif;
        private MotifDisplay mdChart;
        private MotifDisplay mdNegative;
        private MotifDisplay mdPositive;
        private System.Windows.Forms.TabPage tInfo;
        private System.Windows.Forms.FlowLayoutPanel flowpanelReference;
        private System.Windows.Forms.Label lNotes;
        private System.Windows.Forms.TextBox eNotes;
        private System.Windows.Forms.LinkLabel linkLoadFromFile;
        private System.Windows.Forms.OpenFileDialog dlgOpenImage;
        private Controls.ImageDisplay imageReference;
        private System.Windows.Forms.TabPage tVisualMatrix;
        private Controls.ColorMatrixDisplay mdMatrix;
        private Controls.ThresholdEntry thresholdEntry;
        private System.Windows.Forms.LinkLabel linkRun;
        private System.Windows.Forms.RadioButton rbPerRowColumn;
        private System.Windows.Forms.RadioButton rbMaxValue;
        private System.Windows.Forms.Button btnSaveMotif;
        private System.Windows.Forms.Button btnRunScorer;
        private System.Windows.Forms.ContextMenuStrip cmsRunScorer;
        private System.Windows.Forms.ToolStripMenuItem cmiPeptideScorer;
        private System.Windows.Forms.ToolStripMenuItem cmiProteinScorer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}