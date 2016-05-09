using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PKDataBase.DAL;
using System.Data.SqlClient;
using PKDataBase.Model;
using PKDataBase.BAL;
using System.Text.RegularExpressions;

namespace PKDataBaseView
{
    public partial class Form1 : Form
    {
        private BAL bal = new BAL();

        private List<Model> allModels = new List<Model>();
        private List<Garage> allGarages = new List<Garage>();
        private List<String> allBrands = new List<String>();

        public Form1()
        {
            InitializeComponent();
            carDataGridView.AutoGenerateColumns = true;
            LoadAllCars();
            carDataGridView.AutoResizeColumns();
            carDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            FillCarComboBoxes();

            customerDataGridView.AutoGenerateColumns = true;
            LoadAllCustomers();
            customerDataGridView.AutoResizeColumns();
            customerMsgLabel.Text = "";

            bookingDataGridView.AutoGenerateColumns = true;
            LoadAllBookings();
            bookingDataGridView.AutoResizeColumns();
            bookingMsgLabel.Text = "";

            garageDataGridView.AutoGenerateColumns = true;
            garageDataGridView.AutoResizeColumns();
            LoadAllGarages();
            garageMsgLabel.Text = "";
        }


        //Car Methods

        private void LoadAllCars()
        {
            List<Car> cars = bal.GetAllCars();
            DataTable table = new DataTable();

            table.Columns.Add("RegNbr");
            table.Columns.Add("Brand");
            table.Columns.Add("Model");
            table.Columns.Add("Color");
            table.Columns.Add("Garage");
            table.Columns.Add("Seats");
            table.Columns.Add("Price");

            foreach (Car c in cars)
            {
                DataRow row = table.NewRow();
                row[0] = c.RegNbr;
                row[1] = c.Model.Brand;
                row[2] = c.Model.Name;
                row[3] = c.Color;
                row[4] = c.Garage.Address;
                row[5] = c.Model.Seats;
                row[6] = c.Model.Price;
                table.Rows.Add(row);
            }
            carDataGridView.DataSource = table;
            carDataGridView.Update();

        }

        private void carSearchBtn_Click(object sender, EventArgs e)
        {
            carMsgLabel.Text = "";
            CarSearch(null);
            
        }

        private void carUpdateBtn_Click(object sender, EventArgs e)
        {
            carMsgLabel.Text = "";
            List<String> fieldErrors = CarFieldCheck();
            if (fieldErrors.Count == 0)
            {

                Car c = new Car();
                c.RegNbr = carRegNbrField.Text;

                if (bal.GetSpecifiedCars(c).Count == 0)
                {
                    carMsgLabel.Text = "There exists no car with the Reg. Number " + c.RegNbr +
                        " in the database.\nPlease add a car with that Reg. Number before editing it.";
                }
                else
                { 
                    Model m = new Model();
                    m.Name = carModelComboBox.Text;
                    List<Model> models = bal.GetSpecifiedModels(m);

                        m.Brand = carBrandComboBox.Text;
                        m.Price = Int32.Parse(carPriceField.Text);
                        m.Seats = Int32.Parse(carSeatsField.Text);

                    c.Model = m;
                    c.Color = carColorComboBox.Text;

                    Garage g = new Garage();
                    g.Address = carGarageComboBox.Text;
                    List<Garage> garages = bal.GetSpecifiedGarages(g);
                    g = garages[0];
                    c.Garage = g;

                    bal.UpdateCar(c);
                    CarSearch(c.RegNbr);
                    carMsgLabel.Text = "Car with Reg. Number " + c.RegNbr +" was updated.";
                }
            }
            else
            {
                String errorMessage = "Could not update car. The following values were invalid: ";

                foreach (String s in fieldErrors)
                {
                    errorMessage += "\n" + s;
                }

                MessageBox.Show(errorMessage);
            }
        }

