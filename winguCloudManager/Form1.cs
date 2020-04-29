using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winguCloudManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage1");
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage2");
        }

        private void btnResource_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage3");
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage4");
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage5");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("tabPage6");
        }
    }
}
