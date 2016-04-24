using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using PKDataBase.Model;

namespace PKDataBase.DAL
{
    class DAL
    {
        private SqlConnection conn = new SqlConnection();
        private SqlDataAdapter dataAdapter;


        public SqlDataAdapter executeCommand(String query)
        {    
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            
                    
               
            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = conn;
            dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            return dataAdapter;
        }

        public List<Car> getAllCars()
        {
            conn.ConnectionString = "Data Source=HannesAsus; Initial Catalog=hyrenbil; User ID=sa; Password=sa";
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Car", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Car> cars = new List<Car>();
            while (reader.Read())
            {
                Car c = new Car();
                c.RegNbr = reader["regNbr"].ToString();
                c.Color = reader["color"].ToString();
                cars.Add(c);
            }
            conn.Close();
            conn.Dispose();
            return cars;
        }

    }
}
