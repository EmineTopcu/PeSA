namespace PeSA.Windows
{
    partial class frmMotifScorer
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
            this.pMotif = new System.Windows.Forms.Panel();
            this.mdChart = new PeSA.Windows.MotifDisplay();
            this.mdNegative = new PeSA.Windows.MotifDisplay();
            this.mdPositive = new PeSA.Windows.MotifDisplay();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.pMotifTop = new System.Windows.Forms.Panel();
            this.lCutoff = new System.Windows.Forms.Label();
            this.eNegCutoff = new System.Windows.Forms.TextBox();
            this.ePosCutoff = new System.Windows.Forms.TextBox();
            this.lScorerThresholds = new System.Windows.Forms.Label();
            this.eScorerNegThreshold = new System.Windows.Forms.TextBox();
            this.eScorerPosThreshold = new System.Windows.Forms.TextBox();
            this.lMotifThresholds = new System.Windows.Forms.Label();
            this.lNegativeThreshold = new System.Windows.Forms.Label();
            this.lPosThreshold = new System.Windows.Forms.Label();
            this.eNegativeThreshold = new System.Windows.Forms.TextBox();
            this.ePositiveThreshold = new System.Windows.Forms.TextBox();
            this.eTarget = new System.Windows.Forms.TextBox();
            this.eWildtype = new System.Windows.Forms.TextBox();
            this.lWildtype = new System.Windows.Forms.Label();
            this.lTarget = new System.Windows.Forms.Label();
            this.splitRight = new System.Windows.Forms.SplitContainer();
            this.pPeptides = new System.Windows.Forms.Panel();
            this.ePeptides = new System.Windows.Forms.RichTextBox();
            this.pListTop = new System.Windows.Forms.Panel();
            this.lPeptideList = new System.Windows.Forms.Label();
            this.lLoadPeptides = new System.Windows.Forms.LinkLabel();
            this.dgScores = new System.Windows.Forms.DataGridView();
            this.colPeptide = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSegment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosMatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNegMatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatchScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeightScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriorityScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pScoresTop = new System.Windows.Forms.Panel();
            this.lScoreList = new System.Windows.Forms.Label();
            this.lSaveScores = new System.Windows.Forms.LinkLabel();
            this.pBottom = new System.Windows.Forms.Panel();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnLoadMotif = new System.Windows.Forms.Button();
            this.dlgOpenMotif = new System.Windows.Forms.OpenFileDialog();
            this.dlgOpenPeptides = new System.Windows.Forms.OpenFileDialog();
            this.dlgExcelExport = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pMotif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pMotifTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.pPeptides.SuspendLayout();
            this.pListTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgScores)).BeginInit();
            this.pScoresTop.SuspendLayout();
            this.pBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMotif
            // 
            this.pMotif.AutoScroll = true;
            this.pMotif.Controls.Add(this.mdChart);
            this.pMotif.Controls.Add(this.mdNegative);
            this.pMotif.Controls.Add(this.mdPositive);
            this.pMotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMotif.Location = new System.Drawing.Point(0, 163);
            this.pMotif.Name = "pMotif";
            this.pMotif.Size = new System.Drawing.Size(325, 421);
            this.pMotif.TabIndex = 1;
            // 
            // mdChart
            // 
            this.mdChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdChart.Image = null;
            this.mdChart.LabelText = "Chart";
            this.mdChart.Location = new System.Drawing.Point(0, 234);
            this.mdChart.Margin = new System.Windows.Forms.Padding(4);
            this.mdChart.Name = "mdChart";
            this.mdChart.Size = new System.Drawing.Size(325, 117);
            this.mdChart.TabIndex = 5;
            // 
            // mdNegative
            // 
            this.mdNegative.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdNegative.Image = null;
            this.mdNegative.LabelText = "Negative Motif";
            this.mdNegative.Location = new System.Drawing.Point(0, 117);
            this.mdNegative.Margin = new System.Windows.Forms.Padding(4);
            this.mdNegative.Name = "mdNegative";
            this.mdNegative.Size = new System.Drawing.Size(325, 117);
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
            this.mdPositive.Size = new System.Drawing.Size(325, 117);
            this.mdPositive.TabIndex = 3;
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.pMotif);
            this.splitMain.Panel1.Controls.Add(this.pMotifTop);
            this.splitMain.Panel1MinSize = 325;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitRight);
            this.splitMain.Panel2MinSize = 437;
            this.splitMain.Size = new System.Drawing.Size(800, 584);
            this.splitMain.SplitterDistance = 325;
            this.splitMain.TabIndex = 2;
            // 
            // pMotifTop
            // 
            this.pMotifTop.Controls.Add(this.lCutoff);
            this.pMotifTop.Controls.Add(this.eNegCutoff);
            this.pMotifTop.Controls.Add(this.ePosCutoff);
            this.pMotifTop.Controls.Add(this.lScorerThresholds);
            this.pMotifTop.Controls.Add(this.eScorerNegThreshold);
            this.pMotifTop.Controls.Add(this.eScorerPosThreshold);
            this.pMotifTop.Controls.Add(this.lMotifThresholds);
            this.pMotifTop.Controls.Add(this.lNegativeThreshold);
            this.pMotifTop.Controls.Add(this.lPosThreshold);
            this.pMotifTop.Controls.Add(this.eNegativeThreshold);
            this.pMotifTop.Controls.Add(this.ePositiveThreshold);
            this.pMotifTop.Controls.Add(this.eTarget);
            this.pMotifTop.Controls.Add(this.eWildtype);
            this.pMotifTop.Controls.Add(this.lWildtype);
            this.pMotifTop.Controls.Add(this.lTarget);
            this.pMotifTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMotifTop.Location = new System.Drawing.Point(0, 0);
            this.pMotifTop.Name = "pMotifTop";
            this.pMotifTop.Size = new System.Drawing.Size(325, 163);
            this.pMotifTop.TabIndex = 2;
            // 
            // lCutoff
            // 
            this.lCutoff.Location = new System.Drawing.Point(238, 67);
            this.lCutoff.Name = "lCutoff";
            this.lCutoff.Size = new System.Drawing.Size(49, 32);
            this.lCutoff.TabIndex = 24;
            this.lCutoff.Text = "Match Cut-off";
            // 
            // eNegCutoff
            // 
            this.eNegCutoff.Location = new System.Drawing.Point(240, 127);
            this.eNegCutoff.Name = "eNegCutoff";
            this.eNegCutoff.Size = new System.Drawing.Size(47, 20);
            this.eNegCutoff.TabIndex = 23;
            this.toolTip1.SetToolTip(this.eNegCutoff, "Display peptides with at most cut-off matches with the negative motif");
            // 
            // ePosCutoff
            // 
            this.ePosCutoff.Location = new System.Drawing.Point(240, 101);
            this.ePosCutoff.Name = "ePosCutoff";
            this.ePosCutoff.Size = new System.Drawing.Size(47, 20);
            this.ePosCutoff.TabIndex = 22;
            this.toolTip1.SetToolTip(this.ePosCutoff, "Display peptides with at least cut-off matches with the positive motif");
            // 
            // lScorerThresholds
            // 
            this.lScorerThresholds.Location = new System.Drawing.Point(177, 67);
            this.lScorerThresholds.Name = "lScorerThresholds";
            this.lScorerThresholds.Size = new System.Drawing.Size(61, 32);
            this.lScorerThresholds.TabIndex = 19;
            this.lScorerThresholds.Text = "Changed Thresholds";
            // 
            // eScorerNegThreshold
            // 
            this.eScorerNegThreshold.Location = new System.Drawing.Point(178, 127);
            this.eScorerNegThreshold.Name = "eScorerNegThreshold";
            this.eScorerNegThreshold.Size = new System.Drawing.Size(47, 20);
            this.eScorerNegThreshold.TabIndex = 16;
            this.toolTip1.SetToolTip(this.eScorerNegThreshold, "Range: [0.0-1.0]");
            // 
            // eScorerPosThreshold
            // 
            this.eScorerPosThreshold.Location = new System.Drawing.Point(178, 101);
            this.eScorerPosThreshold.Name = "eScorerPosThreshold";
            this.eScorerPosThreshold.Size = new System.Drawing.Size(47, 20);
            this.eScorerPosThreshold.TabIndex = 15;
            this.toolTip1.SetToolTip(this.eScorerPosThreshold, "Range: [0.0-1.0]");
            // 
            // lMotifThresholds
            // 
            this.lMotifThresholds.Location = new System.Drawing.Point(112, 67);
            this.lMotifThresholds.Name = "lMotifThresholds";
            this.lMotifThresholds.Size = new System.Drawing.Size(65, 32);
            this.lMotifThresholds.TabIndex = 14;
            this.lMotifThresholds.Text = "Motif Thresholds";
            // 
            // lNegativeThreshold
            // 
            this.lNegativeThreshold.AutoSize = true;
            this.lNegativeThreshold.Location = new System.Drawing.Point(11, 127);
            this.lNegativeThreshold.Name = "lNegativeThreshold";
            this.lNegativeThreshold.Size = new System.Drawing.Size(50, 13);
            this.lNegativeThreshold.TabIndex = 13;
            this.lNegativeThreshold.Text = "Negative";
            // 
            // lPosThreshold
            // 
            this.lPosThreshold.AutoSize = true;
            this.lPosThreshold.Location = new System.Drawing.Point(11, 105);
            this.lPosThreshold.Name = "lPosThreshold";
            this.lPosThreshold.Size = new System.Drawing.Size(44, 13);
            this.lPosThreshold.TabIndex = 12;
            this.lPosThreshold.Text = "Positive";
            // 
            // eNegativeThreshold
            // 
            this.eNegativeThreshold.Location = new System.Drawing.Point(114, 127);
            this.eNegativeThreshold.Name = "eNegativeThreshold";
            this.eNegativeThreshold.ReadOnly = true;
            this.eNegativeThreshold.Size = new System.Drawing.Size(47, 20);
            this.eNegativeThreshold.TabIndex = 11;
            // 
            // ePositiveThreshold
            // 
            this.ePositiveThreshold.Location = new System.Drawing.Point(114, 101);
            this.ePositiveThreshold.Name = "ePositiveThreshold";
            this.ePositiveThreshold.ReadOnly = true;
            this.ePositiveThreshold.Size = new System.Drawing.Size(47, 20);
            this.ePositiveThreshold.TabIndex = 10;
            // 
            // eTarget
            // 
            this.eTarget.Location = new System.Drawing.Point(115, 32);
            this.eTarget.Name = "eTarget";
            this.eTarget.Size = new System.Drawing.Size(47, 20);
            this.eTarget.TabIndex = 9;
            // 
            // eWildtype
            // 
            this.eWildtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eWildtype.Location = new System.Drawing.Point(115, 6);
            this.eWildtype.Name = "eWildtype";
            this.eWildtype.ReadOnly = true;
            this.eWildtype.Size = new System.Drawing.Size(207, 20);
            this.eWildtype.TabIndex = 8;
            // 
            // lWildtype
            // 
            this.lWildtype.AutoSize = true;
            this.lWildtype.Location = new System.Drawing.Point(11, 8);
            this.lWildtype.Name = "lWildtype";
            this.lWildtype.Size = new System.Drawing.Size(48, 13);
            this.lWildtype.TabIndex = 7;
            this.lWildtype.Text = "Wildtype";
            // 
            // lTarget
            // 
            this.lTarget.AutoSize = true;
            this.lTarget.Location = new System.Drawing.Point(11, 35);
            this.lTarget.Name = "lTarget";
            this.lTarget.Size = new System.Drawing.Size(104, 13);
            this.lTarget.TabIndex = 6;
            this.lTarget.Text = "Motif Target Position";
            // 
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Name = "splitRight";
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.pPeptides);
            this.splitRight.Panel1MinSize = 157;
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.dgScores);
            this.splitRight.Panel2.Controls.Add(this.pScoresTop);
            this.splitRight.Panel2MinSize = 280;
            this.splitRight.Size = new System.Drawing.Size(471, 584);
            this.splitRight.SplitterDistance = 167;
            this.splitRight.TabIndex = 46;
            // 
            // pPeptides
            // 
            this.pPeptides.Controls.Add(this.ePeptides);
            this.pPeptides.Controls.Add(this.pListTop);
            this.pPeptides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPeptides.Location = new System.Drawing.Point(0, 0);
            this.pPeptides.Name = "pPeptides";
            this.pPeptides.Size = new System.Drawing.Size(167, 584);
            this.pPeptides.TabIndex = 44;
            // 
            // ePeptides
            // 
            this.ePeptides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ePeptides.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ePeptides.Location = new System.Drawing.Point(0, 41);
            this.ePeptides.Name = "ePeptides";
            this.ePeptides.Size = new System.Drawing.Size(167, 543);
            this.ePeptides.TabIndex = 41;
            this.ePeptides.Text = "";
            // 
            // pListTop
            // 
            this.pListTop.Controls.Add(this.lPeptideList);
            this.pListTop.Controls.Add(this.lLoadPeptides);
            this.pListTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pListTop.Location = new System.Drawing.Point(0, 0);
            this.pListTop.Name = "pListTop";
            this.pListTop.Size = new System.Drawing.Size(167, 41);
            this.pListTop.TabIndex = 43;
            // 
            // lPeptideList
            // 
            this.lPeptideList.AutoSize = true;
            this.lPeptideList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPeptideList.Location = new System.Drawing.Point(3, 13);
            this.lPeptideList.Name = "lPeptideList";
            this.lPeptideList.Size = new System.Drawing.Size(82, 17);
            this.lPeptideList.TabIndex = 40;
            this.lPeptideList.Text = "Peptide List";
            // 
            // lLoadPeptides
            // 
            this.lLoadPeptides.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lLoadPeptides.AutoSize = true;
            this.lLoadPeptides.Location = new System.Drawing.Point(92, 15);
            this.lLoadPeptides.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLoadPeptides.Name = "lLoadPeptides";
            this.lLoadPeptides.Size = new System.Drawing.Size(73, 13);
            this.lLoadPeptides.TabIndex = 42;
            this.lLoadPeptides.TabStop = true;
            this.lLoadPeptides.Text = "Load from File";
            this.lLoadPeptides.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLoadPeptides_LinkClicked);
            // 
            // dgScores
            // 
            this.dgScores.AllowUserToAddRows = false;
            this.dgScores.AllowUserToDeleteRows = false;
            this.dgScores.AllowUserToOrderColumns = true;
            this.dgScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPeptide,
            this.colSegment,
            this.colPosMatch,
            this.colNegMatch,
            this.colMatchScore,
            this.colWeightScore,
            this.colPriorityScore});
            this.dgScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgScores.Location = new System.Drawing.Point(0, 42);
            this.dgScores.Name = "dgScores";
            this.dgScores.RowHeadersVisible = false;
            this.dgScores.Size = new System.Drawing.Size(300, 542);
            this.dgScores.TabIndex = 43;
            // 
            // colPeptide
            // 
            this.colPeptide.HeaderText = "Peptide";
            this.colPeptide.Name = "colPeptide";
            this.colPeptide.ReadOnly = true;
            // 
            // colSegment
            // 
            this.colSegment.HeaderText = "Segment";
            this.colSegment.Name = "colSegment";
            this.colSegment.ReadOnly = true;
            // 
            // colPosMatch
            // 
            this.colPosMatch.HeaderText = "Positive Match";
            this.colPosMatch.Name = "colPosMatch";
            this.colPosMatch.ReadOnly = true;
            // 
            // colNegMatch
            // 
            this.colNegMatch.HeaderText = "Negative Match";
            this.colNegMatch.Name = "colNegMatch";
            this.colNegMatch.ReadOnly = true;
            // 
            // colMatchScore
            // 
            this.colMatchScore.HeaderText = "MatchScore";
            this.colMatchScore.Name = "colMatchScore";
            this.colMatchScore.ReadOnly = true;
            // 
            // colWeightScore
            // 
            this.colWeightScore.HeaderText = "Weight Score";
            this.colWeightScore.Name = "colWeightScore";
            this.colWeightScore.ReadOnly = true;
            // 
            // colPriorityScore
            // 
            this.colPriorityScore.HeaderText = "Priority Score";
            this.colPriorityScore.Name = "colPriorityScore";
            this.colPriorityScore.ReadOnly = true;
            // 
            // pScoresTop
            // 
            this.pScoresTop.Controls.Add(this.lScoreList);
            this.pScoresTop.Controls.Add(this.lSaveScores);
            this.pScoresTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pScoresTop.Location = new System.Drawing.Point(0, 0);
            this.pScoresTop.Name = "pScoresTop";
            this.pScoresTop.Size = new System.Drawing.Size(300, 42);
            this.pScoresTop.TabIndex = 45;
            // 
            // lScoreList
            // 
            this.lScoreList.AutoSize = true;
            this.lScoreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreList.Location = new System.Drawing.Point(3, 13);
            this.lScoreList.Name = "lScoreList";
            this.lScoreList.Size = new System.Drawing.Size(71, 17);
            this.lScoreList.TabIndex = 40;
            this.lScoreList.Text = "Score List";
            // 
            // lSaveScores
            // 
            this.lSaveScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSaveScores.AutoSize = true;
            this.lSaveScores.Location = new System.Drawing.Point(217, 15);
            this.lSaveScores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSaveScores.Name = "lSaveScores";
            this.lSaveScores.Size = new System.Drawing.Size(78, 13);
            this.lSaveScores.TabIndex = 42;
            this.lSaveScores.TabStop = true;
            this.lSaveScores.Text = "Export to Excel";
            this.lSaveScores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSaveScores_LinkClicked);
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnScore);
            this.pBottom.Controls.Add(this.btnLoadMotif);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 584);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(800, 33);
            this.pBottom.TabIndex = 6;
            // 
            // btnScore
            // 
            this.btnScore.Location = new System.Drawing.Point(84, 5);
            this.btnScore.Name = "btnScore";
            this.btnScore.Size = new System.Drawing.Size(75, 23);
            this.btnScore.TabIndex = 1;
            this.btnScore.Text = "Score";
            this.btnScore.UseVisualStyleBackColor = true;
            this.btnScore.Click += new System.EventHandler(this.btnScore_Click);
            // 
            // btnLoadMotif
            // 
            this.btnLoadMotif.Location = new System.Drawing.Point(3, 5);
            this.btnLoadMotif.Name = "btnLoadMotif";
            this.btnLoadMotif.Size = new System.Drawing.Size(75, 23);
            this.btnLoadMotif.TabIndex = 0;
            this.btnLoadMotif.Text = "Load Motif";
            this.btnLoadMotif.UseVisualStyleBackColor = true;
            this.btnLoadMotif.Click += new System.EventHandler(this.btnLoadMotif_Click);
            // 
            // dlgOpenMotif
            // 
            this.dlgOpenMotif.FileName = "Open Motif";
            this.dlgOpenMotif.Filter = "PeSA Motif File|*.pmtf";
            this.dlgOpenMotif.Title = "Open Project";
            // 
            // dlgOpenPeptides
            // 
            this.dlgOpenPeptides.FileName = "Peptides.txt";
            this.dlgOpenPeptides.Filter = "Text Files|*.txt|Excel Files|*.xls;*.xlsx;*.xlsm|Comma Delimited|*.csv";
            // 
            // dlgExcelExport
            // 
            this.dlgExcelExport.Filter = "Excel Files|*.xlsx;*.xlsm";
            this.dlgExcelExport.Title = "Export to Excel";
            // 
            // frmMotifScorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pBottom);
            this.Name = "frmMotifScorer";
            this.Text = "Motif Scorer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pMotif.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pMotifTop.ResumeLayout(false);
            this.pMotifTop.PerformLayout();
            this.splitRight.Panel1.ResumeLayout(false);
            this.splitRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).EndInit();
            this.splitRight.ResumeLayout(false);
            this.pPeptides.ResumeLayout(false);
            this.pListTop.ResumeLayout(false);
            this.pListTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgScores)).EndInit();
            this.pScoresTop.ResumeLayout(false);
            this.pScoresTop.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMotif;
        private MotifDisplay mdChart;
        private MotifDisplay mdNegative;
        private MotifDisplay mdPositive;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Button btnLoadMotif;
        private System.Windows.Forms.DataGridView dgScores;
        private System.Windows.Forms.Panel pPeptides;
        private System.Windows.Forms.Label lPeptideList;
        private System.Windows.Forms.RichTextBox ePeptides;
        private System.Windows.Forms.LinkLabel lLoadPeptides;
        private System.Windows.Forms.OpenFileDialog dlgOpenMotif;
        private System.Windows.Forms.OpenFileDialog dlgOpenPeptides;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeptide;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNegMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeightScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriorityScore;
        private System.Windows.Forms.Label lTarget;
        private System.Windows.Forms.Panel pMotifTop;
        private System.Windows.Forms.TextBox eTarget;
        private System.Windows.Forms.TextBox eWildtype;
        private System.Windows.Forms.Label lWildtype;
        private System.Windows.Forms.Panel pScoresTop;
        private System.Windows.Forms.Label lScoreList;
        private System.Windows.Forms.LinkLabel lSaveScores;
        private System.Windows.Forms.Panel pListTop;
        private System.Windows.Forms.Label lNegativeThreshold;
        private System.Windows.Forms.Label lPosThreshold;
        private System.Windows.Forms.TextBox eNegativeThreshold;
        private System.Windows.Forms.TextBox ePositiveThreshold;
        private System.Windows.Forms.Label lScorerThresholds;
        private System.Windows.Forms.Label lMotifThresholds;
        private System.Windows.Forms.TextBox eScorerNegThreshold;
        private System.Windows.Forms.TextBox eScorerPosThreshold;
        private System.Windows.Forms.SaveFileDialog dlgExcelExport;
        private System.Windows.Forms.Label lCutoff;
        private System.Windows.Forms.TextBox eNegCutoff;
        private System.Windows.Forms.TextBox ePosCutoff;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitRight;
    }
}