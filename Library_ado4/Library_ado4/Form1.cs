using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Library_ado4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Reload_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        public void add()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OV0HT1I\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Books values ('" + txtBookTitle.Text + "','" + txtAuthor.Text + "','" + txtPage.Text + "','" + txtTopic.Text + "','" + txtCode.Text + "')", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added");
            conn.Close();
        }
        public void reload()
        {
            txtAuthor.Text = "";
            txtBookTitle.Text = "";
            txtCode.Text = "";
            txtPage.Text = "";
            txtTopic.Text = "";
            dataGrid.DataSource = null;
        }

        public void delete()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OV0HT1I\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            conn.Open();
            string sql = "Delete from Books where Title = '"+txtBookTitle.Text+"', Author= '"+txtAuthor.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            conn.Close();
        }

        public void search()
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OV0HT1I\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
            conn.Open();
            string strsql = "select * From Books";
            SqlDataAdapter adap = new SqlDataAdapter(strsql, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            dataGrid.DataSource = ds.Tables[0];
        }

        public static void modify()
        {
            Form2 f = new Form2();
        }

        private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add();
        }

        private void reloadAllRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reload();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void modifiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modify();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);

        }
    }
}
