namespace PeSA.Windows
{
    partial class frmMotifValidationDesigner
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
            this.lNegativeThreshold = new System.Windows.Forms.Label();
            this.lPosThreshold = new System.Windows.Forms.Label();
            this.eWildtype = new System.Windows.Forms.TextBox();
            this.lWildtype = new System.Windows.Forms.Label();
            this.lValidationList = new System.Windows.Forms.Label();
            this.eOutput = new System.Windows.Forms.RichTextBox();
            this.eTemplate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pBottom = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
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
            this.pMotif.Location = new System.Drawing.Point(0, 115);
            this.pMotif.Name = "pMotif";
            this.pMotif.Size = new System.Drawing.Size(453, 469);
            this.pMotif.TabIndex = 1;
            // 
            // mdChart
            // 
            this.mdChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdChart.Image = null;
            this.mdChart.LabelText = "Chart";
            this.mdChart.Location = new System.Drawing.Point(0, 298);
            this.mdChart.Name = "mdChart";
            this.mdChart.Size = new System.Drawing.Size(453, 149);
            this.mdChart.TabIndex = 5;
            // 
            // mdNegative
            // 
            this.mdNegative.Dock = System.Windows.Forms.DockStyle.Top;
            this.mdNegative.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdNegative.Image = null;
            this.mdNegative.LabelText = "Negative Motif";
            this.mdNegative.Location = new System.Drawing.Point(0, 149);
            this.mdNegative.Margin = new System.Windows.Forms.Padding(4);
            this.mdNegative.Name = "mdNegative";
            this.mdNegative.Size = new System.Drawing.Size(453, 149);
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
            this.mdPositive.Size = new System.Drawing.Size(453, 149);
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
            this.splitMain.Panel2.Controls.Add(this.lValidationList);
            this.splitMain.Panel2.Controls.Add(this.eOutput);
            this.splitMain.Panel2.Controls.Add(this.eTemplate);
            this.splitMain.Panel2.Controls.Add(this.label1);
            this.splitMain.Panel2MinSize = 110;
            this.splitMain.Size = new System.Drawing.Size(800, 584);
            this.splitMain.SplitterDistance = 453;
            this.splitMain.TabIndex = 2;
            // 
            // pMotifTop
            // 
            this.pMotifTop.Controls.Add(this.lCutoff);
            this.pMotifTop.Controls.Add(this.eNegCutoff);
            this.pMotifTop.Controls.Add(this.ePosCutoff);
            this.pMotifTop.Controls.Add(this.lNegativeThreshold);
            this.pMotifTop.Controls.Add(this.lPosThreshold);
            this.pMotifTop.Controls.Add(this.eWildtype);
            this.pMotifTop.Controls.Add(this.lWildtype);
            this.pMotifTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pMotifTop.Location = new System.Drawing.Point(0, 0);
            this.pMotifTop.Name = "pMotifTop";
            this.pMotifTop.Size = new System.Drawing.Size(453, 115);
            this.pMotifTop.TabIndex = 2;
            // 
            // lCutoff
            // 
            this.lCutoff.AutoSize = true;
            this.lCutoff.Location = new System.Drawing.Point(62, 37);
            this.lCutoff.Name = "lCutoff";
            this.lCutoff.Size = new System.Drawing.Size(89, 13);
            this.lCutoff.TabIndex = 24;
            this.lCutoff.Text = "Specificity Cut-off";
            // 
            // eNegCutoff
            // 
            this.eNegCutoff.Location = new System.Drawing.Point(65, 79);
            this.eNegCutoff.Name = "eNegCutoff";
            this.eNegCutoff.Size = new System.Drawing.Size(47, 20);
            this.eNegCutoff.TabIndex = 23;
            this.toolTip1.SetToolTip(this.eNegCutoff, "Display peptides with at most cut-off matches with the negative motif");
            // 
            // ePosCutoff
            // 
            this.ePosCutoff.Location = new System.Drawing.Point(65, 53);
            this.ePosCutoff.Name = "ePosCutoff";
            this.ePosCutoff.Size = new System.Drawing.Size(47, 20);
            this.ePosCutoff.TabIndex = 22;
            this.toolTip1.SetToolTip(this.ePosCutoff, "Display peptides with at least cut-off matches with the positive motif");
            // 
            // lNegativeThreshold
            // 
            this.lNegativeThreshold.AutoSize = true;
            this.lNegativeThreshold.Location = new System.Drawing.Point(12, 82);
            this.lNegativeThreshold.Name = "lNegativeThreshold";
            this.lNegativeThreshold.Size = new System.Drawing.Size(50, 13);
            this.lNegativeThreshold.TabIndex = 13;
            this.lNegativeThreshold.Text = "Negative";
            // 
            // lPosThreshold
            // 
            this.lPosThreshold.AutoSize = true;
            this.lPosThreshold.Location = new System.Drawing.Point(12, 60);
            this.lPosThreshold.Name = "lPosThreshold";
            this.lPosThreshold.Size = new System.Drawing.Size(44, 13);
            this.lPosThreshold.TabIndex = 12;
            this.lPosThreshold.Text = "Positive";
            // 
            // eWildtype
            // 
            this.eWildtype.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eWildtype.Location = new System.Drawing.Point(65, 8);
            this.eWildtype.Name = "eWildtype";
            this.eWildtype.ReadOnly = true;
            this.eWildtype.Size = new System.Drawing.Size(385, 20);
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
            // lValidationList
            // 
            this.lValidationList.AutoSize = true;
            this.lValidationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lValidationList.Location = new System.Drawing.Point(3, 9);
            this.lValidationList.Name = "lValidationList";
            this.lValidationList.Size = new System.Drawing.Size(96, 17);
            this.lValidationList.TabIndex = 13;
            this.lValidationList.Text = "Validation List";
            // 
            // eOutput
            // 
            this.eOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eOutput.Location = new System.Drawing.Point(3, 60);
            this.eOutput.Margin = new System.Windows.Forms.Padding(2);
            this.eOutput.Name = "eOutput";
            this.eOutput.Size = new System.Drawing.Size(338, 522);
            this.eOutput.TabIndex = 10;
            this.eOutput.Text = "";
            // 
            // eTemplate
            // 
            this.eTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eTemplate.Location = new System.Drawing.Point(67, 34);
            this.eTemplate.Margin = new System.Windows.Forms.Padding(2);
            this.eTemplate.Name = "eTemplate";
            this.eTemplate.ReadOnly = true;
            this.eTemplate.Size = new System.Drawing.Size(265, 20);
            this.eTemplate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Template";
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnExport);
            this.pBottom.Controls.Add(this.btnGenerate);
            this.pBottom.Controls.Add(this.btnLoadMotif);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 584);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(800, 33);
            this.pBottom.TabIndex = 6;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(168, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 23);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export to Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(87, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnLoadMotif
            // 
            this.btnLoadMotif.Location = new System.Drawing.Point(3, 6);
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
            // frmMotifValidationDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.splitMain);
            this.Controls.Add(this.pBottom);
            this.Name = "frmMotifValidationDesigner";
            this.Text = "Motif Validation Designer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pMotif.ResumeLayout(false);
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            this.splitMain.Panel2.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitMain;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Button btnLoadMotif;
        private System.Windows.Forms.OpenFileDialog dlgOpenMotif;
        private System.Windows.Forms.OpenFileDialog dlgOpenPeptides;
        private System.Windows.Forms.Panel pMotifTop;
        private System.Windows.Forms.TextBox eWildtype;
        private System.Windows.Forms.Label lWildtype;
        private System.Windows.Forms.Label lNegativeThreshold;
        private System.Windows.Forms.Label lPosThreshold;
        private System.Windows.Forms.SaveFileDialog dlgExcelExport;
        private System.Windows.Forms.Label lCutoff;
        private System.Windows.Forms.TextBox eNegCutoff;
        private System.Windows.Forms.TextBox ePosCutoff;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.RichTextBox eOutput;
        private System.Windows.Forms.TextBox eTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lValidationList;
    }
}