using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static string connectString = "Data Source=DESKTOP-RJR1A23;Initial Catalog=Timesheet;Integrated Security=True";
        SqlConnection myConnection = new SqlConnection(connectString);
        public Form1()
        {
            InitializeComponent();
            UpdateOrganization();
            UpdateSubdivision();
            UpdatePost();
            UpdateEmployee();
        }
        /// <summary>
        /// Обвноление датагрида для таблицы Организации
        /// </summary>
        public void UpdateOrganization()
        {
            myConnection.Open();
            string query = @"SELECT [Id]
                                        ,[Name_orgn] As 'Наименование организации'
                                        ,[Address] As 'Адрес организации'
                                        ,[Inn] As 'ИНН организации'
                                    FROM [dbo].[Organization]";
            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridWatchOrganization.DataSource = dt;
            dataGridWatchOrganization.Columns[0].Visible = false;
            command.ExecuteNonQuery();
            myConnection.Close();
        }
        /// <summary>
        /// Обвноление датагрида для таблицы Подразделения
        /// </summary>
        public void UpdateSubdivision()
        {
            myConnection.Open();
            string query = @"SELECT [Subdivision].[Id]
                                  ,[Name_orgn] as 'Наименование Организация'
                                  ,[Name_Org] 'Наименование подразделения'
                              FROM [dbo].[Subdivision]
                              LEFT JOIN [dbo].[Organization] ON [Organization].[Id] = [Subdivision].[Id_Organization]";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridWatchSubdivision.DataSource = dt;
            dataGridWatchSubdivision.Columns[0].Visible = false;
            command.ExecuteNonQuery();
            myConnection.Close();
        }
        /// <summary>
        /// Загрузка данных в dataGrid таблицы Должности
        /// </summary>
        public void UpdatePost()
        {
            myConnection.Open();
            string query = @"SELECT [Id]
                                   ,[Name_Post] as 'Должность'
                             FROM [dbo].[Post]";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridWatchPost.DataSource = dt;
            dataGridWatchPost.Columns[0].Visible = false;

            dataGridWatchPost.Columns[1].Width = 200;

            command.ExecuteNonQuery();
            myConnection.Close();
        }
        /// <summary>
        /// Загрузка данных в dataGrid таблицы Сотрудники
        /// </summary>
        public void UpdateEmployee()
        {
            myConnection.Open();
            string query = @"SELECT [Employee].[Id]
                                ,[Name_Org] as 'Подразделение'
                                ,[Name_Post] as 'Должность' 
                                ,[FIO] as 'ФИО'
                                ,[Birth_Date] 'Дата Рождения'
                                ,[Date_of_employment] as 'Дата трудоустройства' 
                             FROM [dbo].[Employee]
                             LEFT JOIN [dbo].[Subdivision] ON [Subdivision].[Id] = [Employee].[Id_Subdivision]
                             LEFT JOIN [dbo].[Post] ON [Post].[Id] = [Employee].[Id_Post]";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridWatchEmployee.DataSource = dt;
            dataGridWatchEmployee.Columns[0].Visible = false;


            command.ExecuteNonQuery();
            myConnection.Close();
        }
        /// <summary>
        /// Загрузка данных в dataGrid таблицы Табель учёта рабочего времени
        /// </summary>
        public void UpdateTableSheet()
        {
            dataGridWatchTableSheet.Columns[0].Visible = false;
            dataGridWatchTableSheet.Columns[1].Width = 50;
            dataGridWatchTableSheet.Columns[2].Width = 100;
            dataGridWatchTableSheet.Columns[3].Width = 100;
            try
            {
                for(int i = 0; i < ((DataTable)dataGridWatchTableSheet.DataSource).Columns.Count; i++)
                {
                    int n;
                    bool isnumeric = int.TryParse(dataGridWatchTableSheet.Columns[i].Name, out n);
                    if (isnumeric == true)
                    {
                        dataGridWatchTableSheet.Columns[i].Width = 25;
                    }
                }
            }
            catch
            {

            }
            finally
            {
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "timesheetDataSet.Organization". При необходимости она может быть перемещена или удалена.
            this.organizationTableAdapter.Fill(this.timesheetDataSet.Organization);

        }
        /// <summary>
        /// Добавление Новое организации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddOrganization_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Organization] " +
                    "([Name_orgn],[Address],[Inn]) " +
                    "VALUES" +
                    "(@Name_orgn, " +
                    "@Address," +
                    "@Inn)");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Name_orgn", NameOrg.Text);
                cmd.Parameters.AddWithValue("@Address", AddsressOrg.Text);
                cmd.Parameters.AddWithValue("@Inn", InnOrg.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Организация: " + NameOrg.Text + " Добавлена");
            }
            UpdateOrganization();
        }
        /// <summary>
        /// Редактирование выбранной организации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateOrganization_Click(object sender, EventArgs e)
        {
            DataTable patientTable = new DataTable();
            string s = comboBox1.Text;

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Organization] " +
                    "SET Name_orgn = @Name_orgn, Address = @Address, Inn = @Inn " +
                    "WHERE Name_orgn = '" + comboBox1.Text + "'");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Address", textBox5.Text);
                cmd.Parameters.AddWithValue("@Name_Orgn", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Inn", textBox4.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
            }

            MessageBox.Show("Организация: " + s + " Отредактирована");
            UpdateOrganization();
        }
        /// <summary>
        /// Загрузка содержимого в Combobox при клике на вкладку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void LoadCombobox_Click(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"SELECT [Id],[Name_orgn],[Address],[Inn] FROM [dbo].[Organization]";
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                connection.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Organization");
                comboBox1.ValueMember = "Id";
                comboBox1.DisplayMember = "Name_Orgn";
                comboBox1.DataSource = ds.Tables["Organization"];

                comboBox2.ValueMember = "Id";
                comboBox2.DisplayMember = "Name_Orgn";
                comboBox2.DataSource = ds.Tables["Organization"];
                connection.Close();
            }
        }
        /// <summary>
        /// запрос в базу данных по выбраному значению в Combobox и заполение textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string s = comboBox1.Text;
                string query = @"SELECT [Id],[Name_orgn],[Address],[Inn] FROM [dbo].[Organization] WHERE [Name_orgn] = '" + s + "'";
                //string query = @"SELECT [Id],[Name_orgn],[Address],[Inn] FROM [dbo].[Organization] WHERE [Id] = 1";
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    reader.Read();

                    textBox8.Text = reader.GetValue(1).ToString();
                    textBox5.Text = reader.GetValue(2).ToString();
                    textBox4.Text = reader.GetValue(3).ToString();

                }
                connection.Close();
            }
        }
        /// <summary>
        /// Удаление оргнизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteOrganization_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string s = comboBox1.Text;
                SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Organization] WHERE [Name_orgn] = '" + s + "'");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Организация: " + s + " Удалена");
            }

            UpdateOrganization();
        }

        /// <summary>
        /// Добавление нового подразделение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSubdivision_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Subdivision]" +
                                                        "([Id_Organization]" +
                                                        ",[Name_Org])" +
                                                    "VALUES" +
                                                       "(@Id_Organization, " +
                                                        "@Name_Org)");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                connection.Open();
                string query = @"SELECT [Id]
                                        ,[Name_orgn]
                                        ,[Address]
                                        ,[Inn]
                                    FROM [dbo].[Organization] WHERE [Name_orgn] ='" + OrganizationFK.Text + "'";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                string check;

                if (reader.HasRows) // если есть данные
                {
                    reader.Read();
                    check = reader.GetValue(0).ToString();
                    cmd.Parameters.AddWithValue("@Id_Organization", check);
                    reader.Close();
                }

                cmd.Parameters.AddWithValue("@Name_Org", NameSubdivision.Text);

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Организация: " + NameSubdivision.Text + " Добавлена");
            }
            UpdateSubdivision();
        }
        /// <summary>
        /// Загрузка Combobox для таблицы подразделение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Subdivision_Click(object sender, EventArgs e)
        {
            OrganizationFK.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateSubdivison.DropDownStyle = ComboBoxStyle.DropDownList;
            DeleteSubdivision.DropDownStyle = ComboBoxStyle.DropDownList;

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"SELECT [Subdivision].[Id]
                                  ,[Name_orgn]
                                  ,[Name_Org]
                              FROM [dbo].[Subdivision]
                              LEFT JOIN [dbo].[Organization] ON [Organization].[Id] = [Subdivision].[Id_Organization]";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                connection.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Subdivision");

                UpdateSubdivison.ValueMember = "Id";
                UpdateSubdivison.DisplayMember = "Name_org";
                UpdateSubdivison.DataSource = ds.Tables["Subdivision"];

                DeleteSubdivision.ValueMember = "Id";
                DeleteSubdivision.DisplayMember = "Name_org";
                DeleteSubdivision.DataSource = ds.Tables["Subdivision"];

                connection.Close();


                 query = @"SELECT [Id],[Name_orgn],[Address],[Inn] FROM [dbo].[Organization]";

                da = new SqlDataAdapter(query, connection);
                connection.Open();
                ds = new DataSet();
                da.Fill(ds, "Organization");

                OrganizationFK.ValueMember = "Id";
                OrganizationFK.DisplayMember = "Name_orgn";
                OrganizationFK.DataSource = ds.Tables["Organization"];

                connection.Close();

            }
        }
        /// <summary>
        /// Редактирование Подразделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UdpSubdivision_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                //comboBox1.SelectedValue.ToString()
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Subdivision] SET " +
                                                       "Name_Org = @Name_Org " +
                                                       "WHERE Name_Org = '" + UpdateSubdivison.Text + "'");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Name_Org", UpdNameSub.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Подразделение: " + UpdNameSub.Text + " Отредактирована");
            UpdateSubdivision();
        }
        /// <summary>
        /// Удаление подразделения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Subdivision] WHERE [Name_Org] = '" + DeleteSubdivision.Text + "'");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Организация: " + DeleteSubdivision.Text + " Удалена");
            }

            UpdateSubdivision();
        }
        /// <summary>
        /// Заполнение lable от выбраного значения в combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateSubdivison_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"SELECT [Subdivision].[Id]
                                  ,[Name_orgn]
                                  ,[Name_Org]
                              FROM [dbo].[Subdivision]
                              LEFT JOIN [dbo].[Organization] ON [Organization].[Id] = [Subdivision].[Id_Organization]
                                WHERE [Name_Org] = '" + UpdateSubdivison.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                connection.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Subdivision");
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    reader.Read();

                    UpdNameSub.Text = reader.GetValue(2).ToString();

                }
            }


        }
        /// <summary>
        /// Добавление новой должности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPost_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Post]" +
                                                    "([Name_Post]) " +
                                               "VALUES (@Name_Post)");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Name_Post", AddNamePost.Text);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Должность: " + AddNamePost.Text + " Добавлена");
            }
            UpdatePost();
        }
        /// <summary>
        /// Заполнение combobox в должностях при переходе во вкладку
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Post_Click(object sender, EventArgs e)
        {
            UpdPostBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeletePostBox.DropDownStyle = ComboBoxStyle.DropDownList;

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"SELECT [Id]
                                        ,[Name_Post]
                                 FROM [dbo].[Post]";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                connection.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Post");

                UpdPostBox.ValueMember = "Id";
                UpdPostBox.DisplayMember = "Name_Post";
                UpdPostBox.DataSource = ds.Tables["Post"];

                DeletePostBox.ValueMember = "Id";
                DeletePostBox.DisplayMember = "Name_Post";
                DeletePostBox.DataSource = ds.Tables["Post"];

                connection.Close();

            }
        }
        /// <summary>
        /// Заполнение lable от выбраного значения в combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdPostBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"SELECT [Id]
                                       ,[Name_Post]
                                    FROM [dbo].[Post]
                                    WHERE[Name_Post] = '" + UpdPostBox.Text + "'";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                connection.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Post");
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    reader.Read();

                    UpdPostText.Text = reader.GetValue(1).ToString();

                }
            }
        }
        /// <summary>
        /// Редактирование выбранной должности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UdpPostButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Post] SET " +
                                                       "Name_Post = @Name_Post " +
                                                       "WHERE Name_Post = '" + UpdPostBox.Text + "'");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Name_Post", UpdPostText.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Должность: " + UpdPostText.Text + " изменена");
            UpdatePost();
        }
        /// <summary>
        /// Удаление выбранной должности
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Post] " +
                                                    "WHERE [Name_Post] = '" + UpdPostBox.Text + "'");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Должность: " + UpdPostBox.Text + " Удалена");
            }

            UpdatePost();
        }
        /// <summary>
        /// Загрузка данных в combobox при переходе во вкладку сотрудники
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Employee_Click(object sender, EventArgs e)
        {
            AddEmloyeeSubBox.DropDownStyle = ComboBoxStyle.DropDownList;        // бокс выбор подразделения(вкладка добавление)
            AddEmployeePostBox.DropDownStyle = ComboBoxStyle.DropDownList;      // бокс выбор должности (вкладка добавление)
            EditFioEmloyeeSubBox.DropDownStyle = ComboBoxStyle.DropDownList;    // бокс выбор сотрудника(вкладка редактирование)
            EditEmloyeeSubBox.DropDownStyle = ComboBoxStyle.DropDownList;       // бокс выбор подразделения(вкладка редактирование)
            EditEmployeePostBox.DropDownStyle = ComboBoxStyle.DropDownList;     // бокс выбор Должности(вкладка редактирование)
            DelEmloyeeSubBox.DropDownStyle = ComboBoxStyle.DropDownList;        // бокс выбор сотрудника(вкладка удаление)

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string Sub = @"SELECT [Id]
                                      ,[Id_Organization]
                                      ,[Name_Org]
                                  FROM [dbo].[Subdivision]";

                SqlDataAdapter da = new SqlDataAdapter(Sub, connection);
                connection.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Subdivision");

                AddEmloyeeSubBox.ValueMember = "Id";
                AddEmloyeeSubBox.DisplayMember = "Name_Org";
                AddEmloyeeSubBox.DataSource = ds.Tables["Subdivision"];

                EditEmloyeeSubBox.ValueMember = "Id";
                EditEmloyeeSubBox.DisplayMember = "Name_Org";
                EditEmloyeeSubBox.DataSource = ds.Tables["Subdivision"];

                connection.Close();

                string query = @"SELECT [Id]
                                      ,[Name_Post]
                                  FROM [dbo].[Post]";

                SqlDataAdapter da1 = new SqlDataAdapter(query, connection);
                connection.Open();
                DataSet ds1 = new DataSet();
                da1.Fill(ds1, "Post");

                AddEmployeePostBox.ValueMember = "Id";
                AddEmployeePostBox.DisplayMember = "Name_Post";
                AddEmployeePostBox.DataSource = ds1.Tables["Post"];

                EditEmployeePostBox.ValueMember = "Id";
                EditEmployeePostBox.DisplayMember = "Name_Post";
                EditEmployeePostBox.DataSource = ds1.Tables["Post"];

                connection.Close();

                string edit = @"SELECT [Id]
                                  ,[FIO]
                              FROM [dbo].[Employee]";

                SqlDataAdapter ea1 = new SqlDataAdapter(edit, connection);
                connection.Open();
                DataSet es1 = new DataSet();
                ea1.Fill(es1, "Employee");

                EditFioEmloyeeSubBox.ValueMember = "Id";
                EditFioEmloyeeSubBox.DisplayMember = "FIO";
                EditFioEmloyeeSubBox.DataSource = es1.Tables["Employee"];

                DelEmloyeeSubBox.ValueMember = "Id";
                DelEmloyeeSubBox.DisplayMember = "FIO";
                DelEmloyeeSubBox.DataSource = es1.Tables["Employee"];


                connection.Close();
            }
        }
        /// <summary>
        /// Добавление сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            //comboBox1.SelectedValue.ToString()
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Employee] " +
                                                       "([Id_Subdivision]" +
                                                       ",[Id_Post]" +
                                                       ",[FIO]" +
                                                       ",[Birth_Date]" +
                                                       ",[Date_of_employment])" +
                                                    "VALUES" +
                                                       "(@Id_Subdivision, " +
                                                       "@Id_Post, " +
                                                       "@FIO, " +
                                                       "@Birth_Date, " +
                                                       "@Date_of_employment)");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                connection.Open();

                cmd.Parameters.AddWithValue("@Id_Subdivision", AddEmloyeeSubBox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Id_Post", AddEmployeePostBox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@FIO", AddFioText.Text);
                cmd.Parameters.AddWithValue("@Birth_Date", AddDOBEmployeeData.Value.ToString("dd.mm.yyyy"));
                cmd.Parameters.AddWithValue("@Date_of_employment", AddEmpEmployeeData.Value.ToString("dd.mm.yyyy"));

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Сотрудник: " + AddFioText.Text + " Добавлен");
            }
            UpdateSubdivision();
        }
        /// <summary>
        /// Редактирование сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditEmployeeButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Employee] SET " +
                                                       "Id_Subdivision = @Id_Subdivision, " +
                                                       "Id_Post = @Id_Post, " +
                                                       "FIO = @FIO, " +
                                                       "Birth_Date = @Birth_Date, " +
                                                       "Date_of_employment = @Date_of_employment " +
                                                    "WHERE Id = '" + EditFioEmloyeeSubBox.SelectedValue.ToString() + "'");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Id_Subdivision", EditEmloyeeSubBox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@Id_Post", EditEmployeePostBox.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@FIO", EditFioEmployee.Text);
                cmd.Parameters.AddWithValue("@Birth_Date", EditDOBEmployeeData.Value);
                cmd.Parameters.AddWithValue("@Date_of_employment", EditEmpEmployeeData.Value);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Данные сотрудника: " + EditFioEmloyeeSubBox.Text + " изменены");
            UpdateEmployee();
        }
        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteEmployeeButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[Employee] " +
                                                    "WHERE [Id] = '" + EditFioEmloyeeSubBox.SelectedValue.ToString() + "'");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Сотрудник: " + EditFioEmloyeeSubBox.Text + " Удалён.");
            }

            UpdateEmployee();
        }
        /// <summary>
        /// заполнение всех полей при выборе сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditFioEmloyeeSubBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"SELECT  [Employee].[Id]
                                        ,[Id_Subdivision]
                                        ,[Id_Post]
                                        ,[FIO]
                                        ,[Birth_Date]
                                        ,[Date_of_employment]
                                    FROM [dbo].[Employee]
                                    LEFT JOIN [dbo].[Subdivision] ON [Subdivision].[Id] = [Employee].[Id_Subdivision]
	                                LEFT JOIN [dbo].[Post] ON [Post].[Id] = [Employee].[Id_Post]
                                    WHERE [Employee].[Id] = '" + EditFioEmloyeeSubBox.SelectedValue.ToString() + "'";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                connection.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Employee");
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows) // если есть данные
                {
                    reader.Read();
                    EditEmloyeeSubBox.SelectedValue = reader.GetValue(1).ToString();
                    EditEmployeePostBox.SelectedValue = reader.GetValue(2).ToString();
                    EditFioEmployee.Text     = reader.GetValue(3).ToString();
                    EditDOBEmployeeData.Text     = reader.GetValue(4).ToString();
                    EditEmpEmployeeData.Text     = reader.GetValue(5).ToString();

                }
            }
        }
        /// <summary>
        /// Заполенение бокса датами табелей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TabControl1_Click(object sender, EventArgs e)
        {
            DatetableBox.DropDownStyle = ComboBoxStyle.DropDownList;

            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"SELECT [Id]
                                      ,[Date_Create]
                                  FROM [dbo].[Tabel]";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                connection.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Tabel");

                DatetableBox.ValueMember = "Id";
                DatetableBox.DisplayMember = "Date_Create";
                DatetableBox.DataSource = ds.Tables["Tabel"];

                connection.Close();

            }
        }
        /// <summary>
        /// Вывод табеля по дате
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DatetableBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            myConnection.Open();
            string query = @"SELECT [Timesheet].[Id]
                                ,[Id_table] as 'Номер табеля'
                                ,[Name_Org] as 'Подразделение'
                                ,[FIo] as 'Сотрудник'
                                ,[1]
                                ,[2]
                                ,[3]
                                ,[4]
                                ,[5]
                                ,[6]
                                ,[7]
                                ,[8]
                                ,[9]
                                ,[10]
                                ,[11]
                                ,[12]
                                ,[13]
                                ,[14]
                                ,[15]
                                ,[16]
                                ,[17]
                                ,[18]
                                ,[19]
                                ,[20]
                                ,[21]
                                ,[22]
                                ,[23]
                                ,[24]
                                ,[25]
                                ,[26]
                                ,[27]
                                ,[28]
                                ,[29]
                                ,[30]
                                ,[31]
                                ,[Hours_Worked] 'Количество рабочих часов' 
                                ,[Sick_days] 'Больничных дней' 
                                ,[Vacation_days] 'Отпускных дней'
                            FROM [dbo].[TimeSheet]
                            LEFT JOIN [dbo].[Tabel] ON [Tabel].[Id] = [Timesheet].[Id_table]
	                        LEFT JOIN [dbo].[Subdivision] ON [Subdivision].[Id] = [Timesheet].[Id_Subdivision]
	                        LEFT JOIN [dbo].[Employee] ON [Employee].[Id] = [Timesheet].[Id_employee]
                            WHERE [Id_table] = '" + DatetableBox.SelectedValue.ToString() + "'";

            SqlCommand command = new SqlCommand(query, myConnection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridWatchTableSheet.DataSource = dt;
            command.ExecuteNonQuery();
            UpdateTableSheet();
            myConnection.Close();
        }
        /// <summary>
        /// Создание нового табеля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTableSheet_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Tabel] " +
                                                    "([Date_Create]) " +
                                                    "VALUES (@Date_Create)");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Date_Create", DateTime.Now);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                cmd = new SqlCommand(@"INSERT INTO [dbo].[TimeSheet] 
                                        	([1])
                                            VALUES (Null)");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                myConnection.Open();

                string query = @"SELECT TOP 1 [Timesheet].[Id]
                                ,[Id_table] as 'Номер табеля'
                                ,[Name_Org] as 'Подразделение'
                                ,[FIo] as 'Сотрудник'
                                ,[1]
                                ,[2]
                                ,[3]
                                ,[4]
                                ,[5]
                                ,[6]
                                ,[7]
                                ,[8]
                                ,[9]
                                ,[10]
                                ,[11]
                                ,[12]
                                ,[13]
                                ,[14]
                                ,[15]
                                ,[16]
                                ,[17]
                                ,[18]
                                ,[19]
                                ,[20]
                                ,[21]
                                ,[22]
                                ,[23]
                                ,[24]
                                ,[25]
                                ,[26]
                                ,[27]
                                ,[28]
                                ,[29]
                                ,[30]
                                ,[31]
                                ,[Hours_Worked] 'Количество рабочих часов' 
                                ,[Sick_days] 'Больничных дней' 
                                ,[Vacation_days] 'Отпускных дней'
                            FROM [dbo].[TimeSheet]
                            LEFT JOIN [dbo].[Tabel] ON [Tabel].[Id] = [Timesheet].[Id_table]
	                        LEFT JOIN [dbo].[Subdivision] ON [Subdivision].[Id] = [Timesheet].[Id_Subdivision]
	                        LEFT JOIN [dbo].[Employee] ON [Employee].[Id] = [Timesheet].[Id_employee]
                            ORDER
                            BY Id DESC";

                SqlCommand command = new SqlCommand(query, myConnection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dataGridView1.DataSource = dt;
                command.ExecuteNonQuery();
                UpdateTableSheet();
                

                myConnection.Close();

            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                string query = @"SELECT TOP 1 [Timesheet].[Id]
                                ,[Id_table] as 'Номер табеля'
                                ,[Name_Org] as 'Подразделение'
                                ,[FIo] as 'Сотрудник'
                                ,[1]
                                ,[2]
                                ,[3]
                                ,[4]
                                ,[5]
                                ,[6]
                                ,[7]
                                ,[8]
                                ,[9]
                                ,[10]
                                ,[11]
                                ,[12]
                                ,[13]
                                ,[14]
                                ,[15]
                                ,[16]
                                ,[17]
                                ,[18]
                                ,[19]
                                ,[20]
                                ,[21]
                                ,[22]
                                ,[23]
                                ,[24]
                                ,[25]
                                ,[26]
                                ,[27]
                                ,[28]
                                ,[29]
                                ,[30]
                                ,[31]
                                ,[Hours_Worked] 'Количество рабочих часов' 
                                ,[Sick_days] 'Больничных дней' 
                                ,[Vacation_days] 'Отпускных дней'
                            FROM [dbo].[TimeSheet]
                            LEFT JOIN [dbo].[Tabel] ON [Tabel].[Id] = [Timesheet].[Id_table]
	                        LEFT JOIN [dbo].[Subdivision] ON [Subdivision].[Id] = [Timesheet].[Id_Subdivision]
	                        LEFT JOIN [dbo].[Employee] ON [Employee].[Id] = [Timesheet].[Id_employee]
                            ORDER
                            BY Id DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                connection.Open();
                DataSet ds = new DataSet();
                da.Fill(ds, "Tabel");

                DatetableBox.ValueMember = "Id";
                DatetableBox.DisplayMember = "Name_Org";
                DatetableBox.DataSource = ds.Tables["Tabel"];


                connection.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application XlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook XlWorkBook = XlApp.Workbooks.Add(); //создать новый файл: XlApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet XlWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)XlWorkBook.Worksheets.get_Item(1); //1-й лист по порядку
            for (int i = 0; i < dataGridWatchTableSheet.Rows.Count; i++)
            {

                for (int j = 0; j < dataGridWatchTableSheet.ColumnCount; j++)
                {
                    XlWorkSheet.Cells[1, j + 1] = dataGridWatchTableSheet.Columns[j].HeaderText.ToString();
                    XlWorkSheet.Cells[i + 2, j + 1] = dataGridWatchTableSheet.Rows[i].Cells[j].Value;
                }
            }
            XlApp.Visible = true;
        }
    }
}
