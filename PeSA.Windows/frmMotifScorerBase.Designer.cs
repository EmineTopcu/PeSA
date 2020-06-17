namespace PeSA.Windows
{
    partial class frmMotifScorerBase
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
            this.pBottom = new System.Windows.Forms.Panel();
            this.btnScore = new System.Windows.Forms.Button();
            this.btnLoadMotif = new System.Windows.Forms.Button();
            this.dlgOpenMotif = new System.Windows.Forms.OpenFileDialog();
            this.dlgExcelExport = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pMotif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pMotifTop.SuspendLayout();
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
            // dlgExcelExport
            // 
            this.dlgExcelExport.Filter = "Excel Files|*.xlsx;*.xlsm";
            this.dlgExcelExport.Title = "Export to Excel";
            // 
            // frmMotifScorerBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pBottom);
            this.Name = "frmMotifScorerBase";
            this.Text = "Motif Scorer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pMotif.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pMotifTop.ResumeLayout(false);
            this.pMotifTop.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMotif;
        private MotifDisplay mdChart;
        private MotifDisplay mdNegative;
        private MotifDisplay mdPositive;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Button btnLoadMotif;
        private System.Windows.Forms.OpenFileDialog dlgOpenMotif;
        private System.Windows.Forms.Button btnScore;
        private System.Windows.Forms.Label lTarget;
        private System.Windows.Forms.Panel pMotifTop;
        private System.Windows.Forms.TextBox eWildtype;
        private System.Windows.Forms.Label lWildtype;
        private System.Windows.Forms.Label lNegativeThreshold;
        private System.Windows.Forms.Label lPosThreshold;
        private System.Windows.Forms.TextBox eNegativeThreshold;
        private System.Windows.Forms.TextBox ePositiveThreshold;
        private System.Windows.Forms.Label lScorerThresholds;
        private System.Windows.Forms.Label lMotifThresholds;
        private System.Windows.Forms.SaveFileDialog dlgExcelExport;
        private System.Windows.Forms.Label lCutoff;
        private System.Windows.Forms.ToolTip toolTip1;
        protected System.Windows.Forms.SplitContainer splitMain;
        protected System.Windows.Forms.TextBox eTarget;
        protected System.Windows.Forms.TextBox eScorerNegThreshold;
        protected System.Windows.Forms.TextBox eScorerPosThreshold;
        protected System.Windows.Forms.TextBox eNegCutoff;
        protected System.Windows.Forms.TextBox ePosCutoff;
    }
}