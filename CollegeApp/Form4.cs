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
    public partial class Form4 : Form
    {
        private int studentId;
        private SqlConnection myConnection;
        private bool isExist;
        private string summaOplati;
        private DateTime oplataDate;
        public Form4(int stId, SqlConnection conn, bool exist, string summ, DateTime time)
        {
            this.studentId = stId;
            this.myConnection = conn;
            this.isExist = exist;
            this.summaOplati = summ;
            this.oplataDate = time;
            InitializeComponent();
            if (isExist) {
                textBox1.Text = summaOplati.Trim();
                dateTimePicker1.Value = oplataDate;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1) {
                MessageBox.Show("Поле оплаты не может быть пустым", "Ошибка!");
                return;
            }
            string time = dateTimePicker1.Value.ToString("dd/M/yyyy HH:mm:ss");
            if (!isExist)
            {
                string query = "INSERT INTO [Table] (StudentId, DataOplati, Summa)";
                query += " VALUES (@StudentId, @DataOplati, @Summa)";
               
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.AddWithValue("@StudentId", studentId);
                myCommand.Parameters.AddWithValue("@DataOplati", time);
                myCommand.Parameters.AddWithValue("@Summa", textBox1.Text.ToString());
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            else
            {
                string query1 = "UPDATE [Table] set DataOplati = @DataOplati, Summa= @Summa Where StudentId = @StudentId and DataOplati = @OplataDate";

                myConnection.Open();
                SqlCommand myCommand1 = new SqlCommand(query1, myConnection);
                myCommand1.Parameters.AddWithValue("@StudentId", studentId);
                myCommand1.Parameters.AddWithValue("@DataOplati", time);
                myCommand1.Parameters.AddWithValue("@Summa", textBox1.Text.ToString());
                myCommand1.Parameters.AddWithValue("@OplataDate", oplataDate.ToString("dd/M/yyyy HH:mm:ss"));
                myCommand1.ExecuteNonQuery();
                myConnection.Close();
            }
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }
    }
}