        private void carAddBtn_Click(object sender, EventArgs e)
        {
            carMsgLabel.Text = "";
            List<String> fieldErrors = CarFieldCheck();
            if (RegNbrCheck(carRegNbrField.Text) && fieldErrors.Count == 0)
            {

                Car c = new Car();
                c.RegNbr = carRegNbrField.Text;

                if (bal.GetSpecifiedCars(c).Count > 0)
                {
                    carMsgLabel.Text = "There already exists a car with the Reg. Number " + c.RegNbr +
                        " in the database. \nPlease enter another Reg. Number or delete the other car.";
                }
                else
                {
                    Model m = new Model();
                    m.Name = carModelComboBox.Text;
                    List<Model> models = bal.GetSpecifiedModels(m);

                    if (models.Count == 1)
                    {
                        m = models[0];
                    }
                    else
                    {
                        m.Brand = carBrandComboBox.Text;
                        m.Price = Int32.Parse(carPriceField.Text);
                        m.Seats = Int32.Parse(carSeatsField.Text);
                        bal.InsertModel(m);
                    }

                    c.Model = m;
                    c.Color = carColorComboBox.Text;

                    Garage g = new Garage();
                    g.Address = carGarageComboBox.Text;
                    List<Garage> garages = bal.GetSpecifiedGarages(g);
                    g = garages[0];
                    c.Garage = g;

                    bal.InsertCar(c);
                    carMsgLabel.Text = "Car with Reg. Number " + c.RegNbr + " added";
                    LoadAllCars();
                    CleanCarFields();
                }
                
            }
            else
            {
                String errorMessage = "Could not add car. The following values were invalid: ";

                foreach (String s in fieldErrors)
                {
                    errorMessage += "\n" + s;
                }

                MessageBox.Show(errorMessage);
            }
        }

        private void carDeleteBtn_Click(object sender, EventArgs e)
        {
            carMsgLabel.Text = "";

            Car c = new Car();
            c.RegNbr = carRegNbrField.Text;
            List<Car> cars = bal.GetSpecifiedCars(c);
            if(carRegNbrField.Text.Length == 0)
            {
                carMsgLabel.Text = "Please enter the Reg. Number of the car you want to delete.";
            }else
            {
                if (cars.Count == 0)
                {
                    MessageBox.Show("There exists no car with the Reg. Number " + c.RegNbr +
                            " in the database. Please add a car with that Reg. Number before deleting it.");
                }
                else
                {
                    Model m = new Model();
                    m.Name = carModelComboBox.Text;
                    c.Model = m;
                    bal.DeleteCar(c);
                    carMsgLabel.Text = "Car with Reg. Number " + c.RegNbr + " has been deleted.";
                    LoadAllCars();
                }
            }
            CleanCarFields();
        }

        private void carModelComboBox_Leave_1(object sender, EventArgs e)
        {
            Model m = new Model();
            m.Name = carModelComboBox.Text;
            List<Model> models = bal.GetSpecifiedModels(m);

            if (models.Count == 1)
            {
                Model m2 = models[0];
                carBrandComboBox.Items.Clear();
                carBrandComboBox.Text = m2.Brand; 
                carBrandComboBox.Items.Add(m2.Brand);
                carPriceField.Text = m2.Price.ToString();
                carSeatsField.Text = m2.Seats.ToString();
            }
            else if (carModelComboBox.Text.Equals(""))

            {
                carModelComboBox.Items.Clear();
                foreach (Model m2 in allModels)
                {
                    carModelComboBox.Items.Add(m2.Name);
                }
            }
            else if (models.Count > 1)
            {
                carModelComboBox.Items.Clear();
                foreach(Model m2 in models)
                {
                    carModelComboBox.Items.Add(m2);
                }
            }

        }

        private void carBrandComboBox_Leave(object sender, EventArgs e)
        {
            if(allBrands.Contains(carBrandComboBox.Text))
            {
                carModelComboBox.Items.Clear();
                foreach(Model m in allModels)
                {
                    if (m.Brand.Equals(carBrandComboBox.Text))
                    {
                        carModelComboBox.Items.Add(m.Name);
                    }
                }
            }
            else
            {
                carModelComboBox.Items.Clear();
                foreach(Model m in allModels)
                {
                    carModelComboBox.Items.Add(m.Name);
                }
            }
        }

