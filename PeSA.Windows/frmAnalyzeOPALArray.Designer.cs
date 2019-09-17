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
            this.btnLoadQuantification = new System.Windows.Forms.Button();
            this.dlgOpenQuantification = new System.Windows.Forms.OpenFileDialog();
            this.trackThreshold = new System.Windows.Forms.TrackBar();
            this.dgQuantification = new System.Windows.Forms.DataGridView();
            this.cmsClipBoard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.pQuantificationTop = new System.Windows.Forms.Panel();
            this.cbPermutationXAxis = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.eThreshold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pBottom = new System.Windows.Forms.Panel();
            this.btnCreateMotif = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dlgOpenProject = new System.Windows.Forms.OpenFileDialog();
            this.dlgSaveProject = new System.Windows.Forms.SaveFileDialog();
            this.dlgExcelExport = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgNormalized = new System.Windows.Forms.DataGridView();
            this.pNormalizedTop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).BeginInit();
            this.cmsClipBoard.SuspendLayout();
            this.pQuantificationTop.SuspendLayout();
            this.pBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNormalized)).BeginInit();
            this.pNormalizedTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadQuantification
            // 
            this.btnLoadQuantification.AutoSize = true;
            this.btnLoadQuantification.Location = new System.Drawing.Point(106, 4);
            this.btnLoadQuantification.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadQuantification.Name = "btnLoadQuantification";
            this.btnLoadQuantification.Size = new System.Drawing.Size(83, 23);
            this.btnLoadQuantification.TabIndex = 1;
            this.btnLoadQuantification.Text = "Load from File";
            this.btnLoadQuantification.UseVisualStyleBackColor = true;
            this.btnLoadQuantification.Click += new System.EventHandler(this.btnLoadQuantification_Click);
            // 
            // dlgOpenQuantification
            // 
            this.dlgOpenQuantification.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm|Comma Delimited|*.csv";
            this.dlgOpenQuantification.Title = "Open Quantification Matrix";
            // 
            // trackThreshold
            // 
            this.trackThreshold.LargeChange = 1;
            this.trackThreshold.Location = new System.Drawing.Point(253, -2);
            this.trackThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.trackThreshold.Maximum = 100;
            this.trackThreshold.Name = "trackThreshold";
            this.trackThreshold.Size = new System.Drawing.Size(216, 45);
            this.trackThreshold.TabIndex = 3;
            this.trackThreshold.TickFrequency = 10;
            this.trackThreshold.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackThreshold.Value = 50;
            this.trackThreshold.ValueChanged += new System.EventHandler(this.trackThreshold_ValueChanged);
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
            this.dgQuantification.Size = new System.Drawing.Size(584, 231);
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
            this.pQuantificationTop.Controls.Add(this.cbPermutationXAxis);
            this.pQuantificationTop.Controls.Add(this.btnRun);
            this.pQuantificationTop.Controls.Add(this.label3);
            this.pQuantificationTop.Controls.Add(this.btnLoadQuantification);
            this.pQuantificationTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pQuantificationTop.Location = new System.Drawing.Point(0, 0);
            this.pQuantificationTop.Name = "pQuantificationTop";
            this.pQuantificationTop.Size = new System.Drawing.Size(584, 30);
            this.pQuantificationTop.TabIndex = 1;
            // 
            // cbPermutationXAxis
            // 
            this.cbPermutationXAxis.AutoSize = true;
            this.cbPermutationXAxis.Location = new System.Drawing.Point(203, 7);
            this.cbPermutationXAxis.Margin = new System.Windows.Forms.Padding(2);
            this.cbPermutationXAxis.Name = "cbPermutationXAxis";
            this.cbPermutationXAxis.Size = new System.Drawing.Size(117, 17);
            this.cbPermutationXAxis.TabIndex = 5;
            this.cbPermutationXAxis.Text = "X Axis: Permutation";
            this.cbPermutationXAxis.ThreeState = true;
            this.cbPermutationXAxis.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.AutoSize = true;
            this.btnRun.Location = new System.Drawing.Point(529, 4);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(50, 23);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantification";
            // 
            // eThreshold
            // 
            this.eThreshold.Location = new System.Drawing.Point(170, 2);
            this.eThreshold.Name = "eThreshold";
            this.eThreshold.Size = new System.Drawing.Size(78, 20);
            this.eThreshold.TabIndex = 7;
            this.eThreshold.Leave += new System.EventHandler(this.eThreshold_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Threshold";
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnCreateMotif);
            this.pBottom.Controls.Add(this.btnExport);
            this.pBottom.Controls.Add(this.btnLoad);
            this.pBottom.Controls.Add(this.btnSave);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 525);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(584, 36);
            this.pBottom.TabIndex = 4;
            // 
            // btnCreateMotif
            // 
            this.btnCreateMotif.Location = new System.Drawing.Point(346, 6);
            this.btnCreateMotif.Name = "btnCreateMotif";
            this.btnCreateMotif.Size = new System.Drawing.Size(117, 23);
            this.btnCreateMotif.TabIndex = 3;
            this.btnCreateMotif.Text = "Create Motif";
            this.btnCreateMotif.UseVisualStyleBackColor = true;
            this.btnCreateMotif.Click += new System.EventHandler(this.btnCreateMotif_Click);
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgQuantification);
            this.splitContainer1.Panel1.Controls.Add(this.pQuantificationTop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgNormalized);
            this.splitContainer1.Panel2.Controls.Add(this.pNormalizedTop);
            this.splitContainer1.Size = new System.Drawing.Size(584, 525);
            this.splitContainer1.SplitterDistance = 261;
            this.splitContainer1.TabIndex = 5;
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
            this.dgNormalized.Location = new System.Drawing.Point(0, 30);
            this.dgNormalized.Margin = new System.Windows.Forms.Padding(2);
            this.dgNormalized.Name = "dgNormalized";
            this.dgNormalized.ReadOnly = true;
            this.dgNormalized.RowHeadersVisible = false;
            this.dgNormalized.RowTemplate.Height = 28;
            this.dgNormalized.Size = new System.Drawing.Size(584, 230);
            this.dgNormalized.TabIndex = 1;
            // 
            // pNormalizedTop
            // 
            this.pNormalizedTop.Controls.Add(this.label2);
            this.pNormalizedTop.Controls.Add(this.eThreshold);
            this.pNormalizedTop.Controls.Add(this.label5);
            this.pNormalizedTop.Controls.Add(this.trackThreshold);
            this.pNormalizedTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNormalizedTop.Location = new System.Drawing.Point(0, 0);
            this.pNormalizedTop.Name = "pNormalizedTop";
            this.pNormalizedTop.Size = new System.Drawing.Size(584, 30);
            this.pNormalizedTop.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Normalized";
            // 
            // frmAnalyzeOPALArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pBottom);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAnalyzeOPALArray";
            this.Text = "OPAL Array Analysis";
            this.Load += new System.EventHandler(this.frmOPALArray_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).EndInit();
            this.cmsClipBoard.ResumeLayout(false);
            this.pQuantificationTop.ResumeLayout(false);
            this.pQuantificationTop.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNormalized)).EndInit();
            this.pNormalizedTop.ResumeLayout(false);
            this.pNormalizedTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoadQuantification;
        private System.Windows.Forms.OpenFileDialog dlgOpenQuantification;
        private System.Windows.Forms.TrackBar trackThreshold;
        private System.Windows.Forms.DataGridView dgQuantification;
        private System.Windows.Forms.Panel pQuantificationTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.TextBox eThreshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateMotif;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.OpenFileDialog dlgOpenProject;
        private System.Windows.Forms.SaveFileDialog dlgSaveProject;
        private System.Windows.Forms.SaveFileDialog dlgExcelExport;
        private System.Windows.Forms.ContextMenuStrip cmsClipBoard;
        private System.Windows.Forms.ToolStripMenuItem cmiPaste;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.CheckBox cbPermutationXAxis;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgNormalized;
        private System.Windows.Forms.Panel pNormalizedTop;
        private System.Windows.Forms.Label label2;
    }
}