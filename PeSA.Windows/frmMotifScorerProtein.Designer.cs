namespace PeSA.Windows
{
    partial class frmMotifScorerProtein
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
            this.eProtein = new System.Windows.Forms.RichTextBox();
            this.pListTop = new System.Windows.Forms.Panel();
            this.lProteinSeq = new System.Windows.Forms.Label();
            this.lLoadProteinSeq = new System.Windows.Forms.LinkLabel();
            this.dgScores = new System.Windows.Forms.DataGridView();
            this.colProtein = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSegment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPosMatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNegMatch = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatchScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWeightScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPriorityScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pScoresTop = new System.Windows.Forms.Panel();
            this.lScoreList = new System.Windows.Forms.Label();
            this.lSaveScores = new System.Windows.Forms.LinkLabel();
            this.dlgOpenProtein = new System.Windows.Forms.OpenFileDialog();
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
            this.splitMain.Panel2MinSize = 220;
            this.splitMain.SplitterDistance = 476;
            // 
            // eTarget
            // 
            this.eTargetPosition.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // eScorerNegThreshold
            // 
            this.eScorerNegThreshold.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // eScorerPosThreshold
            // 
            this.eScorerPosThreshold.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // eNegCutoff
            // 
            this.eNegCutoff.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // ePosCutoff
            // 
            this.ePosCutoff.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            // 
            // splitRight
            // 
            this.splitRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitRight.Location = new System.Drawing.Point(0, 0);
            this.splitRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitRight.Name = "splitRight";
            this.splitRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitRight.Panel1
            // 
            this.splitRight.Panel1.Controls.Add(this.pPeptides);
            this.splitRight.Panel1MinSize = 42;
            // 
            // splitRight.Panel2
            // 
            this.splitRight.Panel2.Controls.Add(this.dgScores);
            this.splitRight.Panel2.Controls.Add(this.pScoresTop);
            this.splitRight.Panel2MinSize = 65;
            this.splitRight.Size = new System.Drawing.Size(586, 718);
            this.splitRight.SplitterDistance = 245;
            this.splitRight.SplitterWidth = 5;
            this.splitRight.TabIndex = 48;
            // 
            // pPeptides
            // 
            this.pPeptides.Controls.Add(this.eProtein);
            this.pPeptides.Controls.Add(this.pListTop);
            this.pPeptides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPeptides.Location = new System.Drawing.Point(0, 0);
            this.pPeptides.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pPeptides.Name = "pPeptides";
            this.pPeptides.Size = new System.Drawing.Size(586, 245);
            this.pPeptides.TabIndex = 44;
            // 
            // eProtein
            // 
            this.eProtein.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eProtein.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eProtein.Location = new System.Drawing.Point(0, 50);
            this.eProtein.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eProtein.Name = "eProtein";
            this.eProtein.Size = new System.Drawing.Size(586, 195);
            this.eProtein.TabIndex = 44;
            this.eProtein.Text = "";
            this.eProtein.Enter += new System.EventHandler(this.eProtein_Enter);
            this.eProtein.Leave += new System.EventHandler(this.eProtein_Leave);
            // 
            // pListTop
            // 
            this.pListTop.Controls.Add(this.lProteinSeq);
            this.pListTop.Controls.Add(this.lLoadProteinSeq);
            this.pListTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pListTop.Location = new System.Drawing.Point(0, 0);
            this.pListTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pListTop.Name = "pListTop";
            this.pListTop.Size = new System.Drawing.Size(586, 50);
            this.pListTop.TabIndex = 43;
            // 
            // lProteinSeq
            // 
            this.lProteinSeq.AutoSize = true;
            this.lProteinSeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProteinSeq.Location = new System.Drawing.Point(4, 16);
            this.lProteinSeq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lProteinSeq.Name = "lProteinSeq";
            this.lProteinSeq.Size = new System.Drawing.Size(141, 20);
            this.lProteinSeq.TabIndex = 40;
            this.lProteinSeq.Text = "Protein Sequence";
            // 
            // lLoadProteinSeq
            // 
            this.lLoadProteinSeq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lLoadProteinSeq.AutoSize = true;
            this.lLoadProteinSeq.Location = new System.Drawing.Point(486, 18);
            this.lLoadProteinSeq.Name = "lLoadProteinSeq";
            this.lLoadProteinSeq.Size = new System.Drawing.Size(98, 17);
            this.lLoadProteinSeq.TabIndex = 42;
            this.lLoadProteinSeq.TabStop = true;
            this.lLoadProteinSeq.Text = "Load from File";
            this.lLoadProteinSeq.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLoadProteinSeq_LinkClicked);
            // 
            // dgScores
            // 
            this.dgScores.AllowUserToAddRows = false;
            this.dgScores.AllowUserToDeleteRows = false;
            this.dgScores.AllowUserToOrderColumns = true;
            this.dgScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProtein,
            this.colPosition,
            this.colSegment,
            this.colPosMatch,
            this.colNegMatch,
            this.colMatchScore,
            this.colWeightScore,
            this.colPriorityScore});
            this.dgScores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgScores.Location = new System.Drawing.Point(0, 52);
            this.dgScores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgScores.Name = "dgScores";
            this.dgScores.RowHeadersVisible = false;
            this.dgScores.RowHeadersWidth = 51;
            this.dgScores.Size = new System.Drawing.Size(586, 416);
            this.dgScores.TabIndex = 43;
            // 
            // colProtein
            // 
            this.colProtein.HeaderText = "Protein";
            this.colProtein.MinimumWidth = 6;
            this.colProtein.Name = "colProtein";
            this.colProtein.ReadOnly = true;
            this.colProtein.Width = 125;
            // 
            // colPosition
            // 
            this.colPosition.HeaderText = "Position";
            this.colPosition.MinimumWidth = 6;
            this.colPosition.Name = "colPosition";
            this.colPosition.ReadOnly = true;
            this.colPosition.Width = 125;
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
            this.pScoresTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pScoresTop.Name = "pScoresTop";
            this.pScoresTop.Size = new System.Drawing.Size(586, 52);
            this.pScoresTop.TabIndex = 45;
            // 
            // lScoreList
            // 
            this.lScoreList.AutoSize = true;
            this.lScoreList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScoreList.Location = new System.Drawing.Point(4, 16);
            this.lScoreList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lScoreList.Name = "lScoreList";
            this.lScoreList.Size = new System.Drawing.Size(86, 20);
            this.lScoreList.TabIndex = 40;
            this.lScoreList.Text = "Score List";
            // 
            // lSaveScores
            // 
            this.lSaveScores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lSaveScores.AutoSize = true;
            this.lSaveScores.Location = new System.Drawing.Point(476, 18);
            this.lSaveScores.Name = "lSaveScores";
            this.lSaveScores.Size = new System.Drawing.Size(101, 17);
            this.lSaveScores.TabIndex = 42;
            this.lSaveScores.TabStop = true;
            this.lSaveScores.Text = "Export to Excel";
            this.lSaveScores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lSaveScores_LinkClicked);
            // 
            // dlgOpenProtein
            // 
            this.dlgOpenProtein.FileName = "ProteinSeq.txt";
            this.dlgOpenProtein.Filter = "Fasta|*.fasta|Text Files|*.txt|Comma Delimited|*.csv";
            // 
            // frmMotifScorerProtein
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(1067, 759);
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmMotifScorerProtein";
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
        private System.Windows.Forms.RichTextBox eProtein;
        private System.Windows.Forms.Panel pListTop;
        private System.Windows.Forms.Label lProteinSeq;
        private System.Windows.Forms.LinkLabel lLoadProteinSeq;
        private System.Windows.Forms.DataGridView dgScores;
        private System.Windows.Forms.Panel pScoresTop;
        private System.Windows.Forms.Label lScoreList;
        private System.Windows.Forms.LinkLabel lSaveScores;
        private System.Windows.Forms.OpenFileDialog dlgOpenProtein;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProtein;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSegment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNegMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatchScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWeightScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPriorityScore;
    }
}
