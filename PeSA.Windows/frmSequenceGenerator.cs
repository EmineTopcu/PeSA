using PeSA.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeSA.Windows
{
    public partial class frmSequenceGenerator : Form
    {
        const string templateRules = "[ACD] will place either A, C, or D.\r\n" +
                "[-ACD] will use all amino acid residues except A, C, and D.\r\n" +
                "[{AC}{DEF}] will use sequence of AC or DEF";
        public frmSequenceGenerator()
        {
            InitializeComponent();
           
        }

        private void lQuestion_Click(object sender, EventArgs e)
        {
            MessageBox.Show(templateRules, Analyzer.ProgramName);

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            List<string> seqList = SequenceGenerator.Combinations(eTemplate.Text);
            if (seqList == null)
            {
                eOutput.Text = "Wrong template format.\r\n" + templateRules;
                return;
            }
            eOutput.Text = "There are " + seqList.Count() + " peptide sequences generated.\r\n";
            eOutput.Text += string.Join("\r\n", seqList);
        }
    }
}
