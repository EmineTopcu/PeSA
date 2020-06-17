namespace PeSA.Windows.Controls
{
    partial class ImageDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageDisplay));
            this.pInfoTop = new System.Windows.Forms.Panel();
            this.linkClear = new System.Windows.Forms.LinkLabel();
            this.linkLoad = new System.Windows.Forms.LinkLabel();
            this.lReferenceImage = new System.Windows.Forms.Label();
            this.pbReferenceImage = new System.Windows.Forms.PictureBox();
            this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.pInfoTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReferenceImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pInfoTop
            // 
            this.pInfoTop.Controls.Add(this.linkClear);
            this.pInfoTop.Controls.Add(this.linkLoad);
            this.pInfoTop.Controls.Add(this.lReferenceImage);
            this.pInfoTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pInfoTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pInfoTop.Location = new System.Drawing.Point(0, 0);
            this.pInfoTop.Name = "pInfoTop";
            this.pInfoTop.Size = new System.Drawing.Size(400, 31);
            this.pInfoTop.TabIndex = 6;
            // 
            // linkClear
            // 
            this.linkClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkClear.AutoSize = true;
            this.linkClear.Location = new System.Drawing.Point(355, 13);
            this.linkClear.Name = "linkClear";
            this.linkClear.Size = new System.Drawing.Size(31, 13);
            this.linkClear.TabIndex = 5;
            this.linkClear.TabStop = true;
            this.linkClear.Text = "Clear";
            this.linkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
            // 
            // linkLoad
            // 
            this.linkLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLoad.AutoSize = true;
            this.linkLoad.Location = new System.Drawing.Point(318, 13);
            this.linkLoad.Name = "linkLoad";
            this.linkLoad.Size = new System.Drawing.Size(31, 13);
            this.linkLoad.TabIndex = 4;
            this.linkLoad.TabStop = true;
            this.linkLoad.Text = "Load";
            this.linkLoad.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLoad_LinkClicked);
            // 
            // lReferenceImage
            // 
            this.lReferenceImage.AutoSize = true;
            this.lReferenceImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lReferenceImage.Location = new System.Drawing.Point(3, 3);
            this.lReferenceImage.Name = "lReferenceImage";
            this.lReferenceImage.Padding = new System.Windows.Forms.Padding(3);
            this.lReferenceImage.Size = new System.Drawing.Size(122, 23);
            this.lReferenceImage.TabIndex = 3;
            this.lReferenceImage.Text = "Reference Image";
            // 
            // pbReferenceImage
            // 
            this.pbReferenceImage.BackColor = System.Drawing.SystemColors.Window;
            this.pbReferenceImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbReferenceImage.Image = ((System.Drawing.Image)(resources.GetObject("pbReferenceImage.Image")));
            this.pbReferenceImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbReferenceImage.InitialImage")));
            this.pbReferenceImage.Location = new System.Drawing.Point(0, 31);
            this.pbReferenceImage.Name = "pbReferenceImage";
            this.pbReferenceImage.Padding = new System.Windows.Forms.Padding(3);
            this.pbReferenceImage.Size = new System.Drawing.Size(400, 169);
            this.pbReferenceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReferenceImage.TabIndex = 5;
            this.pbReferenceImage.TabStop = false;
            // 
            // dlgOpenImage
            // 
            this.dlgOpenImage.FileName = "Open Image";
            this.dlgOpenImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // ImageDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbReferenceImage);
            this.Controls.Add(this.pInfoTop);
            this.Name = "ImageDisplay";
            this.Size = new System.Drawing.Size(400, 200);
            this.pInfoTop.ResumeLayout(false);
            this.pInfoTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbReferenceImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pInfoTop;
        private System.Windows.Forms.LinkLabel linkClear;
        private System.Windows.Forms.LinkLabel linkLoad;
        private System.Windows.Forms.Label lReferenceImage;
        private System.Windows.Forms.PictureBox pbReferenceImage;
        private System.Windows.Forms.OpenFileDialog dlgOpenImage;
    }
}
