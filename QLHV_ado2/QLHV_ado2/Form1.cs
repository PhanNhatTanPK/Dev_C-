using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHV_ado2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string strconn = @"Data Source=DESKTOP-OV0HT1I\SQLEXPRESS;Initial Catalog=QLHV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string sql = "INSERT into nguoidung values ('" + txtUserName.Text + "',' "+ txtPassword.Text +"')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã thêm thành công");
            conn.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string strconn = @"Data Source=DESKTOP-OV0HT1I\SQLEXPRESS;Initial Catalog=QLHV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string sql = "DELETE FROM nguoidung WHERE tendangnhap = '" + txtUserName.Text + " '";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Đã xóa thành công");
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLHVDataSet.nguoidung' table. You can move, or remove it, as needed.
            this.nguoidungTableAdapter.Fill(this.qLHVDataSet.nguoidung);

        }

        private void DGView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