        private void CarSearch(String regNbr)
        {
            Car c1 = new Car();
            if (regNbr == null)
            {
                c1.RegNbr = carRegNbrField.Text;
                Model m = new Model();
                m.Name = carModelComboBox.Text;
                m.Brand = carBrandComboBox.Text;

                String seats = carSeatsField.Text;
                if (seats.Length < 1)
                {
                    m.Seats = 0;
                }
                else
                {
                    m.Seats = Int32.Parse(seats);
                }

                String price = carPriceField.Text;
                if (price.Length < 1)
                {
                    m.Price = Int32.MaxValue;
                }
                else
                {
                    m.Price = Int32.Parse(price);
                }

                c1.Model = m;
                c1.Color = carColorComboBox.Text;
                Garage g = new Garage();
                g.Address = carGarageComboBox.Text;
                c1.Garage = g;
            }
            else
            {
                c1.RegNbr = regNbr;
            }

            List<Car> cars = bal.GetSpecifiedCars(c1);
            DataTable table = new DataTable();

            table.Columns.Add("RegNbr");
            table.Columns.Add("Brand");
            table.Columns.Add("Model");
            table.Columns.Add("Color");
            table.Columns.Add("Garage");
            table.Columns.Add("Seats");
            table.Columns.Add("Price");

            foreach (Car c in cars)
            {
                DataRow row = table.NewRow();
                row[0] = c.RegNbr;
                row[1] = c.Model.Brand;
                row[2] = c.Model.Name;
                row[3] = c.Color;
                row[4] = c.Garage.Address;
                row[5] = c.Model.Seats;
                row[6] = c.Model.Price;
                table.Rows.Add(row);
            }
            carDataGridView.DataSource = table;
            carDataGridView.Update();

            if (cars.Count == 0)
            {
                carMsgLabel.Text = "No cars in the database matches the search criteria.";
            }
            if (cars.Count == 1)
            {
                carRegNbrField.Text = cars[0].RegNbr;
                carModelComboBox.Text = cars[0].Model.Name;
                carBrandComboBox.Text = cars[0].Model.Brand;
                carColorComboBox.Text = cars[0].Color;
                carSeatsField.Text = cars[0].Model.Seats.ToString();
                carPriceField.Text = cars[0].Model.Price.ToString();
                carGarageComboBox.Text = cars[0].Garage.Address;
            }
        }

        private List<String> CarFieldCheck()
        {
            
            List<String> result = new List<String>();
            int i;
            if (!RegNbrCheck(carRegNbrField.Text))
            {
                result.Add("Reg. Number: The value of the Reg. Number field must be 3 letters followed by 3 digits.");
            }
            if (carModelComboBox.Text.Length == 0){
                result.Add("Model: The model field can not be empty, please type/select a value.");
            }
            if (carBrandComboBox.Text.Length == 0){
                result.Add("Brand: The brand field can not be empty, please type/select a value.");
            }
            if (carColorComboBox.Text.Length == 0)
            {
                result.Add("Color: The color field can not be empty, please type/select a value.");
            }
            if(!Int32.TryParse(carPriceField.Text, out i))
            {
                result.Add("Price: The value of the Price field must be a number.");
            }
            if (!Int32.TryParse(carSeatsField.Text, out i)){
                result.Add("Seats: The value of the Seats field must be a number.");
            }
            if(carGarageComboBox.Text.Length == 0)
            {
                result.Add("Garage: The garage field can not be empty, please select a value.");
            }

            return result;
        }

        private bool RegNbrCheck(String s)
        {
            Regex regNbrPattern = new Regex("^[a-zåäöA-ZÅÄÖ]{3}[0-9]{3}$");
            
            return regNbrPattern.IsMatch(s);
        }

        private void FillCarComboBoxes()
        {
            allModels = bal.GetAllModels();
            allGarages = bal.GetAllGarages();
            this.carGarageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            carModelComboBox.Items.Clear();
            carBrandComboBox.Items.Clear();
            carGarageComboBox.Items.Clear();

            foreach (Model m in allModels)
            {
                carModelComboBox.Items.Add(m.Name);
                if (!allBrands.Contains(m.Brand))
                {
                    allBrands.Add(m.Brand);
                }
            }

            foreach (String s in allBrands)
            {
                carBrandComboBox.Items.Add(s);
            }

            carGarageComboBox.Items.Add("");

            foreach (Garage g in allGarages)
            {
                carGarageComboBox.Items.Add(g.Address);
            }
        }

        private void CleanCarFields()
        {
            carRegNbrField.Text = "";
            carModelComboBox.Text = "";
            carBrandComboBox.Text = "";
            carColorComboBox.Text = "";
            carSeatsField.Text = "";
            carPriceField.Text = "";
            carGarageComboBox.SelectedIndex = 0;
            FillCarComboBoxes();
        }

        private void carClearBtn_Click(object sender, EventArgs e)
        {
            CleanCarFields();
        }

        //End Car Methods
        
            //Customer Methods

