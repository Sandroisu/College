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
    public partial class Form2 : Form
    {
        private int studentId;
        private SqlConnection myConnection;
        private bool isExist;
        public Form2(bool exists, int stId, SqlConnection sql)
        {
          
            this.studentId = stId;
            this.myConnection = sql;
            this.isExist = exists;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (isExist)
            {
                button1.Text = "Изменить";
                myConnection.Open();
                string sql = @" SELECT StudentName, Gruppa, Course, Speciality FROM Students where StudentId = @StudentId";

                using (SqlCommand comm = new SqlCommand(sql, myConnection))
                {
                    comm.Parameters.AddWithValue("@StudentId", studentId);

                    SqlDataReader reader = comm.ExecuteReader();
                    {
                        if (!reader.Read())
                            throw new Exception("Something is very wrong");

                        String name = reader.GetString(0).Trim();
                        String grup = reader.GetString(1).Trim();
                        String kurs = reader.GetString(2).Trim();
                        String spec = reader.GetString(3).Trim();
                       
                        textBox1.Text = name;
                        textBox2.Text = grup;
                        textBox3.Text = kurs;
                        textBox4.Text = spec;
                    }
                    myConnection.Close();
                }
            }
            else {
                button1.Text = "Добавить";
            }
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isExist)
            {
                string query1 = "UPDATE Students set StudentName = @StudentName, Gruppa= @Gruppa, Course= @Course, Speciality= @Speciality Where StudentId = @StudentId";

                myConnection.Open();
                SqlCommand myCommand1 = new SqlCommand(query1, myConnection);
                myCommand1.Parameters.AddWithValue("@StudentId", studentId);
                myCommand1.Parameters.AddWithValue("@StudentName", textBox1.Text.ToString());
                myCommand1.Parameters.AddWithValue("@Gruppa", textBox2.Text.ToString());
                myCommand1.Parameters.AddWithValue("@Course", textBox3.Text.ToString());
                myCommand1.Parameters.AddWithValue("@Speciality", textBox4.Text.ToString());
                myCommand1.ExecuteNonQuery();
                myConnection.Close();
            }
            else
            {
                if (textBox1.Text.Length < 1)
                {
                    MessageBox.Show("Поле Фамилия должно быть не пустым", "Ошибка!");
                    return;
                }
                string query = "INSERT INTO Students (StudentName, Gruppa, Course, Speciality)";
                query += " VALUES (@StudentName, @Gruppa, @Course, @Speciality)";
                myConnection.Open();
                SqlCommand myCommand = new SqlCommand(query, myConnection);
                myCommand.Parameters.AddWithValue("@StudentName", textBox1.Text.ToString());
                myCommand.Parameters.AddWithValue("@Gruppa", textBox2.Text.ToString());
                myCommand.Parameters.AddWithValue("@Course", textBox3.Text.ToString());
                myCommand.Parameters.AddWithValue("@Speciality", textBox4.Text.ToString());

                // ... other parameters
                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            this.Close();
            
        }
    }

   
}
