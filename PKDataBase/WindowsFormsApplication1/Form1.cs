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

namespace PKDataBaseView
{
    public partial class Form1 : Form
    {
        private DAL dal = new DAL();

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void carSearchBtn_Click(object sender, EventArgs e)
        {
            List<Car> cars = dal.getAllCars();
            DataTable table = new DataTable();
            table.Columns.Add("RegNbr");
            table.Columns.Add("Color");

            foreach(Car c in cars)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell regNbrCell = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell colorCell = new DataGridViewTextBoxCell();
                regNbrCell.Value = c.RegNbr;
                row.Cells.Add(regNbrCell);
                colorCell.Value = c.Color;
                row.Cells.Add(colorCell);
                table.Rows.Add(row);

            }
            carDataGridView.DataSource = table;
            MessageBox.Show(table.Rows[0][0].ToString());
            carDataGridView.Update();
        } 
    }
}