        private void LoadAllCustomers()
        {
            List<Customer> customers = bal.GetAllCustomers();
            DataTable customerTable = new DataTable();

            customerTable.Columns.Add("Customer ID");
            customerTable.Columns.Add("First Name");
            customerTable.Columns.Add("Last Name");
            customerTable.Columns.Add("Address");
            customerTable.Columns.Add("Phone Number");

            foreach (Customer c in customers)
            {
                DataRow row = customerTable.NewRow();
                row[0] = c.CustomerID;
                row[1] = c.FirstName;
                row[2] = c.LastName;
                row[3] = c.Address;
                row[4] = c.PhoneNbr;
                customerTable.Rows.Add(row);
            }
            customerDataGridView.DataSource = customerTable;
            customerDataGridView.Update();
        }

        private void customerSearchBtn_Click(object sender, EventArgs e)
        {
            customerMsgLabel.Text = "";
            CustomerSearch(null);
        }

        private void customerUpdateBtn_Click(object sender, EventArgs e)
        {
            customerMsgLabel.Text = "";
            List<String> errorMessages = CustomerFieldCheck();

            if(errorMessages.Count == 0)
            {
                Customer c = new Customer();
                c.CustomerID = customerIDField.Text;
                if(bal.GetSpecifiedCustomers(c).Count == 0)
                {
                    customerMsgLabel.Text = "No customer with ID " + c.CustomerID + 
                        " exists.\nPlease add a customer with that ID before editing.";
                } else
                {
                    c.FirstName = customerFirstNameField.Text;
                    c.LastName = customerLastNameField.Text;
                    c.Address = customerAddressField.Text;
                    c.PhoneNbr = customerPhoneNbrField.Text;

                    bal.UpdateCustomer(c);
                    customerMsgLabel.Text = "Customer with ID " + c.CustomerID + " was updated.";
                    CustomerSearch(c.CustomerID);
                }
            }
            else
            {
                String errorMessage = "Could not update customer. The following values were invalid: ";

                foreach (String s in errorMessages)
                {
                    errorMessage += "\n" + s;
                }

                MessageBox.Show(errorMessage);
            }
        }

        private void customerAddBtn_Click(object sender, EventArgs e)
        {
            customerMsgLabel.Text = "";
            List<String> errorMessages = CustomerFieldCheck();
            if(errorMessages.Count == 0)
            {
                
                Customer c = new Customer();
                c.CustomerID = customerIDField.Text;

                if(bal.GetSpecifiedCustomers(c).Count > 0)
                {
                    customerMsgLabel.Text = "There already exists a customer with ID " + c.CustomerID + ".\nPlease select another ID.";
                } else
                {
                    c.FirstName = customerFirstNameField.Text;
                    c.LastName = customerLastNameField.Text;
                    c.PhoneNbr = customerPhoneNbrField.Text;
                    c.Address = customerAddressField.Text;

                    bal.InsertCustomer(c);
                    customerMsgLabel.Text = "Customer " + c.FirstName + " " + c.LastName + " was added.";
                    LoadAllCustomers();
                }
            }
            else
            {
                String errorMessage = "Could not add customer. The following values were invalid: ";

                foreach (String s in errorMessages)
                {
                    errorMessage += "\n" + s;
                }

                MessageBox.Show(errorMessage);
            }
        }

        private void customerDeleteBtn_Click(object sender, EventArgs e)
        {
            if (customerIDField.Text == "")
            {
                customerMsgLabel.Text = "Please enter the ID of the customer you want to delete";
            }
            else
            {
                Customer c = new Customer();
                c.CustomerID = customerIDField.Text;

                if (bal.GetSpecifiedCustomers(c).Count == 0)
                {
                    customerMsgLabel.Text = "No customer with that ID exists, cannot delete.";
                }
                else
                {
                    bal.DeleteCustomer(c);
                    LoadAllCustomers();
                    customerMsgLabel.Text = "Customer with ID " + c.CustomerID + " has been deleted.";
                }
            }
        }

        private void customerClearBtn_Click(object sender, EventArgs e)
        {
            ClearCustomerFields();
        }

