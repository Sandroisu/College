namespace CollegeApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addStudent = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.oplataChange = new System.Windows.Forms.Button();
            this.oplataDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadOut = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.collegeDBDataSet = new CollegeApp.CollegeDBDataSet();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentsTableAdapter = new CollegeApp.CollegeDBDataSetTableAdapters.StudentsTableAdapter();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruppaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parentsTableAdapter = new CollegeApp.CollegeDBDataSetTableAdapters.ParentsTableAdapter();
            this.studentIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOotecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOmatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new CollegeApp.CollegeDBDataSetTableAdapters.TableTableAdapter();
            this.studentIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataOplatiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.summaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить оплату";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.gruppaDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(545, 162);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Редактировать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Фамилия И.О. отца:";
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(6, 187);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(132, 23);
            this.addStudent.TabIndex = 9;
            this.addStudent.Text = "Добавить студента";
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 128);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о родителях";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Нет данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Нет данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Фамилия И.О. матери:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(282, 187);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 23);
            this.button5.TabIndex = 8;
            this.button5.Text = "Удалить студента";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(144, 187);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Редактировать запись";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn2,
            this.dataOplatiDataGridViewTextBoxColumn,
            this.summaDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.tableBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(6, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(347, 295);
            this.dataGridView3.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIdDataGridViewTextBoxColumn1,
            this.fIOotecDataGridViewTextBoxColumn,
            this.fIOmatDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.parentsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(557, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(25, 35);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.Visible = false;
            // 
            // oplataChange
            // 
            this.oplataChange.Location = new System.Drawing.Point(114, 320);
            this.oplataChange.Name = "oplataChange";
            this.oplataChange.Size = new System.Drawing.Size(102, 23);
            this.oplataChange.TabIndex = 13;
            this.oplataChange.Text = "Изменить";
            this.oplataChange.Click += new System.EventHandler(this.changeOplata);
            // 
            // oplataDelete
            // 
            this.oplataDelete.Location = new System.Drawing.Point(222, 320);
            this.oplataDelete.Name = "oplataDelete";
            this.oplataDelete.Size = new System.Drawing.Size(102, 23);
            this.oplataDelete.TabIndex = 12;
            this.oplataDelete.Text = "Удалить";
            this.oplataDelete.UseVisualStyleBackColor = true;
            this.oplataDelete.Click += new System.EventHandler(this.deleteOplata);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.loadOut);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.addStudent);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Location = new System.Drawing.Point(12, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 374);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Личные данные студентов";
            // 
            // loadOut
            // 
            this.loadOut.Location = new System.Drawing.Point(420, 187);
            this.loadOut.Name = "loadOut";
            this.loadOut.Size = new System.Drawing.Size(132, 23);
            this.loadOut.TabIndex = 10;
            this.loadOut.Text = "Выгрузить отчет";
            this.loadOut.UseVisualStyleBackColor = true;
            this.loadOut.Click += new System.EventHandler(this.outLoad);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView3);
            this.groupBox3.Controls.Add(this.oplataDelete);
            this.groupBox3.Controls.Add(this.oplataChange);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(588, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 374);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Данные об оплате";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.collegeDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // collegeDBDataSet
            // 
            this.collegeDBDataSet.DataSetName = "CollegeDBDataSet";
            this.collegeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.bindingSource1;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // gruppaDataGridViewTextBoxColumn
            // 
            this.gruppaDataGridViewTextBoxColumn.DataPropertyName = "Gruppa";
            this.gruppaDataGridViewTextBoxColumn.HeaderText = "Gruppa";
            this.gruppaDataGridViewTextBoxColumn.Name = "gruppaDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "Speciality";
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            // 
            // parentsBindingSource
            // 
            this.parentsBindingSource.DataMember = "Parents";
            this.parentsBindingSource.DataSource = this.bindingSource1;
            // 
            // parentsTableAdapter
            // 
            this.parentsTableAdapter.ClearBeforeFill = true;
            // 
            // studentIdDataGridViewTextBoxColumn1
            // 
            this.studentIdDataGridViewTextBoxColumn1.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn1.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn1.Name = "studentIdDataGridViewTextBoxColumn1";
            // 
            // fIOotecDataGridViewTextBoxColumn
            // 
            this.fIOotecDataGridViewTextBoxColumn.DataPropertyName = "FIOotec";
            this.fIOotecDataGridViewTextBoxColumn.HeaderText = "FIOotec";
            this.fIOotecDataGridViewTextBoxColumn.Name = "fIOotecDataGridViewTextBoxColumn";
            // 
            // fIOmatDataGridViewTextBoxColumn
            // 
            this.fIOmatDataGridViewTextBoxColumn.DataPropertyName = "FIOmat";
            this.fIOmatDataGridViewTextBoxColumn.HeaderText = "FIOmat";
            this.fIOmatDataGridViewTextBoxColumn.Name = "fIOmatDataGridViewTextBoxColumn";
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.bindingSource1;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // studentIdDataGridViewTextBoxColumn2
            // 
            this.studentIdDataGridViewTextBoxColumn2.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn2.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn2.Name = "studentIdDataGridViewTextBoxColumn2";
            // 
            // dataOplatiDataGridViewTextBoxColumn
            // 
            this.dataOplatiDataGridViewTextBoxColumn.DataPropertyName = "DataOplati";
            this.dataOplatiDataGridViewTextBoxColumn.HeaderText = "DataOplati";
            this.dataOplatiDataGridViewTextBoxColumn.Name = "dataOplatiDataGridViewTextBoxColumn";
            // 
            // summaDataGridViewTextBoxColumn
            // 
            this.summaDataGridViewTextBoxColumn.DataPropertyName = "Summa";
            this.summaDataGridViewTextBoxColumn.HeaderText = "Summa";
            this.summaDataGridViewTextBoxColumn.Name = "summaDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 395);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.Text = "Ведомость оплат";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button oplataChange;
        private System.Windows.Forms.Button oplataDelete;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button loadOut;
        private System.Windows.Forms.BindingSource bindingSource1;
        private CollegeDBDataSet collegeDBDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private CollegeDBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gruppaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource parentsBindingSource;
        private CollegeDBDataSetTableAdapters.ParentsTableAdapter parentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOotecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOmatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private CollegeDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataOplatiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn summaDataGridViewTextBoxColumn;
    }
}

