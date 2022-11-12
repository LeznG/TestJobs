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
            this.dataGridWatchSubdivision = new System.Windows.Forms.DataGridView();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.timesheetDataSet = new WindowsFormsApp1.TimesheetDataSet();
            this.organizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.organizationTableAdapter = new WindowsFormsApp1.TimesheetDataSetTableAdapters.OrganizationTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWatchOrganization)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWatchSubdivision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timesheetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1196, 505);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1188, 479);
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
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1176, 467);
            this.tabControl2.TabIndex = 0;
            this.tabControl2.Click += new System.EventHandler(this.LoadCombobox_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridWatchOrganization);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1168, 441);
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
            this.tabPage4.Size = new System.Drawing.Size(1168, 441);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Добавление";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // InnOrg
            // 
            this.InnOrg.Location = new System.Drawing.Point(189, 85);
            this.InnOrg.Name = "InnOrg";
            this.InnOrg.Size = new System.Drawing.Size(350, 20);
            this.InnOrg.TabIndex = 6;
            // 
            // AddsressOrg
            // 
            this.AddsressOrg.Location = new System.Drawing.Point(189, 50);
            this.AddsressOrg.Name = "AddsressOrg";
            this.AddsressOrg.Size = new System.Drawing.Size(350, 20);
            this.AddsressOrg.TabIndex = 5;
            // 
            // NameOrg
            // 
            this.NameOrg.Location = new System.Drawing.Point(189, 16);
            this.NameOrg.Name = "NameOrg";
            this.NameOrg.Size = new System.Drawing.Size(350, 20);
            this.NameOrg.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Инн организации";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Адрес организации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование организации";
            // 
            // AddOrganization
            // 
            this.AddOrganization.Location = new System.Drawing.Point(9, 126);
            this.AddOrganization.Name = "AddOrganization";
            this.AddOrganization.Size = new System.Drawing.Size(164, 20);
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
            this.tabPage5.Size = new System.Drawing.Size(1168, 441);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Редактирование";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(189, 50);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(350, 20);
            this.textBox8.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Наименование организации";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 16);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(350, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(189, 124);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(350, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(189, 85);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(350, 20);
            this.textBox5.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Инн организации";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Адрес организации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Выбор организации";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 20);
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
            this.tabPage6.Size = new System.Drawing.Size(1168, 441);
            this.tabPage6.TabIndex = 3;
            this.tabPage6.Text = "Удаление";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(14, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 20);
            this.button3.TabIndex = 17;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.DeleteOrganization_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(197, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(350, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Наименование организации";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridWatchSubdivision);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1188, 479);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Подразделения";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridWatchSubdivision
            // 
            this.dataGridWatchSubdivision.AllowUserToAddRows = false;
            this.dataGridWatchSubdivision.AllowUserToDeleteRows = false;
            this.dataGridWatchSubdivision.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWatchSubdivision.Location = new System.Drawing.Point(6, 6);
            this.dataGridWatchSubdivision.Name = "dataGridWatchSubdivision";
            this.dataGridWatchSubdivision.ReadOnly = true;
            this.dataGridWatchSubdivision.Size = new System.Drawing.Size(1176, 467);
            this.dataGridWatchSubdivision.TabIndex = 0;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1188, 479);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Должности";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage8
            // 
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(1188, 479);
            this.tabPage8.TabIndex = 3;
            this.tabPage8.Text = "Сотрудники";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabPage9
            // 
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(1188, 479);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWatchSubdivision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timesheetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationBindingSource)).EndInit();
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
    }
}

