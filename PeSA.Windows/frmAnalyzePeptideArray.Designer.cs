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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLoadPeptideList = new System.Windows.Forms.Button();
            this.cmsLoadPeptide = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiLoadPeptideList = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiLoadPeptideMatrix = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadQuantification = new System.Windows.Forms.Button();
            this.dlgOpenPeptideList = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenQuantification = new System.Windows.Forms.OpenFileDialog();
            this.trackThreshold = new System.Windows.Forms.TrackBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgPeptides = new System.Windows.Forms.DataGridView();
            this.cmsPeptide = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPastePeptide = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiFindPeptide = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiFindNext = new System.Windows.Forms.ToolStripMenuItem();
            this.pPeptidesTop = new System.Windows.Forms.Panel();
            this.ePeptideLength = new System.Windows.Forms.TextBox();
            this.lPeptideLength = new System.Windows.Forms.Label();
            this.lArrayInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgQuantification = new System.Windows.Forms.DataGridView();
            this.cmsQuantification = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPasteQuantification = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lQuantification = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dgNormalized = new System.Windows.Forms.DataGridView();
            this.pBottom = new System.Windows.Forms.Panel();
            this.btnMotifGenerator = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.eThreshold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eNormalizeBy = new System.Windows.Forms.TextBox();
            this.lNormalizeBy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dlgOpenProject = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveProject = new System.Windows.Forms.SaveFileDialog();
            this.dlgExcelExport = new System.Windows.Forms.SaveFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dlgOpenPeptideMatrix = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveMotif = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveMotif = new System.Windows.Forms.Button();
            this.cmsLoadPeptide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeptides)).BeginInit();
            this.cmsPeptide.SuspendLayout();
            this.pPeptidesTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).BeginInit();
            this.cmsQuantification.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNormalized)).BeginInit();
            this.pBottom.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoadPeptideList
            // 
            this.btnLoadPeptideList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadPeptideList.AutoSize = true;
            this.btnLoadPeptideList.ContextMenuStrip = this.cmsLoadPeptide;
            this.btnLoadPeptideList.Location = new System.Drawing.Point(459, 4);
            this.btnLoadPeptideList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadPeptideList.Name = "btnLoadPeptideList";
            this.btnLoadPeptideList.Size = new System.Drawing.Size(120, 23);
            this.btnLoadPeptideList.TabIndex = 1;
            this.btnLoadPeptideList.Text = "Load from File";
            this.btnLoadPeptideList.UseVisualStyleBackColor = true;
            this.btnLoadPeptideList.Click += new System.EventHandler(this.btnLoadPeptideList_Click);
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
            // btnLoadQuantification
            // 
            this.btnLoadQuantification.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadQuantification.AutoSize = true;
            this.btnLoadQuantification.Location = new System.Drawing.Point(459, 4);
            this.btnLoadQuantification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadQuantification.Name = "btnLoadQuantification";
            this.btnLoadQuantification.Size = new System.Drawing.Size(120, 23);
            this.btnLoadQuantification.TabIndex = 2;
            this.btnLoadQuantification.Text = "Load from File";
            this.btnLoadQuantification.UseVisualStyleBackColor = true;
            this.btnLoadQuantification.Click += new System.EventHandler(this.btnLoadQuantification_Click);
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
            // trackThreshold
            // 
            this.trackThreshold.LargeChange = 1;
            this.trackThreshold.Location = new System.Drawing.Point(260, 18);
            this.trackThreshold.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackThreshold.Maximum = 100;
            this.trackThreshold.Name = "trackThreshold";
            this.trackThreshold.Size = new System.Drawing.Size(216, 45);
            this.trackThreshold.TabIndex = 3;
            this.trackThreshold.TickFrequency = 10;
            this.trackThreshold.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackThreshold.Value = 50;
            this.trackThreshold.ValueChanged += new System.EventHandler(this.trackThreshold_ValueChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgPeptides);
            this.splitContainer1.Panel1.Controls.Add(this.pPeptidesTop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgQuantification);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(584, 367);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
            // 
            // dgPeptides
            // 
            this.dgPeptides.AllowUserToAddRows = false;
            this.dgPeptides.AllowUserToDeleteRows = false;
            this.dgPeptides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeptides.ContextMenuStrip = this.cmsPeptide;
            this.dgPeptides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPeptides.Location = new System.Drawing.Point(0, 30);
            this.dgPeptides.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgPeptides.Name = "dgPeptides";
            this.dgPeptides.ReadOnly = true;
            this.dgPeptides.RowTemplate.Height = 28;
            this.dgPeptides.Size = new System.Drawing.Size(584, 150);
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
            this.cmiFindPeptide.Click += new System.EventHandler(this.cmiSearchPeptide_Click);
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
            this.pPeptidesTop.Controls.Add(this.ePeptideLength);
            this.pPeptidesTop.Controls.Add(this.lPeptideLength);
            this.pPeptidesTop.Controls.Add(this.lArrayInfo);
            this.pPeptidesTop.Controls.Add(this.label1);
            this.pPeptidesTop.Controls.Add(this.btnLoadPeptideList);
            this.pPeptidesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPeptidesTop.Location = new System.Drawing.Point(0, 0);
            this.pPeptidesTop.Name = "pPeptidesTop";
            this.pPeptidesTop.Size = new System.Drawing.Size(584, 30);
            this.pPeptidesTop.TabIndex = 1;
            // 
            // ePeptideLength
            // 
            this.ePeptideLength.Location = new System.Drawing.Point(177, 5);
            this.ePeptideLength.Name = "ePeptideLength";
            this.ePeptideLength.Size = new System.Drawing.Size(78, 20);
            this.ePeptideLength.TabIndex = 6;
            this.ePeptideLength.Leave += new System.EventHandler(this.ePeptideLength_Leave);
            // 
            // lPeptideLength
            // 
            this.lPeptideLength.AutoSize = true;
            this.lPeptideLength.Location = new System.Drawing.Point(98, 8);
            this.lPeptideLength.Name = "lPeptideLength";
            this.lPeptideLength.Size = new System.Drawing.Size(79, 13);
            this.lPeptideLength.TabIndex = 4;
            this.lPeptideLength.Text = "Peptide Length";
            // 
            // lArrayInfo
            // 
            this.lArrayInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lArrayInfo.Location = new System.Drawing.Point(271, 9);
            this.lArrayInfo.MinimumSize = new System.Drawing.Size(20, 0);
            this.lArrayInfo.Name = "lArrayInfo";
            this.lArrayInfo.Size = new System.Drawing.Size(130, 13);
            this.lArrayInfo.TabIndex = 3;
            this.lArrayInfo.Text = "20x30 matrix - Rows first";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Peptides";
            // 
            // dgQuantification
            // 
            this.dgQuantification.AllowUserToAddRows = false;
            this.dgQuantification.AllowUserToDeleteRows = false;
            this.dgQuantification.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgQuantification.ContextMenuStrip = this.cmsQuantification;
            this.dgQuantification.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgQuantification.Location = new System.Drawing.Point(0, 30);
            this.dgQuantification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgQuantification.Name = "dgQuantification";
            this.dgQuantification.ReadOnly = true;
            this.dgQuantification.RowTemplate.Height = 28;
            this.dgQuantification.Size = new System.Drawing.Size(584, 154);
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
            this.panel2.Controls.Add(this.lQuantification);
            this.panel2.Controls.Add(this.btnLoadQuantification);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 30);
            this.panel2.TabIndex = 3;
            // 
            // lQuantification
            // 
            this.lQuantification.AutoSize = true;
            this.lQuantification.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lQuantification.Location = new System.Drawing.Point(15, 8);
            this.lQuantification.Name = "lQuantification";
            this.lQuantification.Size = new System.Drawing.Size(230, 13);
            this.lQuantification.TabIndex = 2;
            this.lQuantification.Text = "Quantification (Background normalized)";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.splitContainer1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgNormalized);
            this.splitContainer2.Panel2.Controls.Add(this.pBottom);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(584, 549);
            this.splitContainer2.SplitterDistance = 367;
            this.splitContainer2.TabIndex = 5;
            // 
            // dgNormalized
            // 
            this.dgNormalized.AllowUserToAddRows = false;
            this.dgNormalized.AllowUserToDeleteRows = false;
            this.dgNormalized.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.dgNormalized.Location = new System.Drawing.Point(0, 53);
            this.dgNormalized.Name = "dgNormalized";
            this.dgNormalized.ReadOnly = true;
            this.dgNormalized.Size = new System.Drawing.Size(584, 89);
            this.dgNormalized.TabIndex = 3;
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnSaveMotif);
            this.pBottom.Controls.Add(this.btnMotifGenerator);
            this.pBottom.Controls.Add(this.btnExport);
            this.pBottom.Controls.Add(this.btnLoad);
            this.pBottom.Controls.Add(this.btnSave);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 142);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(584, 36);
            this.pBottom.TabIndex = 4;
            // 
            // btnMotifGenerator
            // 
            this.btnMotifGenerator.Location = new System.Drawing.Point(346, 6);
            this.btnMotifGenerator.Name = "btnMotifGenerator";
            this.btnMotifGenerator.Size = new System.Drawing.Size(117, 23);
            this.btnMotifGenerator.TabIndex = 3;
            this.btnMotifGenerator.Text = "Run Motif Generator";
            this.btnMotifGenerator.UseVisualStyleBackColor = true;
            this.btnMotifGenerator.Click += new System.EventHandler(this.btnMotifGenerator_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.eThreshold);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.eNormalizeBy);
            this.panel1.Controls.Add(this.lNormalizeBy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.trackThreshold);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 53);
            this.panel1.TabIndex = 2;
            // 
            // eThreshold
            // 
            this.eThreshold.Location = new System.Drawing.Point(177, 27);
            this.eThreshold.Name = "eThreshold";
            this.eThreshold.Size = new System.Drawing.Size(78, 20);
            this.eThreshold.TabIndex = 7;
            this.eThreshold.Leave += new System.EventHandler(this.eThreshold_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Threshold";
            // 
            // eNormalizeBy
            // 
            this.eNormalizeBy.Location = new System.Drawing.Point(177, 3);
            this.eNormalizeBy.Name = "eNormalizeBy";
            this.eNormalizeBy.Size = new System.Drawing.Size(78, 20);
            this.eNormalizeBy.TabIndex = 5;
            this.eNormalizeBy.Leave += new System.EventHandler(this.eNormalizeBy_Leave);
            // 
            // lNormalizeBy
            // 
            this.lNormalizeBy.AutoSize = true;
            this.lNormalizeBy.Location = new System.Drawing.Point(98, 8);
            this.lNormalizeBy.Name = "lNormalizeBy";
            this.lNormalizeBy.Size = new System.Drawing.Size(68, 13);
            this.lNormalizeBy.TabIndex = 4;
            this.lNormalizeBy.Text = "Normalize By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
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
            // btnSaveMotif
            // 
            this.btnSaveMotif.Location = new System.Drawing.Point(467, 6);
            this.btnSaveMotif.Name = "btnSaveMotif";
            this.btnSaveMotif.Size = new System.Drawing.Size(105, 23);
            this.btnSaveMotif.TabIndex = 6;
            this.btnSaveMotif.Text = "Save Motif";
            this.btnSaveMotif.UseVisualStyleBackColor = true;
            this.btnSaveMotif.Click += new System.EventHandler(this.btnSaveMotif_Click);
            // 
            // frmAnalyzePeptideArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 549);
            this.Controls.Add(this.splitContainer2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(508, 294);
            this.Name = "frmAnalyzePeptideArray";
            this.Text = "Peptide Array Analysis";
            this.Load += new System.EventHandler(this.frmPeptideArray_Load);
            this.cmsLoadPeptide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPeptides)).EndInit();
            this.cmsPeptide.ResumeLayout(false);
            this.pPeptidesTop.ResumeLayout(false);
            this.pPeptidesTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).EndInit();
            this.cmsQuantification.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNormalized)).EndInit();
            this.pBottom.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoadPeptideList;
        private System.Windows.Forms.Button btnLoadQuantification;
        private System.Windows.Forms.OpenFileDialog dlgOpenPeptideList;
        private System.Windows.Forms.OpenFileDialog dlgOpenQuantification;
        private System.Windows.Forms.TrackBar trackThreshold;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgQuantification;
        private System.Windows.Forms.Panel pPeptidesTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lQuantification;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgNormalized;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox eThreshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eNormalizeBy;
        private System.Windows.Forms.Label lNormalizeBy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMotifGenerator;
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
        private System.Windows.Forms.Button btnSaveMotif;
        private System.Windows.Forms.SaveFileDialog dlgSaveMotif;
    }
}