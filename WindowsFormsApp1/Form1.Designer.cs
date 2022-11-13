namespace WindowsFormsApp1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridWatchOrganization = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.InnOrg = new System.Windows.Forms.TextBox();
            this.AddsressOrg = new System.Windows.Forms.TextBox();
            this.NameOrg = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddOrganization = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Subdivision = new System.Windows.Forms.TabControl();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.dataGridWatchSubdivision = new System.Windows.Forms.DataGridView();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.OrganizationFK = new System.Windows.Forms.ComboBox();
            this.NameSubdivision = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddSubdivision = new System.Windows.Forms.Button();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.UpdateSubdivison = new System.Windows.Forms.ComboBox();
            this.UpdNameSub = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.UdpSubdivision = new System.Windows.Forms.Button();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.DeleteSubdivision = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DeleteSubButton = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.timesheetDataSet = new WindowsFormsApp1.TimesheetDataSet();
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organizationTableAdapter = new WindowsFormsApp1.TimesheetDataSetTableAdapters.OrganizationTableAdapter();
            this.Post = new System.Windows.Forms.TabControl();
            this.tabPage14 = new System.Windows.Forms.TabPage();
            this.tabPage15 = new System.Windows.Forms.TabPage();
            this.tabPage16 = new System.Windows.Forms.TabPage();
            this.tabPage17 = new System.Windows.Forms.TabPage();
            this.dataGridWatchPost = new System.Windows.Forms.DataGridView();
            this.AddNamePost = new System.Windows.Forms.TextBox();
            this.AddPost = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.UdpPostButton = new System.Windows.Forms.Button();
            this.UpdPostText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.UpdPostBox = new System.Windows.Forms.ComboBox();
            this.DeletePostBox = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWatchOrganization)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Subdivision.SuspendLayout();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWatchSubdivision)).BeginInit();
            this.tabPage11.SuspendLayout();
            this.tabPage12.SuspendLayout();
            this.tabPage13.SuspendLayout();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timesheetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            this.Post.SuspendLayout();
            this.tabPage14.SuspendLayout();
            this.tabPage15.SuspendLayout();
            this.tabPage16.SuspendLayout();
            this.tabPage17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWatchPost)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1196, 505);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1188, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Организации";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl2.ItemSize = new System.Drawing.Size(77, 18);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1110, 467);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Click += new System.EventHandler(this.LoadCombobox_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridWatchOrganization);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1102, 441);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Просмотр";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridWatchOrganization
            // 
            this.dataGridWatchOrganization.AllowUserToAddRows = false;
            this.dataGridWatchOrganization.AllowUserToDeleteRows = false;
            this.dataGridWatchOrganization.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWatchOrganization.Location = new System.Drawing.Point(6, 6);
            this.dataGridWatchOrganization.Name = "dataGridWatchOrganization";
            this.dataGridWatchOrganization.ReadOnly = true;
            this.dataGridWatchOrganization.Size = new System.Drawing.Size(1156, 429);
            this.dataGridWatchOrganization.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.InnOrg);
            this.tabPage4.Controls.Add(this.AddsressOrg);
            this.tabPage4.Controls.Add(this.NameOrg);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.AddOrganization);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1102, 441);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Добавление";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // InnOrg
            // 
            this.InnOrg.Location = new System.Drawing.Point(189, 85);
            this.InnOrg.Name = "InnOrg";
            this.InnOrg.Size = new System.Drawing.Size(350, 22);
            this.InnOrg.TabIndex = 6;
            // 
            // AddsressOrg
            // 
            this.AddsressOrg.Location = new System.Drawing.Point(189, 50);
            this.AddsressOrg.Name = "AddsressOrg";
            this.AddsressOrg.Size = new System.Drawing.Size(350, 22);
            this.AddsressOrg.TabIndex = 5;
            // 
            // NameOrg
            // 
            this.NameOrg.Location = new System.Drawing.Point(189, 16);
            this.NameOrg.Name = "NameOrg";
            this.NameOrg.Size = new System.Drawing.Size(350, 22);
            this.NameOrg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Инн организации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес организации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование организации";
            // 
            // AddOrganization
            // 
            this.AddOrganization.Location = new System.Drawing.Point(9, 126);
            this.AddOrganization.Name = "AddOrganization";
            this.AddOrganization.Size = new System.Drawing.Size(164, 23);
            this.AddOrganization.TabIndex = 0;
            this.AddOrganization.Text = "Добавить организацию";
            this.AddOrganization.UseVisualStyleBackColor = true;
            this.AddOrganization.Click += new System.EventHandler(this.AddOrganization_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox8);
            this.tabPage5.Controls.Add(this.label10);
            this.tabPage5.Controls.Add(this.comboBox1);
            this.tabPage5.Controls.Add(this.textBox4);
            this.tabPage5.Controls.Add(this.textBox5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1102, 441);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Редактирование";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(189, 50);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(350, 22);
            this.textBox8.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label10.Location = new System.Drawing.Point(3, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 15);
            this.label10.TabIndex = 15;
            this.label10.Text = "Наименование организации";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 23);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(189, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(350, 22);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(189, 85);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(350, 22);
            this.textBox5.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Инн организации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label5.Location = new System.Drawing.Point(3, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Адрес организации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Выбор организации";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Редактировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UpdateOrganization_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.button3);
            this.tabPage6.Controls.Add(this.comboBox2);
            this.tabPage6.Controls.Add(this.label7);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1102, 441);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Удаление";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 26);
            this.button3.TabIndex = 17;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteOrganization_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(189, 16);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(350, 23);
            this.comboBox2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label7.Location = new System.Drawing.Point(6, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Выбор организации";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Subdivision);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1188, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подразделения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Subdivision
            // 
            this.Subdivision.Controls.Add(this.tabPage10);
            this.Subdivision.Controls.Add(this.tabPage11);
            this.Subdivision.Controls.Add(this.tabPage12);
            this.Subdivision.Controls.Add(this.tabPage13);
            this.Subdivision.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.Subdivision.ItemSize = new System.Drawing.Size(77, 18);
            this.Subdivision.Location = new System.Drawing.Point(6, 6);
            this.Subdivision.Name = "Subdivision";
            this.Subdivision.SelectedIndex = 0;
            this.Subdivision.Size = new System.Drawing.Size(1179, 467);
            this.Subdivision.TabIndex = 1;
            this.Subdivision.Click += new System.EventHandler(this.Subdivision_Click);
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.dataGridWatchSubdivision);
            this.tabPage10.Location = new System.Drawing.Point(4, 22);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage10.Size = new System.Drawing.Size(1171, 441);
            this.tabPage10.TabIndex = 0;
            this.tabPage10.Text = "Просмотр";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // dataGridWatchSubdivision
            // 
            this.dataGridWatchSubdivision.AllowUserToAddRows = false;
            this.dataGridWatchSubdivision.AllowUserToDeleteRows = false;
            this.dataGridWatchSubdivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWatchSubdivision.Location = new System.Drawing.Point(6, 6);
            this.dataGridWatchSubdivision.Name = "dataGridWatchSubdivision";
            this.dataGridWatchSubdivision.ReadOnly = true;
            this.dataGridWatchSubdivision.Size = new System.Drawing.Size(1159, 429);
            this.dataGridWatchSubdivision.TabIndex = 0;
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.OrganizationFK);
            this.tabPage11.Controls.Add(this.NameSubdivision);
            this.tabPage11.Controls.Add(this.label9);
            this.tabPage11.Controls.Add(this.label11);
            this.tabPage11.Controls.Add(this.AddSubdivision);
            this.tabPage11.Location = new System.Drawing.Point(4, 22);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage11.Size = new System.Drawing.Size(1171, 441);
            this.tabPage11.TabIndex = 1;
            this.tabPage11.Text = "Добавление";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // OrganizationFK
            // 
            this.OrganizationFK.FormattingEnabled = true;
            this.OrganizationFK.Location = new System.Drawing.Point(186, 7);
            this.OrganizationFK.Name = "OrganizationFK";
            this.OrganizationFK.Size = new System.Drawing.Size(350, 23);
            this.OrganizationFK.TabIndex = 13;
            // 
            // NameSubdivision
            // 
            this.NameSubdivision.Location = new System.Drawing.Point(186, 42);
            this.NameSubdivision.Name = "NameSubdivision";
            this.NameSubdivision.Size = new System.Drawing.Size(350, 22);
            this.NameSubdivision.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label9.Location = new System.Drawing.Point(3, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Наименование подразделения";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 7);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 15);
            this.label11.TabIndex = 8;
            this.label11.Text = "Наименование организации";
            // 
            // AddSubdivision
            // 
            this.AddSubdivision.Location = new System.Drawing.Point(6, 75);
            this.AddSubdivision.Name = "AddSubdivision";
            this.AddSubdivision.Size = new System.Drawing.Size(164, 23);
            this.AddSubdivision.TabIndex = 7;
            this.AddSubdivision.Text = "Добавить подразделение";
            this.AddSubdivision.UseVisualStyleBackColor = true;
            this.AddSubdivision.Click += new System.EventHandler(this.AddSubdivision_Click);
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.UpdateSubdivison);
            this.tabPage12.Controls.Add(this.UpdNameSub);
            this.tabPage12.Controls.Add(this.label8);
            this.tabPage12.Controls.Add(this.label12);
            this.tabPage12.Controls.Add(this.UdpSubdivision);
            this.tabPage12.Location = new System.Drawing.Point(4, 22);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage12.Size = new System.Drawing.Size(1171, 441);
            this.tabPage12.TabIndex = 2;
            this.tabPage12.Text = "Редактирование";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // UpdateSubdivison
            // 
            this.UpdateSubdivison.FormattingEnabled = true;
            this.UpdateSubdivison.Location = new System.Drawing.Point(186, 7);
            this.UpdateSubdivison.Name = "UpdateSubdivison";
            this.UpdateSubdivison.Size = new System.Drawing.Size(350, 23);
            this.UpdateSubdivison.TabIndex = 18;
            this.UpdateSubdivison.SelectedIndexChanged += new System.EventHandler(this.UpdateSubdivison_SelectedIndexChanged);
            // 
            // UpdNameSub
            // 
            this.UpdNameSub.Location = new System.Drawing.Point(186, 42);
            this.UpdNameSub.Name = "UpdNameSub";
            this.UpdNameSub.Size = new System.Drawing.Size(350, 22);
            this.UpdNameSub.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label8.Location = new System.Drawing.Point(3, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Наименование подразделения";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 15);
            this.label12.TabIndex = 15;
            this.label12.Text = "Выбор организации";
            // 
            // UdpSubdivision
            // 
            this.UdpSubdivision.Location = new System.Drawing.Point(6, 75);
            this.UdpSubdivision.Name = "UdpSubdivision";
            this.UdpSubdivision.Size = new System.Drawing.Size(164, 23);
            this.UdpSubdivision.TabIndex = 14;
            this.UdpSubdivision.Text = "Изменить подразделение";
            this.UdpSubdivision.UseVisualStyleBackColor = true;
            this.UdpSubdivision.Click += new System.EventHandler(this.UdpSubdivision_Click);
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.DeleteSubdivision);
            this.tabPage13.Controls.Add(this.label13);
            this.tabPage13.Controls.Add(this.DeleteSubButton);
            this.tabPage13.Location = new System.Drawing.Point(4, 22);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage13.Size = new System.Drawing.Size(1171, 441);
            this.tabPage13.TabIndex = 3;
            this.tabPage13.Text = "Удаление";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // DeleteSubdivision
            // 
            this.DeleteSubdivision.FormattingEnabled = true;
            this.DeleteSubdivision.Location = new System.Drawing.Point(186, 7);
            this.DeleteSubdivision.Name = "DeleteSubdivision";
            this.DeleteSubdivision.Size = new System.Drawing.Size(350, 23);
            this.DeleteSubdivision.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.label13.Location = new System.Drawing.Point(3, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 15);
            this.label13.TabIndex = 19;
            this.label13.Text = "Наименование подразделения";
            // 
            // DeleteSubButton
            // 
            this.DeleteSubButton.Location = new System.Drawing.Point(6, 40);
            this.DeleteSubButton.Name = "DeleteSubButton";
            this.DeleteSubButton.Size = new System.Drawing.Size(164, 23);
            this.DeleteSubButton.TabIndex = 18;
            this.DeleteSubButton.Text = "Удалить подразделение";
            this.DeleteSubButton.UseVisualStyleBackColor = true;
            this.DeleteSubButton.Click += new System.EventHandler(this.button5_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.Post);
            this.tabPage7.Location = new System.Drawing.Point(4, 24);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1188, 477);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Должности";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 24);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1188, 477);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Сотрудники";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 24);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1188, 477);
            this.tabPage9.TabIndex = 4;
            this.tabPage9.Text = "Табель учёта времени";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // timesheetDataSet
            // 
            this.timesheetDataSet.DataSetName = "TimesheetDataSet";
            this.timesheetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // organizationBindingSource
            // 
            this.organizationBindingSource.DataMember = "Organization";
            this.organizationBindingSource.DataSource = this.timesheetDataSet;
            // 
            // organizationTableAdapter
            // 
            this.organizationTableAdapter.ClearBeforeFill = true;
            // 
            // Post
            // 
            this.Post.Controls.Add(this.tabPage14);
            this.Post.Controls.Add(this.tabPage15);
            this.Post.Controls.Add(this.tabPage16);
            this.Post.Controls.Add(this.tabPage17);
            this.Post.Location = new System.Drawing.Point(6, 6);
            this.Post.Name = "Post";
            this.Post.SelectedIndex = 0;
            this.Post.Size = new System.Drawing.Size(1179, 465);
            this.Post.TabIndex = 0;
            this.Post.Click += new System.EventHandler(this.Post_Click);
            // 
            // tabPage14
            // 
            this.tabPage14.Controls.Add(this.dataGridWatchPost);
            this.tabPage14.Location = new System.Drawing.Point(4, 24);
            this.tabPage14.Name = "tabPage14";
            this.tabPage14.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage14.Size = new System.Drawing.Size(1171, 437);
            this.tabPage14.TabIndex = 0;
            this.tabPage14.Text = "Просмотр";
            this.tabPage14.UseVisualStyleBackColor = true;
            // 
            // tabPage15
            // 
            this.tabPage15.Controls.Add(this.label14);
            this.tabPage15.Controls.Add(this.AddPost);
            this.tabPage15.Controls.Add(this.AddNamePost);
            this.tabPage15.Location = new System.Drawing.Point(4, 24);
            this.tabPage15.Name = "tabPage15";
            this.tabPage15.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage15.Size = new System.Drawing.Size(1171, 437);
            this.tabPage15.TabIndex = 1;
            this.tabPage15.Text = "Добавление";
            this.tabPage15.UseVisualStyleBackColor = true;
            // 
            // tabPage16
            // 
            this.tabPage16.Controls.Add(this.UpdPostBox);
            this.tabPage16.Controls.Add(this.label16);
            this.tabPage16.Controls.Add(this.label15);
            this.tabPage16.Controls.Add(this.UdpPostButton);
            this.tabPage16.Controls.Add(this.UpdPostText);
            this.tabPage16.Location = new System.Drawing.Point(4, 24);
            this.tabPage16.Name = "tabPage16";
            this.tabPage16.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage16.Size = new System.Drawing.Size(1171, 437);
            this.tabPage16.TabIndex = 2;
            this.tabPage16.Text = "Редактирование";
            this.tabPage16.UseVisualStyleBackColor = true;
            // 
            // tabPage17
            // 
            this.tabPage17.Controls.Add(this.DeleteButton);
            this.tabPage17.Controls.Add(this.DeletePostBox);
            this.tabPage17.Controls.Add(this.label17);
            this.tabPage17.Location = new System.Drawing.Point(4, 24);
            this.tabPage17.Name = "tabPage17";
            this.tabPage17.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage17.Size = new System.Drawing.Size(1171, 437);
            this.tabPage17.TabIndex = 3;
            this.tabPage17.Text = "Удаление";
            this.tabPage17.UseVisualStyleBackColor = true;
            // 
            // dataGridWatchPost
            // 
            this.dataGridWatchPost.AllowUserToAddRows = false;
            this.dataGridWatchPost.AllowUserToDeleteRows = false;
            this.dataGridWatchPost.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWatchPost.Location = new System.Drawing.Point(6, 6);
            this.dataGridWatchPost.Name = "dataGridWatchPost";
            this.dataGridWatchPost.ReadOnly = true;
            this.dataGridWatchPost.Size = new System.Drawing.Size(1159, 425);
            this.dataGridWatchPost.TabIndex = 0;
            // 
            // AddNamePost
            // 
            this.AddNamePost.Location = new System.Drawing.Point(143, 7);
            this.AddNamePost.Name = "AddNamePost";
            this.AddNamePost.Size = new System.Drawing.Size(350, 22);
            this.AddNamePost.TabIndex = 0;
            // 
            // AddPost
            // 
            this.AddPost.Location = new System.Drawing.Point(6, 36);
            this.AddPost.Name = "AddPost";
            this.AddPost.Size = new System.Drawing.Size(119, 30);
            this.AddPost.TabIndex = 1;
            this.AddPost.Text = "Добавить";
            this.AddPost.UseVisualStyleBackColor = true;
            this.AddPost.Click += new System.EventHandler(this.AddPost_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(122, 15);
            this.label14.TabIndex = 2;
            this.label14.Text = "Название должности";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(122, 15);
            this.label15.TabIndex = 5;
            this.label15.Text = "Название должности";
            // 
            // UdpPostButton
            // 
            this.UdpPostButton.Location = new System.Drawing.Point(6, 70);
            this.UdpPostButton.Name = "UdpPostButton";
            this.UdpPostButton.Size = new System.Drawing.Size(119, 30);
            this.UdpPostButton.TabIndex = 4;
            this.UdpPostButton.Text = "Редактировать";
            this.UdpPostButton.UseVisualStyleBackColor = true;
            this.UdpPostButton.Click += new System.EventHandler(this.UdpPostButton_Click);
            // 
            // UpdPostText
            // 
            this.UpdPostText.Location = new System.Drawing.Point(141, 42);
            this.UpdPostText.Name = "UpdPostText";
            this.UpdPostText.Size = new System.Drawing.Size(350, 22);
            this.UpdPostText.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 15);
            this.label16.TabIndex = 6;
            this.label16.Text = "Выбор должности";
            // 
            // UpdPostBox
            // 
            this.UpdPostBox.FormattingEnabled = true;
            this.UpdPostBox.Location = new System.Drawing.Point(141, 9);
            this.UpdPostBox.Name = "UpdPostBox";
            this.UpdPostBox.Size = new System.Drawing.Size(350, 23);
            this.UpdPostBox.TabIndex = 7;
            this.UpdPostBox.SelectedIndexChanged += new System.EventHandler(this.UpdPostBox_SelectedIndexChanged);
            // 
            // DeletePostBox
            // 
            this.DeletePostBox.FormattingEnabled = true;
            this.DeletePostBox.Location = new System.Drawing.Point(141, 9);
            this.DeletePostBox.Name = "DeletePostBox";
            this.DeletePostBox.Size = new System.Drawing.Size(350, 23);
            this.DeletePostBox.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 15);
            this.label17.TabIndex = 8;
            this.label17.Text = "Выбор должности";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(9, 47);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(119, 30);
            this.DeleteButton.TabIndex = 10;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1501, 529);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWatchOrganization)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.Subdivision.ResumeLayout(false);
            this.tabPage10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWatchSubdivision)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            this.tabPage13.ResumeLayout(false);
            this.tabPage13.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.timesheetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
            this.Post.ResumeLayout(false);
            this.tabPage14.ResumeLayout(false);
            this.tabPage15.ResumeLayout(false);
            this.tabPage15.PerformLayout();
            this.tabPage16.ResumeLayout(false);
            this.tabPage16.PerformLayout();
            this.tabPage17.ResumeLayout(false);
            this.tabPage17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWatchPost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridWatchOrganization;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage2;
        private TimesheetDataSet timesheetDataSet;
        private System.Windows.Forms.BindingSource organizationBindingSource;
        private TimesheetDataSetTableAdapters.OrganizationTableAdapter organizationTableAdapter;
        private System.Windows.Forms.Button AddOrganization;
        private System.Windows.Forms.TextBox InnOrg;
        private System.Windows.Forms.TextBox AddsressOrg;
        private System.Windows.Forms.TextBox NameOrg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridWatchSubdivision;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabControl Subdivision;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.ComboBox OrganizationFK;
        private System.Windows.Forms.TextBox NameSubdivision;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button AddSubdivision;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.ComboBox UpdateSubdivison;
        private System.Windows.Forms.TextBox UpdNameSub;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button UdpSubdivision;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button DeleteSubButton;
        private System.Windows.Forms.ComboBox DeleteSubdivision;
        private System.Windows.Forms.TabControl Post;
        private System.Windows.Forms.TabPage tabPage14;
        private System.Windows.Forms.DataGridView dataGridWatchPost;
        private System.Windows.Forms.TabPage tabPage15;
        private System.Windows.Forms.TabPage tabPage16;
        private System.Windows.Forms.TabPage tabPage17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button AddPost;
        private System.Windows.Forms.TextBox AddNamePost;
        private System.Windows.Forms.ComboBox UpdPostBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button UdpPostButton;
        private System.Windows.Forms.TextBox UpdPostText;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox DeletePostBox;
        private System.Windows.Forms.Label label17;
    }
}

