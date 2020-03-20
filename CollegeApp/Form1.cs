using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace CollegeApp
{
    public partial class Form1 : Form
    {
        private Form2 childForm;
        private Form3 parentForm;
        private Form4 oplataForm;
        private const string connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\a-slatinin\Documents\CollegeDB.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection myConnection;
        public Form1()
        {
            InitializeComponent();
            myConnection = new SqlConnection(connStr);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "collegeDBDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.collegeDBDataSet.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "collegeDBDataSet.Parents". При необходимости она может быть перемещена или удалена.
            this.parentsTableAdapter.Fill(this.collegeDBDataSet.Parents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "collegeDBDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.collegeDBDataSet.Students);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "collegeDBDataSet.Table". При необходимости она может быть перемещена или удалена.
            this.tableTableAdapter.Fill(this.collegeDBDataSet.Table);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "collegeDBDataSet.Parents". При необходимости она может быть перемещена или удалена.
            this.parentsTableAdapter.Fill(this.collegeDBDataSet.Parents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "collegeDBDataSet.Students". При необходимости она может быть перемещена или удалена.
            this.studentsTableAdapter.Fill(this.collegeDBDataSet.Students);

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows[0].Selected = true;
            }

            if (dataGridView3.Rows.Count > 0)
            {
                dataGridView3.Rows[0].Selected = true;
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            setParents();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            oplataForm = new Form4(id, myConnection, false, "", new DateTime());
            oplataForm.FormClosing += new FormClosingEventHandler(this.Form4_FormClosing);
            oplataForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isExist = false;
            if (dataGridView1.SelectedRows[0].Cells[0].Value == null)
            {

                MessageBox.Show("Сначала выберите студента", "Ошибка!");

                return;
            }
            string currentStudentId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            for (int i = 0; i < this.collegeDBDataSet.Parents.Rows.Count; i++)
            {

                string perentStudentId = this.collegeDBDataSet.Parents.Rows[i][0].ToString();
                if (currentStudentId.Equals(perentStudentId))
                {
                    isExist = true;
                }
            }
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            string otec = label3.Text.ToString();
            string mat = label4.Text.ToString();
            parentForm = new Form3(isExist, id, myConnection, otec, mat);
            parentForm.FormClosing += new FormClosingEventHandler(this.Form3_FormClosing);
            parentForm.Show();

        }


        private void button4_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Parents WHERE StudentId = @StudentId";
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@StudentId", 35);


            myCommand.ExecuteNonQuery();
            myConnection.Close();
            this.parentsTableAdapter.Fill(this.collegeDBDataSet.Parents);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0 || dataGridView1.SelectedRows[0].Cells[0].Value == null || dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            int seletion = (int)dataGridView1.SelectedRows[0].Index;
            string currentId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string query = "DELETE FROM Students WHERE StudentId = @StudentId";
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@StudentId", currentId);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            string query1 = "DELETE FROM Parents WHERE StudentId = @StudentId";
            myConnection.Open();
            SqlCommand myCommand1 = new SqlCommand(query1, myConnection);
            myCommand1.Parameters.AddWithValue("@StudentId", currentId);
            myCommand1.ExecuteNonQuery();
            myConnection.Close();
            string query2 = "DELETE FROM [Table] WHERE StudentId = @StudentId";
            myConnection.Open();
            SqlCommand myCommand2 = new SqlCommand(query2, myConnection);
            myCommand2.Parameters.AddWithValue("@StudentId", currentId);
            myCommand2.ExecuteNonQuery();
            myConnection.Close();
            this.studentsTableAdapter.Fill(this.collegeDBDataSet.Students);
            this.parentsTableAdapter.Fill(this.collegeDBDataSet.Parents);
            this.tableTableAdapter.Fill(this.collegeDBDataSet.Table);
            label3.Text = "Нет данных";
            label4.Text = "Нет данных";
            if (dataGridView1.Rows.Count != 0)
            {
                dataGridView1.Rows[seletion].Selected = true;
            }


        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.studentsTableAdapter.Fill(this.collegeDBDataSet.Students);
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.parentsTableAdapter.Fill(this.collegeDBDataSet.Parents);
            setParents();
        }
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.tableTableAdapter.Fill(this.collegeDBDataSet.Table);
            dataGridView3.Sort(dataGridView3.Columns[0], ListSortDirection.Ascending);
        }

        private void setParents()
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {

                string g = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        return;
                    }
                    string p = row.Cells[0].Value.ToString();
                    if (p.Equals(g))
                    {
                        if (row.Cells[1].Value.ToString().Length > 0)
                        {
                            label3.Text = row.Cells[1].Value.ToString();
                        }
                        else
                        {
                            label3.Text = "Нет данных";
                        }
                        if (row.Cells[2].Value.ToString().Length > 0)
                        {
                            label4.Text = row.Cells[2].Value.ToString();
                        }
                        else
                        {
                            label4.Text = "Нет данных";
                        }
                        return;
                    }
                    else
                    {
                        label3.Text = "Нет данных";
                        label4.Text = "Нет данных";
                    }
                }
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            childForm = new Form2(true, id, myConnection);
            childForm.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);
            childForm.Show();
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            childForm = new Form2(false, 0, myConnection);
            childForm.FormClosing += new FormClosingEventHandler(this.Form2_FormClosing);
            childForm.Show();
        }

        private void changeOplata(object sender, EventArgs e)
        {
            int id = (int)dataGridView3.SelectedRows[0].Cells[0].Value;
            string date = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            string summa = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
            oplataForm = new Form4(id, myConnection, true, summa, DateTime.Parse(date));
            oplataForm.FormClosing += new FormClosingEventHandler(this.Form4_FormClosing);
            oplataForm.Show();
        }

        private void deleteOplata(object sender, EventArgs e)
        {
            string currentId = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            string oplataDate = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            string query = "DELETE FROM [Table] WHERE StudentId = @StudentId and DataOplati = @data";
            DateTime time = DateTime.Parse(oplataDate);
            myConnection.Open();
            SqlCommand myCommand = new SqlCommand(query, myConnection);
            myCommand.Parameters.AddWithValue("@StudentId", currentId);
            myCommand.Parameters.AddWithValue("@data", time.ToString("dd/M/yyyy HH:mm:ss"));
            myCommand.ExecuteNonQuery();
            myConnection.Close();
            this.tableTableAdapter.Fill(this.collegeDBDataSet.Table);
        }

        private void outLoad(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 1 || dataGridView1.Rows[0].Cells[0].Value == null) {
                return;
            }
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Interactive = false;
            ExcelApp.Cells[1, 1] = "№п/п";
            ExcelApp.Cells[1, 2] = "Фамилия И.О. студента";
            ExcelApp.Cells[1, 3] = "Группа";
            ExcelApp.Cells[1, 4] = "Курс";
            ExcelApp.Cells[1, 5] = "Специальность";
            ExcelApp.Cells[1, 6] = "Фамилия И.О. отца";
            ExcelApp.Cells[1, 7] = "Фамилия И.О. матери";
            ExcelApp.Cells[1, 8] = "Всего оплачено";
            
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {

                string id = dataGridView1.Rows[i].Cells[0].Value.ToString();
                string name = dataGridView1.Rows[i].Cells[1].Value.ToString();
                string gruppa = dataGridView1.Rows[i].Cells[2].Value.ToString();
                string kurs = dataGridView1.Rows[i].Cells[3].Value.ToString();
                string spec = dataGridView1.Rows[i].Cells[4].Value.ToString();
                string papa = "";
                string mama = "";
                int sum = 0;
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        break;
                    }
                    string parents = row.Cells[0].Value.ToString();
                    if (parents.Equals(id))
                    {
                        if (row.Cells[1].Value.ToString().Length > 0)
                        {
                            papa = row.Cells[1].Value.ToString();
                        }
                        else
                        {
                            papa = "Нет данных";
                        }
                        if (row.Cells[2].Value.ToString().Length > 0)
                        {
                            mama = row.Cells[2].Value.ToString();
                        }
                        else
                        {
                            mama = "Нет данных";
                        }

                    }
                }

                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (row.Cells[0].Value == null)
                    {
                        break;
                    }
                    string oplata = row.Cells[0].Value.ToString();
                    if (oplata.Equals(id))
                    {
                        if (row.Cells[2].Value.ToString().Length > 0)
                        {
                            sum = sum + Int32.Parse(row.Cells[2].Value.ToString().Trim());
                        }


                    }
                }

                ExcelApp.Cells[i + 2, 1] = i + 1;
                ExcelApp.Cells[i + 2, 2] = name;
                ExcelApp.Cells[i + 2, 3] = gruppa;
                ExcelApp.Cells[i + 2, 4] = kurs;
                ExcelApp.Cells[i + 2, 5] = spec;
                ExcelApp.Cells[i + 2, 6] = papa;
                ExcelApp.Cells[i + 2, 7] = mama;
                ExcelApp.Cells[i + 2, 8] = sum;

            }
            ExcelApp.Interactive = true;
            ExcelApp.Visible = true;
        } 
    }
}