        private void CustomerSearch(String custID)
        {
            Customer cust = new Customer();
            if (custID == null)
            {
                cust.CustomerID = customerIDField.Text;
                cust.PhoneNbr = customerPhoneNbrField.Text;
                cust.Address = customerAddressField.Text;
                cust.FirstName = customerFirstNameField.Text;
                cust.LastName = customerLastNameField.Text;
            }
            else
            {
                cust.CustomerID = custID;
            }

            List<Customer> customers = bal.GetSpecifiedCustomers(cust);
            DataTable customerTable = new DataTable();

            customerTable.Columns.Add("Customer ID");
            customerTable.Columns.Add("First Name");
            customerTable.Columns.Add("Last Name");
            customerTable.Columns.Add("Address");
            customerTable.Columns.Add("Phone Number");

            foreach (Customer c in customers)
            {
                DataRow row = customerTable.NewRow();
                row[0] = c.CustomerID;
                row[1] = c.FirstName;
                row[2] = c.LastName;
                row[3] = c.Address;
                row[4] = c.PhoneNbr;
                customerTable.Rows.Add(row);
            }
            customerDataGridView.DataSource = customerTable;
            customerDataGridView.Update();

            if (customers.Count == 0)
            {
                carMsgLabel.Text = "No customers in the database matches the search criteria.";
            }
            if (customers.Count == 1)
            {
                customerIDField.Text = customers[0].CustomerID;
                customerFirstNameField.Text = customers[0].FirstName;
                customerLastNameField.Text = customers[0].LastName;
                customerPhoneNbrField.Text = customers[0].PhoneNbr;
                customerAddressField.Text = customers[0].Address;
            }
        }

        private List<String> CustomerFieldCheck()
        {
            List<String> errorMessages = new List<String>();
            int i;

            if (customerIDField.Text.Length == 0)
            {
                errorMessages.Add("Customer ID: The Customer ID field can not be empty, please enter a value.");
            }
            if (customerFirstNameField.Text.Length == 0)
            {
                errorMessages.Add("First Name: The First Name field can not be empty, please enter a value.");
            }
            if (customerLastNameField.Text.Length == 0)
            {
                errorMessages.Add("Last Name: The Last Name field can not be empty, please enter a value.");
            }
            if (customerPhoneNbrField.Text.Length == 0)
            {
                errorMessages.Add("Phone Number: The Phone Number field can not be empty, please enter a value.");
            }
            else if (!CheckIfOnlyNumbers(customerPhoneNbrField.Text))
            {
                errorMessages.Add("Phone Number: The Phone number must contain only digits, no spaces, dashes or other characters.");
            }
            if (customerAddressField.Text.Length == 0)
            {
                errorMessages.Add("Address: The Address field can not be empty, please enter a value.");
            }
            return errorMessages;
        }

        private bool CheckIfOnlyNumbers(String s)
        {
            Regex numberPattern = new Regex("^[0-9]+$");

            return numberPattern.IsMatch(s);
        }

        private void ClearCustomerFields()
        {
            customerIDField.Text = "";
            customerPhoneNbrField.Text = "";
            customerAddressField.Text = "";
            customerFirstNameField.Text = "";
            customerLastNameField.Text = "";
        }


        //End Customer Methods

        //Booking Methods

        private void LoadAllBookings()
        {
            List<Booking> bookings = bal.GetAllBookings();
            DataTable bookingTable = new DataTable();

            bookingTable.Columns.Add("Booking Number");
            bookingTable.Columns.Add("Customer ID");
            bookingTable.Columns.Add("Reg. Number");
            bookingTable.Columns.Add("Start Date");
            bookingTable.Columns.Add("End Date");

            foreach (Booking b in bookings)
            {
                DataRow row = bookingTable.NewRow();
                row[0] = b.BookingNbr;
                row[1] = b.Customer.CustomerID;
                row[2] = b.Car.RegNbr;
                row[3] = b.StartDate.ToShortDateString();
                row[4] = b.EndDate.ToShortDateString();
                bookingTable.Rows.Add(row);
            }
            bookingDataGridView.DataSource = bookingTable;
            bookingDataGridView.Update();
        }

        private void bookingSearchBtn_Click(object sender, EventArgs e)
        {
            bookingMsgLabel.Text = "";
            BookingSearch(null);
        }

