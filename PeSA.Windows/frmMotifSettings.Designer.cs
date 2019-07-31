namespace PeSA.Windows
{
    partial class frmMotifSettings
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.pColors = new System.Windows.Forms.Panel();
            this.l = new System.Windows.Forms.Label();
            this.eMaxAAPerColumn = new System.Windows.Forms.TextBox();
            this.lThreshold = new System.Windows.Forms.Label();
            this.eThreshold = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDefaultColors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(18, 14);
            this.lWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(50, 20);
            this.lWidth.TabIndex = 37;
            this.lWidth.Text = "Width";
            // 
            // eMotifWidth
            // 
            this.eMotifWidth.Location = new System.Drawing.Point(80, 9);
            this.eMotifWidth.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eMotifWidth.Name = "eMotifWidth";
            this.eMotifWidth.Size = new System.Drawing.Size(80, 26);
            this.eMotifWidth.TabIndex = 34;
            this.eMotifWidth.Text = "800";
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(186, 14);
            this.lHeight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(56, 20);
            this.lHeight.TabIndex = 36;
            this.lHeight.Text = "Height";
            // 
            // eMotifHeight
            // 
            this.eMotifHeight.Location = new System.Drawing.Point(248, 9);
            this.eMotifHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eMotifHeight.Name = "eMotifHeight";
            this.eMotifHeight.Size = new System.Drawing.Size(80, 26);
            this.eMotifHeight.TabIndex = 35;
            this.eMotifHeight.Text = "200";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Motif Colors";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(219, 462);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pColors
            // 
            this.pColors.AutoSize = true;
            this.pColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColors.Location = new System.Drawing.Point(24, 168);
            this.pColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pColors.Name = "pColors";
            this.pColors.Size = new System.Drawing.Size(306, 280);
            this.pColors.TabIndex = 41;
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.Location = new System.Drawing.Point(18, 54);
            this.l.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(219, 20);
            this.l.TabIndex = 43;
            this.l.Text = "Maximum amino acids/column";
            this.toolTip1.SetToolTip(this.l, "Used for motifs created by permutation arrays");
            // 
            // eMaxAAPerColumn
            // 
            this.eMaxAAPerColumn.Location = new System.Drawing.Point(248, 49);
            this.eMaxAAPerColumn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eMaxAAPerColumn.Name = "eMaxAAPerColumn";
            this.eMaxAAPerColumn.Size = new System.Drawing.Size(80, 26);
            this.eMaxAAPerColumn.TabIndex = 36;
            this.eMaxAAPerColumn.Text = "10";
            this.toolTip1.SetToolTip(this.eMaxAAPerColumn, "Used for motifs created by permutation arrays");
            // 
            // lThreshold
            // 
            this.lThreshold.AutoSize = true;
            this.lThreshold.Location = new System.Drawing.Point(20, 92);
            this.lThreshold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lThreshold.Name = "lThreshold";
            this.lThreshold.Size = new System.Drawing.Size(158, 20);
            this.lThreshold.TabIndex = 45;
            this.lThreshold.Text = "Frequency Threshold";
            // 
            // eThreshold
            // 
            this.eThreshold.Location = new System.Drawing.Point(249, 88);
            this.eThreshold.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eThreshold.Name = "eThreshold";
            this.eThreshold.Size = new System.Drawing.Size(80, 26);
            this.eThreshold.TabIndex = 38;
            this.eThreshold.Text = "0.1";
            this.toolTip1.SetToolTip(this.eThreshold, "Used for motifs created by a peptide list");
            // 
            // btnDefaultColors
            // 
            this.btnDefaultColors.AutoSize = true;
            this.btnDefaultColors.Location = new System.Drawing.Point(26, 462);
            this.btnDefaultColors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDefaultColors.Name = "btnDefaultColors";
            this.btnDefaultColors.Size = new System.Drawing.Size(124, 35);
            this.btnDefaultColors.TabIndex = 46;
            this.btnDefaultColors.Text = "Default Colors";
            this.toolTip1.SetToolTip(this.btnDefaultColors, "Acidic polar (DE): Red\r\nBasic polar (RHK): Green\r\nNeutral polar (NQSTY): Blue\r\nNo" +
        "npolar (AILMFWV): Pink\r\nSpecial (CGP): Black");
            this.btnDefaultColors.UseVisualStyleBackColor = true;
            this.btnDefaultColors.Click += new System.EventHandler(this.btnDefaultColors_Click);
            // 
            // frmMotifSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 504);
            this.Controls.Add(this.btnDefaultColors);
            this.Controls.Add(this.lThreshold);
            this.Controls.Add(this.eThreshold);
            this.Controls.Add(this.l);
            this.Controls.Add(this.eMaxAAPerColumn);
            this.Controls.Add(this.pColors);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lWidth);
            this.Controls.Add(this.eMotifWidth);
            this.Controls.Add(this.lHeight);
            this.Controls.Add(this.eMotifHeight);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 560);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(368, 560);
            this.Name = "frmMotifSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Motif Settings";
            this.toolTip1.SetToolTip(this, "Used for motifs created by a peptide list");
            this.Load += new System.EventHandler(this.frmMotifSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.TextBox eMotifWidth;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.TextBox eMotifHeight;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pColors;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.TextBox eMaxAAPerColumn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lThreshold;
        private System.Windows.Forms.TextBox eThreshold;
        private System.Windows.Forms.Button btnDefaultColors;
    }
}