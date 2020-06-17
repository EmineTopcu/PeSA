namespace PeSA.Windows
{
    partial class frmSettings
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
            this.lWidth = new System.Windows.Forms.Label();
            this.eMotifWidth = new System.Windows.Forms.TextBox();
            this.lHeight = new System.Windows.Forms.Label();
            this.eMotifHeight = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSave = new System.Windows.Forms.Button();
            this.l = new System.Windows.Forms.Label();
            this.eMaxAAPerColumn = new System.Windows.Forms.TextBox();
            this.lThreshold = new System.Windows.Forms.Label();
            this.eThreshold = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkResetColors = new System.Windows.Forms.LinkLabel();
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tColors = new System.Windows.Forms.TabPage();
            this.pColors = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tMotif = new System.Windows.Forms.TabPage();
            this.tArray = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lColumnNumber = new System.Windows.Forms.Label();
            this.eRowNumber = new System.Windows.Forms.TextBox();
            this.lRowNumber = new System.Windows.Forms.Label();
            this.eColumnNumber = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lYAxis = new System.Windows.Forms.Label();
            this.rbBottomToTop = new System.Windows.Forms.RadioButton();
            this.rbTopToBottom = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lAxisMode = new System.Windows.Forms.Label();
            this.rbRowFirst = new System.Windows.Forms.RadioButton();
            this.rbColumnsFirst = new System.Windows.Forms.RadioButton();
            this.pBottom = new System.Windows.Forms.Panel();
            this.tabSettings.SuspendLayout();
            this.tColors.SuspendLayout();
            this.pColors.SuspendLayout();
            this.tMotif.SuspendLayout();
            this.tArray.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(8, 18);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(35, 13);
            this.lWidth.TabIndex = 37;
            this.lWidth.Text = "Width";
            // 
            // eMotifWidth
            // 
            this.eMotifWidth.Location = new System.Drawing.Point(49, 15);
            this.eMotifWidth.Name = "eMotifWidth";
            this.eMotifWidth.Size = new System.Drawing.Size(55, 20);
            this.eMotifWidth.TabIndex = 34;
            this.eMotifWidth.Text = "800";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(120, 18);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(38, 13);
            this.lHeight.TabIndex = 36;
            this.lHeight.Text = "Height";
            // 
            // eMotifHeight
            // 
            this.eMotifHeight.Location = new System.Drawing.Point(161, 15);
            this.eMotifHeight.Name = "eMotifHeight";
            this.eMotifHeight.Size = new System.Drawing.Size(55, 20);
            this.eMotifHeight.TabIndex = 35;
            this.eMotifHeight.Text = "200";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(9, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(8, 44);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(149, 13);
            this.l.TabIndex = 43;
            this.l.Text = "Maximum amino acids/column";
            this.toolTip1.SetToolTip(this.l, "Used for motifs created by permutation arrays");
            // 
            // eMaxAAPerColumn
            // 
            this.eMaxAAPerColumn.Location = new System.Drawing.Point(161, 41);
            this.eMaxAAPerColumn.Name = "eMaxAAPerColumn";
            this.eMaxAAPerColumn.Size = new System.Drawing.Size(55, 20);
            this.eMaxAAPerColumn.TabIndex = 36;
            this.eMaxAAPerColumn.Text = "10";
            this.toolTip1.SetToolTip(this.eMaxAAPerColumn, "Used for motifs created by permutation arrays");
            // 
            // lThreshold
            // 
            this.lThreshold.AutoSize = true;
            this.lThreshold.Location = new System.Drawing.Point(9, 69);
            this.lThreshold.Name = "lThreshold";
            this.lThreshold.Size = new System.Drawing.Size(107, 13);
            this.lThreshold.TabIndex = 45;
            this.lThreshold.Text = "Frequency Threshold";
            // 
            // eThreshold
            // 
            this.eThreshold.Location = new System.Drawing.Point(162, 66);
            this.eThreshold.Name = "eThreshold";
            this.eThreshold.Size = new System.Drawing.Size(55, 20);
            this.eThreshold.TabIndex = 38;
            this.eThreshold.Text = "0.1";
            this.toolTip1.SetToolTip(this.eThreshold, "Used for motifs created by a peptide list");
            // 
            // linkResetColors
            // 
            this.linkResetColors.AutoSize = true;
            this.linkResetColors.Location = new System.Drawing.Point(2, 189);
            this.linkResetColors.Name = "linkResetColors";
            this.linkResetColors.Size = new System.Drawing.Size(67, 13);
            this.linkResetColors.TabIndex = 0;
            this.linkResetColors.TabStop = true;
            this.linkResetColors.Text = "Reset Colors";
            this.toolTip1.SetToolTip(this.linkResetColors, "Acidic polar (DE): Red\r\nBasic polar (RHK): Green\r\nNeutral polar (NQSTY): Blue\r\nNo" +
        "npolar (AILMFWV): Pink\r\nSpecial (CGP): Black\r\nNonstandard (OU): Green");
            this.linkResetColors.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkResetColors_LinkClicked);
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tColors);
            this.tabSettings.Controls.Add(this.tMotif);
            this.tabSettings.Controls.Add(this.tArray);
            this.tabSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSettings.Location = new System.Drawing.Point(0, 0);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(290, 250);
            this.tabSettings.TabIndex = 47;
            // 
            // tColors
            // 
            this.tColors.Controls.Add(this.pColors);
            this.tColors.Controls.Add(this.label1);
            this.tColors.Location = new System.Drawing.Point(4, 22);
            this.tColors.Name = "tColors";
            this.tColors.Padding = new System.Windows.Forms.Padding(3);
            this.tColors.Size = new System.Drawing.Size(282, 224);
            this.tColors.TabIndex = 1;
            this.tColors.Text = "Colors";
            this.tColors.UseVisualStyleBackColor = true;
            // 
            // pColors
            // 
            this.pColors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pColors.Controls.Add(this.linkResetColors);
            this.pColors.Location = new System.Drawing.Point(0, 19);
            this.pColors.Name = "pColors";
            this.pColors.Size = new System.Drawing.Size(282, 205);
            this.pColors.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amino Acid Colors";
            // 
            // tMotif
            // 
            this.tMotif.Controls.Add(this.lWidth);
            this.tMotif.Controls.Add(this.eMaxAAPerColumn);
            this.tMotif.Controls.Add(this.eMotifWidth);
            this.tMotif.Controls.Add(this.l);
            this.tMotif.Controls.Add(this.lHeight);
            this.tMotif.Controls.Add(this.eMotifHeight);
            this.tMotif.Controls.Add(this.eThreshold);
            this.tMotif.Controls.Add(this.lThreshold);
            this.tMotif.Location = new System.Drawing.Point(4, 22);
            this.tMotif.Name = "tMotif";
            this.tMotif.Padding = new System.Windows.Forms.Padding(3);
            this.tMotif.Size = new System.Drawing.Size(282, 179);
            this.tMotif.TabIndex = 0;
            this.tMotif.Text = "Motif";
            this.tMotif.UseVisualStyleBackColor = true;
            // 
            // tArray
            // 
            this.tArray.Controls.Add(this.panel3);
            this.tArray.Controls.Add(this.panel2);
            this.tArray.Controls.Add(this.panel1);
            this.tArray.Location = new System.Drawing.Point(4, 22);
            this.tArray.Name = "tArray";
            this.tArray.Size = new System.Drawing.Size(282, 179);
            this.tArray.TabIndex = 2;
            this.tArray.Text = "Array";
            this.tArray.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lColumnNumber);
            this.panel3.Controls.Add(this.eRowNumber);
            this.panel3.Controls.Add(this.lRowNumber);
            this.panel3.Controls.Add(this.eColumnNumber);
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 37);
            this.panel3.TabIndex = 62;
            // 
            // lColumnNumber
            // 
            this.lColumnNumber.AutoSize = true;
            this.lColumnNumber.Location = new System.Drawing.Point(3, 13);
            this.lColumnNumber.Name = "lColumnNumber";
            this.lColumnNumber.Size = new System.Drawing.Size(69, 13);
            this.lColumnNumber.TabIndex = 56;
            this.lColumnNumber.Text = "# of Columns";
            // 
            // eRowNumber
            // 
            this.eRowNumber.Location = new System.Drawing.Point(210, 10);
            this.eRowNumber.Name = "eRowNumber";
            this.eRowNumber.Size = new System.Drawing.Size(55, 20);
            this.eRowNumber.TabIndex = 54;
            this.eRowNumber.Text = "20";
            // 
            // lRowNumber
            // 
            this.lRowNumber.AutoSize = true;
            this.lRowNumber.Location = new System.Drawing.Point(148, 13);
            this.lRowNumber.Name = "lRowNumber";
            this.lRowNumber.Size = new System.Drawing.Size(56, 13);
            this.lRowNumber.TabIndex = 55;
            this.lRowNumber.Text = "# of Rows";
            // 
            // eColumnNumber
            // 
            this.eColumnNumber.Location = new System.Drawing.Point(78, 10);
            this.eColumnNumber.Name = "eColumnNumber";
            this.eColumnNumber.Size = new System.Drawing.Size(55, 20);
            this.eColumnNumber.TabIndex = 53;
            this.eColumnNumber.Text = "30";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lYAxis);
            this.panel2.Controls.Add(this.rbBottomToTop);
            this.panel2.Controls.Add(this.rbTopToBottom);
            this.panel2.Location = new System.Drawing.Point(0, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 54);
            this.panel2.TabIndex = 61;
            // 
            // lYAxis
            // 
            this.lYAxis.AutoSize = true;
            this.lYAxis.Location = new System.Drawing.Point(3, 9);
            this.lYAxis.Name = "lYAxis";
            this.lYAxis.Size = new System.Drawing.Size(154, 13);
            this.lYAxis.TabIndex = 52;
            this.lYAxis.Text = "Wild Type Sequence on Y Axis";
            // 
            // rbBottomToTop
            // 
            this.rbBottomToTop.AutoSize = true;
            this.rbBottomToTop.Location = new System.Drawing.Point(104, 28);
            this.rbBottomToTop.Name = "rbBottomToTop";
            this.rbBottomToTop.Size = new System.Drawing.Size(159, 17);
            this.rbBottomToTop.TabIndex = 51;
            this.rbBottomToTop.Text = "Bottom to Top (Left to Right)";
            this.rbBottomToTop.UseVisualStyleBackColor = true;
            // 
            // rbTopToBottom
            // 
            this.rbTopToBottom.AutoSize = true;
            this.rbTopToBottom.Checked = true;
            this.rbTopToBottom.Location = new System.Drawing.Point(6, 28);
            this.rbTopToBottom.Name = "rbTopToBottom";
            this.rbTopToBottom.Size = new System.Drawing.Size(92, 17);
            this.rbTopToBottom.TabIndex = 50;
            this.rbTopToBottom.TabStop = true;
            this.rbTopToBottom.Text = "Top to Bottom";
            this.rbTopToBottom.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lAxisMode);
            this.panel1.Controls.Add(this.rbRowFirst);
            this.panel1.Controls.Add(this.rbColumnsFirst);
            this.panel1.Location = new System.Drawing.Point(0, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 56);
            this.panel1.TabIndex = 60;
            // 
            // lAxisMode
            // 
            this.lAxisMode.AutoSize = true;
            this.lAxisMode.Location = new System.Drawing.Point(3, 9);
            this.lAxisMode.Name = "lAxisMode";
            this.lAxisMode.Size = new System.Drawing.Size(139, 13);
            this.lAxisMode.TabIndex = 59;
            this.lAxisMode.Text = "Peptide placement on array:";
            // 
            // rbRowFirst
            // 
            this.rbRowFirst.AutoSize = true;
            this.rbRowFirst.Checked = true;
            this.rbRowFirst.Location = new System.Drawing.Point(6, 28);
            this.rbRowFirst.Name = "rbRowFirst";
            this.rbRowFirst.Size = new System.Drawing.Size(71, 17);
            this.rbRowFirst.TabIndex = 57;
            this.rbRowFirst.TabStop = true;
            this.rbRowFirst.Text = "Rows first";
            this.rbRowFirst.UseVisualStyleBackColor = true;
            // 
            // rbColumnsFirst
            // 
            this.rbColumnsFirst.AutoSize = true;
            this.rbColumnsFirst.Location = new System.Drawing.Point(104, 28);
            this.rbColumnsFirst.Name = "rbColumnsFirst";
            this.rbColumnsFirst.Size = new System.Drawing.Size(84, 17);
            this.rbColumnsFirst.TabIndex = 58;
            this.rbColumnsFirst.Text = "Columns first";
            this.rbColumnsFirst.UseVisualStyleBackColor = true;
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnSave);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 250);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(290, 36);
            this.pBottom.TabIndex = 48;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 286);
            this.Controls.Add(this.tabSettings);
            this.Controls.Add(this.pBottom);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(306, 325);
            this.Name = "frmSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Settings";
            this.toolTip1.SetToolTip(this, "Used for motifs created by a peptide list");
            this.Load += new System.EventHandler(this.frmMotifSettings_Load);
            this.tabSettings.ResumeLayout(false);
            this.tColors.ResumeLayout(false);
            this.tColors.PerformLayout();
            this.pColors.ResumeLayout(false);
            this.pColors.PerformLayout();
            this.tMotif.ResumeLayout(false);
            this.tMotif.PerformLayout();
            this.tArray.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.TextBox eMotifWidth;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.TextBox eMotifHeight;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox eMaxAAPerColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lThreshold;
        private System.Windows.Forms.TextBox eThreshold;
        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tColors;
        private System.Windows.Forms.TabPage tMotif;
        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.LinkLabel linkResetColors;
        private System.Windows.Forms.TabPage tArray;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lColumnNumber;
        private System.Windows.Forms.TextBox eRowNumber;
        private System.Windows.Forms.Label lRowNumber;
        private System.Windows.Forms.TextBox eColumnNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lYAxis;
        private System.Windows.Forms.RadioButton rbBottomToTop;
        private System.Windows.Forms.RadioButton rbTopToBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lAxisMode;
        private System.Windows.Forms.RadioButton rbRowFirst;
        private System.Windows.Forms.RadioButton rbColumnsFirst;
        private System.Windows.Forms.Panel pColors;
    }
}