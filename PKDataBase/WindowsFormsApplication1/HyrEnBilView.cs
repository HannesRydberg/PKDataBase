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
            FillComboBoxes();
            
        }

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
            carDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            carDataGridView.Update();
        }

        private void carSearchBtn_Click(object sender, EventArgs e)
        {
            carMsgLabel.Text = "";
            Car c1 = new Car();
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
            carDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void carUpdateBtn_Click(object sender, EventArgs e)
        {
            carMsgLabel.Text = "";
            List<String> fieldErrors = FieldCheck();
            if (fieldErrors.Count == 0)
            {

                Car c = new Car();
                c.RegNbr = carRegNbrField.Text;

                if (bal.GetSpecifiedCars(c).Count == 0)
                {
                    carMsgLabel.Text = "There exists no car with the Reg. Number " + c.RegNbr +
                        " in the database. Please add a car with that Reg. Number before editing it.";
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
                    Search(c.RegNbr);
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
            List<String> fieldErrors = FieldCheck();
            if (RegNbrCheck() && fieldErrors.Count == 0)
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
                    CleanFields();
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
            CleanFields();
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

        private List<String> FieldCheck()
        {
            
            List<String> result = new List<String>();
            int i;
            if (!RegNbrCheck())
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

        private bool RegNbrCheck()
        {
            Regex regNbrPattern = new Regex("^[a-zåäöA-ZÅÄÖ]{3}[0-9]{3}$");
            
            return regNbrPattern.IsMatch(carRegNbrField.Text);
        }

        private void FillComboBoxes()
        {
            allModels = bal.GetAllModels();
            allGarages = bal.GetAllGarages();
            this.carGarageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LoadAllCars();
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

        private void CleanFields()
        {
            carRegNbrField.Text = "";
            carModelComboBox.Text = "";
            carBrandComboBox.Text = "";
            carColorComboBox.Text = "";
            carSeatsField.Text = "";
            carPriceField.Text = "";
            carGarageComboBox.SelectedIndex = 0;
            FillComboBoxes();
        }

        private void carClearBtn_Click(object sender, EventArgs e)
        {
            CleanFields();
        }

        private void Search(String regNbr)
        {
            
        }    
    }
}