        private void bookingUpdateBtn_Click(object sender, EventArgs e)
        {
            bookingMsgLabel.Text = "";
            List<String> errorMessages = BookingFieldCheck();
            if(errorMessages.Count == 0)
            {
                Booking b = new Booking();
                b.BookingNbr = bookingNbrField.Text;
                
                if(bal.GetSpecifiedBookings(b).Count == 0)
                {
                    bookingMsgLabel.Text = "No booking with Booking Number " + b.BookingNbr + " exists." +
                        "Cannot update booking.";
                }
                else
                {
                    Car car = new Car();
                    car.RegNbr = bookingRegNbrField.Text;
                    b.Car = car;
                    Customer customer = new Customer();
                    customer.CustomerID = bookingCustomerIDField.Text;
                    b.Customer = customer;
                    b.StartDate = startDateTimePicker.Value;
                    b.EndDate = endDateTimePicker.Value;

                    bal.UpdateBooking(b);
                    bookingMsgLabel.Text = "Booking with Booking Number " + b.BookingNbr + " was updated.";
                    BookingSearch(b.BookingNbr);
                }
            }
            else
            {
                String errorMessage = "Could not update booking. The following values were invalid: ";

                foreach (String s in errorMessages)
                {
                    errorMessage += "\n" + s;
                }

                MessageBox.Show(errorMessage);
            }
        }

        private void bookingAddBtn_Click(object sender, EventArgs e)
        {
            bookingMsgLabel.Text = "";
            List<String> errorMessages = BookingFieldCheck();
            if(errorMessages.Count == 0)
            {
                Booking b = new Booking();
                b.BookingNbr = bookingNbrField.Text;
                if(bal.GetSpecifiedBookings(b).Count < 0)
                {
                    bookingMsgLabel.Text = "There already exists a booking with Booking Number " + b.BookingNbr +
                        "\nPlease choose another Booking Number.";
                }
                else
                {
                    Car car = new Car();
                    car.RegNbr = bookingRegNbrField.Text;
                    b.Car = car;
                    Customer customer = new Customer();
                    customer.CustomerID = bookingCustomerIDField.Text;
                    b.Customer = customer;
                    b.StartDate = startDateTimePicker.Value;
                    b.EndDate = endDateTimePicker.Value;

                    bal.InsertBooking(b);
                    bookingMsgLabel.Text = "Booking with Booking Number " + b.BookingNbr + " was added.";
                }
            } else
            {
                String errorMessage = "Could not add booking. The following values were invalid: ";

                foreach (String s in errorMessages)
                {
                    errorMessage += "\n" + s;
                }

                MessageBox.Show(errorMessage);
            }         
        }

        private void bookingRemoveBtn_Click(object sender, EventArgs e)
        {
            bookingMsgLabel.Text = "";
            if(bookingNbrField.Text == "")
            {
                bookingMsgLabel.Text = "Please enter the Booking Number of the booking you want to remove.";
            }
            else
            {
                Booking b = new Booking();
                b.BookingNbr = bookingNbrField.Text;
                if (bal.GetSpecifiedBookings(b).Count == 0)
                {
                    bookingMsgLabel.Text = "No booking with that Booking Number exists, cannot remove.";
                }
                else
                {
                    bal.DeleteBooking(b);
                    LoadAllBookings();
                    bookingMsgLabel.Text = "Booking with Booking Number " + b.BookingNbr + " has been removed";
                }
            }
           
        }

        private void bookingClearBtn_Click(object sender, EventArgs e)
        {
            ClearBookingFields();
        }

        private void BookingSearch(String bookingNbr)
        {
            Booking b = new Booking();
            if (bookingNbr == null)
            {
                b.BookingNbr = bookingNbrField.Text;
                Car car = new Car();
                car.RegNbr = bookingRegNbrField.Text;
                b.Car = car;
                Customer customer = new Customer();
                customer.CustomerID = bookingCustomerIDField.Text;
                b.Customer = customer;
            }
            else
            {
                b.BookingNbr = bookingNbr;
            }
            List<Booking> bookings = bal.GetSpecifiedBookings(b);
            if (bookings.Count == 0)
            {
                bookingMsgLabel.Text = "No bookings that matched the criteria were found.";
            }

            DataTable bookingTable = new DataTable();

            bookingTable.Columns.Add("Booking Number");
            bookingTable.Columns.Add("Customer ID");
            bookingTable.Columns.Add("Reg. Number");
            bookingTable.Columns.Add("Start Date");
            bookingTable.Columns.Add("End Date");

            foreach (Booking tmpBooking in bookings)
            {
                DataRow row = bookingTable.NewRow();
                row[0] = tmpBooking.BookingNbr;
                row[1] = tmpBooking.Customer.CustomerID;
                row[2] = tmpBooking.Car.RegNbr;
                row[3] = tmpBooking.StartDate.ToShortDateString();
                row[4] = tmpBooking.EndDate.ToShortDateString();
                bookingTable.Rows.Add(row);
            }
            bookingDataGridView.DataSource = bookingTable;
            bookingDataGridView.Update();

        }

