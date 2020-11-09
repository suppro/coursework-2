namespace ARU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClientPatronymic = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsData1 = new ARU.ClientsData();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label18 = new System.Windows.Forms.Label();
            this.dtimeDead = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dtimeBirth = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDeceasedPatronymic = new System.Windows.Forms.TextBox();
            this.txtDeceasedName = new System.Windows.Forms.TextBox();
            this.txtDeceasedSurname = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDeceased = new System.Windows.Forms.Button();
            this.dgvDeceased = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deceasedstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deceasedData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deceasedData1 = new ARU.DeceasedData();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmployeeAge = new System.Windows.Forms.TextBox();
            this.cmbEmployeePosition = new System.Windows.Forms.ComboBox();
            this.positionsData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.positionsData1 = new ARU.PositionsData();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmployeePatronymic = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.employeeData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeData1 = new ARU.EmployeeData();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbPartsOrder = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtOrderData = new System.Windows.Forms.DateTimePicker();
            this.txtOrderSum = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderData1 = new ARU.OrderData();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cbOrderNum = new System.Windows.Forms.ComboBox();
            this.orderNumData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderNumData1 = new ARU.OrderNumData();
            this.cbStatusOrder = new System.Windows.Forms.ComboBox();
            this.statusData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusData1 = new ARU.StatusData();
            this.label27 = new System.Windows.Forms.Label();
            this.txtNumGrave = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.dtimeFuneral = new System.Windows.Forms.DateTimePicker();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.txtIdDeceased = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.dgvPartsOrder = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsOrderData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsOrderData1 = new ARU.PartsOrderData();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.graveData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.graveData1 = new ARU.GraveData();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.clientTableAdapter1 = new ARU.ClientsDataTableAdapters.ClientTableAdapter();
            this.deceasedTableAdapter1 = new ARU.DeceasedDataTableAdapters.DeceasedTableAdapter();
            this.dataTable1TableAdapter3 = new ARU.EmployeeDataTableAdapters.DataTable1TableAdapter();
            this.dataTable1TableAdapter4 = new ARU.PartsOrderDataTableAdapters.DataTable1TableAdapter();
            this.orderTableAdapter3 = new ARU.OrderNumDataTableAdapters.OrderTableAdapter();
            this.statusTableAdapter1 = new ARU.StatusDataTableAdapters.StatusTableAdapter();
            this.positionTableAdapter1 = new ARU.PositionsDataTableAdapters.PositionTableAdapter();
            this.dataTable1TableAdapter5 = new ARU.GraveDataTableAdapters.DataTable1TableAdapter();
            this.orderTableAdapter2 = new ARU.OrderDataTableAdapters.OrderTableAdapter();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsData1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsData1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeceased)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deceasedData1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deceasedData1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsData1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderData1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderData1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumData1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusData1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOrderData1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOrderData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graveData1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graveData1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(20, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(811, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDeleteClient);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtClientPatronymic);
            this.tabPage1.Controls.Add(this.txtClientName);
            this.tabPage1.Controls.Add(this.txtClientSurname);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnClient);
            this.tabPage1.Controls.Add(this.dgvClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Клиенты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.Location = new System.Drawing.Point(24, 185);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(184, 23);
            this.btnDeleteClient.TabIndex = 12;
            this.btnDeleteClient.Text = "Удалить запись ";
            this.btnDeleteClient.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Имя";
            // 
            // txtClientPatronymic
            // 
            this.txtClientPatronymic.Location = new System.Drawing.Point(24, 130);
            this.txtClientPatronymic.Name = "txtClientPatronymic";
            this.txtClientPatronymic.Size = new System.Drawing.Size(184, 20);
            this.txtClientPatronymic.TabIndex = 8;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(24, 91);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(184, 20);
            this.txtClientName.TabIndex = 7;
            // 
            // txtClientSurname
            // 
            this.txtClientSurname.Location = new System.Drawing.Point(24, 52);
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.Size = new System.Drawing.Size(184, 20);
            this.txtClientSurname.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(32, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Добавить клиента";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(24, 156);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(184, 23);
            this.btnClient.TabIndex = 3;
            this.btnClient.Text = "Добавить клиента";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.AddClient);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AutoGenerateColumns = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvClient.DataSource = this.clientsData1BindingSource;
            this.dgvClient.Location = new System.Drawing.Point(245, 6);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.Size = new System.Drawing.Size(552, 355);
            this.dgvClient.TabIndex = 0;
            this.dgvClient.DoubleClick += new System.EventHandler(this.selectClient);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn4.HeaderText = "ID Клиента";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "patronymic";
            this.dataGridViewTextBoxColumn3.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // clientsData1BindingSource
            // 
            this.clientsData1BindingSource.DataMember = "Client";
            this.clientsData1BindingSource.DataSource = this.clientsData1;
            // 
            // clientsData1
            // 
            this.clientsData1.DataSetName = "ClientsData";
            this.clientsData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label18);
            this.tabPage5.Controls.Add(this.dtimeDead);
            this.tabPage5.Controls.Add(this.label17);
            this.tabPage5.Controls.Add(this.dtimeBirth);
            this.tabPage5.Controls.Add(this.label13);
            this.tabPage5.Controls.Add(this.label14);
            this.tabPage5.Controls.Add(this.txtDeceasedPatronymic);
            this.tabPage5.Controls.Add(this.txtDeceasedName);
            this.tabPage5.Controls.Add(this.txtDeceasedSurname);
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.label16);
            this.tabPage5.Controls.Add(this.btnDeceased);
            this.tabPage5.Controls.Add(this.dgvDeceased);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(803, 367);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Покойники";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(8, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 22;
            this.label18.Text = "Дата смерти";
            // 
            // dtimeDead
            // 
            this.dtimeDead.Location = new System.Drawing.Point(9, 208);
            this.dtimeDead.Name = "dtimeDead";
            this.dtimeDead.Size = new System.Drawing.Size(184, 20);
            this.dtimeDead.TabIndex = 21;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 13);
            this.label17.TabIndex = 20;
            this.label17.Text = "Дата рождения";
            // 
            // dtimeBirth
            // 
            this.dtimeBirth.Location = new System.Drawing.Point(9, 169);
            this.dtimeBirth.Name = "dtimeBirth";
            this.dtimeBirth.Size = new System.Drawing.Size(184, 20);
            this.dtimeBirth.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Отчество";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "Имя";
            // 
            // txtDeceasedPatronymic
            // 
            this.txtDeceasedPatronymic.Location = new System.Drawing.Point(9, 130);
            this.txtDeceasedPatronymic.Name = "txtDeceasedPatronymic";
            this.txtDeceasedPatronymic.Size = new System.Drawing.Size(184, 20);
            this.txtDeceasedPatronymic.TabIndex = 16;
            // 
            // txtDeceasedName
            // 
            this.txtDeceasedName.Location = new System.Drawing.Point(9, 91);
            this.txtDeceasedName.Name = "txtDeceasedName";
            this.txtDeceasedName.Size = new System.Drawing.Size(184, 20);
            this.txtDeceasedName.TabIndex = 15;
            // 
            // txtDeceasedSurname
            // 
            this.txtDeceasedSurname.Location = new System.Drawing.Point(9, 52);
            this.txtDeceasedSurname.Name = "txtDeceasedSurname";
            this.txtDeceasedSurname.Size = new System.Drawing.Size(184, 20);
            this.txtDeceasedSurname.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Фамилия";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(7, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 24);
            this.label16.TabIndex = 12;
            this.label16.Text = "Добавить покойника";
            // 
            // btnDeceased
            // 
            this.btnDeceased.Location = new System.Drawing.Point(9, 234);
            this.btnDeceased.Name = "btnDeceased";
            this.btnDeceased.Size = new System.Drawing.Size(184, 23);
            this.btnDeceased.TabIndex = 11;
            this.btnDeceased.Text = "Добавить покойника";
            this.btnDeceased.UseVisualStyleBackColor = true;
            this.btnDeceased.Click += new System.EventHandler(this.AddDeceased);
            // 
            // dgvDeceased
            // 
            this.dgvDeceased.AllowUserToAddRows = false;
            this.dgvDeceased.AutoGenerateColumns = false;
            this.dgvDeceased.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeceased.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.deceasedstatusDataGridViewTextBoxColumn});
            this.dgvDeceased.DataSource = this.deceasedData1BindingSource;
            this.dgvDeceased.Location = new System.Drawing.Point(209, 6);
            this.dgvDeceased.Name = "dgvDeceased";
            this.dgvDeceased.RowHeadersVisible = false;
            this.dgvDeceased.Size = new System.Drawing.Size(588, 355);
            this.dgvDeceased.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn5.HeaderText = "ID Покойника";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn6.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn7.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "patronymic";
            this.dataGridViewTextBoxColumn8.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "birth_date";
            this.dataGridViewTextBoxColumn9.HeaderText = "Дата рождения";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "death_date";
            this.dataGridViewTextBoxColumn10.HeaderText = "Дата смерти";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // deceasedstatusDataGridViewTextBoxColumn
            // 
            this.deceasedstatusDataGridViewTextBoxColumn.DataPropertyName = "deceased_status";
            this.deceasedstatusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.deceasedstatusDataGridViewTextBoxColumn.Name = "deceasedstatusDataGridViewTextBoxColumn";
            // 
            // deceasedData1BindingSource
            // 
            this.deceasedData1BindingSource.DataMember = "Deceased";
            this.deceasedData1BindingSource.DataSource = this.deceasedData1;
            // 
            // deceasedData1
            // 
            this.deceasedData1.DataSetName = "DeceasedData";
            this.deceasedData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtEmployeeAge);
            this.tabPage2.Controls.Add(this.cmbEmployeePosition);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtEmployeePatronymic);
            this.tabPage2.Controls.Add(this.txtEmployeeName);
            this.tabPage2.Controls.Add(this.txtEmployeeSurname);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.btnEmployee);
            this.tabPage2.Controls.Add(this.dgvEmployee);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Персонал";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 153);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Кол-во лет";
            // 
            // txtEmployeeAge
            // 
            this.txtEmployeeAge.Location = new System.Drawing.Point(15, 169);
            this.txtEmployeeAge.Name = "txtEmployeeAge";
            this.txtEmployeeAge.Size = new System.Drawing.Size(184, 20);
            this.txtEmployeeAge.TabIndex = 21;
            // 
            // cmbEmployeePosition
            // 
            this.cmbEmployeePosition.DataSource = this.positionsData1BindingSource;
            this.cmbEmployeePosition.DisplayMember = "position_name";
            this.cmbEmployeePosition.FormattingEnabled = true;
            this.cmbEmployeePosition.Location = new System.Drawing.Point(15, 208);
            this.cmbEmployeePosition.Name = "cmbEmployeePosition";
            this.cmbEmployeePosition.Size = new System.Drawing.Size(184, 21);
            this.cmbEmployeePosition.TabIndex = 20;
            this.cmbEmployeePosition.ValueMember = "id";
            // 
            // positionsData1BindingSource
            // 
            this.positionsData1BindingSource.DataMember = "Position";
            this.positionsData1BindingSource.DataSource = this.positionsData1;
            // 
            // positionsData1
            // 
            this.positionsData1.DataSetName = "PositionsData";
            this.positionsData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Должность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Отчество";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Имя";
            // 
            // txtEmployeePatronymic
            // 
            this.txtEmployeePatronymic.Location = new System.Drawing.Point(15, 130);
            this.txtEmployeePatronymic.Name = "txtEmployeePatronymic";
            this.txtEmployeePatronymic.Size = new System.Drawing.Size(184, 20);
            this.txtEmployeePatronymic.TabIndex = 16;
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(15, 91);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(184, 20);
            this.txtEmployeeName.TabIndex = 15;
            // 
            // txtEmployeeSurname
            // 
            this.txtEmployeeSurname.Location = new System.Drawing.Point(15, 52);
            this.txtEmployeeSurname.Name = "txtEmployeeSurname";
            this.txtEmployeeSurname.Size = new System.Drawing.Size(184, 20);
            this.txtEmployeeSurname.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Фамилия";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(13, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(189, 24);
            this.label10.TabIndex = 12;
            this.label10.Text = "Добавить персонал";
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(15, 235);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(184, 23);
            this.btnEmployee.TabIndex = 11;
            this.btnEmployee.Text = "Добавить сотрудника";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.AddPersonal);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.AllowUserToAddRows = false;
            this.dgvEmployee.AutoGenerateColumns = false;
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.dgvEmployee.DataSource = this.employeeData1BindingSource;
            this.dgvEmployee.Location = new System.Drawing.Point(233, 6);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowHeadersVisible = false;
            this.dgvEmployee.Size = new System.Drawing.Size(564, 355);
            this.dgvEmployee.TabIndex = 0;
            // 
            // employeeData1BindingSource
            // 
            this.employeeData1BindingSource.DataMember = "DataTable1";
            this.employeeData1BindingSource.DataSource = this.employeeData1;
            // 
            // employeeData1
            // 
            this.employeeData1.DataSetName = "EmployeeData";
            this.employeeData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbPartsOrder);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.button8);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.txtOrderData);
            this.tabPage3.Controls.Add(this.txtOrderSum);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.txtClientID);
            this.tabPage3.Controls.Add(this.txtEmployeeID);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.dgvOrder);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(803, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Заказы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbPartsOrder
            // 
            this.cbPartsOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPartsOrder.FormattingEnabled = true;
            this.cbPartsOrder.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbPartsOrder.Location = new System.Drawing.Point(16, 177);
            this.cbPartsOrder.Name = "cbPartsOrder";
            this.cbPartsOrder.Size = new System.Drawing.Size(184, 21);
            this.cbPartsOrder.TabIndex = 40;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(14, 159);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(117, 13);
            this.label25.TabIndex = 39;
            this.label25.Text = "Кол-во частей заказа";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(16, 272);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(184, 23);
            this.button8.TabIndex = 38;
            this.button8.Text = "Изменить заказ";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(18, 335);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(184, 23);
            this.button7.TabIndex = 37;
            this.button7.Text = "Уточнить детали заказа";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 36;
            this.label19.Text = "Сумма заказа";
            // 
            // txtOrderData
            // 
            this.txtOrderData.Location = new System.Drawing.Point(16, 217);
            this.txtOrderData.Name = "txtOrderData";
            this.txtOrderData.Size = new System.Drawing.Size(184, 20);
            this.txtOrderData.TabIndex = 35;
            // 
            // txtOrderSum
            // 
            this.txtOrderSum.Location = new System.Drawing.Point(16, 132);
            this.txtOrderSum.Name = "txtOrderSum";
            this.txtOrderSum.Size = new System.Drawing.Size(184, 20);
            this.txtOrderSum.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 201);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "Дата заказа";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 13);
            this.label22.TabIndex = 29;
            this.label22.Text = "ID Клиента";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(16, 93);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(184, 20);
            this.txtClientID.TabIndex = 27;
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(16, 54);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(184, 20);
            this.txtEmployeeID.TabIndex = 26;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 38);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(80, 13);
            this.label23.TabIndex = 25;
            this.label23.Text = "ID Сотрудника";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(32, 8);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(153, 24);
            this.label24.TabIndex = 24;
            this.label24.Text = "Добавить заказ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(16, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(184, 23);
            this.button5.TabIndex = 23;
            this.button5.Text = "Добавить заказ";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.AddOrder);
            // 
            // dgvOrder
            // 
            this.dgvOrder.AllowUserToAddRows = false;
            this.dgvOrder.AutoGenerateColumns = false;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.dgvOrder.DataSource = this.orderData1BindingSource;
            this.dgvOrder.Location = new System.Drawing.Point(223, 8);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersVisible = false;
            this.dgvOrder.Size = new System.Drawing.Size(574, 356);
            this.dgvOrder.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "order_num";
            this.dataGridViewTextBoxColumn19.HeaderText = "Номер Заказа";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "parts_order";
            this.dataGridViewTextBoxColumn23.HeaderText = "Части заказа";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "order_sum";
            this.dataGridViewTextBoxColumn20.HeaderText = "Сумма заказа";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "order_date";
            this.dataGridViewTextBoxColumn21.HeaderText = "Дата Заказа";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn22.HeaderText = "id";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.ReadOnly = true;
            this.dataGridViewTextBoxColumn22.Visible = false;
            // 
            // orderData1BindingSource
            // 
            this.orderData1BindingSource.DataMember = "Order";
            this.orderData1BindingSource.DataSource = this.orderData1;
            // 
            // orderData1
            // 
            this.orderData1.DataSetName = "OrderData";
            this.orderData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cbOrderNum);
            this.tabPage4.Controls.Add(this.cbStatusOrder);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.txtNumGrave);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.dtimeFuneral);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.label31);
            this.tabPage4.Controls.Add(this.txtIdDeceased);
            this.tabPage4.Controls.Add(this.label32);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.label21);
            this.tabPage4.Controls.Add(this.dgvPartsOrder);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(803, 367);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Части заказа";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cbOrderNum
            // 
            this.cbOrderNum.DataSource = this.orderNumData1BindingSource;
            this.cbOrderNum.DisplayMember = "order_num";
            this.cbOrderNum.FormattingEnabled = true;
            this.cbOrderNum.Location = new System.Drawing.Point(23, 55);
            this.cbOrderNum.Name = "cbOrderNum";
            this.cbOrderNum.Size = new System.Drawing.Size(182, 21);
            this.cbOrderNum.TabIndex = 55;
            this.cbOrderNum.ValueMember = "id";
            // 
            // orderNumData1BindingSource
            // 
            this.orderNumData1BindingSource.DataMember = "Order";
            this.orderNumData1BindingSource.DataSource = this.orderNumData1;
            // 
            // orderNumData1
            // 
            this.orderNumData1.DataSetName = "OrderNumData";
            this.orderNumData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbStatusOrder
            // 
            this.cbStatusOrder.DataSource = this.statusData1BindingSource;
            this.cbStatusOrder.DisplayMember = "status_name";
            this.cbStatusOrder.FormattingEnabled = true;
            this.cbStatusOrder.Location = new System.Drawing.Point(23, 213);
            this.cbStatusOrder.Name = "cbStatusOrder";
            this.cbStatusOrder.Size = new System.Drawing.Size(182, 21);
            this.cbStatusOrder.TabIndex = 54;
            this.cbStatusOrder.ValueMember = "id";
            // 
            // statusData1BindingSource
            // 
            this.statusData1BindingSource.DataMember = "Status";
            this.statusData1BindingSource.DataSource = this.statusData1;
            // 
            // statusData1
            // 
            this.statusData1.DataSetName = "StatusData";
            this.statusData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(20, 157);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(101, 13);
            this.label27.TabIndex = 52;
            this.label27.Text = "Дата захоронения";
            // 
            // txtNumGrave
            // 
            this.txtNumGrave.Location = new System.Drawing.Point(23, 134);
            this.txtNumGrave.Name = "txtNumGrave";
            this.txtNumGrave.Size = new System.Drawing.Size(182, 20);
            this.txtNumGrave.TabIndex = 50;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(20, 118);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(143, 13);
            this.label28.TabIndex = 49;
            this.label28.Text = "Номер места захоронения";
            // 
            // dtimeFuneral
            // 
            this.dtimeFuneral.Location = new System.Drawing.Point(23, 173);
            this.dtimeFuneral.Name = "dtimeFuneral";
            this.dtimeFuneral.Size = new System.Drawing.Size(182, 20);
            this.dtimeFuneral.TabIndex = 48;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(20, 196);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(80, 13);
            this.label29.TabIndex = 47;
            this.label29.Text = "Статус заказа";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(20, 79);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(77, 13);
            this.label31.TabIndex = 44;
            this.label31.Text = "ID Покойника";
            // 
            // txtIdDeceased
            // 
            this.txtIdDeceased.Location = new System.Drawing.Point(23, 95);
            this.txtIdDeceased.Name = "txtIdDeceased";
            this.txtIdDeceased.Size = new System.Drawing.Size(182, 20);
            this.txtIdDeceased.TabIndex = 43;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(20, 40);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(81, 13);
            this.label32.TabIndex = 41;
            this.label32.Text = "Номер Заказа";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(23, 240);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(184, 23);
            this.button6.TabIndex = 40;
            this.button6.Text = "Добавить часть заказа";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AddPartOrder);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(6, 6);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(219, 24);
            this.label21.TabIndex = 1;
            this.label21.Text = "Добавить часть заказа";
            // 
            // dgvPartsOrder
            // 
            this.dgvPartsOrder.AllowUserToAddRows = false;
            this.dgvPartsOrder.AutoGenerateColumns = false;
            this.dgvPartsOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartsOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25,
            this.dataGridViewTextBoxColumn26,
            this.dataGridViewTextBoxColumn27,
            this.dataGridViewTextBoxColumn28});
            this.dgvPartsOrder.DataSource = this.partsOrderData1BindingSource;
            this.dgvPartsOrder.Location = new System.Drawing.Point(245, 6);
            this.dgvPartsOrder.Name = "dgvPartsOrder";
            this.dgvPartsOrder.RowHeadersVisible = false;
            this.dgvPartsOrder.Size = new System.Drawing.Size(555, 355);
            this.dgvPartsOrder.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "order_num";
            this.dataGridViewTextBoxColumn24.HeaderText = "Номер заказа";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "fio";
            this.dataGridViewTextBoxColumn25.HeaderText = "ФИО Клиента";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.DataPropertyName = "burial_date";
            this.dataGridViewTextBoxColumn26.HeaderText = "Дата погребения";
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.DataPropertyName = "grave_number";
            this.dataGridViewTextBoxColumn27.HeaderText = "Номер могилы";
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.DataPropertyName = "status_name";
            this.dataGridViewTextBoxColumn28.HeaderText = "Статус заказа";
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            // 
            // partsOrderData1BindingSource
            // 
            this.partsOrderData1BindingSource.DataMember = "DataTable1";
            this.partsOrderData1BindingSource.DataSource = this.partsOrderData1;
            // 
            // partsOrderData1
            // 
            this.partsOrderData1.DataSetName = "PartsOrderData";
            this.partsOrderData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn29,
            this.dataGridViewTextBoxColumn30});
            this.dataGridView1.DataSource = this.graveData1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(846, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(210, 339);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.DataPropertyName = "grave_number";
            this.dataGridViewTextBoxColumn29.HeaderText = "Номер могилы";
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.DataPropertyName = "status_value";
            this.dataGridViewTextBoxColumn30.HeaderText = "Статус";
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            // 
            // graveData1BindingSource
            // 
            this.graveData1BindingSource.DataMember = "DataTable1";
            this.graveData1BindingSource.DataSource = this.graveData1;
            // 
            // graveData1
            // 
            this.graveData1.DataSetName = "GraveData";
            this.graveData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(842, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Места захоронения:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(846, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить место";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddGrave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Меню программы:";
            // 
            // clientTableAdapter1
            // 
            this.clientTableAdapter1.ClearBeforeFill = true;
            // 
            // deceasedTableAdapter1
            // 
            this.deceasedTableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter3
            // 
            this.dataTable1TableAdapter3.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter4
            // 
            this.dataTable1TableAdapter4.ClearBeforeFill = true;
            // 
            // orderTableAdapter3
            // 
            this.orderTableAdapter3.ClearBeforeFill = true;
            // 
            // statusTableAdapter1
            // 
            this.statusTableAdapter1.ClearBeforeFill = true;
            // 
            // positionTableAdapter1
            // 
            this.positionTableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter5
            // 
            this.dataTable1TableAdapter5.ClearBeforeFill = true;
            // 
            // orderTableAdapter2
            // 
            this.orderTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn12.HeaderText = "ID Сотрудника";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "position_name";
            this.dataGridViewTextBoxColumn11.HeaderText = "Должность";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "surname";
            this.dataGridViewTextBoxColumn13.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn14.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "patronymic";
            this.dataGridViewTextBoxColumn15.HeaderText = "Отчество";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn16.HeaderText = "Возраст";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "login";
            this.dataGridViewTextBoxColumn17.HeaderText = "Логин";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "password";
            this.dataGridViewTextBoxColumn18.HeaderText = "Пароль";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 444);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ritual management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsData1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsData1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeceased)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deceasedData1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deceasedData1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionsData1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.positionsData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderData1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderData1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumData1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderNumData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusData1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartsOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOrderData1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsOrderData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graveData1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graveData1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private GraveData graveData;
        private GraveDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravenumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.DataGridView dgvDeceased;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientPatronymic;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmployeeAge;
        private System.Windows.Forms.ComboBox cmbEmployeePosition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmployeePatronymic;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label label6;
        private ClientsData clientsData;
        private ClientsDataTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker dtimeDead;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtimeBirth;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDeceasedPatronymic;
        private System.Windows.Forms.TextBox txtDeceasedName;
        private System.Windows.Forms.TextBox txtDeceasedSurname;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnDeceased;
        private EmployeeData employeeData;
        private DeceasedData deceasedData;
        private DeceasedDataTableAdapters.DeceasedTableAdapter deceasedTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DateTimePicker txtOrderData;
        private System.Windows.Forms.TextBox txtOrderSum;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cbStatusOrder;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox txtNumGrave;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DateTimePicker dtimeFuneral;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtIdDeceased;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dgvPartsOrder;
        private PositionsData positionsData;
        private PositionsDataTableAdapters.PositionTableAdapter positionTableAdapter;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private OrderData orderData;
        private OrderDataTableAdapters.OrderTableAdapter orderTableAdapter;
        private PartsOrderData partsOrderData;
        private PartsOrderDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn burialdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gravenumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusnameDataGridViewTextBoxColumn;
        private StatusData statusData;
        private StatusDataTableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private EmployeeDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.ComboBox cbPartsOrder;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordernumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsorderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox cbOrderNum;
        private OrderNumData orderNumData;
        private OrderNumDataTableAdapters.OrderTableAdapter orderTableAdapter1;
        private System.Windows.Forms.BindingSource clientsData1BindingSource;
        private ClientsData clientsData1;
        private ClientsDataTableAdapters.ClientTableAdapter clientTableAdapter1;
        private System.Windows.Forms.BindingSource deceasedData1BindingSource;
        private DeceasedData deceasedData1;
        private DeceasedDataTableAdapters.DeceasedTableAdapter deceasedTableAdapter1;
        private System.Windows.Forms.BindingSource employeeData1BindingSource;
        private EmployeeData employeeData1;
        private EmployeeDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter3;
        private OrderData orderData1;
        private System.Windows.Forms.BindingSource partsOrderData1BindingSource;
        private PartsOrderData partsOrderData1;
        private PartsOrderDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter4;
        private System.Windows.Forms.BindingSource orderNumData1BindingSource;
        private OrderNumData orderNumData1;
        private OrderNumDataTableAdapters.OrderTableAdapter orderTableAdapter3;
        private System.Windows.Forms.BindingSource statusData1BindingSource;
        private StatusData statusData1;
        private StatusDataTableAdapters.StatusTableAdapter statusTableAdapter1;
        private System.Windows.Forms.BindingSource positionsData1BindingSource;
        private PositionsData positionsData1;
        private PositionsDataTableAdapters.PositionTableAdapter positionTableAdapter1;
        private System.Windows.Forms.BindingSource graveData1BindingSource;
        private GraveData graveData1;
        private GraveDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private System.Windows.Forms.BindingSource orderData1BindingSource;
        private OrderDataTableAdapters.OrderTableAdapter orderTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn deceasedstatusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn deceasedstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
    }
}

