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
            Update();
        }
        public new void Update()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "timesheetDataSet.Organization". При необходимости она может быть перемещена или удалена.
            this.organizationTableAdapter.Fill(this.timesheetDataSet.Organization);

        }

        private void button2_Click(object sender, EventArgs e)
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
                cmd.Parameters.AddWithValue("@Name_orgn", textBox1.Text);
                cmd.Parameters.AddWithValue("@Address", textBox2.Text);
                cmd.Parameters.AddWithValue("Inn", textBox3.Text);
                connection.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Организация: " + textBox1.Text + " Добавлена");
                connection.Close();
            }
            Update();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable patientTable = new DataTable();
            string s = comboBox1.Text;
            using (SqlConnection connection = new SqlConnection(connectString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("UPDATE [dbo].[Organization] " +
                    "SET Name_orgn = @Name_orgn, Address = @Address, Inn = @Inn " +
                    "WHERE Name_orgn = '" + s + "'");
                cmd.CommandType = CommandType.Text;
                cmd.Connection = connection;
                cmd.Parameters.AddWithValue("@Address", textBox5.Text);
                cmd.Parameters.AddWithValue("@Name_Orgn", s);
                cmd.Parameters.AddWithValue("@Inn", textBox4.Text);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
            Update();
        }

        public void tabControl2_Click(object sender, EventArgs e)
        {
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
                connection.Close();
            }
        }
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
                    while (reader.Read())
                    {
                        textBox5.Text = reader.GetValue(2).ToString();
                        textBox4.Text = reader.GetValue(3).ToString();
                    }
                }
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
                    while (reader.Read())
                    {
                        textBox5.Text = reader.GetValue(2).ToString();
                        textBox4.Text = reader.GetValue(3).ToString();
                    }
                }
                connection.Close();
            }
        }
    }
}
