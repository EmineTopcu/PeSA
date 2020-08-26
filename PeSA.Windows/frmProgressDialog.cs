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
    public partial class frmProgressDialog : Form
    {
        public int ProgressMax
        {
            set => progressBar1.Maximum = value;
        }
    public int ProgressValue
        {
            get => progressBar1.Value;
            set { progressBar1.Value = Math.Min(value, progressBar1.Maximum); }
        }

        public frmProgressDialog()
        {
            InitializeComponent();
        }
    }
}
