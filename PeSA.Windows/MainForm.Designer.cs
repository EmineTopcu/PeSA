namespace PeSA.Windows
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mSettingsMotif = new System.Windows.Forms.ToolStripMenuItem();
            this.mSettingsPeptideArray = new System.Windows.Forms.ToolStripMenuItem();
            this.mSettingsPermutationArray = new System.Windows.Forms.ToolStripMenuItem();
            this.mAnalyze = new System.Windows.Forms.ToolStripMenuItem();
            this.mAnalyzePeptideList = new System.Windows.Forms.ToolStripMenuItem();
            this.mAnalyzePeptideArray = new System.Windows.Forms.ToolStripMenuItem();
            this.mAnalyzePermutationArray = new System.Windows.Forms.ToolStripMenuItem();
            this.mAnalyzeOPALArray = new System.Windows.Forms.ToolStripMenuItem();
            this.mWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mWindowCascadeAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mWindowTileAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mWindowCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnPeptideList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPeptideArray = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPermutationArray = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOPALArray = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSequenceGenerator = new System.Windows.Forms.ToolStripButton();
            this.mTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolsSequenceGenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSettings,
            this.mAnalyze,
            this.mTools,
            this.mWindow,
            this.mHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1312, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mSettings
            // 
            this.mSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSettingsMotif,
            this.mSettingsPeptideArray,
            this.mSettingsPermutationArray});
            this.mSettings.Name = "mSettings";
            this.mSettings.Size = new System.Drawing.Size(74, 24);
            this.mSettings.Text = "Settings";
            // 
            // mSettingsMotif
            // 
            this.mSettingsMotif.Name = "mSettingsMotif";
            this.mSettingsMotif.Size = new System.Drawing.Size(260, 26);
            this.mSettingsMotif.Text = "Motif Settings";
            this.mSettingsMotif.Click += new System.EventHandler(this.mSettingsMotif_Click);
            // 
            // mSettingsPeptideArray
            // 
            this.mSettingsPeptideArray.Name = "mSettingsPeptideArray";
            this.mSettingsPeptideArray.Size = new System.Drawing.Size(260, 26);
            this.mSettingsPeptideArray.Text = "Peptide Array Settings";
            this.mSettingsPeptideArray.Click += new System.EventHandler(this.mSettingsPeptideArray_Click);
            // 
            // mSettingsPermutationArray
            // 
            this.mSettingsPermutationArray.Name = "mSettingsPermutationArray";
            this.mSettingsPermutationArray.Size = new System.Drawing.Size(260, 26);
            this.mSettingsPermutationArray.Text = "Permutation Array Settings";
            this.mSettingsPermutationArray.Click += new System.EventHandler(this.mSettingsPermutationArray_Click);
            // 
            // mAnalyze
            // 
            this.mAnalyze.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAnalyzePeptideList,
            this.mAnalyzePeptideArray,
            this.mAnalyzePermutationArray,
            this.mAnalyzeOPALArray});
            this.mAnalyze.Name = "mAnalyze";
            this.mAnalyze.Size = new System.Drawing.Size(73, 24);
            this.mAnalyze.Text = "Analyze";
            // 
            // mAnalyzePeptideList
            // 
            this.mAnalyzePeptideList.Name = "mAnalyzePeptideList";
            this.mAnalyzePeptideList.Size = new System.Drawing.Size(283, 26);
            this.mAnalyzePeptideList.Text = "Create Motif from Peptide List";
            this.mAnalyzePeptideList.Click += new System.EventHandler(this.mAnalyzePeptideList_Click);
            // 
            // mAnalyzePeptideArray
            // 
            this.mAnalyzePeptideArray.Name = "mAnalyzePeptideArray";
            this.mAnalyzePeptideArray.Size = new System.Drawing.Size(283, 26);
            this.mAnalyzePeptideArray.Text = "Analyze Peptide Array";
            this.mAnalyzePeptideArray.Click += new System.EventHandler(this.mAnalyzePeptideArray_Click);
            // 
            // mAnalyzePermutationArray
            // 
            this.mAnalyzePermutationArray.Name = "mAnalyzePermutationArray";
            this.mAnalyzePermutationArray.Size = new System.Drawing.Size(283, 26);
            this.mAnalyzePermutationArray.Text = "Analyze Permutation Array";
            this.mAnalyzePermutationArray.Click += new System.EventHandler(this.mAnalyzePermutationArray_Click);
            // 
            // mAnalyzeOPALArray
            // 
            this.mAnalyzeOPALArray.Name = "mAnalyzeOPALArray";
            this.mAnalyzeOPALArray.Size = new System.Drawing.Size(283, 26);
            this.mAnalyzeOPALArray.Text = "Analyze OPAL Array";
            this.mAnalyzeOPALArray.Click += new System.EventHandler(this.mAnalyzeOPALArray_Click);
            // 
            // mWindow
            // 
            this.mWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mWindowCascadeAll,
            this.mWindowTileAll,
            this.mWindowCloseAll});
            this.mWindow.Name = "mWindow";
            this.mWindow.Size = new System.Drawing.Size(76, 24);
            this.mWindow.Text = "Window";
            // 
            // mWindowCascadeAll
            // 
            this.mWindowCascadeAll.Name = "mWindowCascadeAll";
            this.mWindowCascadeAll.Size = new System.Drawing.Size(216, 26);
            this.mWindowCascadeAll.Text = "Cascade All";
            this.mWindowCascadeAll.Click += new System.EventHandler(this.mWindowCascadeAll_Click);
            // 
            // mWindowTileAll
            // 
            this.mWindowTileAll.Name = "mWindowTileAll";
            this.mWindowTileAll.Size = new System.Drawing.Size(216, 26);
            this.mWindowTileAll.Text = "Tile";
            this.mWindowTileAll.Click += new System.EventHandler(this.mWindowTileAll_Click);
            // 
            // mWindowCloseAll
            // 
            this.mWindowCloseAll.Name = "mWindowCloseAll";
            this.mWindowCloseAll.Size = new System.Drawing.Size(216, 26);
            this.mWindowCloseAll.Text = "Close All";
            this.mWindowCloseAll.Click += new System.EventHandler(this.mWindowCloseAll_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAbout});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(53, 24);
            this.mHelp.Text = "Help";
            // 
            // mAbout
            // 
            this.mAbout.Name = "mAbout";
            this.mAbout.Size = new System.Drawing.Size(125, 26);
            this.mAbout.Text = "About";
            this.mAbout.Click += new System.EventHandler(this.mAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPeptideList,
            this.toolStripSeparator1,
            this.btnPeptideArray,
            this.toolStripSeparator2,
            this.btnPermutationArray,
            this.toolStripSeparator3,
            this.btnOPALArray,
            this.toolStripSeparator4,
            this.btnSequenceGenerator});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1312, 89);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPeptideList
            // 
            this.btnPeptideList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPeptideList.Image = ((System.Drawing.Image)(resources.GetObject("btnPeptideList.Image")));
            this.btnPeptideList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPeptideList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPeptideList.Name = "btnPeptideList";
            this.btnPeptideList.Size = new System.Drawing.Size(68, 86);
            this.btnPeptideList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPeptideList.Click += new System.EventHandler(this.btnPeptideList_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 89);
            // 
            // btnPeptideArray
            // 
            this.btnPeptideArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPeptideArray.Image = ((System.Drawing.Image)(resources.GetObject("btnPeptideArray.Image")));
            this.btnPeptideArray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPeptideArray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPeptideArray.Name = "btnPeptideArray";
            this.btnPeptideArray.Size = new System.Drawing.Size(68, 86);
            this.btnPeptideArray.Click += new System.EventHandler(this.btnPeptideArray_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 89);
            // 
            // btnPermutationArray
            // 
            this.btnPermutationArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPermutationArray.Image = ((System.Drawing.Image)(resources.GetObject("btnPermutationArray.Image")));
            this.btnPermutationArray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPermutationArray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPermutationArray.Name = "btnPermutationArray";
            this.btnPermutationArray.Size = new System.Drawing.Size(68, 86);
            this.btnPermutationArray.Click += new System.EventHandler(this.btnPermutationArray_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 89);
            // 
            // btnOPALArray
            // 
            this.btnOPALArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOPALArray.Image = ((System.Drawing.Image)(resources.GetObject("btnOPALArray.Image")));
            this.btnOPALArray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOPALArray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOPALArray.Name = "btnOPALArray";
            this.btnOPALArray.Size = new System.Drawing.Size(68, 86);
            this.btnOPALArray.Click += new System.EventHandler(this.btnOPALArray_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 89);
            // 
            // btnSequenceGenerator
            // 
            this.btnSequenceGenerator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSequenceGenerator.Image = ((System.Drawing.Image)(resources.GetObject("btnSequenceGenerator.Image")));
            this.btnSequenceGenerator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSequenceGenerator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSequenceGenerator.Name = "btnSequenceGenerator";
            this.btnSequenceGenerator.Size = new System.Drawing.Size(68, 86);
            this.btnSequenceGenerator.Click += new System.EventHandler(this.btnSequenceGenerator_Click);
            // 
            // mTools
            // 
            this.mTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolsSequenceGenerator});
            this.mTools.Name = "mTools";
            this.mTools.Size = new System.Drawing.Size(56, 24);
            this.mTools.Text = "Tools";
            // 
            // mToolsSequenceGenerator
            // 
            this.mToolsSequenceGenerator.Name = "mToolsSequenceGenerator";
            this.mToolsSequenceGenerator.Size = new System.Drawing.Size(218, 26);
            this.mToolsSequenceGenerator.Text = "Sequence Generator";
            this.mToolsSequenceGenerator.Click += new System.EventHandler(this.mToolsSequenceGenerator_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 840);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Peptide Specificity Analyst - PeSA";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mAnalyze;
        private System.Windows.Forms.ToolStripMenuItem mAnalyzePeptideList;
        private System.Windows.Forms.ToolStripMenuItem mWindow;
        private System.Windows.Forms.ToolStripMenuItem mWindowCascadeAll;
        private System.Windows.Forms.ToolStripMenuItem mWindowTileAll;
        private System.Windows.Forms.ToolStripMenuItem mSettings;
        private System.Windows.Forms.ToolStripMenuItem mSettingsMotif;
        private System.Windows.Forms.ToolStripMenuItem mHelp;
        private System.Windows.Forms.ToolStripMenuItem mAbout;
        private System.Windows.Forms.ToolStripMenuItem mAnalyzePeptideArray;
        private System.Windows.Forms.ToolStripMenuItem mSettingsPeptideArray;
        private System.Windows.Forms.ToolStripMenuItem mAnalyzePermutationArray;
        private System.Windows.Forms.ToolStripMenuItem mWindowCloseAll;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnPeptideArray;
        private System.Windows.Forms.ToolStripButton btnPermutationArray;
        private System.Windows.Forms.ToolStripButton btnPeptideList;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mAnalyzeOPALArray;
        private System.Windows.Forms.ToolStripButton btnOPALArray;
        private System.Windows.Forms.ToolStripMenuItem mSettingsPermutationArray;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSequenceGenerator;
        private System.Windows.Forms.ToolStripMenuItem mTools;
        private System.Windows.Forms.ToolStripMenuItem mToolsSequenceGenerator;
    }
}

