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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string strconn = @"Data Source=DESKTOP-OV0HT1I\SQLEXPRESS;Initial Catalog=QLHV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strconn);
            conn.Open();
            string sql = "UPDATE Nguoidung SET tendangnhap='" + txtNewuser.Text
+ "' WHERE tendangnhap='" + txtOlduser.Text  + "'";


            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Cập Nhật thành công");
            conn.Close();
        }
    }
}
