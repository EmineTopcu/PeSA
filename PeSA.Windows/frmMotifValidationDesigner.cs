using PeSA.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeSA.Windows
{
    public partial class frmMotifValidationDesigner : Form
    {
        Motif Motif;
        MotifValidator Validator;
        string Title = "Motif Validation Designer";
        string ProjectName = "";
        public frmMotifValidationDesigner()
        {
            InitializeComponent();
        }

        private void SetText(FileDialog dlg)
        {
            ProjectName = FormUtil.SetText(this, dlg, Title);
        }
        private void LoadMotif()
        {
            DialogResult dlg = dlgOpenMotif.ShowDialog();
            if (dlg != DialogResult.OK) return;
            SetText(dlgOpenMotif);
            string filename = dlgOpenMotif.FileName;
            try
            {
                Motif = Motif.ReadFromFile(filename);
            }
            catch
            {
                MessageBox.Show("The file may be corrupted or not a valid PeSA motif file.", Analyzer.ProgramName);
                return;
            }
            Validator = new MotifValidator();
            Settings settings = Settings.Load("default.settings");
            int heightImage = 200;
            int widthImage = 800;
            if (settings != null)
            {
                heightImage = settings.MotifHeight;
                widthImage = settings.MotifWidth;
            }
            mdPositive.Image = Motif.GetPositiveMotif(widthImage, heightImage);
            mdNegative.Image = Motif.GetNegativeMotif(widthImage, heightImage);
            mdChart.Image = Motif.GetBarChart(pMotif.Width - 6);
            eWildtype.Text = Motif.WildTypePeptide;
        }
        private void btnLoadMotif_Click(object sender, EventArgs e)
        {
            LoadMotif();
        }

        private void GenerateValidationSequence()
        {
            if (!int.TryParse(ePosCutoff.Text, out int pos))
                pos = 1;
            if (!int.TryParse(eNegCutoff.Text, out int neg))
                neg = 1;
            if (!Validator.Run(Motif, pos, neg))
            {
                eTemplate.Text = "";
                eOutput.Text = "";
            }
            eTemplate.Text = Validator.FullTemplate;
            eOutput.Text = "There are " + Validator.Count + " peptide sequences generated.\r\n";

            if (Validator.FullTemplate != Validator.PositiveTemplate)
                eOutput.Text += "\r\nPositive motif only: [" + Validator.PositiveSequenceList.Count() + "]\r\n";
            eOutput.Text += string.Join("\r\n", Validator.PositiveSequenceList);

            if (Validator.FullTemplate != Validator.PositiveTemplate)
            {
                eOutput.Text += "\r\n\r\nIncluding negative motif: [" + Validator.NegativeSequenceList.Count() + "]\r\n";
                eOutput.Text += string.Join("\r\n", Validator.NegativeSequenceList);
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (Motif == null) return;
            GenerateValidationSequence();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (Motif == null) return;
            dlgExcelExport.FileName = ProjectName;
            DialogResult dlg = dlgExcelExport.ShowDialog();
            if (dlg != DialogResult.OK) return;

            string filename = dlgExcelExport.FileName;
            if (FileUtil.ExportMotifValidatorToExcel(filename, Validator, true, out string errormsg))
                MessageBox.Show("Validation list and motif is exported as an excel file:" + filename, Analyzer.ProgramName);
            else if (errormsg != "")
                MessageBox.Show(errormsg, Analyzer.ProgramName);
        }
    }
}
