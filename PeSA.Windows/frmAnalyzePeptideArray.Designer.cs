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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnalyzePeptideArray));
            cmsLoadPeptide = new ContextMenuStrip(components);
            cmiLoadPeptideList = new ToolStripMenuItem();
            cmiLoadPeptideMatrix = new ToolStripMenuItem();
            dlgOpenPeptideList = new OpenFileDialog();
            dlgOpenQuantification = new OpenFileDialog();
            splitLeftTop = new SplitContainer();
            dgPeptides = new DataGridView();
            cmsPeptide = new ContextMenuStrip(components);
            cmiPastePeptide = new ToolStripMenuItem();
            cmiFindPeptide = new ToolStripMenuItem();
            cmiFindNext = new ToolStripMenuItem();
            pPeptidesTop = new Panel();
            linkRun = new LinkLabel();
            lLoadPeptides = new LinkLabel();
            lArrayInfo = new Label();
            lPeptides = new Label();
            dgQuantification = new DataGridView();
            cmsQuantification = new ContextMenuStrip(components);
            cmiPasteQuantification = new ToolStripMenuItem();
            panel2 = new Panel();
            linkLoadQuantification = new LinkLabel();
            lQuantification = new Label();
            ePeptideLength = new TextBox();
            lPeptideLength = new Label();
            splitLeft = new SplitContainer();
            dgNormalized = new DataGridView();
            panel1 = new Panel();
            thresholdEntry = new Controls.ThresholdEntry();
            eNormalizeBy = new TextBox();
            lNormalizeBy = new Label();
            label2 = new Label();
            pBottom = new Panel();
            btnRunScorer = new Button();
            btnSaveMotif = new Button();
            btnExport = new Button();
            btnLoad = new Button();
            btnSave = new Button();
            dlgOpenProject = new OpenFileDialog();
            dlgSaveProject = new SaveFileDialog();
            dlgExcelExport = new SaveFileDialog();
            errorProvider1 = new ErrorProvider(components);
            dlgOpenPeptideMatrix = new OpenFileDialog();
            dlgSaveMotif = new SaveFileDialog();
            splitMain = new SplitContainer();
            tabImages = new TabControl();
            tMotif = new TabPage();
            pMotif = new Panel();
            mdNegative = new MotifDisplay();
            mdMain = new MotifDisplay();
            panel3 = new Panel();
            lQuestion = new Label();
            label3 = new Label();
            eKeyPosition = new TextBox();
            lAminoAcid = new Label();
            eAminoAcid = new TextBox();
            label6 = new Label();
            eFreqThreshold = new TextBox();
            tInfo = new TabPage();
            flowpanelReference = new FlowLayoutPanel();
            imageReference = new Controls.ImageDisplay();
            lNotes = new Label();
            eNotes = new TextBox();
            tDecisionList = new TabPage();
            dgDecision = new DataGridView();
            colPeptide = new DataGridViewTextBoxColumn();
            colWeight = new DataGridViewTextBoxColumn();
            colDecision = new DataGridViewTextBoxColumn();
            dlgOpenImage = new OpenFileDialog();
            cmsRunScorer = new ContextMenuStrip(components);
            cmiPeptideScorer = new ToolStripMenuItem();
            cmiProteinScorer = new ToolStripMenuItem();
            mdShifted = new MotifDisplay();
            cmsLoadPeptide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitLeftTop).BeginInit();
            splitLeftTop.Panel1.SuspendLayout();
            splitLeftTop.Panel2.SuspendLayout();
            splitLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgPeptides).BeginInit();
            cmsPeptide.SuspendLayout();
            pPeptidesTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgQuantification).BeginInit();
            cmsQuantification.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitLeft).BeginInit();
            splitLeft.Panel1.SuspendLayout();
            splitLeft.Panel2.SuspendLayout();
            splitLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgNormalized).BeginInit();
            panel1.SuspendLayout();
            pBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            tabImages.SuspendLayout();
            tMotif.SuspendLayout();
            pMotif.SuspendLayout();
            panel3.SuspendLayout();
            tInfo.SuspendLayout();
            flowpanelReference.SuspendLayout();
            tDecisionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgDecision).BeginInit();
            cmsRunScorer.SuspendLayout();
            SuspendLayout();
            // 
            // cmsLoadPeptide
            // 
            cmsLoadPeptide.ImageScalingSize = new Size(24, 24);
            cmsLoadPeptide.Items.AddRange(new ToolStripItem[] { cmiLoadPeptideList, cmiLoadPeptideMatrix });
            cmsLoadPeptide.Name = "cmsLoadPeptide";
            cmsLoadPeptide.Size = new Size(181, 48);
            // 
            // cmiLoadPeptideList
            // 
            cmiLoadPeptideList.Name = "cmiLoadPeptideList";
            cmiLoadPeptideList.Size = new Size(180, 22);
            cmiLoadPeptideList.Text = "Load Peptide List";
            cmiLoadPeptideList.Click += cmiLoadPeptideList_Click;
            // 
            // cmiLoadPeptideMatrix
            // 
            cmiLoadPeptideMatrix.Name = "cmiLoadPeptideMatrix";
            cmiLoadPeptideMatrix.Size = new Size(180, 22);
            cmiLoadPeptideMatrix.Text = "Load Peptide Matrix";
            cmiLoadPeptideMatrix.Click += cmiLoadPeptideMatrix_Click;
            // 
            // dlgOpenPeptideList
            // 
            dlgOpenPeptideList.FileName = "Peptides.txt";
            dlgOpenPeptideList.Filter = "Text files|*.txt";
            // 
            // dlgOpenQuantification
            // 
            dlgOpenQuantification.FileName = "GridMeasurementsTable.xls";
            dlgOpenQuantification.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|Comma Delimited|*.csv";
            // 
            // splitLeftTop
            // 
            splitLeftTop.Dock = DockStyle.Fill;
            splitLeftTop.Location = new Point(0, 0);
            splitLeftTop.Margin = new Padding(2);
            splitLeftTop.Name = "splitLeftTop";
            splitLeftTop.Orientation = Orientation.Horizontal;
            // 
            // splitLeftTop.Panel1
            // 
            splitLeftTop.Panel1.Controls.Add(dgPeptides);
            splitLeftTop.Panel1.Controls.Add(pPeptidesTop);
            splitLeftTop.Panel1MinSize = 32;
            // 
            // splitLeftTop.Panel2
            // 
            splitLeftTop.Panel2.Controls.Add(dgQuantification);
            splitLeftTop.Panel2.Controls.Add(panel2);
            splitLeftTop.Panel2MinSize = 32;
            splitLeftTop.Size = new Size(676, 591);
            splitLeftTop.SplitterDistance = 199;
            splitLeftTop.SplitterWidth = 3;
            splitLeftTop.TabIndex = 4;
            // 
            // dgPeptides
            // 
            dgPeptides.AllowUserToAddRows = false;
            dgPeptides.AllowUserToDeleteRows = false;
            dgPeptides.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgPeptides.ContextMenuStrip = cmsPeptide;
            dgPeptides.Dock = DockStyle.Fill;
            dgPeptides.Location = new Point(0, 35);
            dgPeptides.Margin = new Padding(2);
            dgPeptides.Name = "dgPeptides";
            dgPeptides.ReadOnly = true;
            dgPeptides.RowTemplate.Height = 28;
            dgPeptides.Size = new Size(676, 164);
            dgPeptides.TabIndex = 2;
            // 
            // cmsPeptide
            // 
            cmsPeptide.ImageScalingSize = new Size(24, 24);
            cmsPeptide.Items.AddRange(new ToolStripItem[] { cmiPastePeptide, cmiFindPeptide, cmiFindNext });
            cmsPeptide.Name = "cmsClipBoard";
            cmsPeptide.Size = new Size(203, 70);
            // 
            // cmiPastePeptide
            // 
            cmiPastePeptide.Name = "cmiPastePeptide";
            cmiPastePeptide.ShortcutKeys = Keys.Control | Keys.V;
            cmiPastePeptide.Size = new Size(202, 22);
            cmiPastePeptide.Text = "Paste from Excel";
            cmiPastePeptide.Click += cmiPastePeptide_Click;
            // 
            // cmiFindPeptide
            // 
            cmiFindPeptide.Name = "cmiFindPeptide";
            cmiFindPeptide.ShortcutKeys = Keys.Control | Keys.F;
            cmiFindPeptide.Size = new Size(202, 22);
            cmiFindPeptide.Text = "Find Peptide";
            cmiFindPeptide.Click += cmiFindPeptide_Click;
            // 
            // cmiFindNext
            // 
            cmiFindNext.Name = "cmiFindNext";
            cmiFindNext.ShortcutKeys = Keys.Control | Keys.N;
            cmiFindNext.Size = new Size(202, 22);
            cmiFindNext.Text = "Find Next";
            cmiFindNext.Click += cmiFindNext_Click;
            // 
            // pPeptidesTop
            // 
            pPeptidesTop.Controls.Add(linkRun);
            pPeptidesTop.Controls.Add(lLoadPeptides);
            pPeptidesTop.Controls.Add(lArrayInfo);
            pPeptidesTop.Controls.Add(lPeptides);
            pPeptidesTop.Dock = DockStyle.Top;
            pPeptidesTop.Location = new Point(0, 0);
            pPeptidesTop.Margin = new Padding(4, 3, 4, 3);
            pPeptidesTop.Name = "pPeptidesTop";
            pPeptidesTop.Size = new Size(676, 35);
            pPeptidesTop.TabIndex = 1;
            // 
            // linkRun
            // 
            linkRun.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkRun.AutoSize = true;
            linkRun.Location = new Point(522, 10);
            linkRun.Margin = new Padding(2, 0, 2, 0);
            linkRun.Name = "linkRun";
            linkRun.Size = new Size(28, 15);
            linkRun.TabIndex = 22;
            linkRun.TabStop = true;
            linkRun.Text = "Run";
            linkRun.Visible = false;
            linkRun.LinkClicked += linkRun_LinkClicked;
            // 
            // lLoadPeptides
            // 
            lLoadPeptides.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lLoadPeptides.AutoSize = true;
            lLoadPeptides.ContextMenuStrip = cmsLoadPeptide;
            lLoadPeptides.Location = new Point(558, 10);
            lLoadPeptides.Margin = new Padding(2, 0, 2, 0);
            lLoadPeptides.Name = "lLoadPeptides";
            lLoadPeptides.Size = new Size(83, 15);
            lLoadPeptides.TabIndex = 21;
            lLoadPeptides.TabStop = true;
            lLoadPeptides.Text = "Load from File";
            lLoadPeptides.LinkClicked += lLoadPeptides_LinkClicked;
            // 
            // lArrayInfo
            // 
            lArrayInfo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lArrayInfo.Location = new Point(353, 10);
            lArrayInfo.Margin = new Padding(4, 0, 4, 0);
            lArrayInfo.MinimumSize = new Size(23, 0);
            lArrayInfo.Name = "lArrayInfo";
            lArrayInfo.Size = new Size(152, 15);
            lArrayInfo.TabIndex = 3;
            lArrayInfo.Text = "20x30 matrix - Rows first";
            // 
            // lPeptides
            // 
            lPeptides.AutoSize = true;
            lPeptides.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lPeptides.Location = new Point(7, 7);
            lPeptides.Margin = new Padding(4, 0, 4, 0);
            lPeptides.Name = "lPeptides";
            lPeptides.Size = new Size(63, 17);
            lPeptides.TabIndex = 2;
            lPeptides.Text = "Peptides";
            // 
            // dgQuantification
            // 
            dgQuantification.AllowUserToAddRows = false;
            dgQuantification.AllowUserToDeleteRows = false;
            dgQuantification.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgQuantification.ContextMenuStrip = cmsQuantification;
            dgQuantification.Dock = DockStyle.Fill;
            dgQuantification.Location = new Point(0, 35);
            dgQuantification.Margin = new Padding(2);
            dgQuantification.Name = "dgQuantification";
            dgQuantification.ReadOnly = true;
            dgQuantification.RowTemplate.Height = 28;
            dgQuantification.Size = new Size(676, 354);
            dgQuantification.TabIndex = 0;
            // 
            // cmsQuantification
            // 
            cmsQuantification.ImageScalingSize = new Size(24, 24);
            cmsQuantification.Items.AddRange(new ToolStripItem[] { cmiPasteQuantification });
            cmsQuantification.Name = "cmsClipBoard";
            cmsQuantification.Size = new Size(203, 26);
            // 
            // cmiPasteQuantification
            // 
            cmiPasteQuantification.Name = "cmiPasteQuantification";
            cmiPasteQuantification.ShortcutKeys = Keys.Control | Keys.V;
            cmiPasteQuantification.Size = new Size(202, 22);
            cmiPasteQuantification.Text = "Paste from Excel";
            cmiPasteQuantification.Click += cmiPasteQuantification_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(linkLoadQuantification);
            panel2.Controls.Add(lQuantification);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(676, 35);
            panel2.TabIndex = 3;
            // 
            // linkLoadQuantification
            // 
            linkLoadQuantification.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLoadQuantification.AutoSize = true;
            linkLoadQuantification.Location = new Point(558, 9);
            linkLoadQuantification.Margin = new Padding(2, 0, 2, 0);
            linkLoadQuantification.Name = "linkLoadQuantification";
            linkLoadQuantification.Size = new Size(83, 15);
            linkLoadQuantification.TabIndex = 3;
            linkLoadQuantification.TabStop = true;
            linkLoadQuantification.Text = "Load from File";
            linkLoadQuantification.LinkClicked += linkLoadQuantification_LinkClicked;
            // 
            // lQuantification
            // 
            lQuantification.AutoSize = true;
            lQuantification.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lQuantification.Location = new Point(7, 7);
            lQuantification.Margin = new Padding(4, 0, 4, 0);
            lQuantification.Name = "lQuantification";
            lQuantification.Size = new Size(258, 17);
            lQuantification.TabIndex = 2;
            lQuantification.Text = "Quantification (Background normalized)";
            // 
            // ePeptideLength
            // 
            ePeptideLength.Location = new Point(142, 12);
            ePeptideLength.Margin = new Padding(4, 3, 4, 3);
            ePeptideLength.Name = "ePeptideLength";
            ePeptideLength.Size = new Size(63, 20);
            ePeptideLength.TabIndex = 6;
            ePeptideLength.Leave += ePeptideLength_Leave;
            // 
            // lPeptideLength
            // 
            lPeptideLength.AutoSize = true;
            lPeptideLength.Location = new Point(14, 16);
            lPeptideLength.Margin = new Padding(4, 0, 4, 0);
            lPeptideLength.Name = "lPeptideLength";
            lPeptideLength.Size = new Size(79, 13);
            lPeptideLength.TabIndex = 4;
            lPeptideLength.Text = "Peptide Length";
            // 
            // splitLeft
            // 
            splitLeft.Dock = DockStyle.Fill;
            splitLeft.Location = new Point(0, 0);
            splitLeft.Margin = new Padding(4, 3, 4, 3);
            splitLeft.Name = "splitLeft";
            splitLeft.Orientation = Orientation.Horizontal;
            // 
            // splitLeft.Panel1
            // 
            splitLeft.Panel1.Controls.Add(splitLeftTop);
            splitLeft.Panel1MinSize = 64;
            // 
            // splitLeft.Panel2
            // 
            splitLeft.Panel2.Controls.Add(dgNormalized);
            splitLeft.Panel2.Controls.Add(panel1);
            splitLeft.Panel2MinSize = 115;
            splitLeft.Size = new Size(676, 916);
            splitLeft.SplitterDistance = 591;
            splitLeft.SplitterWidth = 5;
            splitLeft.TabIndex = 5;
            // 
            // dgNormalized
            // 
            dgNormalized.AllowUserToAddRows = false;
            dgNormalized.AllowUserToDeleteRows = false;
            dgNormalized.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = "N3";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgNormalized.DefaultCellStyle = dataGridViewCellStyle1;
            dgNormalized.Dock = DockStyle.Fill;
            dgNormalized.Location = new Point(0, 85);
            dgNormalized.Margin = new Padding(4, 3, 4, 3);
            dgNormalized.Name = "dgNormalized";
            dgNormalized.ReadOnly = true;
            dgNormalized.Size = new Size(676, 235);
            dgNormalized.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(thresholdEntry);
            panel1.Controls.Add(eNormalizeBy);
            panel1.Controls.Add(lNormalizeBy);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 85);
            panel1.TabIndex = 2;
            // 
            // thresholdEntry
            // 
            thresholdEntry.Location = new Point(233, 2);
            thresholdEntry.Margin = new Padding(5);
            thresholdEntry.MinimumSize = new Size(467, 81);
            thresholdEntry.Name = "thresholdEntry";
            thresholdEntry.NegativeThreshold = 0.5D;
            thresholdEntry.PositiveThreshold = 0.5D;
            thresholdEntry.Size = new Size(467, 81);
            thresholdEntry.TabIndex = 12;
            thresholdEntry.ThresholdChanged += thresholdEntry_ThresholdChanged;
            // 
            // eNormalizeBy
            // 
            eNormalizeBy.Location = new Point(94, 50);
            eNormalizeBy.Margin = new Padding(4, 3, 4, 3);
            eNormalizeBy.Name = "eNormalizeBy";
            eNormalizeBy.Size = new Size(90, 23);
            eNormalizeBy.TabIndex = 5;
            eNormalizeBy.Leave += eNormalizeBy_Leave;
            // 
            // lNormalizeBy
            // 
            lNormalizeBy.AutoSize = true;
            lNormalizeBy.Location = new Point(7, 54);
            lNormalizeBy.Margin = new Padding(4, 0, 4, 0);
            lNormalizeBy.Name = "lNormalizeBy";
            lNormalizeBy.Size = new Size(77, 15);
            lNormalizeBy.TabIndex = 4;
            lNormalizeBy.Text = "Normalize By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 7);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 2;
            label2.Text = "Normalized";
            // 
            // pBottom
            // 
            pBottom.Controls.Add(btnRunScorer);
            pBottom.Controls.Add(btnSaveMotif);
            pBottom.Controls.Add(btnExport);
            pBottom.Controls.Add(btnLoad);
            pBottom.Controls.Add(btnSave);
            pBottom.Dock = DockStyle.Bottom;
            pBottom.Location = new Point(0, 916);
            pBottom.Margin = new Padding(4, 3, 4, 3);
            pBottom.Name = "pBottom";
            pBottom.Size = new Size(1396, 42);
            pBottom.TabIndex = 4;
            // 
            // btnRunScorer
            // 
            btnRunScorer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRunScorer.Location = new Point(1130, 7);
            btnRunScorer.Margin = new Padding(4, 3, 4, 3);
            btnRunScorer.Name = "btnRunScorer";
            btnRunScorer.Size = new Size(122, 27);
            btnRunScorer.TabIndex = 5;
            btnRunScorer.Text = "Run Scorer";
            btnRunScorer.UseVisualStyleBackColor = true;
            btnRunScorer.Click += btnRunScorer_Click;
            // 
            // btnSaveMotif
            // 
            btnSaveMotif.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSaveMotif.Location = new Point(1260, 7);
            btnSaveMotif.Margin = new Padding(4, 3, 4, 3);
            btnSaveMotif.Name = "btnSaveMotif";
            btnSaveMotif.Size = new Size(122, 27);
            btnSaveMotif.TabIndex = 4;
            btnSaveMotif.Text = "Save Motif";
            btnSaveMotif.UseVisualStyleBackColor = true;
            btnSaveMotif.Click += btnSaveMotif_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(270, 7);
            btnExport.Margin = new Padding(4, 3, 4, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(122, 27);
            btnExport.TabIndex = 2;
            btnExport.Text = "Export to Excel";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(140, 7);
            btnLoad.Margin = new Padding(4, 3, 4, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(122, 27);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load Project";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(10, 7);
            btnSave.Margin = new Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(122, 27);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save Project";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dlgOpenProject
            // 
            dlgOpenProject.FileName = "Open Project";
            dlgOpenProject.Filter = "PeSA Peptide Array Project File|*.ppep";
            // 
            // dlgSaveProject
            // 
            dlgSaveProject.Filter = "PeSA Peptide Array Project File|*.ppep";
            dlgSaveProject.OverwritePrompt = false;
            // 
            // dlgExcelExport
            // 
            dlgExcelExport.Filter = "Excel Files|*.xlsx;*.xlsm";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // dlgOpenPeptideMatrix
            // 
            dlgOpenPeptideMatrix.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|Comma Delimited|*.csv";
            // 
            // dlgSaveMotif
            // 
            dlgSaveMotif.Filter = "PeSA Motif File|*.pmtf";
            dlgSaveMotif.Title = "Save Motif File";
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Margin = new Padding(4, 3, 4, 3);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(splitLeft);
            splitMain.Panel1MinSize = 580;
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(tabImages);
            splitMain.Panel2MinSize = 315;
            splitMain.Size = new Size(1396, 916);
            splitMain.SplitterDistance = 676;
            splitMain.SplitterWidth = 5;
            splitMain.TabIndex = 6;
            // 
            // tabImages
            // 
            tabImages.Controls.Add(tMotif);
            tabImages.Controls.Add(tInfo);
            tabImages.Controls.Add(tDecisionList);
            tabImages.Dock = DockStyle.Fill;
            tabImages.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tabImages.Location = new Point(0, 0);
            tabImages.Margin = new Padding(4, 3, 4, 3);
            tabImages.Name = "tabImages";
            tabImages.SelectedIndex = 0;
            tabImages.Size = new Size(715, 916);
            tabImages.TabIndex = 6;
            // 
            // tMotif
            // 
            tMotif.Controls.Add(pMotif);
            tMotif.Location = new Point(4, 25);
            tMotif.Margin = new Padding(4, 3, 4, 3);
            tMotif.Name = "tMotif";
            tMotif.Padding = new Padding(4, 3, 4, 3);
            tMotif.Size = new Size(707, 887);
            tMotif.TabIndex = 0;
            tMotif.Text = "Motif";
            tMotif.UseVisualStyleBackColor = true;
            // 
            // pMotif
            // 
            pMotif.AutoScroll = true;
            pMotif.Controls.Add(mdShifted);
            pMotif.Controls.Add(mdNegative);
            pMotif.Controls.Add(mdMain);
            pMotif.Controls.Add(panel3);
            pMotif.Dock = DockStyle.Fill;
            pMotif.Location = new Point(4, 3);
            pMotif.Margin = new Padding(4, 3, 4, 3);
            pMotif.Name = "pMotif";
            pMotif.Size = new Size(699, 881);
            pMotif.TabIndex = 0;
            // 
            // mdNegative
            // 
            mdNegative.Dock = DockStyle.Top;
            mdNegative.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            mdNegative.Image = null;
            mdNegative.LabelText = "Negative Motif";
            mdNegative.Location = new Point(0, 354);
            mdNegative.Margin = new Padding(5);
            mdNegative.Name = "mdNegative";
            mdNegative.Padding = new Padding(0, 5, 0, 0);
            mdNegative.Size = new Size(699, 221);
            mdNegative.TabIndex = 3;
            // 
            // mdMain
            // 
            mdMain.Dock = DockStyle.Top;
            mdMain.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            mdMain.Image = null;
            mdMain.LabelText = "Motif";
            mdMain.Location = new Point(0, 133);
            mdMain.Margin = new Padding(5);
            mdMain.Name = "mdMain";
            mdMain.Padding = new Padding(0, 5, 0, 0);
            mdMain.Size = new Size(699, 221);
            mdMain.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(lQuestion);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(ePeptideLength);
            panel3.Controls.Add(eKeyPosition);
            panel3.Controls.Add(lPeptideLength);
            panel3.Controls.Add(lAminoAcid);
            panel3.Controls.Add(eAminoAcid);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(eFreqThreshold);
            panel3.Dock = DockStyle.Top;
            panel3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4, 3, 4, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(699, 133);
            panel3.TabIndex = 2;
            // 
            // lQuestion
            // 
            lQuestion.AutoSize = true;
            lQuestion.Location = new Point(214, 69);
            lQuestion.Margin = new Padding(4, 0, 4, 0);
            lQuestion.Name = "lQuestion";
            lQuestion.Size = new Size(13, 13);
            lQuestion.TabIndex = 43;
            lQuestion.Text = "?";
            lQuestion.Click += lQuestion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(14, 44);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 13);
            label3.TabIndex = 42;
            label3.Text = "Key position";
            // 
            // eKeyPosition
            // 
            eKeyPosition.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            eKeyPosition.Location = new Point(142, 39);
            eKeyPosition.Margin = new Padding(4, 3, 4, 3);
            eKeyPosition.Name = "eKeyPosition";
            eKeyPosition.Size = new Size(63, 20);
            eKeyPosition.TabIndex = 37;
            eKeyPosition.Leave += eKeyPosition_Leave;
            // 
            // lAminoAcid
            // 
            lAminoAcid.AutoSize = true;
            lAminoAcid.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lAminoAcid.Location = new Point(14, 72);
            lAminoAcid.Margin = new Padding(4, 0, 4, 0);
            lAminoAcid.Name = "lAminoAcid";
            lAminoAcid.Size = new Size(94, 13);
            lAminoAcid.TabIndex = 41;
            lAminoAcid.Text = "Target Amino Acid";
            // 
            // eAminoAcid
            // 
            eAminoAcid.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            eAminoAcid.Location = new Point(142, 67);
            eAminoAcid.Margin = new Padding(4, 3, 4, 3);
            eAminoAcid.Name = "eAminoAcid";
            eAminoAcid.Size = new Size(63, 20);
            eAminoAcid.TabIndex = 38;
            eAminoAcid.Leave += eAminoAcid_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(14, 99);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(107, 13);
            label6.TabIndex = 40;
            label6.Text = "Frequency Threshold";
            // 
            // eFreqThreshold
            // 
            eFreqThreshold.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            eFreqThreshold.Location = new Point(142, 95);
            eFreqThreshold.Margin = new Padding(4, 3, 4, 3);
            eFreqThreshold.Name = "eFreqThreshold";
            eFreqThreshold.Size = new Size(63, 20);
            eFreqThreshold.TabIndex = 39;
            eFreqThreshold.Text = "0.1";
            eFreqThreshold.Leave += eFreqThreshold_Leave;
            // 
            // tInfo
            // 
            tInfo.Controls.Add(flowpanelReference);
            tInfo.Location = new Point(4, 25);
            tInfo.Margin = new Padding(4, 3, 4, 3);
            tInfo.Name = "tInfo";
            tInfo.Padding = new Padding(4, 3, 4, 3);
            tInfo.Size = new Size(192, 71);
            tInfo.TabIndex = 1;
            tInfo.Text = "Info";
            tInfo.UseVisualStyleBackColor = true;
            // 
            // flowpanelReference
            // 
            flowpanelReference.AutoScroll = true;
            flowpanelReference.BackColor = SystemColors.Control;
            flowpanelReference.Controls.Add(imageReference);
            flowpanelReference.Controls.Add(lNotes);
            flowpanelReference.Controls.Add(eNotes);
            flowpanelReference.Dock = DockStyle.Fill;
            flowpanelReference.FlowDirection = FlowDirection.TopDown;
            flowpanelReference.Location = new Point(4, 3);
            flowpanelReference.Margin = new Padding(4, 3, 4, 3);
            flowpanelReference.Name = "flowpanelReference";
            flowpanelReference.Size = new Size(184, 65);
            flowpanelReference.TabIndex = 1;
            flowpanelReference.WrapContents = false;
            flowpanelReference.ClientSizeChanged += flowpanelReference_ClientSizeChanged;
            // 
            // imageReference
            // 
            imageReference.Image = (Image)resources.GetObject("imageReference.Image");
            imageReference.Location = new Point(5, 5);
            imageReference.Margin = new Padding(5);
            imageReference.Name = "imageReference";
            imageReference.Size = new Size(467, 231);
            imageReference.TabIndex = 5;
            // 
            // lNotes
            // 
            lNotes.AutoSize = true;
            lNotes.Location = new Point(4, 241);
            lNotes.Margin = new Padding(4, 0, 4, 0);
            lNotes.Name = "lNotes";
            lNotes.Padding = new Padding(4, 3, 4, 3);
            lNotes.Size = new Size(53, 23);
            lNotes.TabIndex = 1;
            lNotes.Text = "Notes";
            // 
            // eNotes
            // 
            eNotes.BackColor = Color.White;
            eNotes.Location = new Point(4, 267);
            eNotes.Margin = new Padding(4, 3, 4, 3);
            eNotes.Multiline = true;
            eNotes.Name = "eNotes";
            eNotes.Size = new Size(557, 666);
            eNotes.TabIndex = 2;
            // 
            // tDecisionList
            // 
            tDecisionList.Controls.Add(dgDecision);
            tDecisionList.Location = new Point(4, 25);
            tDecisionList.Margin = new Padding(4, 3, 4, 3);
            tDecisionList.Name = "tDecisionList";
            tDecisionList.Padding = new Padding(4, 3, 4, 3);
            tDecisionList.Size = new Size(192, 71);
            tDecisionList.TabIndex = 2;
            tDecisionList.Text = "Decision List";
            tDecisionList.UseVisualStyleBackColor = true;
            // 
            // dgDecision
            // 
            dgDecision.AllowUserToAddRows = false;
            dgDecision.AllowUserToDeleteRows = false;
            dgDecision.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDecision.Columns.AddRange(new DataGridViewColumn[] { colPeptide, colWeight, colDecision });
            dgDecision.Dock = DockStyle.Fill;
            dgDecision.Location = new Point(4, 3);
            dgDecision.Margin = new Padding(4, 3, 4, 3);
            dgDecision.Name = "dgDecision";
            dgDecision.RowHeadersVisible = false;
            dgDecision.Size = new Size(184, 65);
            dgDecision.TabIndex = 1;
            // 
            // colPeptide
            // 
            colPeptide.HeaderText = "Peptide";
            colPeptide.Name = "colPeptide";
            colPeptide.ReadOnly = true;
            // 
            // colWeight
            // 
            colWeight.HeaderText = "Weight";
            colWeight.Name = "colWeight";
            colWeight.ReadOnly = true;
            // 
            // colDecision
            // 
            colDecision.HeaderText = "Decision";
            colDecision.Name = "colDecision";
            colDecision.ReadOnly = true;
            // 
            // dlgOpenImage
            // 
            dlgOpenImage.FileName = "Open Image";
            dlgOpenImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png\"";
            // 
            // cmsRunScorer
            // 
            cmsRunScorer.Items.AddRange(new ToolStripItem[] { cmiPeptideScorer, cmiProteinScorer });
            cmsRunScorer.Name = "cmsRunScorer";
            cmsRunScorer.Size = new Size(151, 48);
            // 
            // cmiPeptideScorer
            // 
            cmiPeptideScorer.Name = "cmiPeptideScorer";
            cmiPeptideScorer.Size = new Size(150, 22);
            cmiPeptideScorer.Text = "Peptide Scorer";
            cmiPeptideScorer.Click += cmiPeptideScorer_Click;
            // 
            // cmiProteinScorer
            // 
            cmiProteinScorer.Name = "cmiProteinScorer";
            cmiProteinScorer.Size = new Size(150, 22);
            cmiProteinScorer.Text = "Protein Scorer";
            cmiProteinScorer.Click += cmiProteinScorer_Click;
            // 
            // mdShifted
            // 
            mdShifted.Dock = DockStyle.Top;
            mdShifted.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            mdShifted.Image = null;
            mdShifted.LabelText = "Shifted Motif";
            mdShifted.Location = new Point(0, 575);
            mdShifted.Margin = new Padding(5);
            mdShifted.Name = "mdShifted";
            mdShifted.Padding = new Padding(0, 5, 0, 0);
            mdShifted.Size = new Size(699, 221);
            mdShifted.TabIndex = 4;
            mdShifted.Visible = false;
            // 
            // frmAnalyzePeptideArray
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1396, 958);
            Controls.Add(splitMain);
            Controls.Add(pBottom);
            Margin = new Padding(2);
            MinimumSize = new Size(588, 330);
            Name = "frmAnalyzePeptideArray";
            Text = "Peptide Array Analysis";
            Load += frmPeptideArray_Load;
            cmsLoadPeptide.ResumeLayout(false);
            splitLeftTop.Panel1.ResumeLayout(false);
            splitLeftTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitLeftTop).EndInit();
            splitLeftTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgPeptides).EndInit();
            cmsPeptide.ResumeLayout(false);
            pPeptidesTop.ResumeLayout(false);
            pPeptidesTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgQuantification).EndInit();
            cmsQuantification.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitLeft.Panel1.ResumeLayout(false);
            splitLeft.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitLeft).EndInit();
            splitLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgNormalized).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            tabImages.ResumeLayout(false);
            tMotif.ResumeLayout(false);
            pMotif.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tInfo.ResumeLayout(false);
            flowpanelReference.ResumeLayout(false);
            flowpanelReference.PerformLayout();
            tDecisionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgDecision).EndInit();
            cmsRunScorer.ResumeLayout(false);
            ResumeLayout(false);
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
        private System.Windows.Forms.Button btnSaveMotif;
        private System.Windows.Forms.Button btnRunScorer;
        private System.Windows.Forms.ContextMenuStrip cmsRunScorer;
        private System.Windows.Forms.ToolStripMenuItem cmiPeptideScorer;
        private System.Windows.Forms.ToolStripMenuItem cmiProteinScorer;
        private MotifDisplay mdNegative;
        private MotifDisplay mdShifted;
    }
}