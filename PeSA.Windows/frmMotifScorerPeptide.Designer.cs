namespace PeSA.Windows
{
    partial class frmMotifScorerPeptide
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
            this.dlgOpenPeptides = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitRight)).BeginInit();
            this.splitRight.Panel1.SuspendLayout();
            this.splitRight.Panel2.SuspendLayout();
            this.splitRight.SuspendLayout();
            this.pPeptides.SuspendLayout();
            this.pListTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgScores)).BeginInit();
            this.pScoresTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMain
            // 
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.splitRight);
            this.splitMain.Panel2MinSize = 437;
            this.splitMain.Size = new System.Drawing.Size(1087, 584);
            this.splitMain.SplitterDistance = 543;
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
            this.splitRight.Size = new System.Drawing.Size(540, 584);
            this.splitRight.SplitterDistance = 180;
            this.splitRight.TabIndex = 47;
            // 
            // pPeptides
            // 
            this.pPeptides.Controls.Add(this.ePeptides);
            this.pPeptides.Controls.Add(this.pListTop);
            this.pPeptides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPeptides.Location = new System.Drawing.Point(0, 0);
            this.pPeptides.Name = "pPeptides";
            this.pPeptides.Size = new System.Drawing.Size(180, 584);
            this.pPeptides.TabIndex = 44;
            // 
            // ePeptides
            // 
            this.ePeptides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ePeptides.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ePeptides.Location = new System.Drawing.Point(0, 41);
            this.ePeptides.Name = "ePeptides";
            this.ePeptides.Size = new System.Drawing.Size(180, 543);
            this.ePeptides.TabIndex = 44;
            this.ePeptides.Text = "";
            // 
            // pListTop
            // 
            this.pListTop.Controls.Add(this.lPeptideList);
            this.pListTop.Controls.Add(this.lLoadPeptides);
            this.pListTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pListTop.Location = new System.Drawing.Point(0, 0);
            this.pListTop.Name = "pListTop";
            this.pListTop.Size = new System.Drawing.Size(180, 41);
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
            this.lLoadPeptides.Location = new System.Drawing.Point(105, 15);
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
            this.dgScores.RowHeadersWidth = 51;
            this.dgScores.Size = new System.Drawing.Size(356, 542);
            this.dgScores.TabIndex = 43;
            // 
            // colPeptide
            // 
            this.colPeptide.HeaderText = "Peptide";
            this.colPeptide.MinimumWidth = 6;
            this.colPeptide.Name = "colPeptide";
            this.colPeptide.ReadOnly = true;
            this.colPeptide.Width = 125;
            // 
            // colSegment
            // 
            this.colSegment.HeaderText = "Segment";
            this.colSegment.MinimumWidth = 6;
            this.colSegment.Name = "colSegment";
            this.colSegment.ReadOnly = true;
            this.colSegment.Width = 125;
            // 
            // colPosMatch
            // 
            this.colPosMatch.HeaderText = "Positive Match";
            this.colPosMatch.MinimumWidth = 6;
            this.colPosMatch.Name = "colPosMatch";
            this.colPosMatch.ReadOnly = true;
            this.colPosMatch.Width = 125;
            // 
            // colNegMatch
            // 
            this.colNegMatch.HeaderText = "Negative Match";
            this.colNegMatch.MinimumWidth = 6;
            this.colNegMatch.Name = "colNegMatch";
            this.colNegMatch.ReadOnly = true;
            this.colNegMatch.Width = 125;
            // 
            // colMatchScore
            // 
            this.colMatchScore.HeaderText = "MatchScore";
            this.colMatchScore.MinimumWidth = 6;
            this.colMatchScore.Name = "colMatchScore";
            this.colMatchScore.ReadOnly = true;
            this.colMatchScore.Width = 125;
            // 
            // colWeightScore
            // 
            this.colWeightScore.HeaderText = "Weight Score";
            this.colWeightScore.MinimumWidth = 6;
            this.colWeightScore.Name = "colWeightScore";
            this.colWeightScore.ReadOnly = true;
            this.colWeightScore.Width = 125;
            // 
            // colPriorityScore
            // 
            this.colPriorityScore.HeaderText = "Priority Score";
            this.colPriorityScore.MinimumWidth = 6;
            this.colPriorityScore.Name = "colPriorityScore";
            this.colPriorityScore.ReadOnly = true;
            this.colPriorityScore.Width = 125;
            // 
            // pScoresTop
            // 
            this.pScoresTop.Controls.Add(this.lScoreList);
            this.pScoresTop.Controls.Add(this.lSaveScores);
            this.pScoresTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pScoresTop.Location = new System.Drawing.Point(0, 0);
            this.pScoresTop.Name = "pScoresTop";
            this.pScoresTop.Size = new System.Drawing.Size(356, 42);
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
            this.lSaveScores.Location = new System.Drawing.Point(273, 15);
            this.lSaveScores.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lSaveScores.Name = "lSaveScores";
            this.lSaveScores.Size = new System.Drawing.Size(78, 13);
            this.lSaveScores.TabIndex = 42;
            this.lSaveScores.TabStop = true;
            this.lSaveScores.Text = "Export to Excel";
            this.lSaveScores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSaveScores_LinkClicked);
            // 
            // dlgOpenPeptides
            // 
            this.dlgOpenPeptides.FileName = "Peptides.txt";
            this.dlgOpenPeptides.Filter = "Text Files|*.txt|Excel Files|*.xls;*.xlsx;*.xlsm|Comma Delimited|*.csv";
            // 
            // frmMotifScorerPeptide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1087, 617);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMotifScorerPeptide";
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitRight;
        private System.Windows.Forms.Panel pPeptides;
        private System.Windows.Forms.Panel pListTop;
        private System.Windows.Forms.Label lPeptideList;
        private System.Windows.Forms.LinkLabel lLoadPeptides;
        private System.Windows.Forms.DataGridView dgScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPeptide;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNegMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeightScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriorityScore;
        private System.Windows.Forms.Panel pScoresTop;
        private System.Windows.Forms.Label lScoreList;
        private System.Windows.Forms.LinkLabel lSaveScores;
        private System.Windows.Forms.OpenFileDialog dlgOpenPeptides;
        private System.Windows.Forms.RichTextBox ePeptides;
    }
}
