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
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter dataAdapter;
        private DataTable dataTable;

        public void ConnectDB()
        {
            conn = new SqlConnection(
                "user id=sa;" + 
                "password=sa;" + 
                "server=localhost;" + 
                "Database=hyrenbil;" + 
                "Connect timeout=10;");
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
           
            cmd = new SqlCommand("SELECT * FROM Car");
            cmd.Connection = conn;
            dataAdapter = new SqlDataAdapter(cmd);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

        }

    }
}
