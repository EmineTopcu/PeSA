namespace PeSA.Windows
{
    partial class frmPermutationArraySettings
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
            this.btnSave = new System.Windows.Forms.Button();
            this.lYAxis = new System.Windows.Forms.Label();
            this.rbTopToBottom = new System.Windows.Forms.RadioButton();
            this.rbBottomToTop = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Location = new System.Drawing.Point(17, 135);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 35);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lYAxis
            // 
            this.lYAxis.AutoSize = true;
            this.lYAxis.Location = new System.Drawing.Point(13, 23);
            this.lYAxis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lYAxis.Name = "lYAxis";
            this.lYAxis.Size = new System.Drawing.Size(224, 20);
            this.lYAxis.TabIndex = 46;
            this.lYAxis.Text = "Wild Type Sequence on Y Axis";
            // 
            // rbTopToBottom
            // 
            this.rbTopToBottom.AutoSize = true;
            this.rbTopToBottom.Checked = true;
            this.rbTopToBottom.Location = new System.Drawing.Point(18, 55);
            this.rbTopToBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTopToBottom.Name = "rbTopToBottom";
            this.rbTopToBottom.Size = new System.Drawing.Size(135, 24);
            this.rbTopToBottom.TabIndex = 44;
            this.rbTopToBottom.TabStop = true;
            this.rbTopToBottom.Text = "Top to Bottom";
            this.rbTopToBottom.UseVisualStyleBackColor = true;
            // 
            // rbBottomToTop
            // 
            this.rbBottomToTop.AutoSize = true;
            this.rbBottomToTop.Location = new System.Drawing.Point(18, 87);
            this.rbBottomToTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbBottomToTop.Name = "rbBottomToTop";
            this.rbBottomToTop.Size = new System.Drawing.Size(237, 24);
            this.rbBottomToTop.TabIndex = 45;
            this.rbBottomToTop.Text = "Bottom to Top (Left to Right)";
            this.rbBottomToTop.UseVisualStyleBackColor = true;
            // 
            // frmPermutationArraySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 184);
            this.Controls.Add(this.lYAxis);
            this.Controls.Add(this.rbTopToBottom);
            this.Controls.Add(this.rbBottomToTop);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(336, 240);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(336, 240);
            this.Name = "frmPermutationArraySettings";
            this.Text = "Permutation Array Settings";
            this.Load += new System.EventHandler(this.frmPermutationArraySettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lYAxis;
        private System.Windows.Forms.RadioButton rbTopToBottom;
        private System.Windows.Forms.RadioButton rbBottomToTop;
    }
}