namespace PKDataBaseView
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.carsTab = new System.Windows.Forms.TabPage();
            this.carDataGridView = new System.Windows.Forms.DataGridView();
            this.hyrenbilDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hyrenbilDataSet = new PKDataBaseView.hyrenbilDataSet();
            this.carDeleteBtn = new System.Windows.Forms.Button();
            this.carClearBtn = new System.Windows.Forms.Button();
            this.carGarageComboBox = new System.Windows.Forms.ComboBox();
            this.carColorComboBox = new System.Windows.Forms.ComboBox();
            this.carBrandComboBox = new System.Windows.Forms.ComboBox();
            this.carModelComboBox = new System.Windows.Forms.ComboBox();
            this.carGarageLbl = new System.Windows.Forms.Label();
            this.carSeatsLbl = new System.Windows.Forms.Label();
            this.carPriceLbl = new System.Windows.Forms.Label();
            this.carColorLbl = new System.Windows.Forms.Label();
            this.carModelLbl = new System.Windows.Forms.Label();
            this.carBrandLbl = new System.Windows.Forms.Label();
            this.carRegNbrLbl = new System.Windows.Forms.Label();
            this.carMsgLabel = new System.Windows.Forms.Label();
            this.carAddBtn = new System.Windows.Forms.Button();
            this.carUpdateBtn = new System.Windows.Forms.Button();
            this.carSearchBtn = new System.Windows.Forms.Button();
            this.carSeatsField = new System.Windows.Forms.TextBox();
            this.carPriceField = new System.Windows.Forms.TextBox();
            this.carRegNbrField = new System.Windows.Forms.TextBox();
            this.carInfoLbl = new System.Windows.Forms.Label();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.customerClearBtn = new System.Windows.Forms.Button();
            this.customerPhoneNbrLbl = new System.Windows.Forms.Label();
            this.customerAddressLbl = new System.Windows.Forms.Label();
            this.customerLastNameLbl = new System.Windows.Forms.Label();
            this.customerFirstNameLbl = new System.Windows.Forms.Label();
            this.customerCustIDLbl = new System.Windows.Forms.Label();
            this.customerMsgLabel = new System.Windows.Forms.Label();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.customerDeleteBtn = new System.Windows.Forms.Button();
            this.customerAddBtn = new System.Windows.Forms.Button();
            this.customerUpdateBtn = new System.Windows.Forms.Button();
            this.customerSearchBtn = new System.Windows.Forms.Button();
            this.customerLastNameField = new System.Windows.Forms.TextBox();
            this.customerFirstNameField = new System.Windows.Forms.TextBox();
            this.customerAddressField = new System.Windows.Forms.TextBox();
            this.customerPhoneNbrField = new System.Windows.Forms.TextBox();
            this.customerIDField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bookingTab = new System.Windows.Forms.TabPage();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.bookingClearBtn = new System.Windows.Forms.Button();
            this.bookingEndDateLbl = new System.Windows.Forms.Label();
            this.bookingStartDateLbl = new System.Windows.Forms.Label();
            this.bookingRegNbrLbl = new System.Windows.Forms.Label();
            this.bookingCustomerIDLbl = new System.Windows.Forms.Label();
            this.bookingNbrLbl = new System.Windows.Forms.Label();
            this.bookingMsgLabel = new System.Windows.Forms.Label();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.bookingRemoveBtn = new System.Windows.Forms.Button();
            this.bookingAddBtn = new System.Windows.Forms.Button();
            this.bookingUpdateBtn = new System.Windows.Forms.Button();
            this.bookingSearchBtn = new System.Windows.Forms.Button();
            this.bookingRegNbrField = new System.Windows.Forms.TextBox();
            this.bookingCustomerIDField = new System.Windows.Forms.TextBox();
            this.bookingNbrField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.garageTab = new System.Windows.Forms.TabPage();
            this.garageMsgLabel = new System.Windows.Forms.Label();
            this.garageDataGridView = new System.Windows.Forms.DataGridView();
            this.garageRemoveBtn = new System.Windows.Forms.Button();
            this.garageAddBtn = new System.Windows.Forms.Button();
            this.garageUpdateBtn = new System.Windows.Forms.Button();
            this.garageSearchBtn = new System.Windows.Forms.Button();
            this.garageSizeField = new System.Windows.Forms.TextBox();
            this.garageAddressField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hyrenbilDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.garageAddressLbl = new System.Windows.Forms.Label();
            this.garageSizeLbl = new System.Windows.Forms.Label();
            this.garageClearBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.carsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyrenbilDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyrenbilDataSet)).BeginInit();
            this.customersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.bookingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            this.garageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyrenbilDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.carsTab);
            this.tabControl1.Controls.Add(this.customersTab);
            this.tabControl1.Controls.Add(this.bookingTab);
            this.tabControl1.Controls.Add(this.garageTab);
            this.tabControl1.Location = new System.Drawing.Point(9, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1046, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // carsTab
            // 
            this.carsTab.Controls.Add(this.carDataGridView);
            this.carsTab.Controls.Add(this.carDeleteBtn);
            this.carsTab.Controls.Add(this.carClearBtn);
            this.carsTab.Controls.Add(this.carGarageComboBox);
            this.carsTab.Controls.Add(this.carColorComboBox);
            this.carsTab.Controls.Add(this.carBrandComboBox);
            this.carsTab.Controls.Add(this.carModelComboBox);
            this.carsTab.Controls.Add(this.carGarageLbl);
            this.carsTab.Controls.Add(this.carSeatsLbl);
            this.carsTab.Controls.Add(this.carPriceLbl);
            this.carsTab.Controls.Add(this.carColorLbl);
            this.carsTab.Controls.Add(this.carModelLbl);
            this.carsTab.Controls.Add(this.carBrandLbl);
            this.carsTab.Controls.Add(this.carRegNbrLbl);
            this.carsTab.Controls.Add(this.carMsgLabel);
            this.carsTab.Controls.Add(this.carAddBtn);
            this.carsTab.Controls.Add(this.carUpdateBtn);
            this.carsTab.Controls.Add(this.carSearchBtn);
            this.carsTab.Controls.Add(this.carSeatsField);
            this.carsTab.Controls.Add(this.carPriceField);
            this.carsTab.Controls.Add(this.carRegNbrField);
            this.carsTab.Controls.Add(this.carInfoLbl);
            this.carsTab.Location = new System.Drawing.Point(4, 22);
            this.carsTab.Margin = new System.Windows.Forms.Padding(2);
            this.carsTab.Name = "carsTab";
            this.carsTab.Padding = new System.Windows.Forms.Padding(2);
            this.carsTab.Size = new System.Drawing.Size(1038, 427);
            this.carsTab.TabIndex = 0;
            this.carsTab.Text = "Cars";
            this.carsTab.UseVisualStyleBackColor = true;
            // 
            // carDataGridView
            // 
            this.carDataGridView.AllowUserToOrderColumns = true;
            this.carDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carDataGridView.AutoGenerateColumns = false;
            this.carDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carDataGridView.DataSource = this.hyrenbilDataSetBindingSource1;
            this.carDataGridView.Location = new System.Drawing.Point(363, 47);
            this.carDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.RowTemplate.Height = 24;
            this.carDataGridView.Size = new System.Drawing.Size(662, 342);
            this.carDataGridView.TabIndex = 12;
            // 
            // hyrenbilDataSetBindingSource1
            // 
            this.hyrenbilDataSetBindingSource1.DataSource = this.hyrenbilDataSet;
            this.hyrenbilDataSetBindingSource1.Position = 0;
            // 
            // hyrenbilDataSet
            // 
            this.hyrenbilDataSet.DataSetName = "hyrenbilDataSet";
            this.hyrenbilDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carDeleteBtn
            // 
            this.carDeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carDeleteBtn.Location = new System.Drawing.Point(248, 315);
            this.carDeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.carDeleteBtn.Name = "carDeleteBtn";
            this.carDeleteBtn.Size = new System.Drawing.Size(75, 28);
            this.carDeleteBtn.TabIndex = 26;
            this.carDeleteBtn.Text = "Delete";
            this.carDeleteBtn.UseVisualStyleBackColor = true;
            this.carDeleteBtn.Click += new System.EventHandler(this.carDeleteBtn_Click);
            // 
            // carClearBtn
            // 
            this.carClearBtn.Location = new System.Drawing.Point(248, 282);
            this.carClearBtn.Name = "carClearBtn";
            this.carClearBtn.Size = new System.Drawing.Size(75, 28);
            this.carClearBtn.TabIndex = 25;
            this.carClearBtn.Text = "Clear Fields";
            this.carClearBtn.UseVisualStyleBackColor = true;
            this.carClearBtn.Click += new System.EventHandler(this.carClearBtn_Click);
            // 
            // carGarageComboBox
            // 
            this.carGarageComboBox.FormattingEnabled = true;
            this.carGarageComboBox.Location = new System.Drawing.Point(94, 257);
            this.carGarageComboBox.Name = "carGarageComboBox";
            this.carGarageComboBox.Size = new System.Drawing.Size(229, 21);
            this.carGarageComboBox.TabIndex = 24;
            // 
            // carColorComboBox
            // 
            this.carColorComboBox.FormattingEnabled = true;
            this.carColorComboBox.Location = new System.Drawing.Point(94, 188);
            this.carColorComboBox.Name = "carColorComboBox";
            this.carColorComboBox.Size = new System.Drawing.Size(229, 21);
            this.carColorComboBox.TabIndex = 23;
            // 
            // carBrandComboBox
            // 
            this.carBrandComboBox.FormattingEnabled = true;
            this.carBrandComboBox.Location = new System.Drawing.Point(94, 165);
            this.carBrandComboBox.Name = "carBrandComboBox";
            this.carBrandComboBox.Size = new System.Drawing.Size(229, 21);
            this.carBrandComboBox.TabIndex = 22;
            this.carBrandComboBox.Leave += new System.EventHandler(this.carBrandComboBox_Leave);
            // 
            // carModelComboBox
            // 
            this.carModelComboBox.FormattingEnabled = true;
            this.carModelComboBox.Location = new System.Drawing.Point(94, 140);
            this.carModelComboBox.Name = "carModelComboBox";
            this.carModelComboBox.Size = new System.Drawing.Size(229, 21);
            this.carModelComboBox.TabIndex = 21;
            this.carModelComboBox.Leave += new System.EventHandler(this.carModelComboBox_Leave_1);
            // 
            // carGarageLbl
            // 
            this.carGarageLbl.AutoSize = true;
            this.carGarageLbl.Location = new System.Drawing.Point(5, 260);
            this.carGarageLbl.Name = "carGarageLbl";
            this.carGarageLbl.Size = new System.Drawing.Size(42, 13);
            this.carGarageLbl.TabIndex = 20;
            this.carGarageLbl.Text = "Garage";
            // 
            // carSeatsLbl
            // 
            this.carSeatsLbl.AutoSize = true;
            this.carSeatsLbl.Location = new System.Drawing.Point(5, 237);
            this.carSeatsLbl.Name = "carSeatsLbl";
            this.carSeatsLbl.Size = new System.Drawing.Size(34, 13);
            this.carSeatsLbl.TabIndex = 19;
            this.carSeatsLbl.Text = "Seats";
            // 
            // carPriceLbl
            // 
            this.carPriceLbl.AutoSize = true;
            this.carPriceLbl.Location = new System.Drawing.Point(5, 214);
            this.carPriceLbl.Name = "carPriceLbl";
            this.carPriceLbl.Size = new System.Drawing.Size(31, 13);
            this.carPriceLbl.TabIndex = 18;
            this.carPriceLbl.Text = "Price";
            // 
            // carColorLbl
            // 
            this.carColorLbl.AutoSize = true;
            this.carColorLbl.Location = new System.Drawing.Point(5, 191);
            this.carColorLbl.Name = "carColorLbl";
            this.carColorLbl.Size = new System.Drawing.Size(31, 13);
            this.carColorLbl.TabIndex = 17;
            this.carColorLbl.Text = "Color";
            // 
            // carModelLbl
            // 
            this.carModelLbl.AutoSize = true;
            this.carModelLbl.Location = new System.Drawing.Point(5, 143);
            this.carModelLbl.Name = "carModelLbl";
            this.carModelLbl.Size = new System.Drawing.Size(36, 13);
            this.carModelLbl.TabIndex = 16;
            this.carModelLbl.Text = "Model";
            // 
            // carBrandLbl
            // 
            this.carBrandLbl.AutoSize = true;
            this.carBrandLbl.Location = new System.Drawing.Point(5, 168);
            this.carBrandLbl.Name = "carBrandLbl";
            this.carBrandLbl.Size = new System.Drawing.Size(35, 13);
            this.carBrandLbl.TabIndex = 15;
            this.carBrandLbl.Text = "Brand";
            // 
            // carRegNbrLbl
            // 
            this.carRegNbrLbl.AutoSize = true;
            this.carRegNbrLbl.Location = new System.Drawing.Point(5, 120);
            this.carRegNbrLbl.Name = "carRegNbrLbl";
            this.carRegNbrLbl.Size = new System.Drawing.Size(70, 13);
            this.carRegNbrLbl.TabIndex = 14;
            this.carRegNbrLbl.Text = "Reg. Number";
            // 
            // carMsgLabel
            // 
            this.carMsgLabel.AutoSize = true;
            this.carMsgLabel.Location = new System.Drawing.Point(8, 354);
            this.carMsgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carMsgLabel.Name = "carMsgLabel";
            this.carMsgLabel.Size = new System.Drawing.Size(0, 13);
            this.carMsgLabel.TabIndex = 13;
            // 
            // carAddBtn
            // 
            this.carAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carAddBtn.Location = new System.Drawing.Point(169, 315);
            this.carAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.carAddBtn.Name = "carAddBtn";
            this.carAddBtn.Size = new System.Drawing.Size(75, 28);
            this.carAddBtn.TabIndex = 10;
            this.carAddBtn.Text = "Add";
            this.carAddBtn.UseVisualStyleBackColor = true;
            this.carAddBtn.Click += new System.EventHandler(this.carAddBtn_Click);
            // 
            // carUpdateBtn
            // 
            this.carUpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carUpdateBtn.Location = new System.Drawing.Point(90, 315);
            this.carUpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.carUpdateBtn.Name = "carUpdateBtn";
            this.carUpdateBtn.Size = new System.Drawing.Size(75, 28);
            this.carUpdateBtn.TabIndex = 9;
            this.carUpdateBtn.Text = "Update";
            this.carUpdateBtn.UseVisualStyleBackColor = true;
            this.carUpdateBtn.Click += new System.EventHandler(this.carUpdateBtn_Click);
            // 
            // carSearchBtn
            // 
            this.carSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carSearchBtn.Location = new System.Drawing.Point(11, 315);
            this.carSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.carSearchBtn.Name = "carSearchBtn";
            this.carSearchBtn.Size = new System.Drawing.Size(75, 28);
            this.carSearchBtn.TabIndex = 8;
            this.carSearchBtn.Text = "Search";
            this.carSearchBtn.UseVisualStyleBackColor = true;
            this.carSearchBtn.Click += new System.EventHandler(this.carSearchBtn_Click);
            // 
            // carSeatsField
            // 
            this.carSeatsField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carSeatsField.Location = new System.Drawing.Point(94, 234);
            this.carSeatsField.Margin = new System.Windows.Forms.Padding(2);
            this.carSeatsField.Name = "carSeatsField";
            this.carSeatsField.Size = new System.Drawing.Size(229, 20);
            this.carSeatsField.TabIndex = 6;
            // 
            // carPriceField
            // 
            this.carPriceField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carPriceField.Location = new System.Drawing.Point(94, 211);
            this.carPriceField.Margin = new System.Windows.Forms.Padding(2);
            this.carPriceField.Name = "carPriceField";
            this.carPriceField.Size = new System.Drawing.Size(229, 20);
            this.carPriceField.TabIndex = 5;
            // 
            // carRegNbrField
            // 
            this.carRegNbrField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carRegNbrField.Location = new System.Drawing.Point(94, 117);
            this.carRegNbrField.Margin = new System.Windows.Forms.Padding(2);
            this.carRegNbrField.Name = "carRegNbrField";
            this.carRegNbrField.Size = new System.Drawing.Size(229, 20);
            this.carRegNbrField.TabIndex = 1;
            // 
            // carInfoLbl
            // 
            this.carInfoLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carInfoLbl.AutoSize = true;
            this.carInfoLbl.Location = new System.Drawing.Point(81, 89);
            this.carInfoLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carInfoLbl.Name = "carInfoLbl";
            this.carInfoLbl.Size = new System.Drawing.Size(43, 13);
            this.carInfoLbl.TabIndex = 0;
            this.carInfoLbl.Text = "Car info";
            // 
            // customersTab
            // 
            this.customersTab.Controls.Add(this.customerClearBtn);
            this.customersTab.Controls.Add(this.customerPhoneNbrLbl);
            this.customersTab.Controls.Add(this.customerAddressLbl);
            this.customersTab.Controls.Add(this.customerLastNameLbl);
            this.customersTab.Controls.Add(this.customerFirstNameLbl);
            this.customersTab.Controls.Add(this.customerCustIDLbl);
            this.customersTab.Controls.Add(this.customerMsgLabel);
            this.customersTab.Controls.Add(this.customerDataGridView);
            this.customersTab.Controls.Add(this.customerDeleteBtn);
            this.customersTab.Controls.Add(this.customerAddBtn);
            this.customersTab.Controls.Add(this.customerUpdateBtn);
            this.customersTab.Controls.Add(this.customerSearchBtn);
            this.customersTab.Controls.Add(this.customerLastNameField);
            this.customersTab.Controls.Add(this.customerFirstNameField);
            this.customersTab.Controls.Add(this.customerAddressField);
            this.customersTab.Controls.Add(this.customerPhoneNbrField);
            this.customersTab.Controls.Add(this.customerIDField);
            this.customersTab.Controls.Add(this.label2);
            this.customersTab.Location = new System.Drawing.Point(4, 22);
            this.customersTab.Margin = new System.Windows.Forms.Padding(2);
            this.customersTab.Name = "customersTab";
            this.customersTab.Padding = new System.Windows.Forms.Padding(2);
            this.customersTab.Size = new System.Drawing.Size(1038, 427);
            this.customersTab.TabIndex = 1;
            this.customersTab.Text = "Customers";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // customerClearBtn
            // 
            this.customerClearBtn.Location = new System.Drawing.Point(248, 253);
            this.customerClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerClearBtn.Name = "customerClearBtn";
            this.customerClearBtn.Size = new System.Drawing.Size(75, 28);
            this.customerClearBtn.TabIndex = 32;
            this.customerClearBtn.Text = "Clear Fields";
            this.customerClearBtn.UseVisualStyleBackColor = true;
            this.customerClearBtn.Click += new System.EventHandler(this.customerClearBtn_Click);
            // 
            // customerPhoneNbrLbl
            // 
            this.customerPhoneNbrLbl.AutoSize = true;
            this.customerPhoneNbrLbl.Location = new System.Drawing.Point(5, 211);
            this.customerPhoneNbrLbl.Name = "customerPhoneNbrLbl";
            this.customerPhoneNbrLbl.Size = new System.Drawing.Size(78, 13);
            this.customerPhoneNbrLbl.TabIndex = 31;
            this.customerPhoneNbrLbl.Text = "Phone Number";
            // 
            // customerAddressLbl
            // 
            this.customerAddressLbl.AutoSize = true;
            this.customerAddressLbl.Location = new System.Drawing.Point(5, 188);
            this.customerAddressLbl.Name = "customerAddressLbl";
            this.customerAddressLbl.Size = new System.Drawing.Size(45, 13);
            this.customerAddressLbl.TabIndex = 30;
            this.customerAddressLbl.Text = "Address";
            // 
            // customerLastNameLbl
            // 
            this.customerLastNameLbl.AutoSize = true;
            this.customerLastNameLbl.Location = new System.Drawing.Point(5, 165);
            this.customerLastNameLbl.Name = "customerLastNameLbl";
            this.customerLastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.customerLastNameLbl.TabIndex = 29;
            this.customerLastNameLbl.Text = "Last Name";
            // 
            // customerFirstNameLbl
            // 
            this.customerFirstNameLbl.AutoSize = true;
            this.customerFirstNameLbl.Location = new System.Drawing.Point(5, 142);
            this.customerFirstNameLbl.Name = "customerFirstNameLbl";
            this.customerFirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.customerFirstNameLbl.TabIndex = 28;
            this.customerFirstNameLbl.Text = "First Name";
            // 
            // customerCustIDLbl
            // 
            this.customerCustIDLbl.AutoSize = true;
            this.customerCustIDLbl.Location = new System.Drawing.Point(5, 120);
            this.customerCustIDLbl.Name = "customerCustIDLbl";
            this.customerCustIDLbl.Size = new System.Drawing.Size(65, 13);
            this.customerCustIDLbl.TabIndex = 27;
            this.customerCustIDLbl.Text = "Customer ID";
            // 
            // customerMsgLabel
            // 
            this.customerMsgLabel.AutoSize = true;
            this.customerMsgLabel.Location = new System.Drawing.Point(8, 329);
            this.customerMsgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerMsgLabel.Name = "customerMsgLabel";
            this.customerMsgLabel.Size = new System.Drawing.Size(50, 13);
            this.customerMsgLabel.TabIndex = 26;
            this.customerMsgLabel.Text = "Message";
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToOrderColumns = true;
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.DataSource = this.hyrenbilDataSetBindingSource1;
            this.customerDataGridView.Location = new System.Drawing.Point(363, 47);
            this.customerDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.RowTemplate.Height = 24;
            this.customerDataGridView.Size = new System.Drawing.Size(662, 342);
            this.customerDataGridView.TabIndex = 25;
            // 
            // customerDeleteBtn
            // 
            this.customerDeleteBtn.Location = new System.Drawing.Point(248, 285);
            this.customerDeleteBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerDeleteBtn.Name = "customerDeleteBtn";
            this.customerDeleteBtn.Size = new System.Drawing.Size(75, 28);
            this.customerDeleteBtn.TabIndex = 24;
            this.customerDeleteBtn.Text = "Delete";
            this.customerDeleteBtn.UseVisualStyleBackColor = true;
            this.customerDeleteBtn.Click += new System.EventHandler(this.customerDeleteBtn_Click);
            // 
            // customerAddBtn
            // 
            this.customerAddBtn.Location = new System.Drawing.Point(169, 285);
            this.customerAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerAddBtn.Name = "customerAddBtn";
            this.customerAddBtn.Size = new System.Drawing.Size(75, 28);
            this.customerAddBtn.TabIndex = 23;
            this.customerAddBtn.Text = "Add";
            this.customerAddBtn.UseVisualStyleBackColor = true;
            this.customerAddBtn.Click += new System.EventHandler(this.customerAddBtn_Click);
            // 
            // customerUpdateBtn
            // 
            this.customerUpdateBtn.Location = new System.Drawing.Point(90, 285);
            this.customerUpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerUpdateBtn.Name = "customerUpdateBtn";
            this.customerUpdateBtn.Size = new System.Drawing.Size(75, 28);
            this.customerUpdateBtn.TabIndex = 22;
            this.customerUpdateBtn.Text = "Update";
            this.customerUpdateBtn.UseVisualStyleBackColor = true;
            this.customerUpdateBtn.Click += new System.EventHandler(this.customerUpdateBtn_Click);
            // 
            // customerSearchBtn
            // 
            this.customerSearchBtn.Location = new System.Drawing.Point(11, 285);
            this.customerSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerSearchBtn.Name = "customerSearchBtn";
            this.customerSearchBtn.Size = new System.Drawing.Size(75, 28);
            this.customerSearchBtn.TabIndex = 21;
            this.customerSearchBtn.Text = "Search";
            this.customerSearchBtn.UseVisualStyleBackColor = true;
            this.customerSearchBtn.Click += new System.EventHandler(this.customerSearchBtn_Click);
            // 
            // customerLastNameField
            // 
            this.customerLastNameField.Location = new System.Drawing.Point(94, 162);
            this.customerLastNameField.Margin = new System.Windows.Forms.Padding(2);
            this.customerLastNameField.Name = "customerLastNameField";
            this.customerLastNameField.Size = new System.Drawing.Size(229, 20);
            this.customerLastNameField.TabIndex = 18;
            // 
            // customerFirstNameField
            // 
            this.customerFirstNameField.Location = new System.Drawing.Point(94, 139);
            this.customerFirstNameField.Margin = new System.Windows.Forms.Padding(2);
            this.customerFirstNameField.Name = "customerFirstNameField";
            this.customerFirstNameField.Size = new System.Drawing.Size(229, 20);
            this.customerFirstNameField.TabIndex = 17;
            // 
            // customerAddressField
            // 
            this.customerAddressField.Location = new System.Drawing.Point(94, 185);
            this.customerAddressField.Margin = new System.Windows.Forms.Padding(2);
            this.customerAddressField.Name = "customerAddressField";
            this.customerAddressField.Size = new System.Drawing.Size(229, 20);
            this.customerAddressField.TabIndex = 16;
            // 
            // customerPhoneNbrField
            // 
            this.customerPhoneNbrField.Location = new System.Drawing.Point(94, 208);
            this.customerPhoneNbrField.Margin = new System.Windows.Forms.Padding(2);
            this.customerPhoneNbrField.Name = "customerPhoneNbrField";
            this.customerPhoneNbrField.Size = new System.Drawing.Size(229, 20);
            this.customerPhoneNbrField.TabIndex = 15;
            // 
            // customerIDField
            // 
            this.customerIDField.Location = new System.Drawing.Point(94, 117);
            this.customerIDField.Margin = new System.Windows.Forms.Padding(2);
            this.customerIDField.Name = "customerIDField";
            this.customerIDField.Size = new System.Drawing.Size(229, 20);
            this.customerIDField.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Customer info";
            // 
            // bookingTab
            // 
            this.bookingTab.Controls.Add(this.endDateTimePicker);
            this.bookingTab.Controls.Add(this.startDateTimePicker);
            this.bookingTab.Controls.Add(this.bookingClearBtn);
            this.bookingTab.Controls.Add(this.bookingEndDateLbl);
            this.bookingTab.Controls.Add(this.bookingStartDateLbl);
            this.bookingTab.Controls.Add(this.bookingRegNbrLbl);
            this.bookingTab.Controls.Add(this.bookingCustomerIDLbl);
            this.bookingTab.Controls.Add(this.bookingNbrLbl);
            this.bookingTab.Controls.Add(this.bookingMsgLabel);
            this.bookingTab.Controls.Add(this.bookingDataGridView);
            this.bookingTab.Controls.Add(this.bookingRemoveBtn);
            this.bookingTab.Controls.Add(this.bookingAddBtn);
            this.bookingTab.Controls.Add(this.bookingUpdateBtn);
            this.bookingTab.Controls.Add(this.bookingSearchBtn);
            this.bookingTab.Controls.Add(this.bookingRegNbrField);
            this.bookingTab.Controls.Add(this.bookingCustomerIDField);
            this.bookingTab.Controls.Add(this.bookingNbrField);
            this.bookingTab.Controls.Add(this.label3);
            this.bookingTab.Location = new System.Drawing.Point(4, 22);
            this.bookingTab.Margin = new System.Windows.Forms.Padding(2);
            this.bookingTab.Name = "bookingTab";
            this.bookingTab.Padding = new System.Windows.Forms.Padding(2);
            this.bookingTab.Size = new System.Drawing.Size(1038, 427);
            this.bookingTab.TabIndex = 2;
            this.bookingTab.Text = "Booking";
            this.bookingTab.UseVisualStyleBackColor = true;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(94, 212);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(229, 20);
            this.endDateTimePicker.TabIndex = 45;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Location = new System.Drawing.Point(94, 189);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(229, 20);
            this.startDateTimePicker.TabIndex = 44;
            // 
            // bookingClearBtn
            // 
            this.bookingClearBtn.Location = new System.Drawing.Point(248, 253);
            this.bookingClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookingClearBtn.Name = "bookingClearBtn";
            this.bookingClearBtn.Size = new System.Drawing.Size(75, 28);
            this.bookingClearBtn.TabIndex = 43;
            this.bookingClearBtn.Text = "Clear Fields";
            this.bookingClearBtn.UseVisualStyleBackColor = true;
            this.bookingClearBtn.Click += new System.EventHandler(this.bookingClearBtn_Click);
            // 
            // bookingEndDateLbl
            // 
            this.bookingEndDateLbl.AutoSize = true;
            this.bookingEndDateLbl.Location = new System.Drawing.Point(4, 218);
            this.bookingEndDateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookingEndDateLbl.Name = "bookingEndDateLbl";
            this.bookingEndDateLbl.Size = new System.Drawing.Size(52, 13);
            this.bookingEndDateLbl.TabIndex = 42;
            this.bookingEndDateLbl.Text = "End Date";
            // 
            // bookingStartDateLbl
            // 
            this.bookingStartDateLbl.AutoSize = true;
            this.bookingStartDateLbl.Location = new System.Drawing.Point(4, 195);
            this.bookingStartDateLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookingStartDateLbl.Name = "bookingStartDateLbl";
            this.bookingStartDateLbl.Size = new System.Drawing.Size(55, 13);
            this.bookingStartDateLbl.TabIndex = 41;
            this.bookingStartDateLbl.Text = "Start Date";
            // 
            // bookingRegNbrLbl
            // 
            this.bookingRegNbrLbl.AutoSize = true;
            this.bookingRegNbrLbl.Location = new System.Drawing.Point(4, 167);
            this.bookingRegNbrLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookingRegNbrLbl.Name = "bookingRegNbrLbl";
            this.bookingRegNbrLbl.Size = new System.Drawing.Size(69, 13);
            this.bookingRegNbrLbl.TabIndex = 40;
            this.bookingRegNbrLbl.Text = "Car Reg Nbr.";
            // 
            // bookingCustomerIDLbl
            // 
            this.bookingCustomerIDLbl.AutoSize = true;
            this.bookingCustomerIDLbl.Location = new System.Drawing.Point(4, 144);
            this.bookingCustomerIDLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookingCustomerIDLbl.Name = "bookingCustomerIDLbl";
            this.bookingCustomerIDLbl.Size = new System.Drawing.Size(65, 13);
            this.bookingCustomerIDLbl.TabIndex = 39;
            this.bookingCustomerIDLbl.Text = "Customer ID";
            // 
            // bookingNbrLbl
            // 
            this.bookingNbrLbl.AutoSize = true;
            this.bookingNbrLbl.Location = new System.Drawing.Point(4, 120);
            this.bookingNbrLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookingNbrLbl.Name = "bookingNbrLbl";
            this.bookingNbrLbl.Size = new System.Drawing.Size(69, 13);
            this.bookingNbrLbl.TabIndex = 38;
            this.bookingNbrLbl.Text = "Booking Nbr.";
            // 
            // bookingMsgLabel
            // 
            this.bookingMsgLabel.AutoSize = true;
            this.bookingMsgLabel.Location = new System.Drawing.Point(4, 324);
            this.bookingMsgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookingMsgLabel.Name = "bookingMsgLabel";
            this.bookingMsgLabel.Size = new System.Drawing.Size(50, 13);
            this.bookingMsgLabel.TabIndex = 37;
            this.bookingMsgLabel.Text = "Message";
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AllowUserToOrderColumns = true;
            this.bookingDataGridView.AutoGenerateColumns = false;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.DataSource = this.hyrenbilDataSetBindingSource1;
            this.bookingDataGridView.Location = new System.Drawing.Point(363, 47);
            this.bookingDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.RowTemplate.Height = 24;
            this.bookingDataGridView.Size = new System.Drawing.Size(662, 342);
            this.bookingDataGridView.TabIndex = 36;
            // 
            // bookingRemoveBtn
            // 
            this.bookingRemoveBtn.Location = new System.Drawing.Point(248, 285);
            this.bookingRemoveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookingRemoveBtn.Name = "bookingRemoveBtn";
            this.bookingRemoveBtn.Size = new System.Drawing.Size(75, 28);
            this.bookingRemoveBtn.TabIndex = 35;
            this.bookingRemoveBtn.Text = "Remove";
            this.bookingRemoveBtn.UseVisualStyleBackColor = true;
            this.bookingRemoveBtn.Click += new System.EventHandler(this.bookingRemoveBtn_Click);
            // 
            // bookingAddBtn
            // 
            this.bookingAddBtn.Location = new System.Drawing.Point(169, 285);
            this.bookingAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookingAddBtn.Name = "bookingAddBtn";
            this.bookingAddBtn.Size = new System.Drawing.Size(75, 28);
            this.bookingAddBtn.TabIndex = 34;
            this.bookingAddBtn.Text = "Add";
            this.bookingAddBtn.UseVisualStyleBackColor = true;
            this.bookingAddBtn.Click += new System.EventHandler(this.bookingAddBtn_Click);
            // 
            // bookingUpdateBtn
            // 
            this.bookingUpdateBtn.Location = new System.Drawing.Point(90, 285);
            this.bookingUpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookingUpdateBtn.Name = "bookingUpdateBtn";
            this.bookingUpdateBtn.Size = new System.Drawing.Size(75, 28);
            this.bookingUpdateBtn.TabIndex = 33;
            this.bookingUpdateBtn.Text = "Update";
            this.bookingUpdateBtn.UseVisualStyleBackColor = true;
            this.bookingUpdateBtn.Click += new System.EventHandler(this.bookingUpdateBtn_Click);
            // 
            // bookingSearchBtn
            // 
            this.bookingSearchBtn.Location = new System.Drawing.Point(11, 285);
            this.bookingSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookingSearchBtn.Name = "bookingSearchBtn";
            this.bookingSearchBtn.Size = new System.Drawing.Size(75, 28);
            this.bookingSearchBtn.TabIndex = 32;
            this.bookingSearchBtn.Text = "Search";
            this.bookingSearchBtn.UseVisualStyleBackColor = true;
            this.bookingSearchBtn.Click += new System.EventHandler(this.bookingSearchBtn_Click);
            // 
            // bookingRegNbrField
            // 
            this.bookingRegNbrField.Location = new System.Drawing.Point(94, 164);
            this.bookingRegNbrField.Margin = new System.Windows.Forms.Padding(2);
            this.bookingRegNbrField.Name = "bookingRegNbrField";
            this.bookingRegNbrField.Size = new System.Drawing.Size(229, 20);
            this.bookingRegNbrField.TabIndex = 31;
            // 
            // bookingCustomerIDField
            // 
            this.bookingCustomerIDField.Location = new System.Drawing.Point(94, 141);
            this.bookingCustomerIDField.Margin = new System.Windows.Forms.Padding(2);
            this.bookingCustomerIDField.Name = "bookingCustomerIDField";
            this.bookingCustomerIDField.Size = new System.Drawing.Size(229, 20);
            this.bookingCustomerIDField.TabIndex = 30;
            // 
            // bookingNbrField
            // 
            this.bookingNbrField.Location = new System.Drawing.Point(94, 117);
            this.bookingNbrField.Margin = new System.Windows.Forms.Padding(2);
            this.bookingNbrField.Name = "bookingNbrField";
            this.bookingNbrField.Size = new System.Drawing.Size(229, 20);
            this.bookingNbrField.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Booking info";
            // 
            // garageTab
            // 
            this.garageTab.Controls.Add(this.garageClearBtn);
            this.garageTab.Controls.Add(this.garageSizeLbl);
            this.garageTab.Controls.Add(this.garageAddressLbl);
            this.garageTab.Controls.Add(this.garageMsgLabel);
            this.garageTab.Controls.Add(this.garageDataGridView);
            this.garageTab.Controls.Add(this.garageRemoveBtn);
            this.garageTab.Controls.Add(this.garageAddBtn);
            this.garageTab.Controls.Add(this.garageUpdateBtn);
            this.garageTab.Controls.Add(this.garageSearchBtn);
            this.garageTab.Controls.Add(this.garageSizeField);
            this.garageTab.Controls.Add(this.garageAddressField);
            this.garageTab.Controls.Add(this.label4);
            this.garageTab.Location = new System.Drawing.Point(4, 22);
            this.garageTab.Margin = new System.Windows.Forms.Padding(2);
            this.garageTab.Name = "garageTab";
            this.garageTab.Padding = new System.Windows.Forms.Padding(2);
            this.garageTab.Size = new System.Drawing.Size(1038, 427);
            this.garageTab.TabIndex = 3;
            this.garageTab.Text = "Garage";
            this.garageTab.UseVisualStyleBackColor = true;
            // 
            // garageMsgLabel
            // 
            this.garageMsgLabel.AutoSize = true;
            this.garageMsgLabel.Location = new System.Drawing.Point(76, 346);
            this.garageMsgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.garageMsgLabel.Name = "garageMsgLabel";
            this.garageMsgLabel.Size = new System.Drawing.Size(50, 13);
            this.garageMsgLabel.TabIndex = 48;
            this.garageMsgLabel.Text = "Message";
            // 
            // garageDataGridView
            // 
            this.garageDataGridView.AllowUserToOrderColumns = true;
            this.garageDataGridView.AutoGenerateColumns = false;
            this.garageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.garageDataGridView.DataSource = this.hyrenbilDataSetBindingSource1;
            this.garageDataGridView.Location = new System.Drawing.Point(363, 47);
            this.garageDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.garageDataGridView.Name = "garageDataGridView";
            this.garageDataGridView.RowTemplate.Height = 24;
            this.garageDataGridView.Size = new System.Drawing.Size(662, 342);
            this.garageDataGridView.TabIndex = 47;
            // 
            // garageRemoveBtn
            // 
            this.garageRemoveBtn.Location = new System.Drawing.Point(248, 285);
            this.garageRemoveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.garageRemoveBtn.Name = "garageRemoveBtn";
            this.garageRemoveBtn.Size = new System.Drawing.Size(75, 28);
            this.garageRemoveBtn.TabIndex = 46;
            this.garageRemoveBtn.Text = "Remove";
            this.garageRemoveBtn.UseVisualStyleBackColor = true;
            this.garageRemoveBtn.Click += new System.EventHandler(this.garageRemoveBtn_Click);
            // 
            // garageAddBtn
            // 
            this.garageAddBtn.Location = new System.Drawing.Point(169, 285);
            this.garageAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.garageAddBtn.Name = "garageAddBtn";
            this.garageAddBtn.Size = new System.Drawing.Size(75, 28);
            this.garageAddBtn.TabIndex = 45;
            this.garageAddBtn.Text = "Add";
            this.garageAddBtn.UseVisualStyleBackColor = true;
            this.garageAddBtn.Click += new System.EventHandler(this.garageAddBtn_Click);
            // 
            // garageUpdateBtn
            // 
            this.garageUpdateBtn.Location = new System.Drawing.Point(90, 285);
            this.garageUpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.garageUpdateBtn.Name = "garageUpdateBtn";
            this.garageUpdateBtn.Size = new System.Drawing.Size(75, 28);
            this.garageUpdateBtn.TabIndex = 44;
            this.garageUpdateBtn.Text = "Update";
            this.garageUpdateBtn.UseVisualStyleBackColor = true;
            this.garageUpdateBtn.Click += new System.EventHandler(this.garageUpdateBtn_Click);
            // 
            // garageSearchBtn
            // 
            this.garageSearchBtn.Location = new System.Drawing.Point(11, 285);
            this.garageSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.garageSearchBtn.Name = "garageSearchBtn";
            this.garageSearchBtn.Size = new System.Drawing.Size(75, 28);
            this.garageSearchBtn.TabIndex = 43;
            this.garageSearchBtn.Text = "Search";
            this.garageSearchBtn.UseVisualStyleBackColor = true;
            this.garageSearchBtn.Click += new System.EventHandler(this.garageSearchBtn_Click);
            // 
            // garageSizeField
            // 
            this.garageSizeField.Location = new System.Drawing.Point(94, 141);
            this.garageSizeField.Margin = new System.Windows.Forms.Padding(2);
            this.garageSizeField.Name = "garageSizeField";
            this.garageSizeField.Size = new System.Drawing.Size(229, 20);
            this.garageSizeField.TabIndex = 41;
            // 
            // garageAddressField
            // 
            this.garageAddressField.Location = new System.Drawing.Point(94, 117);
            this.garageAddressField.Margin = new System.Windows.Forms.Padding(2);
            this.garageAddressField.Name = "garageAddressField";
            this.garageAddressField.Size = new System.Drawing.Size(229, 20);
            this.garageAddressField.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Garage info";
            // 
            // hyrenbilDataSetBindingSource
            // 
            this.hyrenbilDataSetBindingSource.DataSource = this.hyrenbilDataSet;
            this.hyrenbilDataSetBindingSource.Position = 0;
            // 
            // garageAddressLbl
            // 
            this.garageAddressLbl.AutoSize = true;
            this.garageAddressLbl.Location = new System.Drawing.Point(4, 120);
            this.garageAddressLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.garageAddressLbl.Name = "garageAddressLbl";
            this.garageAddressLbl.Size = new System.Drawing.Size(45, 13);
            this.garageAddressLbl.TabIndex = 49;
            this.garageAddressLbl.Text = "Address";
            // 
            // garageSizeLbl
            // 
            this.garageSizeLbl.AutoSize = true;
            this.garageSizeLbl.Location = new System.Drawing.Point(4, 144);
            this.garageSizeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.garageSizeLbl.Name = "garageSizeLbl";
            this.garageSizeLbl.Size = new System.Drawing.Size(27, 13);
            this.garageSizeLbl.TabIndex = 50;
            this.garageSizeLbl.Text = "Size";
            // 
            // garageClearBtn
            // 
            this.garageClearBtn.Location = new System.Drawing.Point(248, 253);
            this.garageClearBtn.Margin = new System.Windows.Forms.Padding(2);
            this.garageClearBtn.Name = "garageClearBtn";
            this.garageClearBtn.Size = new System.Drawing.Size(75, 28);
            this.garageClearBtn.TabIndex = 51;
            this.garageClearBtn.Text = "Clear Fields";
            this.garageClearBtn.UseVisualStyleBackColor = true;
            this.garageClearBtn.Click += new System.EventHandler(this.garageClearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 477);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.carsTab.ResumeLayout(false);
            this.carsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyrenbilDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyrenbilDataSet)).EndInit();
            this.customersTab.ResumeLayout(false);
            this.customersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.bookingTab.ResumeLayout(false);
            this.bookingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            this.garageTab.ResumeLayout(false);
            this.garageTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garageDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyrenbilDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage carsTab;
        private System.Windows.Forms.DataGridView carDataGridView;
        private System.Windows.Forms.BindingSource hyrenbilDataSetBindingSource1;
        private hyrenbilDataSet hyrenbilDataSet;
        private System.Windows.Forms.Button carAddBtn;
        private System.Windows.Forms.Button carUpdateBtn;
        private System.Windows.Forms.Button carSearchBtn;
        private System.Windows.Forms.TextBox carSeatsField;
        private System.Windows.Forms.TextBox carPriceField;
        private System.Windows.Forms.TextBox carRegNbrField;
        private System.Windows.Forms.Label carInfoLbl;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button customerDeleteBtn;
        private System.Windows.Forms.Button customerAddBtn;
        private System.Windows.Forms.Button customerUpdateBtn;
        private System.Windows.Forms.Button customerSearchBtn;
        private System.Windows.Forms.TextBox customerLastNameField;
        private System.Windows.Forms.TextBox customerFirstNameField;
        private System.Windows.Forms.TextBox customerAddressField;
        private System.Windows.Forms.TextBox customerPhoneNbrField;
        private System.Windows.Forms.TextBox customerIDField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage bookingTab;
        private System.Windows.Forms.TabPage garageTab;
        private System.Windows.Forms.BindingSource hyrenbilDataSetBindingSource;
        private System.Windows.Forms.DataGridView bookingDataGridView;
        private System.Windows.Forms.Button bookingRemoveBtn;
        private System.Windows.Forms.Button bookingAddBtn;
        private System.Windows.Forms.Button bookingUpdateBtn;
        private System.Windows.Forms.Button bookingSearchBtn;
        private System.Windows.Forms.TextBox bookingRegNbrField;
        private System.Windows.Forms.TextBox bookingCustomerIDField;
        private System.Windows.Forms.TextBox bookingNbrField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView garageDataGridView;
        private System.Windows.Forms.Button garageRemoveBtn;
        private System.Windows.Forms.Button garageAddBtn;
        private System.Windows.Forms.Button garageUpdateBtn;
        private System.Windows.Forms.Button garageSearchBtn;
        private System.Windows.Forms.TextBox garageSizeField;
        private System.Windows.Forms.TextBox garageAddressField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label carMsgLabel;
        private System.Windows.Forms.Label customerMsgLabel;
        private System.Windows.Forms.Label bookingMsgLabel;
        private System.Windows.Forms.Label garageMsgLabel;
        private System.Windows.Forms.Label carRegNbrLbl;
        private System.Windows.Forms.Label carBrandLbl;
        private System.Windows.Forms.Label carPriceLbl;
        private System.Windows.Forms.Label carColorLbl;
        private System.Windows.Forms.Label carModelLbl;
        private System.Windows.Forms.Label carGarageLbl;
        private System.Windows.Forms.Label carSeatsLbl;
        private System.Windows.Forms.ComboBox carModelComboBox;
        private System.Windows.Forms.ComboBox carColorComboBox;
        private System.Windows.Forms.ComboBox carBrandComboBox;
        private System.Windows.Forms.ComboBox carGarageComboBox;
        private System.Windows.Forms.Button carClearBtn;
        private System.Windows.Forms.Button carDeleteBtn;
        private System.Windows.Forms.Label customerPhoneNbrLbl;
        private System.Windows.Forms.Label customerAddressLbl;
        private System.Windows.Forms.Label customerLastNameLbl;
        private System.Windows.Forms.Label customerFirstNameLbl;
        private System.Windows.Forms.Label customerCustIDLbl;
        private System.Windows.Forms.Button customerClearBtn;
        private System.Windows.Forms.Label bookingEndDateLbl;
        private System.Windows.Forms.Label bookingStartDateLbl;
        private System.Windows.Forms.Label bookingRegNbrLbl;
        private System.Windows.Forms.Label bookingCustomerIDLbl;
        private System.Windows.Forms.Label bookingNbrLbl;
        private System.Windows.Forms.Button bookingClearBtn;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Label garageSizeLbl;
        private System.Windows.Forms.Label garageAddressLbl;
        private System.Windows.Forms.Button garageClearBtn;
    }
}

