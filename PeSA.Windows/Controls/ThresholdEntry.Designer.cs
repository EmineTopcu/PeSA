namespace PeSA.Windows.Controls
{
    partial class ThresholdEntry
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eNegativeThreshold = new System.Windows.Forms.TextBox();
            this.lNegativeThreshold = new System.Windows.Forms.Label();
            this.trackNegativeThreshold = new System.Windows.Forms.TrackBar();
            this.eThreshold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.trackThreshold = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackNegativeThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // eNegativeThreshold
            // 
            this.eNegativeThreshold.Location = new System.Drawing.Point(112, 44);
            this.eNegativeThreshold.Name = "eNegativeThreshold";
            this.eNegativeThreshold.Size = new System.Drawing.Size(48, 20);
            this.eNegativeThreshold.TabIndex = 16;
            this.eNegativeThreshold.Leave += new System.EventHandler(this.eNegativeThreshold_Leave);
            // 
            // lNegativeThreshold
            // 
            this.lNegativeThreshold.AutoSize = true;
            this.lNegativeThreshold.Location = new System.Drawing.Point(10, 47);
            this.lNegativeThreshold.Name = "lNegativeThreshold";
            this.lNegativeThreshold.Size = new System.Drawing.Size(100, 13);
            this.lNegativeThreshold.TabIndex = 15;
            this.lNegativeThreshold.Text = "Negative Threshold";
            // 
            // trackNegativeThreshold
            // 
            this.trackNegativeThreshold.LargeChange = 1;
            this.trackNegativeThreshold.Location = new System.Drawing.Point(164, 40);
            this.trackNegativeThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.trackNegativeThreshold.Maximum = 100;
            this.trackNegativeThreshold.Name = "trackNegativeThreshold";
            this.trackNegativeThreshold.Size = new System.Drawing.Size(216, 45);
            this.trackNegativeThreshold.TabIndex = 14;
            this.trackNegativeThreshold.TickFrequency = 10;
            this.trackNegativeThreshold.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackNegativeThreshold.Value = 50;
            this.trackNegativeThreshold.ValueChanged += new System.EventHandler(this.trackNegativeThreshold_ValueChanged);
            this.trackNegativeThreshold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackNegativeThreshold_MouseDown);
            this.trackNegativeThreshold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackNegativeThreshold_MouseUp);
            // 
            // eThreshold
            // 
            this.eThreshold.Location = new System.Drawing.Point(112, 12);
            this.eThreshold.Name = "eThreshold";
            this.eThreshold.Size = new System.Drawing.Size(48, 20);
            this.eThreshold.TabIndex = 13;
            this.eThreshold.Leave += new System.EventHandler(this.eThreshold_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Threshold";
            // 
            // trackThreshold
            // 
            this.trackThreshold.LargeChange = 1;
            this.trackThreshold.Location = new System.Drawing.Point(164, 8);
            this.trackThreshold.Margin = new System.Windows.Forms.Padding(2);
            this.trackThreshold.Maximum = 100;
            this.trackThreshold.Name = "trackThreshold";
            this.trackThreshold.Size = new System.Drawing.Size(216, 45);
            this.trackThreshold.TabIndex = 11;
            this.trackThreshold.TickFrequency = 10;
            this.trackThreshold.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackThreshold.Value = 50;
            this.trackThreshold.ValueChanged += new System.EventHandler(this.trackThreshold_ValueChanged);
            this.trackThreshold.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackThreshold_MouseDown);
            this.trackThreshold.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackThreshold_MouseUp);
            // 
            // ThresholdEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.eNegativeThreshold);
            this.Controls.Add(this.lNegativeThreshold);
            this.Controls.Add(this.trackNegativeThreshold);
            this.Controls.Add(this.eThreshold);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackThreshold);
            this.MinimumSize = new System.Drawing.Size(380, 80);
            this.Name = "ThresholdEntry";
            this.Size = new System.Drawing.Size(380, 80);
            ((System.ComponentModel.ISupportInitialize)(this.trackNegativeThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eNegativeThreshold;
        private System.Windows.Forms.Label lNegativeThreshold;
        private System.Windows.Forms.TrackBar trackNegativeThreshold;
        private System.Windows.Forms.TextBox eThreshold;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackThreshold;
    }
}
