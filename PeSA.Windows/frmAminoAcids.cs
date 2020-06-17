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
    public partial class frmAminoAcids : Form
    {
        Settings settings;
        public frmAminoAcids()
        {
            InitializeComponent();
            settings = Settings.Load("default.settings");
            LoadGrid();
        }

        private void LoadGrid()
        {
            dgAminoAcid.RowCount = 0;
            foreach (AminoAcid aa in AminoAcids.GetSortedFullAminoAcidList())
            {
                int rowind = dgAminoAcid.RowCount++;
                dgAminoAcid[0, rowind].Value = aa.Name;
                dgAminoAcid[1, rowind].Value = aa.Abbrev1;
                if (settings.AminoAcidExcludeList != null && settings.AminoAcidExcludeList.Contains(aa.Abbrev1))
                    dgAminoAcid[2, rowind].Value = false;
                else
                    dgAminoAcid[2, rowind].Value = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settings.AminoAcidExcludeList = new List<char>();
            for (int rowind = 0; rowind < dgAminoAcid.RowCount; rowind++)
            {
                if ((bool)dgAminoAcid[2, rowind].Value == false)
                    settings.AminoAcidExcludeList.Add((char)dgAminoAcid[1, rowind].Value);
            }
            if (!settings.Save("default.settings"))
                MessageBox.Show("There was a problem in savings the settings.");
            else
                MessageBox.Show("Modifications are saved.");
        }

    }
}
