using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeApp
{
    public partial class Form3 : Form
    {
        private int studentId;
        private SqlConnection myConnection;
        private bool isExist;
        private string fioOtec;
        private string fioMat;

        public Form3(bool exists, int stId, SqlConnection sql, string otec, string mat)
        {
            this.studentId = stId;
            this.myConnection = sql;
            this.isExist = exists;
            this.fioOtec = otec.Trim();
            this.fioMat = mat.Trim();
            InitializeComponent();
            textBox1.Text = fioOtec;
            textBox2.Text = fioMat;
        }
        public Form3()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isExist) { 
            string query = "INSERT INTO Parents (StudentId, FIOotec, FIOmat)";
            query += " VALUES (@StudentId, @FIOotec, @FIOmat)";
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@StudentId", studentId);
            myCommand.Parameters.AddWithValue("@FIOotec", textBox1.Text.ToString());
            myCommand.Parameters.AddWithValue("@FIOmat", textBox2.Text.ToString());
      

            myCommand.ExecuteNonQuery();
            myConnection.Close();
            }
            else
            {
                string query1 = "UPDATE Parents set FIOotec = @FIOotec, FIOmat= @FIOmat Where StudentId = @StudentId";
        
                myConnection.Open();
                SqlCommand myCommand1 = new SqlCommand(query1, myConnection);
                myCommand1.Parameters.AddWithValue("@StudentId", studentId);
                myCommand1.Parameters.AddWithValue("@FIOotec", textBox1.Text.ToString());
                myCommand1.Parameters.AddWithValue("@FIOmat", textBox2.Text.ToString());
                myCommand1.ExecuteNonQuery();
                myConnection.Close();
            }
            this.Close();
        }
    }
}
