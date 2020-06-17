namespace PeSA.Windows
{
    partial class MotifDisplay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MotifDisplay));
            this.pbMotif = new System.Windows.Forms.PictureBox();
            this.pTop1 = new System.Windows.Forms.Panel();
            this.linkSaveImage = new System.Windows.Forms.LinkLabel();
            this.linkCopyImage = new System.Windows.Forms.LinkLabel();
            this.pLineBottom = new System.Windows.Forms.Panel();
            this.lMotif1 = new System.Windows.Forms.Label();
            this.dlgSaveImage = new System.Windows.Forms.SaveFileDialog();
            this.pGap = new System.Windows.Forms.Panel();
            this.pLineTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMotif)).BeginInit();
            this.pTop1.SuspendLayout();
            this.pGap.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbMotif
            // 
            this.pbMotif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMotif.Image = ((System.Drawing.Image)(resources.GetObject("pbMotif.Image")));
            this.pbMotif.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMotif.InitialImage")));
            this.pbMotif.Location = new System.Drawing.Point(0, 36);
            this.pbMotif.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbMotif.Name = "pbMotif";
            this.pbMotif.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbMotif.Size = new System.Drawing.Size(632, 356);
            this.pbMotif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMotif.TabIndex = 2;
            this.pbMotif.TabStop = false;
            // 
            // pTop1
            // 
            this.pTop1.BackColor = System.Drawing.Color.White;
            this.pTop1.Controls.Add(this.pLineTop);
            this.pTop1.Controls.Add(this.linkSaveImage);
            this.pTop1.Controls.Add(this.linkCopyImage);
            this.pTop1.Controls.Add(this.pLineBottom);
            this.pTop1.Controls.Add(this.lMotif1);
            this.pTop1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop1.Location = new System.Drawing.Point(0, 0);
            this.pTop1.Name = "pTop1";
            this.pTop1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.pTop1.Size = new System.Drawing.Size(632, 36);
            this.pTop1.TabIndex = 3;
            // 
            // linkSaveImage
            // 
            this.linkSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkSaveImage.AutoSize = true;
            this.linkSaveImage.Location = new System.Drawing.Point(559, 8);
            this.linkSaveImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkSaveImage.Name = "linkSaveImage";
            this.linkSaveImage.Size = new System.Drawing.Size(64, 13);
            this.linkSaveImage.TabIndex = 6;
            this.linkSaveImage.TabStop = true;
            this.linkSaveImage.Text = "Save Image";
            this.linkSaveImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSaveImage_LinkClicked);
            // 
            // linkCopyImage
            // 
            this.linkCopyImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkCopyImage.AutoSize = true;
            this.linkCopyImage.Location = new System.Drawing.Point(426, 8);
            this.linkCopyImage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkCopyImage.Name = "linkCopyImage";
            this.linkCopyImage.Size = new System.Drawing.Size(122, 13);
            this.linkCopyImage.TabIndex = 5;
            this.linkCopyImage.TabStop = true;
            this.linkCopyImage.Text = "Copy Image to Clipboard";
            this.linkCopyImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCopyImage_LinkClicked);
            // 
            // pLineBottom
            // 
            this.pLineBottom.BackColor = System.Drawing.Color.Gray;
            this.pLineBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pLineBottom.Location = new System.Drawing.Point(0, 32);
            this.pLineBottom.Name = "pLineBottom";
            this.pLineBottom.Size = new System.Drawing.Size(632, 1);
            this.pLineBottom.TabIndex = 4;
            // 
            // lMotif1
            // 
            this.lMotif1.AutoSize = true;
            this.lMotif1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMotif1.Location = new System.Drawing.Point(6, 6);
            this.lMotif1.Name = "lMotif1";
            this.lMotif1.Size = new System.Drawing.Size(46, 17);
            this.lMotif1.TabIndex = 2;
            this.lMotif1.Text = "Motif1";
            // 
            // dlgSaveImage
            // 
            this.dlgSaveImage.Filter = "Images|*.png;*.bmp;*.jpg";
            // 
            // pGap
            // 
            this.pGap.Controls.Add(this.panel1);
            this.pGap.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pGap.Location = new System.Drawing.Point(0, 392);
            this.pGap.Name = "pGap";
            this.pGap.Size = new System.Drawing.Size(632, 10);
            this.pGap.TabIndex = 4;
            // 
            // pLineTop
            // 
            this.pLineTop.BackColor = System.Drawing.Color.Gray;
            this.pLineTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLineTop.Location = new System.Drawing.Point(0, 0);
            this.pLineTop.Name = "pLineTop";
            this.pLineTop.Size = new System.Drawing.Size(632, 1);
            this.pLineTop.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 1);
            this.panel1.TabIndex = 5;
            // 
            // MotifDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbMotif);
            this.Controls.Add(this.pGap);
            this.Controls.Add(this.pTop1);
            this.Name = "MotifDisplay";
            this.Size = new System.Drawing.Size(632, 402);
            this.SizeChanged += new System.EventHandler(this.MotifDisplay_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbMotif)).EndInit();
            this.pTop1.ResumeLayout(false);
            this.pTop1.PerformLayout();
            this.pGap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMotif;
        private System.Windows.Forms.Panel pTop1;
        private System.Windows.Forms.Label lMotif1;
        private System.Windows.Forms.SaveFileDialog dlgSaveImage;
        private System.Windows.Forms.Panel pLineBottom;
        private System.Windows.Forms.Panel pGap;
        private System.Windows.Forms.LinkLabel linkCopyImage;
        private System.Windows.Forms.LinkLabel linkSaveImage;
        private System.Windows.Forms.Panel pLineTop;
        private System.Windows.Forms.Panel panel1;
    }
}
