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
            this.carDataGridView = new System.Windows.Forms.DataGridView();
            this.hyrenbilDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hyrenbilDataSet = new PKDataBaseView.hyrenbilDataSet();
            this.carRemoveBtn = new System.Windows.Forms.Button();
            this.carAddBtn = new System.Windows.Forms.Button();
            this.carUpdateBtn = new System.Windows.Forms.Button();
            this.carSearchBtn = new System.Windows.Forms.Button();
            this.carSeatsField = new System.Windows.Forms.TextBox();
            this.carPriceField = new System.Windows.Forms.TextBox();
            this.carRegNbrField = new System.Windows.Forms.TextBox();
            this.carInfoLbl = new System.Windows.Forms.Label();
            this.customersTab = new System.Windows.Forms.TabPage();
            this.customerMsgLabel = new System.Windows.Forms.Label();
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.customerRemoveBtn = new System.Windows.Forms.Button();
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
            this.bookingMsgLabel = new System.Windows.Forms.Label();
            this.bookingTable = new System.Windows.Forms.DataGridView();
            this.bookingRemoveBtn = new System.Windows.Forms.Button();
            this.bookingAddBtn = new System.Windows.Forms.Button();
            this.bookingUpdateBtn = new System.Windows.Forms.Button();
            this.bookingSearchBtn = new System.Windows.Forms.Button();
            this.bookingRegNbr = new System.Windows.Forms.TextBox();
            this.bookingCustomerField = new System.Windows.Forms.TextBox();
            this.bookingStartDateField = new System.Windows.Forms.TextBox();
            this.bookingEndDateField = new System.Windows.Forms.TextBox();
            this.bookingNbrField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.garageTab = new System.Windows.Forms.TabPage();
            this.garageMsgLabel = new System.Windows.Forms.Label();
            this.garageTable = new System.Windows.Forms.DataGridView();
            this.garageRemoveBtn = new System.Windows.Forms.Button();
            this.garageAddBtn = new System.Windows.Forms.Button();
            this.garageUpdateBtn = new System.Windows.Forms.Button();
            this.garageSearchBtn = new System.Windows.Forms.Button();
            this.garageSizeField = new System.Windows.Forms.TextBox();
            this.garageAddressField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hyrenbilDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.carsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyrenbilDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyrenbilDataSet)).BeginInit();
            this.customersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.bookingTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTable)).BeginInit();
            this.garageTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garageTable)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(986, 453);
            this.tabControl1.TabIndex = 0;
            // 
            // carsTab
            // 
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
            this.carsTab.Controls.Add(this.carDataGridView);
            this.carsTab.Controls.Add(this.carRemoveBtn);
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
            this.carsTab.Size = new System.Drawing.Size(978, 427);
            this.carsTab.TabIndex = 0;
            this.carsTab.Text = "Cars";
            this.carsTab.UseVisualStyleBackColor = true;
            // 
            // carGarageComboBox
            // 
            this.carGarageComboBox.FormattingEnabled = true;
            this.carGarageComboBox.Location = new System.Drawing.Point(94, 254);
            this.carGarageComboBox.Name = "carGarageComboBox";
            this.carGarageComboBox.Size = new System.Drawing.Size(229, 21);
            this.carGarageComboBox.TabIndex = 24;
            // 
            // carColorComboBox
            // 
            this.carColorComboBox.FormattingEnabled = true;
            this.carColorComboBox.Location = new System.Drawing.Point(94, 185);
            this.carColorComboBox.Name = "carColorComboBox";
            this.carColorComboBox.Size = new System.Drawing.Size(229, 21);
            this.carColorComboBox.TabIndex = 23;
            // 
            // carBrandComboBox
            // 
            this.carBrandComboBox.FormattingEnabled = true;
            this.carBrandComboBox.Location = new System.Drawing.Point(94, 162);
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
            this.carGarageLbl.Location = new System.Drawing.Point(5, 257);
            this.carGarageLbl.Name = "carGarageLbl";
            this.carGarageLbl.Size = new System.Drawing.Size(42, 13);
            this.carGarageLbl.TabIndex = 20;
            this.carGarageLbl.Text = "Garage";
            // 
            // carSeatsLbl
            // 
            this.carSeatsLbl.AutoSize = true;
            this.carSeatsLbl.Location = new System.Drawing.Point(5, 234);
            this.carSeatsLbl.Name = "carSeatsLbl";
            this.carSeatsLbl.Size = new System.Drawing.Size(34, 13);
            this.carSeatsLbl.TabIndex = 19;
            this.carSeatsLbl.Text = "Seats";
            // 
            // carPriceLbl
            // 
            this.carPriceLbl.AutoSize = true;
            this.carPriceLbl.Location = new System.Drawing.Point(5, 211);
            this.carPriceLbl.Name = "carPriceLbl";
            this.carPriceLbl.Size = new System.Drawing.Size(31, 13);
            this.carPriceLbl.TabIndex = 18;
            this.carPriceLbl.Text = "Price";
            // 
            // carColorLbl
            // 
            this.carColorLbl.AutoSize = true;
            this.carColorLbl.Location = new System.Drawing.Point(5, 188);
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
            this.carBrandLbl.Location = new System.Drawing.Point(5, 165);
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
            this.carMsgLabel.Location = new System.Drawing.Point(81, 340);
            this.carMsgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.carMsgLabel.Name = "carMsgLabel";
            this.carMsgLabel.Size = new System.Drawing.Size(0, 13);
            this.carMsgLabel.TabIndex = 13;
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
            this.carDataGridView.Location = new System.Drawing.Point(358, 46);
            this.carDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.carDataGridView.Name = "carDataGridView";
            this.carDataGridView.RowTemplate.Height = 24;
            this.carDataGridView.Size = new System.Drawing.Size(602, 342);
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
            // carRemoveBtn
            // 
            this.carRemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carRemoveBtn.Location = new System.Drawing.Point(256, 288);
            this.carRemoveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.carRemoveBtn.Name = "carRemoveBtn";
            this.carRemoveBtn.Size = new System.Drawing.Size(67, 28);
            this.carRemoveBtn.TabIndex = 11;
            this.carRemoveBtn.Text = "Remove";
            this.carRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // carAddBtn
            // 
            this.carAddBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.carAddBtn.Location = new System.Drawing.Point(182, 288);
            this.carAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.carAddBtn.Name = "carAddBtn";
            this.carAddBtn.Size = new System.Drawing.Size(67, 28);
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
            this.carUpdateBtn.Location = new System.Drawing.Point(112, 288);
            this.carUpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.carUpdateBtn.Name = "carUpdateBtn";
            this.carUpdateBtn.Size = new System.Drawing.Size(67, 28);
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
            this.carSearchBtn.Location = new System.Drawing.Point(38, 288);
            this.carSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.carSearchBtn.Name = "carSearchBtn";
            this.carSearchBtn.Size = new System.Drawing.Size(67, 28);
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
            this.carSeatsField.Location = new System.Drawing.Point(94, 231);
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
            this.carPriceField.Location = new System.Drawing.Point(94, 208);
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
            this.customersTab.Controls.Add(this.customerMsgLabel);
            this.customersTab.Controls.Add(this.customerTable);
            this.customersTab.Controls.Add(this.customerRemoveBtn);
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
            this.customersTab.Size = new System.Drawing.Size(978, 427);
            this.customersTab.TabIndex = 1;
            this.customersTab.Text = "Customers";
            this.customersTab.UseVisualStyleBackColor = true;
            // 
            // customerMsgLabel
            // 
            this.customerMsgLabel.AutoSize = true;
            this.customerMsgLabel.Location = new System.Drawing.Point(76, 337);
            this.customerMsgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerMsgLabel.Name = "customerMsgLabel";
            this.customerMsgLabel.Size = new System.Drawing.Size(50, 13);
            this.customerMsgLabel.TabIndex = 26;
            this.customerMsgLabel.Text = "Message";
            // 
            // customerTable
            // 
            this.customerTable.AllowUserToOrderColumns = true;
            this.customerTable.AutoGenerateColumns = false;
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerTable.DataSource = this.hyrenbilDataSetBindingSource1;
            this.customerTable.Location = new System.Drawing.Point(353, 44);
            this.customerTable.Margin = new System.Windows.Forms.Padding(2);
            this.customerTable.Name = "customerTable";
            this.customerTable.RowTemplate.Height = 24;
            this.customerTable.Size = new System.Drawing.Size(455, 342);
            this.customerTable.TabIndex = 25;
            // 
            // customerRemoveBtn
            // 
            this.customerRemoveBtn.Location = new System.Drawing.Point(250, 285);
            this.customerRemoveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerRemoveBtn.Name = "customerRemoveBtn";
            this.customerRemoveBtn.Size = new System.Drawing.Size(67, 28);
            this.customerRemoveBtn.TabIndex = 24;
            this.customerRemoveBtn.Text = "Remove";
            this.customerRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // customerAddBtn
            // 
            this.customerAddBtn.Location = new System.Drawing.Point(177, 285);
            this.customerAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerAddBtn.Name = "customerAddBtn";
            this.customerAddBtn.Size = new System.Drawing.Size(67, 28);
            this.customerAddBtn.TabIndex = 23;
            this.customerAddBtn.Text = "Add";
            this.customerAddBtn.UseVisualStyleBackColor = true;
            // 
            // customerUpdateBtn
            // 
            this.customerUpdateBtn.Location = new System.Drawing.Point(106, 285);
            this.customerUpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerUpdateBtn.Name = "customerUpdateBtn";
            this.customerUpdateBtn.Size = new System.Drawing.Size(67, 28);
            this.customerUpdateBtn.TabIndex = 22;
            this.customerUpdateBtn.Text = "Update";
            this.customerUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // customerSearchBtn
            // 
            this.customerSearchBtn.Location = new System.Drawing.Point(33, 285);
            this.customerSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.customerSearchBtn.Name = "customerSearchBtn";
            this.customerSearchBtn.Size = new System.Drawing.Size(67, 28);
            this.customerSearchBtn.TabIndex = 21;
            this.customerSearchBtn.Text = "Search";
            this.customerSearchBtn.UseVisualStyleBackColor = true;
            // 
            // customerLastNameField
            // 
            this.customerLastNameField.Location = new System.Drawing.Point(55, 160);
            this.customerLastNameField.Margin = new System.Windows.Forms.Padding(2);
            this.customerLastNameField.Name = "customerLastNameField";
            this.customerLastNameField.Size = new System.Drawing.Size(241, 20);
            this.customerLastNameField.TabIndex = 18;
            this.customerLastNameField.Text = "Last Name";
            // 
            // customerFirstNameField
            // 
            this.customerFirstNameField.Location = new System.Drawing.Point(55, 137);
            this.customerFirstNameField.Margin = new System.Windows.Forms.Padding(2);
            this.customerFirstNameField.Name = "customerFirstNameField";
            this.customerFirstNameField.Size = new System.Drawing.Size(241, 20);
            this.customerFirstNameField.TabIndex = 17;
            this.customerFirstNameField.Text = "First Name";
            // 
            // customerAddressField
            // 
            this.customerAddressField.Location = new System.Drawing.Point(55, 183);
            this.customerAddressField.Margin = new System.Windows.Forms.Padding(2);
            this.customerAddressField.Name = "customerAddressField";
            this.customerAddressField.Size = new System.Drawing.Size(241, 20);
            this.customerAddressField.TabIndex = 16;
            this.customerAddressField.Text = "Address";
            // 
            // customerPhoneNbrField
            // 
            this.customerPhoneNbrField.Location = new System.Drawing.Point(55, 206);
            this.customerPhoneNbrField.Margin = new System.Windows.Forms.Padding(2);
            this.customerPhoneNbrField.Name = "customerPhoneNbrField";
            this.customerPhoneNbrField.Size = new System.Drawing.Size(241, 20);
            this.customerPhoneNbrField.TabIndex = 15;
            this.customerPhoneNbrField.Text = "Phone Number";
            // 
            // customerIDField
            // 
            this.customerIDField.Location = new System.Drawing.Point(55, 115);
            this.customerIDField.Margin = new System.Windows.Forms.Padding(2);
            this.customerIDField.Name = "customerIDField";
            this.customerIDField.Size = new System.Drawing.Size(241, 20);
            this.customerIDField.TabIndex = 14;
            this.customerIDField.Text = "Customer ID";
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
            this.bookingTab.Controls.Add(this.bookingMsgLabel);
            this.bookingTab.Controls.Add(this.bookingTable);
            this.bookingTab.Controls.Add(this.bookingRemoveBtn);
            this.bookingTab.Controls.Add(this.bookingAddBtn);
            this.bookingTab.Controls.Add(this.bookingUpdateBtn);
            this.bookingTab.Controls.Add(this.bookingSearchBtn);
            this.bookingTab.Controls.Add(this.bookingRegNbr);
            this.bookingTab.Controls.Add(this.bookingCustomerField);
            this.bookingTab.Controls.Add(this.bookingStartDateField);
            this.bookingTab.Controls.Add(this.bookingEndDateField);
            this.bookingTab.Controls.Add(this.bookingNbrField);
            this.bookingTab.Controls.Add(this.label3);
            this.bookingTab.Location = new System.Drawing.Point(4, 22);
            this.bookingTab.Margin = new System.Windows.Forms.Padding(2);
            this.bookingTab.Name = "bookingTab";
            this.bookingTab.Padding = new System.Windows.Forms.Padding(2);
            this.bookingTab.Size = new System.Drawing.Size(978, 427);
            this.bookingTab.TabIndex = 2;
            this.bookingTab.Text = "Booking";
            this.bookingTab.UseVisualStyleBackColor = true;
            // 
            // bookingMsgLabel
            // 
            this.bookingMsgLabel.AutoSize = true;
            this.bookingMsgLabel.Location = new System.Drawing.Point(76, 342);
            this.bookingMsgLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookingMsgLabel.Name = "bookingMsgLabel";
            this.bookingMsgLabel.Size = new System.Drawing.Size(50, 13);
            this.bookingMsgLabel.TabIndex = 37;
            this.bookingMsgLabel.Text = "Message";
            // 
            // bookingTable
            // 
            this.bookingTable.AllowUserToOrderColumns = true;
            this.bookingTable.AutoGenerateColumns = false;
            this.bookingTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingTable.DataSource = this.hyrenbilDataSetBindingSource1;
            this.bookingTable.Location = new System.Drawing.Point(353, 44);
            this.bookingTable.Margin = new System.Windows.Forms.Padding(2);
            this.bookingTable.Name = "bookingTable";
            this.bookingTable.RowTemplate.Height = 24;
            this.bookingTable.Size = new System.Drawing.Size(455, 342);
            this.bookingTable.TabIndex = 36;
            // 
            // bookingRemoveBtn
            // 
            this.bookingRemoveBtn.Location = new System.Drawing.Point(250, 285);
            this.bookingRemoveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookingRemoveBtn.Name = "bookingRemoveBtn";
            this.bookingRemoveBtn.Size = new System.Drawing.Size(67, 28);
            this.bookingRemoveBtn.TabIndex = 35;
            this.bookingRemoveBtn.Text = "Remove";
            this.bookingRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // bookingAddBtn
            // 
            this.bookingAddBtn.Location = new System.Drawing.Point(177, 285);
            this.bookingAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookingAddBtn.Name = "bookingAddBtn";
            this.bookingAddBtn.Size = new System.Drawing.Size(67, 28);
            this.bookingAddBtn.TabIndex = 34;
            this.bookingAddBtn.Text = "Add";
            this.bookingAddBtn.UseVisualStyleBackColor = true;
            // 
            // bookingUpdateBtn
            // 
            this.bookingUpdateBtn.Location = new System.Drawing.Point(106, 285);
            this.bookingUpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookingUpdateBtn.Name = "bookingUpdateBtn";
            this.bookingUpdateBtn.Size = new System.Drawing.Size(67, 28);
            this.bookingUpdateBtn.TabIndex = 33;
            this.bookingUpdateBtn.Text = "Update";
            this.bookingUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // bookingSearchBtn
            // 
            this.bookingSearchBtn.Location = new System.Drawing.Point(33, 285);
            this.bookingSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.bookingSearchBtn.Name = "bookingSearchBtn";
            this.bookingSearchBtn.Size = new System.Drawing.Size(67, 28);
            this.bookingSearchBtn.TabIndex = 32;
            this.bookingSearchBtn.Text = "Search";
            this.bookingSearchBtn.UseVisualStyleBackColor = true;
            // 
            // bookingRegNbr
            // 
            this.bookingRegNbr.Location = new System.Drawing.Point(55, 160);
            this.bookingRegNbr.Margin = new System.Windows.Forms.Padding(2);
            this.bookingRegNbr.Name = "bookingRegNbr";
            this.bookingRegNbr.Size = new System.Drawing.Size(241, 20);
            this.bookingRegNbr.TabIndex = 31;
            this.bookingRegNbr.Text = "Reg. Number";
            // 
            // bookingCustomerField
            // 
            this.bookingCustomerField.Location = new System.Drawing.Point(55, 137);
            this.bookingCustomerField.Margin = new System.Windows.Forms.Padding(2);
            this.bookingCustomerField.Name = "bookingCustomerField";
            this.bookingCustomerField.Size = new System.Drawing.Size(241, 20);
            this.bookingCustomerField.TabIndex = 30;
            this.bookingCustomerField.Text = "Customer ID";
            // 
            // bookingStartDateField
            // 
            this.bookingStartDateField.Location = new System.Drawing.Point(55, 183);
            this.bookingStartDateField.Margin = new System.Windows.Forms.Padding(2);
            this.bookingStartDateField.Name = "bookingStartDateField";
            this.bookingStartDateField.Size = new System.Drawing.Size(241, 20);
            this.bookingStartDateField.TabIndex = 29;
            this.bookingStartDateField.Text = "Start Date";
            // 
            // bookingEndDateField
            // 
            this.bookingEndDateField.Location = new System.Drawing.Point(55, 206);
            this.bookingEndDateField.Margin = new System.Windows.Forms.Padding(2);
            this.bookingEndDateField.Name = "bookingEndDateField";
            this.bookingEndDateField.Size = new System.Drawing.Size(241, 20);
            this.bookingEndDateField.TabIndex = 28;
            this.bookingEndDateField.Text = "End Date";
            // 
            // bookingNbrField
            // 
            this.bookingNbrField.Location = new System.Drawing.Point(55, 115);
            this.bookingNbrField.Margin = new System.Windows.Forms.Padding(2);
            this.bookingNbrField.Name = "bookingNbrField";
            this.bookingNbrField.Size = new System.Drawing.Size(241, 20);
            this.bookingNbrField.TabIndex = 27;
            this.bookingNbrField.Text = "Booking Number";
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
            this.garageTab.Controls.Add(this.garageMsgLabel);
            this.garageTab.Controls.Add(this.garageTable);
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
            this.garageTab.Size = new System.Drawing.Size(978, 427);
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
            // garageTable
            // 
            this.garageTable.AllowUserToOrderColumns = true;
            this.garageTable.AutoGenerateColumns = false;
            this.garageTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.garageTable.DataSource = this.hyrenbilDataSetBindingSource1;
            this.garageTable.Location = new System.Drawing.Point(353, 44);
            this.garageTable.Margin = new System.Windows.Forms.Padding(2);
            this.garageTable.Name = "garageTable";
            this.garageTable.RowTemplate.Height = 24;
            this.garageTable.Size = new System.Drawing.Size(455, 342);
            this.garageTable.TabIndex = 47;
            // 
            // garageRemoveBtn
            // 
            this.garageRemoveBtn.Location = new System.Drawing.Point(250, 285);
            this.garageRemoveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.garageRemoveBtn.Name = "garageRemoveBtn";
            this.garageRemoveBtn.Size = new System.Drawing.Size(67, 28);
            this.garageRemoveBtn.TabIndex = 46;
            this.garageRemoveBtn.Text = "Remove";
            this.garageRemoveBtn.UseVisualStyleBackColor = true;
            // 
            // garageAddBtn
            // 
            this.garageAddBtn.Location = new System.Drawing.Point(177, 285);
            this.garageAddBtn.Margin = new System.Windows.Forms.Padding(2);
            this.garageAddBtn.Name = "garageAddBtn";
            this.garageAddBtn.Size = new System.Drawing.Size(67, 28);
            this.garageAddBtn.TabIndex = 45;
            this.garageAddBtn.Text = "Add";
            this.garageAddBtn.UseVisualStyleBackColor = true;
            // 
            // garageUpdateBtn
            // 
            this.garageUpdateBtn.Location = new System.Drawing.Point(106, 285);
            this.garageUpdateBtn.Margin = new System.Windows.Forms.Padding(2);
            this.garageUpdateBtn.Name = "garageUpdateBtn";
            this.garageUpdateBtn.Size = new System.Drawing.Size(67, 28);
            this.garageUpdateBtn.TabIndex = 44;
            this.garageUpdateBtn.Text = "Update";
            this.garageUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // garageSearchBtn
            // 
            this.garageSearchBtn.Location = new System.Drawing.Point(33, 285);
            this.garageSearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.garageSearchBtn.Name = "garageSearchBtn";
            this.garageSearchBtn.Size = new System.Drawing.Size(67, 28);
            this.garageSearchBtn.TabIndex = 43;
            this.garageSearchBtn.Text = "Search";
            this.garageSearchBtn.UseVisualStyleBackColor = true;
            // 
            // garageSizeField
            // 
            this.garageSizeField.Location = new System.Drawing.Point(55, 137);
            this.garageSizeField.Margin = new System.Windows.Forms.Padding(2);
            this.garageSizeField.Name = "garageSizeField";
            this.garageSizeField.Size = new System.Drawing.Size(241, 20);
            this.garageSizeField.TabIndex = 41;
            this.garageSizeField.Text = "Size";
            // 
            // garageAddressField
            // 
            this.garageAddressField.Location = new System.Drawing.Point(55, 115);
            this.garageAddressField.Margin = new System.Windows.Forms.Padding(2);
            this.garageAddressField.Name = "garageAddressField";
            this.garageAddressField.Size = new System.Drawing.Size(241, 20);
            this.garageAddressField.TabIndex = 38;
            this.garageAddressField.Text = "Address";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 477);
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
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.bookingTab.ResumeLayout(false);
            this.bookingTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingTable)).EndInit();
            this.garageTab.ResumeLayout(false);
            this.garageTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.garageTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hyrenbilDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage carsTab;
        private System.Windows.Forms.DataGridView carDataGridView;
        private System.Windows.Forms.BindingSource hyrenbilDataSetBindingSource1;
        private hyrenbilDataSet hyrenbilDataSet;
        private System.Windows.Forms.Button carRemoveBtn;
        private System.Windows.Forms.Button carAddBtn;
        private System.Windows.Forms.Button carUpdateBtn;
        private System.Windows.Forms.Button carSearchBtn;
        private System.Windows.Forms.TextBox carSeatsField;
        private System.Windows.Forms.TextBox carPriceField;
        private System.Windows.Forms.TextBox carRegNbrField;
        private System.Windows.Forms.Label carInfoLbl;
        private System.Windows.Forms.TabPage customersTab;
        private System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.Button customerRemoveBtn;
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
        private System.Windows.Forms.DataGridView bookingTable;
        private System.Windows.Forms.Button bookingRemoveBtn;
        private System.Windows.Forms.Button bookingAddBtn;
        private System.Windows.Forms.Button bookingUpdateBtn;
        private System.Windows.Forms.Button bookingSearchBtn;
        private System.Windows.Forms.TextBox bookingRegNbr;
        private System.Windows.Forms.TextBox bookingCustomerField;
        private System.Windows.Forms.TextBox bookingStartDateField;
        private System.Windows.Forms.TextBox bookingEndDateField;
        private System.Windows.Forms.TextBox bookingNbrField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView garageTable;
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
    }
}

