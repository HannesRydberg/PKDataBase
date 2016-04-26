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

namespace PKDataBaseView
{
    public partial class Form1 : Form
    {
        //private DAL dal = new DAL();
        private BAL bal = new BAL();

        private List<Model> allModels = new List<Model>();
        private List<Garage> allGarages = new List<Garage>();
        private List<String> allBrands = new List<String>();

        public Form1()
        {
            InitializeComponent();
            carDataGridView.AutoGenerateColumns = true;
            allModels = bal.GetAllModels();
            allGarages = bal.GetAllGarages();

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

            foreach (Garage g in allGarages)
            {
                carGarageComboBox.Items.Add(g.Address);
            }
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
            if(seats.Length < 1)
            {
                m.Seats = 0;
            }
            else
            {
                m.Seats = Int32.Parse(seats);
            }

            String price = carPriceField.Text;
            if(price.Length < 1)
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
                carMsgLabel.Text = "Hittade inga bilar som matchade sökkriterierna.";
            }
        }

        private void carUpdateBtn_Click(object sender, EventArgs e)
        {

        }


        private void carModelComboBox_Leave_1(object sender, EventArgs e)
        {
            Model m = new Model();
            m.Name = carModelComboBox.Text;
            List<Model> models = bal.GetSpecifiedModels(m);

            if (models.Count == 1)
            {
                Model m2 = models[0];
                carBrandComboBox.Text = m2.Brand;
                carPriceField.Text = m2.Price.ToString();
                carSeatsField.Text = m2.Seats.ToString();
            }
            else if (carModelComboBox.Text.Equals(""))

            {
                carModelComboBox.Items.Clear();
                foreach (Model m2 in allModels)
                {
                    carModelComboBox.Items.Add(m2);
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

        private void carAddBtn_Click(object sender, EventArgs e)
        {
            Car c = new Car();
            c.RegNbr = carRegNbrField.Text;
            Model m = new Model();
            m.Name = carModelComboBox.Text;
            List<Model> models = bal.GetSpecifiedModels(m);
            if(models.Count == 1)
            {
                m = models[0];
            }            
        }
    }
}
