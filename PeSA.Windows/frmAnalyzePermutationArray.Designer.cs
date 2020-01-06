namespace PeSA.Windows
{
    partial class frmAnalyzePermutationArray
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
            this.btnLoadQuantification = new System.Windows.Forms.Button();
            this.dlgOpenQuantification = new System.Windows.Forms.OpenFileDialog();
            this.trackThreshold = new System.Windows.Forms.TrackBar();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgQuantification = new System.Windows.Forms.DataGridView();
            this.cmsClipBoard = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.pPeptidesTop = new System.Windows.Forms.Panel();
            this.cbYAxisTopToBottom = new System.Windows.Forms.CheckBox();
            this.cbWildTypeXAxis = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgPeptides = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eThreshold = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnSaveMotif = new System.Windows.Forms.Button();
            this.dlgSaveMotif = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).BeginInit();
            this.cmsClipBoard.SuspendLayout();
            this.pPeptidesTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeptides)).BeginInit();
            this.panel2.SuspendLayout();
            this.pBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadQuantification
            // 
            this.btnLoadQuantification.AutoSize = true;
            this.btnLoadQuantification.Location = new System.Drawing.Point(106, 4);
            this.btnLoadQuantification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadQuantification.Name = "btnLoadQuantification";
            this.btnLoadQuantification.Size = new System.Drawing.Size(120, 23);
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
            this.trackThreshold.Location = new System.Drawing.Point(269, 0);
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
            this.splitContainer1.Panel1.Controls.Add(this.dgQuantification);
            this.splitContainer1.Panel1.Controls.Add(this.pPeptidesTop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgPeptides);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(884, 513);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 4;
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
            this.dgQuantification.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgQuantification.Name = "dgQuantification";
            this.dgQuantification.ReadOnly = true;
            this.dgQuantification.RowHeadersVisible = false;
            this.dgQuantification.RowTemplate.Height = 28;
            this.dgQuantification.Size = new System.Drawing.Size(884, 218);
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
            this.pPeptidesTop.Controls.Add(this.cbYAxisTopToBottom);
            this.pPeptidesTop.Controls.Add(this.cbWildTypeXAxis);
            this.pPeptidesTop.Controls.Add(this.btnRun);
            this.pPeptidesTop.Controls.Add(this.label3);
            this.pPeptidesTop.Controls.Add(this.btnLoadQuantification);
            this.pPeptidesTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pPeptidesTop.Location = new System.Drawing.Point(0, 0);
            this.pPeptidesTop.Name = "pPeptidesTop";
            this.pPeptidesTop.Size = new System.Drawing.Size(884, 30);
            this.pPeptidesTop.TabIndex = 1;
            // 
            // cbYAxisTopToBottom
            // 
            this.cbYAxisTopToBottom.AutoSize = true;
            this.cbYAxisTopToBottom.Location = new System.Drawing.Point(391, 7);
            this.cbYAxisTopToBottom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.cbWildTypeXAxis.Location = new System.Drawing.Point(269, 8);
            this.cbWildTypeXAxis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbWildTypeXAxis.Name = "cbWildTypeXAxis";
            this.cbWildTypeXAxis.Size = new System.Drawing.Size(109, 17);
            this.cbWildTypeXAxis.TabIndex = 5;
            this.cbWildTypeXAxis.Text = "X Axis: Wild Type";
            this.cbWildTypeXAxis.UseVisualStyleBackColor = true;
            this.cbWildTypeXAxis.CheckedChanged += new System.EventHandler(this.cbWildTypeXAxis_CheckedChanged);
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.AutoSize = true;
            this.btnRun.Location = new System.Drawing.Point(796, 4);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(80, 23);
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
            // dgPeptides
            // 
            this.dgPeptides.AllowUserToAddRows = false;
            this.dgPeptides.AllowUserToDeleteRows = false;
            this.dgPeptides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPeptides.ColumnHeadersVisible = false;
            this.dgPeptides.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPeptides.Location = new System.Drawing.Point(0, 30);
            this.dgPeptides.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgPeptides.Name = "dgPeptides";
            this.dgPeptides.ReadOnly = true;
            this.dgPeptides.RowHeadersVisible = false;
            this.dgPeptides.RowTemplate.Height = 28;
            this.dgPeptides.Size = new System.Drawing.Size(884, 232);
            this.dgPeptides.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.eThreshold);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.trackThreshold);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(884, 30);
            this.panel2.TabIndex = 3;
            // 
            // eThreshold
            // 
            this.eThreshold.Location = new System.Drawing.Point(186, 7);
            this.eThreshold.Name = "eThreshold";
            this.eThreshold.Size = new System.Drawing.Size(78, 20);
            this.eThreshold.TabIndex = 7;
            this.eThreshold.Leave += new System.EventHandler(this.eThreshold_Leave);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Threshold";
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnSaveMotif);
            this.pBottom.Controls.Add(this.btnCreateMotif);
            this.pBottom.Controls.Add(this.btnExport);
            this.pBottom.Controls.Add(this.btnLoad);
            this.pBottom.Controls.Add(this.btnSave);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 513);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(884, 36);
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
            // btnSaveMotif
            // 
            this.btnSaveMotif.Location = new System.Drawing.Point(469, 6);
            this.btnSaveMotif.Name = "btnSaveMotif";
            this.btnSaveMotif.Size = new System.Drawing.Size(117, 23);
            this.btnSaveMotif.TabIndex = 4;
            this.btnSaveMotif.Text = "Save Motif";
            this.btnSaveMotif.UseVisualStyleBackColor = true;
            this.btnSaveMotif.Click += new System.EventHandler(this.btnSaveMotif_Click);
            // 
            // dlgSaveMotif
            // 
            this.dlgSaveMotif.Filter = "PeSA Motif File|*.pmtf";
            this.dlgSaveMotif.Title = "Save Motif File";
            // 
            // frmAnalyzePermutationArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 549);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pBottom);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAnalyzePermutationArray";
            this.Text = "Permutation Array Analysis";
            this.Load += new System.EventHandler(this.frmPeptideArray_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgQuantification)).EndInit();
            this.cmsClipBoard.ResumeLayout(false);
            this.pPeptidesTop.ResumeLayout(false);
            this.pPeptidesTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPeptides)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLoadQuantification;
        private System.Windows.Forms.OpenFileDialog dlgOpenQuantification;
        private System.Windows.Forms.TrackBar trackThreshold;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgQuantification;
        private System.Windows.Forms.Panel pPeptidesTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
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
        private System.Windows.Forms.DataGridView dgPeptides;
        private System.Windows.Forms.ContextMenuStrip cmsClipBoard;
        private System.Windows.Forms.ToolStripMenuItem cmiPaste;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.CheckBox cbWildTypeXAxis;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox cbYAxisTopToBottom;
        private System.Windows.Forms.Button btnSaveMotif;
        private System.Windows.Forms.SaveFileDialog dlgSaveMotif;
    }
}