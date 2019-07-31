namespace PeSA.Windows
{
    partial class frmAbout
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
            this.lPTMA = new System.Windows.Forms.Label();
            this.lVersionWindows = new System.Windows.Forms.Label();
            this.lCoder = new System.Windows.Forms.Label();
            this.lLab = new System.Windows.Forms.Label();
            this.lLocation = new System.Windows.Forms.Label();
            this.lVersionEngine = new System.Windows.Forms.Label();
            this.linkGitHub = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lPTMA
            // 
            this.lPTMA.AutoSize = true;
            this.lPTMA.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPTMA.Location = new System.Drawing.Point(18, 32);
            this.lPTMA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPTMA.Name = "lPTMA";
            this.lPTMA.Size = new System.Drawing.Size(441, 40);
            this.lPTMA.TabIndex = 0;
            this.lPTMA.Text = "Peptide Specificity Analyst - PeSA";
            // 
            // lVersionWindows
            // 
            this.lVersionWindows.AutoSize = true;
            this.lVersionWindows.Location = new System.Drawing.Point(21, 105);
            this.lVersionWindows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVersionWindows.Name = "lVersionWindows";
            this.lVersionWindows.Size = new System.Drawing.Size(80, 20);
            this.lVersionWindows.TabIndex = 1;
            this.lVersionWindows.Text = "UI version";
            // 
            // lCoder
            // 
            this.lCoder.AutoSize = true;
            this.lCoder.Location = new System.Drawing.Point(21, 178);
            this.lCoder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCoder.Name = "lCoder";
            this.lCoder.Size = new System.Drawing.Size(102, 20);
            this.lCoder.TabIndex = 2;
            this.lCoder.Text = "Emine Topcu";
            // 
            // lLab
            // 
            this.lLab.AutoSize = true;
            this.lLab.Location = new System.Drawing.Point(21, 212);
            this.lLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLab.Name = "lLab";
            this.lLab.Size = new System.Drawing.Size(86, 20);
            this.lLab.TabIndex = 3;
            this.lLab.Text = "Biggar Lab";
            // 
            // lLocation
            // 
            this.lLocation.AutoSize = true;
            this.lLocation.Location = new System.Drawing.Point(21, 246);
            this.lLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lLocation.Name = "lLocation";
            this.lLocation.Size = new System.Drawing.Size(231, 20);
            this.lLocation.TabIndex = 4;
            this.lLocation.Text = "Carleton University, Ottawa, ON";
            // 
            // lVersionEngine
            // 
            this.lVersionEngine.AutoSize = true;
            this.lVersionEngine.Location = new System.Drawing.Point(21, 138);
            this.lVersionEngine.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lVersionEngine.Name = "lVersionEngine";
            this.lVersionEngine.Size = new System.Drawing.Size(113, 20);
            this.lVersionEngine.TabIndex = 5;
            this.lVersionEngine.Text = "Engine version";
            // 
            // linkGitHub
            // 
            this.linkGitHub.AutoSize = true;
            this.linkGitHub.Location = new System.Drawing.Point(21, 280);
            this.linkGitHub.Name = "linkGitHub";
            this.linkGitHub.Size = new System.Drawing.Size(273, 20);
            this.linkGitHub.TabIndex = 6;
            this.linkGitHub.TabStop = true;
            this.linkGitHub.Text = "https://github.com/EmineTopcu/PeSA";
            this.linkGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkGitHub_LinkClicked);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 318);
            this.Controls.Add(this.linkGitHub);
            this.Controls.Add(this.lVersionEngine);
            this.Controls.Add(this.lLocation);
            this.Controls.Add(this.lLab);
            this.Controls.Add(this.lCoder);
            this.Controls.Add(this.lVersionWindows);
            this.Controls.Add(this.lPTMA);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPTMA;
        private System.Windows.Forms.Label lVersionWindows;
        private System.Windows.Forms.Label lCoder;
        private System.Windows.Forms.Label lLab;
        private System.Windows.Forms.Label lLocation;
        private System.Windows.Forms.Label lVersionEngine;
        private System.Windows.Forms.LinkLabel linkGitHub;
    }
}