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
            SqlDataAdapter dataAdapter = dal.getAllCars();
            DataTable table = new DataTable();
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataAdapter.Fill(table);
            BindingSource hyrenbilDataSetBindingSource1 = new BindingSource();
            hyrenbilDataSetBindingSource1.DataSource = table;
            carTable.DataSource = table;
            dataAdapter.Update(table);
            carTable.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            MessageBox.Show(table.Rows.Count.ToString());
        } 
    }
}
