namespace PeSA.Windows
{
    partial class frmAminoAcids
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
            this.pBottom = new System.Windows.Forms.Panel();
            this.dgAminoAcid = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAbbrev1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInclude = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnSave = new System.Windows.Forms.Button();
            this.pBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAminoAcid)).BeginInit();
            this.SuspendLayout();
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.btnSave);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 414);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(360, 36);
            this.pBottom.TabIndex = 0;
            // 
            // dgAminoAcid
            // 
            this.dgAminoAcid.AllowUserToAddRows = false;
            this.dgAminoAcid.AllowUserToDeleteRows = false;
            this.dgAminoAcid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAminoAcid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colAbbrev1,
            this.colInclude});
            this.dgAminoAcid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgAminoAcid.Location = new System.Drawing.Point(0, 0);
            this.dgAminoAcid.Name = "dgAminoAcid";
            this.dgAminoAcid.Size = new System.Drawing.Size(360, 414);
            this.dgAminoAcid.TabIndex = 1;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colAbbrev1
            // 
            this.colAbbrev1.HeaderText = "Abbrev1";
            this.colAbbrev1.Name = "colAbbrev1";
            this.colAbbrev1.ReadOnly = true;
            // 
            // colInclude
            // 
            this.colInclude.HeaderText = "Include";
            this.colInclude.Name = "colInclude";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(267, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAminoAcids
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.dgAminoAcid);
            this.Controls.Add(this.pBottom);
            this.Name = "frmAminoAcids";
            this.Text = "Amino Acid List";
            this.pBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAminoAcid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.DataGridView dgAminoAcid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAbbrev1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colInclude;
        private System.Windows.Forms.Button btnSave;
    }
}