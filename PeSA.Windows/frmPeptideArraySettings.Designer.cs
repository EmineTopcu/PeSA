namespace PeSA.Windows
{
    partial class frmPeptideArraySettings
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
            this.lColumnNumber = new System.Windows.Forms.Label();
            this.eColumnNumber = new System.Windows.Forms.TextBox();
            this.lRowNumber = new System.Windows.Forms.Label();
            this.eRowNumber = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.rbRowFirst = new System.Windows.Forms.RadioButton();
            this.rbColumnsFirst = new System.Windows.Forms.RadioButton();
            this.lAxisMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lColumnNumber
            // 
            this.lColumnNumber.AutoSize = true;
            this.lColumnNumber.Location = new System.Drawing.Point(27, 23);
            this.lColumnNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lColumnNumber.Name = "lColumnNumber";
            this.lColumnNumber.Size = new System.Drawing.Size(102, 20);
            this.lColumnNumber.TabIndex = 37;
            this.lColumnNumber.Text = "# of Columns";
            // 
            // eColumnNumber
            // 
            this.eColumnNumber.Location = new System.Drawing.Point(140, 18);
            this.eColumnNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eColumnNumber.Name = "eColumnNumber";
            this.eColumnNumber.Size = new System.Drawing.Size(80, 26);
            this.eColumnNumber.TabIndex = 34;
            this.eColumnNumber.Text = "30";
            // 
            // lRowNumber
            // 
            this.lRowNumber.AutoSize = true;
            this.lRowNumber.Location = new System.Drawing.Point(27, 58);
            this.lRowNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lRowNumber.Name = "lRowNumber";
            this.lRowNumber.Size = new System.Drawing.Size(80, 20);
            this.lRowNumber.TabIndex = 36;
            this.lRowNumber.Text = "# of Rows";
            // 
            // eRowNumber
            // 
            this.eRowNumber.Location = new System.Drawing.Point(140, 54);
            this.eRowNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eRowNumber.Name = "eRowNumber";
            this.eRowNumber.Size = new System.Drawing.Size(80, 26);
            this.eRowNumber.TabIndex = 35;
            this.eRowNumber.Text = "20";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(22, 220);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // rbRowFirst
            // 
            this.rbRowFirst.AutoSize = true;
            this.rbRowFirst.Checked = true;
            this.rbRowFirst.Location = new System.Drawing.Point(32, 127);
            this.rbRowFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbRowFirst.Name = "rbRowFirst";
            this.rbRowFirst.Size = new System.Drawing.Size(104, 24);
            this.rbRowFirst.TabIndex = 41;
            this.rbRowFirst.TabStop = true;
            this.rbRowFirst.Text = "Rows first";
            this.rbRowFirst.UseVisualStyleBackColor = true;
            // 
            // rbColumnsFirst
            // 
            this.rbColumnsFirst.AutoSize = true;
            this.rbColumnsFirst.Location = new System.Drawing.Point(32, 158);
            this.rbColumnsFirst.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbColumnsFirst.Name = "rbColumnsFirst";
            this.rbColumnsFirst.Size = new System.Drawing.Size(126, 24);
            this.rbColumnsFirst.TabIndex = 42;
            this.rbColumnsFirst.Text = "Columns first";
            this.rbColumnsFirst.UseVisualStyleBackColor = true;
            // 
            // lAxisMode
            // 
            this.lAxisMode.AutoSize = true;
            this.lAxisMode.Location = new System.Drawing.Point(27, 98);
            this.lAxisMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAxisMode.Name = "lAxisMode";
            this.lAxisMode.Size = new System.Drawing.Size(206, 20);
            this.lAxisMode.TabIndex = 43;
            this.lAxisMode.Text = "Peptide placement on array:";
            // 
            // frmPeptideArraySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 264);
            this.Controls.Add(this.lAxisMode);
            this.Controls.Add(this.rbRowFirst);
            this.Controls.Add(this.rbColumnsFirst);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lColumnNumber);
            this.Controls.Add(this.eColumnNumber);
            this.Controls.Add(this.lRowNumber);
            this.Controls.Add(this.eRowNumber);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(336, 320);
            this.Name = "frmPeptideArraySettings";
            this.Text = "Peptide Array Settings";
            this.Load += new System.EventHandler(this.frmPeptideArraySettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lColumnNumber;
        private System.Windows.Forms.TextBox eColumnNumber;
        private System.Windows.Forms.Label lRowNumber;
        private System.Windows.Forms.TextBox eRowNumber;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rbRowFirst;
        private System.Windows.Forms.RadioButton rbColumnsFirst;
        private System.Windows.Forms.Label lAxisMode;
    }
}