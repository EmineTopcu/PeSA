namespace PeSA.Windows.Controls
{
    partial class ColorMatrixDisplay
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
            this.pbColorMatrix = new System.Windows.Forms.PictureBox();
            this.rbGrayScale = new System.Windows.Forms.RadioButton();
            this.rbColorScale = new System.Windows.Forms.RadioButton();
            this.pTop = new System.Windows.Forms.Panel();
            this.linkSaveImage = new System.Windows.Forms.LinkLabel();
            this.linkCopyImage = new System.Windows.Forms.LinkLabel();
            this.dlgSaveImage = new System.Windows.Forms.SaveFileDialog();
            this.pImages = new System.Windows.Forms.Panel();
            this.pMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorMatrix)).BeginInit();
            this.pTop.SuspendLayout();
            this.pImages.SuspendLayout();
            this.pMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbColorMatrix
            // 
            this.pbColorMatrix.Location = new System.Drawing.Point(2, 2);
            this.pbColorMatrix.Margin = new System.Windows.Forms.Padding(2);
            this.pbColorMatrix.Name = "pbColorMatrix";
            this.pbColorMatrix.Size = new System.Drawing.Size(388, 368);
            this.pbColorMatrix.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbColorMatrix.TabIndex = 1;
            this.pbColorMatrix.TabStop = false;
            // 
            // rbGrayScale
            // 
            this.rbGrayScale.AutoSize = true;
            this.rbGrayScale.Checked = true;
            this.rbGrayScale.Location = new System.Drawing.Point(14, 14);
            this.rbGrayScale.Margin = new System.Windows.Forms.Padding(2);
            this.rbGrayScale.Name = "rbGrayScale";
            this.rbGrayScale.Size = new System.Drawing.Size(72, 17);
            this.rbGrayScale.TabIndex = 2;
            this.rbGrayScale.TabStop = true;
            this.rbGrayScale.Text = "Grayscale";
            this.rbGrayScale.UseVisualStyleBackColor = true;
            // 
            // rbColorScale
            // 
            this.rbColorScale.AutoSize = true;
            this.rbColorScale.Location = new System.Drawing.Point(94, 14);
            this.rbColorScale.Margin = new System.Windows.Forms.Padding(2);
            this.rbColorScale.Name = "rbColorScale";
            this.rbColorScale.Size = new System.Drawing.Size(61, 17);
            this.rbColorScale.TabIndex = 3;
            this.rbColorScale.Text = "Colored";
            this.rbColorScale.UseVisualStyleBackColor = true;
            this.rbColorScale.CheckedChanged += new System.EventHandler(this.rbColorScale_CheckedChanged);
            // 
            // pTop
            // 
            this.pTop.BackColor = System.Drawing.Color.White;
            this.pTop.Controls.Add(this.linkSaveImage);
            this.pTop.Controls.Add(this.linkCopyImage);
            this.pTop.Controls.Add(this.rbGrayScale);
            this.pTop.Controls.Add(this.rbColorScale);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Margin = new System.Windows.Forms.Padding(2);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(392, 39);
            this.pTop.TabIndex = 4;
            // 
            // linkSaveImage
            // 
            this.linkSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkSaveImage.AutoSize = true;
            this.linkSaveImage.Location = new System.Drawing.Point(312, 14);
            this.linkSaveImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkSaveImage.Name = "linkSaveImage";
            this.linkSaveImage.Size = new System.Drawing.Size(64, 13);
            this.linkSaveImage.TabIndex = 8;
            this.linkSaveImage.TabStop = true;
            this.linkSaveImage.Text = "Save Image";
            this.linkSaveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSaveImage_LinkClicked);
            // 
            // linkCopyImage
            // 
            this.linkCopyImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkCopyImage.AutoSize = true;
            this.linkCopyImage.Location = new System.Drawing.Point(179, 14);
            this.linkCopyImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkCopyImage.Name = "linkCopyImage";
            this.linkCopyImage.Size = new System.Drawing.Size(122, 13);
            this.linkCopyImage.TabIndex = 7;
            this.linkCopyImage.TabStop = true;
            this.linkCopyImage.Text = "Copy Image to Clipboard";
            this.linkCopyImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCopyImage_LinkClicked);
            // 
            // dlgSaveImage
            // 
            this.dlgSaveImage.Filter = "Images|*.png;*.bmp;*.jpg";
            // 
            // pImages
            // 
            this.pImages.AutoScroll = true;
            this.pImages.Controls.Add(this.pbColorMatrix);
            this.pImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pImages.Location = new System.Drawing.Point(0, 0);
            this.pImages.Name = "pImages";
            this.pImages.Size = new System.Drawing.Size(392, 372);
            this.pImages.TabIndex = 7;
            // 
            // pMain
            // 
            this.pMain.Controls.Add(this.pImages);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 39);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(392, 372);
            this.pMain.TabIndex = 9;
            // 
            // ColorMatrixDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.pMain);
            this.Controls.Add(this.pTop);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ColorMatrixDisplay";
            this.Size = new System.Drawing.Size(392, 411);
            ((System.ComponentModel.ISupportInitialize)(this.pbColorMatrix)).EndInit();
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            this.pImages.ResumeLayout(false);
            this.pImages.PerformLayout();
            this.pMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbColorMatrix;
        private System.Windows.Forms.RadioButton rbGrayScale;
        private System.Windows.Forms.RadioButton rbColorScale;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.LinkLabel linkSaveImage;
        private System.Windows.Forms.LinkLabel linkCopyImage;
        private System.Windows.Forms.SaveFileDialog dlgSaveImage;
        private System.Windows.Forms.Panel pImages;
        private System.Windows.Forms.Panel pMain;
    }
}
