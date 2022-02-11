using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm2
{
    public partial class Form1 : Form
    {
        private string source, dest,cl;
        public Form1()
        {
            InitializeComponent();
        }
        #region
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listS_SelectedIndexChanged(object sender, EventArgs e)
        {
            source = listS.Text;
        }

        private void listC_SelectedIndexChanged(object sender, EventArgs e)
        {
            cl = listC.Text;
        }

        private void btV_Click(object sender, EventArgs e)
        {
            if (source == dest)
            {
                MessageBox.Show("Source and Destination can't be the same");
                listS.Focus();
            }
            else
                MessageBox.Show("Data Verified");
        }

        private void btC_Click(object sender, EventArgs e)
        {
            txtTK.Text = "";
            txtPName.Text = "";
            txtPNO.Text = "";
            txtFD.Text = "";
            listC.ClearSelected();
            listS.ClearSelected();
            listD.ClearSelected();
            ClistS.Items.Clear();
            this.ClistS.Items.AddRange(new Object[]
            {
               "Child Care",
               "Nurse",
               "Wheel Chair"
            });
        }

        private void listD_SelectedIndexChanged(object sender, EventArgs e)
        {
            dest = listD.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
