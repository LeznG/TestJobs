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
                SqlCommand cmd = new SqlCommand("INSERT INTO [dbo].[Organization] ([Name_orgn],[Address],[Inn]) " +
                    "VALUES" +
                    "(@Name_orgn, " +
                    "@Address," +
                    "@Inn)");

                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Name_orgn", NameOrg.Text);
                cmd.Parameters.AddWithValue("@Address", AddsressOrg.Text);
                cmd.Parameters.AddWithValue("Inn", InnOrg.Text);
                connection.Open();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Организация: " + NameOrg.Text + " Добавлена");

                connection.Close();
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

    }
}
