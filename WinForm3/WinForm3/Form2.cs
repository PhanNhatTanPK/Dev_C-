using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addtionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int rs = Convert.ToInt32(txtFN.Text) + Convert.ToInt32(txtSN.Text);
            txtR.Text = rs.ToString();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decimal rsr = Convert.ToInt32(txtFN) / Convert.ToInt32(txtSN);
            txtR.Text = rsr.ToString();
        }

        private void multiplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32(txtFN) * Convert.ToInt32(txtSN);
            txtR.Text = r.ToString();
        }

        private void subtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            txtR.Text = (Convert.ToInt32(txtFN) - Convert.ToInt32(txtSN)).ToString();
        }

        private void btCL_Click(object sender, EventArgs e)
        {
            txtR.Text = "";
            txtFN.Text = "";
            txtSN.Text = "";
            btCL.Enabled = false;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
