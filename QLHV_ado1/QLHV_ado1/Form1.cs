using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLHV_ado1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            bool OK = false;
            string c = @"Data Source=DESKTOP-OV0HT1I\SQLEXPRESS;Initial Catalog=QLHV;Integrated Security=True";
            SqlConnection conn = new SqlConnection(c);
            SqlDataReader rdr = null;
            
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select * from nguoidung", conn);
                rdr = cmd.ExecuteReader();
                while(rdr.Read())
                {
                    if ((txtUserName.Text.Trim() == rdr["tendangnhap"].ToString().Trim()) &&
                        (txtPassword.Text.Trim() == rdr["matkhau"].ToString().Trim()))
                    { OK = true; }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Khong ket noi duoc CSDL");
                return;
            }
            finally
            {
                if (rdr != null)
                    rdr.Close();
                if (conn != null)
                    conn.Close();
            }
            if (OK == false)
                MessageBox.Show("Mật khẩu hoặc tài khoản không đúng");
            else
                MessageBox.Show("Đăng nhập thành công");
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
