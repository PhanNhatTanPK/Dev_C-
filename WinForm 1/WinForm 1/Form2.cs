using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm_1
{
    public partial class Form2 : Form
    {
        private string edu, dep;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btCL.Enabled = false;
        }

        private void lbE_SelectedIndexChanged(object sender, EventArgs e)
        {
            edu = lbE.Text;
        }

        private void cbbD_SelectedIndexChanged(object sender, EventArgs e)
        {
            dep = cbbD.Text;
        }

        private void btCL_Click(object sender, EventArgs e)
        {
            txtAD.Text = "";
            txtDOJ.Text = "";
            txtN.Text = "";
            lbE.ClearSelected();
            cbbD.Text = "";
            btCL.Enabled = false;
        }

        private void btEX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Employee Name is: " + txtN 
                +"\nEmployee Address is: " + txtAD 
                +"\nDate of Joining is: " + txtDOJ 
                +"\nEmployee has Education: " + edu 
                +"\nEmployee belong to Department: " + dep);
          
            btCL.Enabled = true;
        }

    }
}
