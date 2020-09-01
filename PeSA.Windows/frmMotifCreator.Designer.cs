namespace PeSA.Windows
{
    partial class frmMotifCreator
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
            this.label1 = new System.Windows.Forms.Label();
            this.dlgOpenPeptides = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label11 = new System.Windows.Forms.Label();
            this.ePeptideLength = new System.Windows.Forms.TextBox();
            this.lOutput = new System.Windows.Forms.Label();
            this.ePeptides = new System.Windows.Forms.RichTextBox();
            this.pMotif = new System.Windows.Forms.Panel();
            this.eOutput = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lQuestion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.eKeyPosition = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.eAminoAcid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.eFreqThreshold = new System.Windows.Forms.TextBox();
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.lLoadPeptides = new System.Windows.Forms.LinkLabel();
            this.pBottom = new System.Windows.Forms.Panel();
            this.btnRunScorer = new System.Windows.Forms.Button();
            this.btnSaveMotif = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmsRunScorer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmiPeptideScorer = new System.Windows.Forms.ToolStripMenuItem();
            this.cmiProteinScorer = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgSaveMotif = new System.Windows.Forms.SaveFileDialog();
            this.dlgExcelExport = new System.Windows.Forms.SaveFileDialog();
            this.linkRun = new System.Windows.Forms.LinkLabel();
            this.mdShifted = new PeSA.Windows.MotifDisplay();
            this.mdMain = new PeSA.Windows.MotifDisplay();
            this.pMotif.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            this.pBottom.SuspendLayout();
            this.cmsRunScorer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Peptide List";
            this.toolTip1.SetToolTip(this.label1, "You can manually enter the peptide list, use copy/paste or load from file using t" +
        "he button below.");
            // 
            // dlgOpenPeptides
            // 
            this.dlgOpenPeptides.FileName = "Peptides.txt";
            this.dlgOpenPeptides.Filter = "Text Files|*.txt|Excel Files|*.xls;*.xlsx;*.xlsm|Comma Delimited|*.csv";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Peptide Length";
            this.toolTip1.SetToolTip(this.label11, "Default: length of the first peptide");
            // 
            // ePeptideLength
            // 
            this.ePeptideLength.Location = new System.Drawing.Point(122, 10);
            this.ePeptideLength.Name = "ePeptideLength";
            this.ePeptideLength.Size = new System.Drawing.Size(55, 20);
            this.ePeptideLength.TabIndex = 44;
            this.toolTip1.SetToolTip(this.ePeptideLength, "Default: length of the first peptide");
            this.ePeptideLength.Leave += new System.EventHandler(this.ePeptideLength_Leave);
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOutput.Location = new System.Drawing.Point(3, 4);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(51, 17);
            this.lOutput.TabIndex = 13;
            this.lOutput.Text = "Output";
            this.toolTip1.SetToolTip(this.lOutput, "You can manually enter the peptide list, use copy/paste or load from file using t" +
        "he button below.");
            // 
            // ePeptides
            // 
            this.ePeptides.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ePeptides.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ePeptides.Location = new System.Drawing.Point(6, 30);
            this.ePeptides.Name = "ePeptides";
            this.ePeptides.Size = new System.Drawing.Size(208, 559);
            this.ePeptides.TabIndex = 38;
            this.ePeptides.Text = "";
            this.ePeptides.FontChanged += new System.EventHandler(this.ePeptides_FontChanged);
            this.ePeptides.TextChanged += new System.EventHandler(this.ePeptides_TextChanged);
            // 
            // pMotif
            // 
            this.pMotif.AutoScroll = true;
            this.pMotif.Controls.Add(this.eOutput);
            this.pMotif.Controls.Add(this.panel1);
            this.pMotif.Controls.Add(this.mdShifted);
            this.pMotif.Controls.Add(this.mdMain);
            this.pMotif.Controls.Add(this.panel3);
            this.pMotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMotif.Location = new System.Drawing.Point(0, 0);
            this.pMotif.Name = "pMotif";
            this.pMotif.Padding = new System.Windows.Forms.Padding(4);
            this.pMotif.Size = new System.Drawing.Size(428, 593);
            this.pMotif.TabIndex = 0;
            // 
            // eOutput
            // 
            this.eOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eOutput.Location = new System.Drawing.Point(4, 434);
            this.eOutput.Name = "eOutput";
            this.eOutput.Size = new System.Drawing.Size(420, 155);
            this.eOutput.TabIndex = 3;
            this.eOutput.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lOutput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 407);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 27);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.ePeptideLength);
            this.panel3.Controls.Add(this.lQuestion);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.eKeyPosition);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.eAminoAcid);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.eFreqThreshold);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 113);
            this.panel3.TabIndex = 2;
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(183, 62);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(13, 13);
            this.lQuestion.TabIndex = 43;
            this.lQuestion.Text = "?";
            this.lQuestion.Click += new System.EventHandler(this.lQuestion_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Key position";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Target Amino Acid";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Frequency Threshold";
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
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.linkRun);
            this.splitMain.Panel1.Controls.Add(this.lLoadPeptides);
            this.splitMain.Panel1.Controls.Add(this.ePeptides);
            this.splitMain.Panel1.Controls.Add(this.label1);
            this.splitMain.Panel1MinSize = 220;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.pMotif);
            this.splitMain.Size = new System.Drawing.Size(652, 593);
            this.splitMain.SplitterDistance = 220;
            this.splitMain.TabIndex = 40;
            // 
            // lLoadPeptides
            // 
            this.lLoadPeptides.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lLoadPeptides.AutoSize = true;
            this.lLoadPeptides.Location = new System.Drawing.Point(141, 13);
            this.lLoadPeptides.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lLoadPeptides.Name = "lLoadPeptides";
            this.lLoadPeptides.Size = new System.Drawing.Size(73, 13);
            this.lLoadPeptides.TabIndex = 39;
            this.lLoadPeptides.TabStop = true;
            this.lLoadPeptides.Text = "Load from File";
            this.lLoadPeptides.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLoadPeptides_LinkClicked);
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnRunScorer);
            this.pBottom.Controls.Add(this.btnSaveMotif);
            this.pBottom.Controls.Add(this.btnExport);
            this.pBottom.Controls.Add(this.btnLoad);
            this.pBottom.Controls.Add(this.btnSave);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 593);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(652, 36);
            this.pBottom.TabIndex = 41;
            // 
            // btnRunScorer
            // 
            this.btnRunScorer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunScorer.Location = new System.Drawing.Point(424, 6);
            this.btnRunScorer.Name = "btnRunScorer";
            this.btnRunScorer.Size = new System.Drawing.Size(105, 23);
            this.btnRunScorer.TabIndex = 5;
            this.btnRunScorer.Text = "Run Scorer";
            this.btnRunScorer.UseVisualStyleBackColor = true;
            this.btnRunScorer.Click += new System.EventHandler(this.btnRunScorer_Click);
            // 
            // btnSaveMotif
            // 
            this.btnSaveMotif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveMotif.Location = new System.Drawing.Point(535, 6);
            this.btnSaveMotif.Name = "btnSaveMotif";
            this.btnSaveMotif.Size = new System.Drawing.Size(105, 23);
            this.btnSaveMotif.TabIndex = 4;
            this.btnSaveMotif.Text = "Save Motif";
            this.btnSaveMotif.UseVisualStyleBackColor = true;
            this.btnSaveMotif.Click += new System.EventHandler(this.btnSaveMotif_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.Maroon;
            this.btnExport.Location = new System.Drawing.Point(234, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(105, 23);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Visible = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Maroon;
            this.btnLoad.Location = new System.Drawing.Point(123, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(105, 23);
            this.btnLoad.TabIndex = 1;
            this.btnLoad.Text = "Load Project";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Maroon;
            this.btnSave.Location = new System.Drawing.Point(12, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save Project";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            // 
            // cmsRunScorer
            // 
            this.cmsRunScorer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmiPeptideScorer,
            this.cmiProteinScorer});
            this.cmsRunScorer.Name = "cmsRunScorer";
            this.cmsRunScorer.Size = new System.Drawing.Size(151, 48);
            // 
            // cmiPeptideScorer
            // 
            this.cmiPeptideScorer.Name = "cmiPeptideScorer";
            this.cmiPeptideScorer.Size = new System.Drawing.Size(150, 22);
            this.cmiPeptideScorer.Text = "Peptide Scorer";
            this.cmiPeptideScorer.Click += new System.EventHandler(this.cmiPeptideScorer_Click);
            // 
            // cmiProteinScorer
            // 
            this.cmiProteinScorer.Name = "cmiProteinScorer";
            this.cmiProteinScorer.Size = new System.Drawing.Size(150, 22);
            this.cmiProteinScorer.Text = "Protein Scorer";
            this.cmiProteinScorer.Click += new System.EventHandler(this.cmiProteinScorer_Click);
            // 
            // dlgSaveMotif
            // 
            this.dlgSaveMotif.Filter = "PeSA Motif File|*.pmtf";
            this.dlgSaveMotif.Title = "Save Motif File";
            // 
            // dlgExcelExport
            // 
            this.dlgExcelExport.Filter = "Excel Files|*.xlsx;*.xlsm";
            this.dlgExcelExport.Title = "Export to Excel";
            // 
            // linkRun
            // 
            this.linkRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkRun.AutoSize = true;
            this.linkRun.Location = new System.Drawing.Point(110, 13);
            this.linkRun.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkRun.Name = "linkRun";
            this.linkRun.Size = new System.Drawing.Size(27, 13);
            this.linkRun.TabIndex = 40;
            this.linkRun.TabStop = true;
            this.linkRun.Text = "Run";
            this.linkRun.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRun_LinkClicked);
            // 
            // mdShifted
            // 
            this.mdShifted.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdShifted.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdShifted.Image = null;
            this.mdShifted.LabelText = "Shifted Motif";
            this.mdShifted.Location = new System.Drawing.Point(4, 262);
            this.mdShifted.Margin = new System.Windows.Forms.Padding(4);
            this.mdShifted.Name = "mdShifted";
            this.mdShifted.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.mdShifted.Size = new System.Drawing.Size(420, 145);
            this.mdShifted.TabIndex = 1;
            this.mdShifted.Visible = false;
            // 
            // mdMain
            // 
            this.mdMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdMain.Image = null;
            this.mdMain.LabelText = "Motif";
            this.mdMain.Location = new System.Drawing.Point(4, 117);
            this.mdMain.Margin = new System.Windows.Forms.Padding(4);
            this.mdMain.Name = "mdMain";
            this.mdMain.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.mdMain.Size = new System.Drawing.Size(420, 145);
            this.mdMain.TabIndex = 0;
            // 
            // frmMotifCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 629);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pBottom);
            this.Name = "frmMotifCreator";
            this.Text = "Create Sequence Motif from Peptide List";
            this.pMotif.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel1.PerformLayout();
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            this.pBottom.ResumeLayout(false);
            this.cmsRunScorer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog dlgOpenPeptides;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RichTextBox ePeptides;
        private System.Windows.Forms.Panel pMotif;
        private MotifDisplay mdShifted;
        private MotifDisplay mdMain;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ePeptideLength;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox eKeyPosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox eAminoAcid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox eFreqThreshold;
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.RichTextBox eOutput;
        private System.Windows.Forms.LinkLabel lLoadPeptides;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Button btnRunScorer;
        private System.Windows.Forms.Button btnSaveMotif;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ContextMenuStrip cmsRunScorer;
        private System.Windows.Forms.ToolStripMenuItem cmiPeptideScorer;
        private System.Windows.Forms.ToolStripMenuItem cmiProteinScorer;
        private System.Windows.Forms.SaveFileDialog dlgSaveMotif;
        private System.Windows.Forms.SaveFileDialog dlgExcelExport;
        private System.Windows.Forms.LinkLabel linkRun;
    }
}