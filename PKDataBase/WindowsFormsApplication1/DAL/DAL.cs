using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PKDataBase.DAL
{
    class DAL
    {
        private SqlConnection conn = new SqlConnection("Data Source=HannesAsus; Initial Catalog=hyrenbil; User ID=sa; Password=sa");
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

        public SqlDataAdapter getAllCars()
        {
            return executeCommand("SELECT * FROM Car");
        }

    }
}
