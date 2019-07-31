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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMotifCreator));
            this.eOutput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadPeptideList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.eMotifWidth = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.eMotifHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.eKeyPosition = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ePeptideLength = new System.Windows.Forms.TextBox();
            this.lAminoAcid = new System.Windows.Forms.Label();
            this.eAminoAcid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.eThreshold = new System.Windows.Forms.TextBox();
            this.btnCreateMotif = new System.Windows.Forms.Button();
            this.dlgOpenPeptides = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lQuestion = new System.Windows.Forms.Label();
            this.lOutput = new System.Windows.Forms.Label();
            this.ePeptides = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // eOutput
            // 
            this.eOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eOutput.Location = new System.Drawing.Point(240, 135);
            this.eOutput.Margin = new System.Windows.Forms.Padding(2);
            this.eOutput.Name = "eOutput";
            this.eOutput.Size = new System.Drawing.Size(331, 267);
            this.eOutput.TabIndex = 11;
            this.eOutput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Peptide List";
            this.toolTip1.SetToolTip(this.label1, "You can manually enter the peptide list, use copy/paste or load from file using t" +
        "he button below.");
            // 
            // btnLoadPeptideList
            // 
            this.btnLoadPeptideList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLoadPeptideList.Location = new System.Drawing.Point(15, 408);
            this.btnLoadPeptideList.Name = "btnLoadPeptideList";
            this.btnLoadPeptideList.Size = new System.Drawing.Size(114, 23);
            this.btnLoadPeptideList.TabIndex = 13;
            this.btnLoadPeptideList.Text = "Load from File";
            this.btnLoadPeptideList.UseVisualStyleBackColor = true;
            this.btnLoadPeptideList.Click += new System.EventHandler(this.btnLoadPeptideList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Motif Width";
            // 
            // eMotifWidth
            // 
            this.eMotifWidth.Location = new System.Drawing.Point(507, 15);
            this.eMotifWidth.Name = "eMotifWidth";
            this.eMotifWidth.Size = new System.Drawing.Size(55, 20);
            this.eMotifWidth.TabIndex = 30;
            this.eMotifWidth.Text = "800";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Motif Height";
            // 
            // eMotifHeight
            // 
            this.eMotifHeight.Location = new System.Drawing.Point(507, 38);
            this.eMotifHeight.Name = "eMotifHeight";
            this.eMotifHeight.Size = new System.Drawing.Size(55, 20);
            this.eMotifHeight.TabIndex = 31;
            this.eMotifHeight.Text = "200";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(239, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Key position";
            this.toolTip1.SetToolTip(this.label3, "Default: Center position");
            // 
            // eKeyPosition
            // 
            this.eKeyPosition.Location = new System.Drawing.Point(349, 37);
            this.eKeyPosition.Name = "eKeyPosition";
            this.eKeyPosition.Size = new System.Drawing.Size(55, 20);
            this.eKeyPosition.TabIndex = 22;
            this.toolTip1.SetToolTip(this.eKeyPosition, "Default: Center position");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Peptide Length";
            this.toolTip1.SetToolTip(this.label2, "Default: length of the first peptide");
            // 
            // ePeptideLength
            // 
            this.ePeptideLength.Location = new System.Drawing.Point(349, 14);
            this.ePeptideLength.Name = "ePeptideLength";
            this.ePeptideLength.Size = new System.Drawing.Size(55, 20);
            this.ePeptideLength.TabIndex = 21;
            this.toolTip1.SetToolTip(this.ePeptideLength, "Default: length of the first peptide");
            // 
            // lAminoAcid
            // 
            this.lAminoAcid.AutoSize = true;
            this.lAminoAcid.Location = new System.Drawing.Point(239, 65);
            this.lAminoAcid.Name = "lAminoAcid";
            this.lAminoAcid.Size = new System.Drawing.Size(94, 13);
            this.lAminoAcid.TabIndex = 27;
            this.lAminoAcid.Text = "Target Amino Acid";
            // 
            // eAminoAcid
            // 
            this.eAminoAcid.Location = new System.Drawing.Point(349, 61);
            this.eAminoAcid.Name = "eAminoAcid";
            this.eAminoAcid.Size = new System.Drawing.Size(55, 20);
            this.eAminoAcid.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Frequency Threshold";
            this.toolTip1.SetToolTip(this.label6, "Amino acids with less frequency will be merged as X.");
            // 
            // eThreshold
            // 
            this.eThreshold.Location = new System.Drawing.Point(349, 84);
            this.eThreshold.Name = "eThreshold";
            this.eThreshold.Size = new System.Drawing.Size(55, 20);
            this.eThreshold.TabIndex = 24;
            this.eThreshold.Text = "0.1";
            this.toolTip1.SetToolTip(this.eThreshold, "Amino acids with less frequency will be merged as X.");
            // 
            // btnCreateMotif
            // 
            this.btnCreateMotif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreateMotif.Location = new System.Drawing.Point(134, 408);
            this.btnCreateMotif.Name = "btnCreateMotif";
            this.btnCreateMotif.Size = new System.Drawing.Size(89, 23);
            this.btnCreateMotif.TabIndex = 34;
            this.btnCreateMotif.Text = "Create Motif";
            this.btnCreateMotif.UseVisualStyleBackColor = true;
            this.btnCreateMotif.Click += new System.EventHandler(this.btnCreateMotif_Click);
            // 
            // dlgOpenPeptides
            // 
            this.dlgOpenPeptides.FileName = "Peptides.txt";
            this.dlgOpenPeptides.Filter = "Text Files|*.txt|Excel Files|*.xls;*.xlsx;*.xlsm|Comma Delimited|*.csv";
            // 
            // lQuestion
            // 
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(410, 65);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(13, 13);
            this.lQuestion.TabIndex = 36;
            this.lQuestion.Text = "?";
            this.toolTip1.SetToolTip(this.lQuestion, resources.GetString("lQuestion.ToolTip"));
            this.lQuestion.Click += new System.EventHandler(this.lQuestion_Click);
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Location = new System.Drawing.Point(239, 120);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(39, 13);
            this.lOutput.TabIndex = 37;
            this.lOutput.Text = "Output";
            // 
            // ePeptides
            // 
            this.ePeptides.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ePeptides.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ePeptides.Location = new System.Drawing.Point(15, 30);
            this.ePeptides.Name = "ePeptides";
            this.ePeptides.Size = new System.Drawing.Size(208, 372);
            this.ePeptides.TabIndex = 38;
            this.ePeptides.Text = "";
            // 
            // frmMotifCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 443);
            this.Controls.Add(this.ePeptides);
            this.Controls.Add(this.lOutput);
            this.Controls.Add(this.lQuestion);
            this.Controls.Add(this.btnCreateMotif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eMotifWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.eMotifHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eKeyPosition);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ePeptideLength);
            this.Controls.Add(this.lAminoAcid);
            this.Controls.Add(this.eAminoAcid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.eThreshold);
            this.Controls.Add(this.btnLoadPeptideList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eOutput);
            this.Name = "frmMotifCreator";
            this.Text = "Create Motif from Peptide List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox eOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoadPeptideList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox eMotifWidth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox eMotifHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eKeyPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ePeptideLength;
        private System.Windows.Forms.Label lAminoAcid;
        private System.Windows.Forms.TextBox eAminoAcid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eThreshold;
        private System.Windows.Forms.Button btnCreateMotif;
        private System.Windows.Forms.OpenFileDialog dlgOpenPeptides;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lQuestion;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.RichTextBox ePeptides;
    }
}