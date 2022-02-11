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

namespace Result_ado3
{
    public partial class Form1 : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter adap;
        private SqlDataReader reader;
        private DataSet dSetExam;
        private string sqlstr;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void populateComboBox()
        {
            this.cbbStudentCode.Items.Clear();
            cmd = new SqlCommand("select StudentCode from Student",conn);
            if ((reader != null) && (!reader.IsClosed))
                reader.Close();
            reader = cmd.ExecuteReader();
            if(reader.HasRows)
            {
                while(reader.Read())
                {
                    this.cbbStudentCode.Items.Add(reader.GetValue(0).ToString());
                }
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-OV0HT1I\SQLEXPRESS;Initial Catalog=Result;Integrated Security=True");
                cmd = new SqlCommand( "select * from Student ",conn);
                conn.Open();
                populateComboBox();
                if (reader!= null && (!reader.IsClosed))
                    reader.Close();
                sqlstr = "select Student.StudentCode, Name, Exam.ExamCode, ExamName, Score from Student, Exam, Result where Exam.ExamCode=Result.ExamCode and Student.StudentCode=Result.StudentCode";
                adap = new SqlDataAdapter(sqlstr,conn);
                dSetExam = new DataSet("ExamResult");
                adap.Fill(dSetExam, "ExamResult");
                dataGridView1.DataSource = dSetExam.Tables[0];
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.Message);
                MessageBox.Show(excep.StackTrace);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (reader != null && (!reader.IsClosed))
                reader.Close();
            sqlstr = "select Student.StudentCode, Name, Exam.ExamCode, ExamName, Score from Student, Exam, Result where Exam.ExamCode=Result.ExamCode and Student.StudentCode=Result.StudentCode and Student.StudentCode = " + Convert.ToInt32(cbbStudentCode.Text);
            adap = new SqlDataAdapter(sqlstr,conn);
            dSetExam = new DataSet("ExamResult");
            adap.Fill(dSetExam,"ExamResult");
            dataGridView1.DataSource = dSetExam.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            conn.Close();
            Application.Exit();
        }
    }
}
