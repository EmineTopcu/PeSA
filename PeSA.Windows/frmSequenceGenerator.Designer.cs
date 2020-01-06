namespace PeSA.Windows
{
    partial class frmSequenceGenerator
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
            this.eOutput = new System.Windows.Forms.RichTextBox();
            this.eTemplate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eOutput
            // 
            this.eOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eOutput.Location = new System.Drawing.Point(8, 45);
            this.eOutput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eOutput.Name = "eOutput";
            this.eOutput.Size = new System.Drawing.Size(391, 214);
            this.eOutput.TabIndex = 7;
            this.eOutput.Text = "";
            // 
            // eTemplate
            // 
            this.eTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eTemplate.Location = new System.Drawing.Point(70, 9);
            this.eTemplate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eTemplate.Name = "eTemplate";
            this.eTemplate.Size = new System.Drawing.Size(230, 20);
            this.eTemplate.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Template";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerate.Location = new System.Drawing.Point(322, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lQuestion
            // 
            this.lQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lQuestion.AutoSize = true;
            this.lQuestion.Location = new System.Drawing.Point(304, 11);
            this.lQuestion.Name = "lQuestion";
            this.lQuestion.Size = new System.Drawing.Size(13, 13);
            this.lQuestion.TabIndex = 37;
            this.lQuestion.Text = "?";
            this.lQuestion.Click += new System.EventHandler(this.lQuestion_Click);
            // 
            // frmSequenceGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 266);
            this.Controls.Add(this.lQuestion);
            this.Controls.Add(this.eOutput);
            this.Controls.Add(this.eTemplate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSequenceGenerator";
            this.Text = "Sequence Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox eOutput;
        private System.Windows.Forms.TextBox eTemplate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lQuestion;
    }
}