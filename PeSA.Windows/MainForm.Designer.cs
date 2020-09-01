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
            this.mAnalyze = new System.Windows.Forms.ToolStripMenuItem();
            this.mAnalyzePeptideList = new System.Windows.Forms.ToolStripMenuItem();
            this.mAnalyzePeptideArray = new System.Windows.Forms.ToolStripMenuItem();
            this.mAnalyzePermutationArray = new System.Windows.Forms.ToolStripMenuItem();
            this.mAnalyzeOPALArray = new System.Windows.Forms.ToolStripMenuItem();
            this.mTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolsSequenceGenerator = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolsMotifBasedPeptideScorer = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolsMotifBasedProteinScorer = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolsMotifValidationDesigner = new System.Windows.Forms.ToolStripMenuItem();
            this.mSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mSettingsMotif = new System.Windows.Forms.ToolStripMenuItem();
            this.mSettingsAminoAcidList = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMotifBasedPeptideScorer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMotifBasedProteinScorer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMotifValidationDesigner = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAnalyze,
            this.mTools,
            this.mSettings,
            this.mWindow,
            this.mHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(984, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mAnalyze
            // 
            this.mAnalyze.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAnalyzePeptideList,
            this.mAnalyzePeptideArray,
            this.mAnalyzePermutationArray,
            this.mAnalyzeOPALArray});
            this.mAnalyze.Name = "mAnalyze";
            this.mAnalyze.Size = new System.Drawing.Size(75, 24);
            this.mAnalyze.Text = "Analyze";
            // 
            // mAnalyzePeptideList
            // 
            this.mAnalyzePeptideList.Name = "mAnalyzePeptideList";
            this.mAnalyzePeptideList.Size = new System.Drawing.Size(291, 26);
            this.mAnalyzePeptideList.Text = "Create Motif from Peptide List";
            this.mAnalyzePeptideList.Click += new System.EventHandler(this.mAnalyzePeptideList_Click);
            // 
            // mAnalyzePeptideArray
            // 
            this.mAnalyzePeptideArray.Name = "mAnalyzePeptideArray";
            this.mAnalyzePeptideArray.Size = new System.Drawing.Size(291, 26);
            this.mAnalyzePeptideArray.Text = "Analyze Peptide Array";
            this.mAnalyzePeptideArray.Click += new System.EventHandler(this.mAnalyzePeptideArray_Click);
            // 
            // mAnalyzePermutationArray
            // 
            this.mAnalyzePermutationArray.Name = "mAnalyzePermutationArray";
            this.mAnalyzePermutationArray.Size = new System.Drawing.Size(291, 26);
            this.mAnalyzePermutationArray.Text = "Analyze Permutation Array";
            this.mAnalyzePermutationArray.Click += new System.EventHandler(this.mAnalyzePermutationArray_Click);
            // 
            // mAnalyzeOPALArray
            // 
            this.mAnalyzeOPALArray.Name = "mAnalyzeOPALArray";
            this.mAnalyzeOPALArray.Size = new System.Drawing.Size(291, 26);
            this.mAnalyzeOPALArray.Text = "Analyze OPAL Array";
            this.mAnalyzeOPALArray.Click += new System.EventHandler(this.mAnalyzeOPALArray_Click);
            // 
            // mTools
            // 
            this.mTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolsSequenceGenerator,
            this.mToolsMotifBasedPeptideScorer,
            this.mToolsMotifBasedProteinScorer,
            this.mToolsMotifValidationDesigner});
            this.mTools.Name = "mTools";
            this.mTools.Size = new System.Drawing.Size(58, 24);
            this.mTools.Text = "Tools";
            // 
            // mToolsSequenceGenerator
            // 
            this.mToolsSequenceGenerator.Name = "mToolsSequenceGenerator";
            this.mToolsSequenceGenerator.Size = new System.Drawing.Size(298, 26);
            this.mToolsSequenceGenerator.Text = "Sequence Generator";
            this.mToolsSequenceGenerator.Click += new System.EventHandler(this.mToolsSequenceGenerator_Click);
            // 
            // mToolsMotifBasedPeptideScorer
            // 
            this.mToolsMotifBasedPeptideScorer.Name = "mToolsMotifBasedPeptideScorer";
            this.mToolsMotifBasedPeptideScorer.Size = new System.Drawing.Size(298, 26);
            this.mToolsMotifBasedPeptideScorer.Text = "Motif Based Peptide List Scorer";
            this.mToolsMotifBasedPeptideScorer.Click += new System.EventHandler(this.mToolsMotifBasedPeptideScorer_Click);
            // 
            // mToolsMotifBasedProteinScorer
            // 
            this.mToolsMotifBasedProteinScorer.Name = "mToolsMotifBasedProteinScorer";
            this.mToolsMotifBasedProteinScorer.Size = new System.Drawing.Size(298, 26);
            this.mToolsMotifBasedProteinScorer.Text = "Motif Based Protein Scorer";
            this.mToolsMotifBasedProteinScorer.Click += new System.EventHandler(this.mToolsMotifBasedProteinScorer_Click);
            // 
            // mToolsMotifValidationDesigner
            // 
            this.mToolsMotifValidationDesigner.Name = "mToolsMotifValidationDesigner";
            this.mToolsMotifValidationDesigner.Size = new System.Drawing.Size(298, 26);
            this.mToolsMotifValidationDesigner.Text = "Motif Validation Designer";
            this.mToolsMotifValidationDesigner.Click += new System.EventHandler(this.mToolsMotifValidationDesigner_Click);
            // 
            // mSettings
            // 
            this.mSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mSettingsMotif,
            this.mSettingsAminoAcidList});
            this.mSettings.Name = "mSettings";
            this.mSettings.Size = new System.Drawing.Size(76, 24);
            this.mSettings.Text = "Settings";
            // 
            // mSettingsMotif
            // 
            this.mSettingsMotif.Name = "mSettingsMotif";
            this.mSettingsMotif.Size = new System.Drawing.Size(226, 26);
            this.mSettingsMotif.Text = "Array/Motif Settings";
            this.mSettingsMotif.Click += new System.EventHandler(this.mSettingsMotif_Click);
            // 
            // mSettingsAminoAcidList
            // 
            this.mSettingsAminoAcidList.Name = "mSettingsAminoAcidList";
            this.mSettingsAminoAcidList.Size = new System.Drawing.Size(226, 26);
            this.mSettingsAminoAcidList.Text = "Amino Acid List";
            this.mSettingsAminoAcidList.Click += new System.EventHandler(this.mSettingsAminoAcidList_Click);
            // 
            // mWindow
            // 
            this.mWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mWindowCascadeAll,
            this.mWindowTileAll,
            this.mWindowCloseAll});
            this.mWindow.Name = "mWindow";
            this.mWindow.Size = new System.Drawing.Size(78, 24);
            this.mWindow.Text = "Window";
            // 
            // mWindowCascadeAll
            // 
            this.mWindowCascadeAll.Name = "mWindowCascadeAll";
            this.mWindowCascadeAll.Size = new System.Drawing.Size(169, 26);
            this.mWindowCascadeAll.Text = "Cascade All";
            this.mWindowCascadeAll.Click += new System.EventHandler(this.mWindowCascadeAll_Click);
            // 
            // mWindowTileAll
            // 
            this.mWindowTileAll.Name = "mWindowTileAll";
            this.mWindowTileAll.Size = new System.Drawing.Size(169, 26);
            this.mWindowTileAll.Text = "Tile";
            this.mWindowTileAll.Click += new System.EventHandler(this.mWindowTileAll_Click);
            // 
            // mWindowCloseAll
            // 
            this.mWindowCloseAll.Name = "mWindowCloseAll";
            this.mWindowCloseAll.Size = new System.Drawing.Size(169, 26);
            this.mWindowCloseAll.Text = "Close All";
            this.mWindowCloseAll.Click += new System.EventHandler(this.mWindowCloseAll_Click);
            // 
            // mHelp
            // 
            this.mHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAbout});
            this.mHelp.Name = "mHelp";
            this.mHelp.Size = new System.Drawing.Size(55, 24);
            this.mHelp.Text = "Help";
            // 
            // mAbout
            // 
            this.mAbout.Name = "mAbout";
            this.mAbout.Size = new System.Drawing.Size(133, 26);
            this.mAbout.Text = "About";
            this.mAbout.Click += new System.EventHandler(this.mAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.White;
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
            this.btnSequenceGenerator,
            this.toolStripSeparator5,
            this.btnMotifBasedPeptideScorer,
            this.toolStripSeparator6,
            this.btnMotifBasedProteinScorer,
            this.toolStripSeparator8,
            this.btnMotifValidationDesigner,
            this.toolStripSeparator7});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(984, 72);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnPeptideList
            // 
            this.btnPeptideList.BackColor = System.Drawing.Color.White;
            this.btnPeptideList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPeptideList.Image = ((System.Drawing.Image)(resources.GetObject("btnPeptideList.Image")));
            this.btnPeptideList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPeptideList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPeptideList.Name = "btnPeptideList";
            this.btnPeptideList.Size = new System.Drawing.Size(68, 69);
            this.btnPeptideList.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPeptideList.Click += new System.EventHandler(this.btnPeptideList_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 72);
            // 
            // btnPeptideArray
            // 
            this.btnPeptideArray.BackColor = System.Drawing.Color.White;
            this.btnPeptideArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPeptideArray.Image = ((System.Drawing.Image)(resources.GetObject("btnPeptideArray.Image")));
            this.btnPeptideArray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPeptideArray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPeptideArray.Name = "btnPeptideArray";
            this.btnPeptideArray.Size = new System.Drawing.Size(68, 69);
            this.btnPeptideArray.Click += new System.EventHandler(this.btnPeptideArray_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 72);
            // 
            // btnPermutationArray
            // 
            this.btnPermutationArray.BackColor = System.Drawing.Color.White;
            this.btnPermutationArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPermutationArray.Image = ((System.Drawing.Image)(resources.GetObject("btnPermutationArray.Image")));
            this.btnPermutationArray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnPermutationArray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPermutationArray.Name = "btnPermutationArray";
            this.btnPermutationArray.Size = new System.Drawing.Size(68, 69);
            this.btnPermutationArray.Click += new System.EventHandler(this.btnPermutationArray_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 72);
            // 
            // btnOPALArray
            // 
            this.btnOPALArray.BackColor = System.Drawing.Color.White;
            this.btnOPALArray.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOPALArray.Image = ((System.Drawing.Image)(resources.GetObject("btnOPALArray.Image")));
            this.btnOPALArray.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnOPALArray.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOPALArray.Name = "btnOPALArray";
            this.btnOPALArray.Size = new System.Drawing.Size(68, 69);
            this.btnOPALArray.Click += new System.EventHandler(this.btnOPALArray_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 72);
            // 
            // btnSequenceGenerator
            // 
            this.btnSequenceGenerator.BackColor = System.Drawing.Color.White;
            this.btnSequenceGenerator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSequenceGenerator.Image = ((System.Drawing.Image)(resources.GetObject("btnSequenceGenerator.Image")));
            this.btnSequenceGenerator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSequenceGenerator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSequenceGenerator.Name = "btnSequenceGenerator";
            this.btnSequenceGenerator.Size = new System.Drawing.Size(68, 69);
            this.btnSequenceGenerator.Click += new System.EventHandler(this.btnSequenceGenerator_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 72);
            // 
            // btnMotifBasedPeptideScorer
            // 
            this.btnMotifBasedPeptideScorer.BackColor = System.Drawing.Color.White;
            this.btnMotifBasedPeptideScorer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMotifBasedPeptideScorer.Image = ((System.Drawing.Image)(resources.GetObject("btnMotifBasedPeptideScorer.Image")));
            this.btnMotifBasedPeptideScorer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMotifBasedPeptideScorer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMotifBasedPeptideScorer.Name = "btnMotifBasedPeptideScorer";
            this.btnMotifBasedPeptideScorer.Size = new System.Drawing.Size(68, 69);
            this.btnMotifBasedPeptideScorer.Click += new System.EventHandler(this.btnMotifBasedPeptideScorer_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 72);
            // 
            // btnMotifBasedProteinScorer
            // 
            this.btnMotifBasedProteinScorer.BackColor = System.Drawing.Color.White;
            this.btnMotifBasedProteinScorer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMotifBasedProteinScorer.Image = ((System.Drawing.Image)(resources.GetObject("btnMotifBasedProteinScorer.Image")));
            this.btnMotifBasedProteinScorer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMotifBasedProteinScorer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMotifBasedProteinScorer.Name = "btnMotifBasedProteinScorer";
            this.btnMotifBasedProteinScorer.Size = new System.Drawing.Size(68, 69);
            this.btnMotifBasedProteinScorer.Click += new System.EventHandler(this.btnMotifBasedProteinScorer_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 72);
            // 
            // btnMotifValidationDesigner
            // 
            this.btnMotifValidationDesigner.BackColor = System.Drawing.Color.White;
            this.btnMotifValidationDesigner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMotifValidationDesigner.Image = ((System.Drawing.Image)(resources.GetObject("btnMotifValidationDesigner.Image")));
            this.btnMotifValidationDesigner.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMotifValidationDesigner.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMotifValidationDesigner.Name = "btnMotifValidationDesigner";
            this.btnMotifValidationDesigner.Size = new System.Drawing.Size(68, 69);
            this.btnMotifValidationDesigner.Click += new System.EventHandler(this.btnMotifValidationDesigner_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 72);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 682);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Peptide Specificity Analyst - PeSA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSequenceGenerator;
        private System.Windows.Forms.ToolStripMenuItem mTools;
        private System.Windows.Forms.ToolStripMenuItem mToolsSequenceGenerator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnMotifBasedPeptideScorer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mSettingsAminoAcidList;
        private System.Windows.Forms.ToolStripMenuItem mToolsMotifBasedPeptideScorer;
        private System.Windows.Forms.ToolStripMenuItem mToolsMotifValidationDesigner;
        private System.Windows.Forms.ToolStripButton btnMotifValidationDesigner;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mToolsMotifBasedProteinScorer;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripButton btnMotifBasedProteinScorer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
    }
}