        private List<String> BookingFieldCheck()
        {
            List<String> errorMessages = new List<String>();
            if(bookingNbrField.Text.Length == 0)
            {
                errorMessages.Add("Booking Number: The Booking Number field cannot be empty, please enter a value.");
            } else if (!CheckIfOnlyNumbers(bookingNbrField.Text))
            {
                errorMessages.Add("Booking Number: The Booking Number may only consist of digits (no spaces or dashes).");
            }
            if(bookingCustomerIDField.Text.Length == 0)
            {
                errorMessages.Add("Customer ID: The Customer ID field cannot be empty, please enter a value.");
            }
            else if (!CheckIfOnlyNumbers(bookingCustomerIDField.Text)){
                errorMessages.Add("Customer ID: The Customer ID may only consist of digits (no spaces or dashes).");
            }
            if(bookingRegNbrField.Text.Length == 0)
            {
                errorMessages.Add("Reg. Number: The Reg. Number field cannot be empty, please enter a value.");
            }
            else if (!RegNbrCheck(bookingRegNbrField.Text))
            {
                errorMessages.Add("Reg. Number: The value of the Reg. Number field must be 3 letters followed by 3 digits.");
            }

            return errorMessages;
        }

        private void ClearBookingFields()
        {
            bookingNbrField.Text = "";
            bookingCustomerIDField.Text = "";
            bookingRegNbrField.Text = "";
        }

        //End Booking Methods

        //Garage Methods

        private void LoadAllGarages()
        {
            List<Garage> garages = bal.GetAllGarages();
            DataTable garageTable = new DataTable();

            garageTable.Columns.Add("Address");
            garageTable.Columns.Add("Size");

            foreach (Garage g in garages)
            {
                DataRow row = garageTable.NewRow();
                row[0] = g.Address;
                row[1] = g.Size;
                garageTable.Rows.Add(row);
            }
            garageDataGridView.DataSource = garageTable;
            garageDataGridView.Update();
        }

        private void garageSearchBtn_Click(object sender, EventArgs e)
        {
            garageMsgLabel.Text = "";
            GarageSearch(null);
        }

        private void garageUpdateBtn_Click(object sender, EventArgs e)
        {
            int size;
            garageMsgLabel.Text = "";
            if (!Int32.TryParse(garageSizeField.Text, out size))
            {
                MessageBox.Show("The size value must be an integer.");
            }
            else
            {
                Garage g = new Garage();
                g.Address = bookingNbrField.Text;

                if (bal.GetSpecifiedGarages(g).Count == 0)
                {
                    bookingMsgLabel.Text = "No garages with Address " + g.Address + " exists." +
                        "Cannot update garage.";
                }
                else
                {
                    g.Size = Int32.Parse(garageSizeField.Text);

                    bal.UpdateGarage(g);
                    bookingMsgLabel.Text = "Garage with address " + g.Address + " was updated.";
                    GarageSearch(g.Address);
                }
            }       
        }
        

        private void garageAddBtn_Click(object sender, EventArgs e)
        {

        }

        private void garageRemoveBtn_Click(object sender, EventArgs e)
        {

        }

        private void garageClearBtn_Click(object sender, EventArgs e)
        {
            ClearGarageFields();
        }

        private void GarageSearch(String address)
        {
            Garage g = new Garage();
            if (address == null)
            {
                g.Address = garageAddressField.Text;
                g.Size = Int32.Parse(garageSizeField.Text);
            }
            else
            {
                g.Address = address;
            }
            List<Garage> garages = bal.GetSpecifiedGarages(g);
            if (garages.Count == 0)
            {
                bookingMsgLabel.Text = "No garages that matched the criteria were found.";
            }

            DataTable garageTable = new DataTable();

            garageTable.Columns.Add("Address");
            garageTable.Columns.Add("Size");

            foreach (Garage tmpGarage in garages)
            {
                DataRow row = garageTable.NewRow();
                row[0] = tmpGarage.Address;
                row[1] = tmpGarage.Size;
                garageTable.Rows.Add(row);
            }
            garageDataGridView.DataSource = garageTable;
            garageDataGridView.Update();
        }

        private void ClearGarageFields()
        {
            garageAddressField.Text = "";
            garageSizeField.Text = "";
        }
    }
}
