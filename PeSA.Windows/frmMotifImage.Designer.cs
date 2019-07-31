namespace PeSA.Windows
{
    partial class frmMotifImage
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCopyToClipboard1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pTop1 = new System.Windows.Forms.Panel();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.lMotif1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.lMotif2 = new System.Windows.Forms.Label();
            this.btnCopyToClipboard2 = new System.Windows.Forms.Button();
            this.dlgSaveImage = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pTop1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 36);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(549, 242);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCopyToClipboard1
            // 
            this.btnCopyToClipboard1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyToClipboard1.AutoSize = true;
            this.btnCopyToClipboard1.Location = new System.Drawing.Point(98, 6);
            this.btnCopyToClipboard1.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyToClipboard1.Name = "btnCopyToClipboard1";
            this.btnCopyToClipboard1.Size = new System.Drawing.Size(143, 23);
            this.btnCopyToClipboard1.TabIndex = 1;
            this.btnCopyToClipboard1.Text = "Copy Image to Clipboard";
            this.btnCopyToClipboard1.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard1.Click += new System.EventHandler(this.btnCopyToClipboard1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(0, 36);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Size = new System.Drawing.Size(549, 240);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.pTop1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(549, 558);
            this.splitContainer1.SplitterDistance = 278;
            this.splitContainer1.TabIndex = 3;
            // 
            // pTop1
            // 
            this.pTop1.Controls.Add(this.btnCopyToClipboard1);
            this.pTop1.Controls.Add(this.btnSave1);
            this.pTop1.Controls.Add(this.lMotif1);
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
            this.btnSave1.Location = new System.Drawing.Point(248, 6);
            this.btnSave1.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(93, 23);
            this.btnSave1.TabIndex = 3;
            this.btnSave1.Text = "Save Image";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // lMotif1
            // 
            this.lMotif1.AutoSize = true;
            this.lMotif1.Location = new System.Drawing.Point(12, 11);
            this.lMotif1.Name = "lMotif1";
            this.lMotif1.Size = new System.Drawing.Size(36, 13);
            this.lMotif1.TabIndex = 2;
            this.lMotif1.Text = "Motif1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCopyToClipboard2);
            this.panel1.Controls.Add(this.btnSave2);
            this.panel1.Controls.Add(this.lMotif2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 36);
            this.panel1.TabIndex = 3;
            // 
            // btnSave2
            // 
            this.btnSave2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave2.AutoSize = true;
            this.btnSave2.Location = new System.Drawing.Point(248, 6);
            this.btnSave2.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(93, 23);
            this.btnSave2.TabIndex = 3;
            this.btnSave2.Text = "Save Image";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // lMotif2
            // 
            this.lMotif2.AutoSize = true;
            this.lMotif2.Location = new System.Drawing.Point(12, 11);
            this.lMotif2.Name = "lMotif2";
            this.lMotif2.Size = new System.Drawing.Size(36, 13);
            this.lMotif2.TabIndex = 2;
            this.lMotif2.Text = "Motif2";
            // 
            // btnCopyToClipboard2
            // 
            this.btnCopyToClipboard2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopyToClipboard2.AutoSize = true;
            this.btnCopyToClipboard2.Location = new System.Drawing.Point(98, 6);
            this.btnCopyToClipboard2.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyToClipboard2.Name = "btnCopyToClipboard2";
            this.btnCopyToClipboard2.Size = new System.Drawing.Size(143, 23);
            this.btnCopyToClipboard2.TabIndex = 1;
            this.btnCopyToClipboard2.Text = "Copy Image to Clipboard";
            this.btnCopyToClipboard2.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard2.Click += new System.EventHandler(this.btnCopyToClipboard2_Click);
            // 
            // dlgSaveImage
            // 
            this.dlgSaveImage.Filter = "Images|*.png;*.bmp;*.jpg";
            // 
            // frmMotifImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 558);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMotifImage";
            this.Text = "Motif";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pTop1.ResumeLayout(false);
            this.pTop1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCopyToClipboard1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pTop1;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label lMotif1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Label lMotif2;
        private System.Windows.Forms.Button btnCopyToClipboard2;
        private System.Windows.Forms.SaveFileDialog dlgSaveImage;
    }
}