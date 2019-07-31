namespace PTMAnalysis
{
    partial class frmChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btnCopyToClipboard1 = new System.Windows.Forms.Button();
            this.pTop1 = new System.Windows.Forms.Panel();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.dlgSaveImage = new System.Windows.Forms.SaveFileDialog();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pTop1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopyToClipboard1
            // 
            this.btnCopyToClipboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyToClipboard1.AutoSize = true;
            this.btnCopyToClipboard1.Enabled = false;
            this.btnCopyToClipboard1.Location = new System.Drawing.Point(11, 8);
            this.btnCopyToClipboard1.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyToClipboard1.Name = "btnCopyToClipboard1";
            this.btnCopyToClipboard1.Size = new System.Drawing.Size(143, 23);
            this.btnCopyToClipboard1.TabIndex = 1;
            this.btnCopyToClipboard1.Text = "Copy Image to Clipboard";
            this.btnCopyToClipboard1.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard1.Click += new System.EventHandler(this.btnCopyToClipboard1_Click);
            // 
            // pTop1
            // 
            this.pTop1.Controls.Add(this.btnCopyToClipboard1);
            this.pTop1.Controls.Add(this.btnSave1);
            this.pTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop1.Location = new System.Drawing.Point(0, 0);
            this.pTop1.Name = "pTop1";
            this.pTop1.Size = new System.Drawing.Size(549, 36);
            this.pTop1.TabIndex = 1;
            // 
            // btnSave1
            // 
            this.btnSave1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave1.AutoSize = true;
            this.btnSave1.Enabled = false;
            this.btnSave1.Location = new System.Drawing.Point(161, 8);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(93, 23);
            this.btnSave1.TabIndex = 3;
            this.btnSave1.Text = "Save Image";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // dlgSaveImage
            // 
            this.dlgSaveImage.Filter = "Images|*.png;*.bmp;*.jpg";
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(0, 36);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(549, 522);
            this.chart.TabIndex = 2;
            this.chart.Text = "chart1";
            // 
            // frmChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 558);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.pTop1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmChart";
            this.Text = "Chart";
            this.pTop1.ResumeLayout(false);
            this.pTop1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCopyToClipboard1;
        private System.Windows.Forms.Panel pTop1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.SaveFileDialog dlgSaveImage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}