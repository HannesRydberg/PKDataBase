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
        

        private SqlDataReader ExecuteCommand(SqlCommand cmd)
        {
            SqlDataReader reader = null;
            try
            {
                conn.ConnectionString = "Data Source=HannesAsus; Initial Catalog=hyrenbil; User ID=sa; Password=sa";
                conn.Open();
                cmd.Connection = conn;
                reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return reader;
        }

        private List<Car> CompleteCars(List<Car> cars)
        {
            conn.Close();
            List<Model.Model> models = GetAllModels();
            conn.Close();
            List<Garage> garages = GetAllGarages();
            conn.Close();
            List<Booking> allBookings = GetAllBookings();

            foreach(Car c in cars)
                {
                for (int i = 0; i < models.Count; i++)
                {
                    if (models[i].Name.Equals(c.Model.Name))
                    {
                        c.Model = models[i];
                        i = models.Count();
                    }
                }

                for (int i = 0; i < garages.Count; i++)
                {
                    if (garages[i].Address.Equals(c.Garage.Address))
                    {
                        c.Garage = garages[i];
                        i = garages.Count();
                    }
                }

                List<Booking> bookings = new List<Booking>();

                for (int i = 0; i < allBookings.Count; i++)
                {
                    if (allBookings[i].Car.RegNbr.Equals(c.RegNbr))
                    {
                        bookings.Add(allBookings[i]);
                    }
                }
                c.Bookings = bookings;
            }
            
            return cars;
        }

        public List<Booking> GetAllBookings()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Booking");
            SqlDataReader reader = ExecuteCommand(cmd);
            List<Booking> bookings = new List<Booking>();

            while (reader.Read())
            {
                Booking b = new Booking();
                b.BookingNbr = reader["bookingNbr"].ToString();

                DateTime startDate;
                DateTime.TryParse(reader["startDate"].ToString(), out startDate);
                b.StartDate = startDate;

                DateTime endDate;
                DateTime.TryParse(reader["endDate"].ToString(), out endDate);
                b.EndDate = endDate;

                b.Car = new Car();
                b.Car.RegNbr = reader["regNbr"].ToString();

                b.Customer = new Customer();
                b.Customer.CustomerID = reader["customerID"].ToString();

                bookings.Add(b);
            }
            conn.Close();


            return bookings;
            
        }

        public List<Customer> GetAllCustomers()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer");
            SqlDataReader reader = ExecuteCommand(cmd);
            List<Customer> customers = new List<Customer>();

            while (reader.Read())
            {
                Customer c = new Customer();
                c.CustomerID = reader["customerID"].ToString();
                c.PhoneNbr = reader["phoneNbr"].ToString();
                c.Address = reader["address"].ToString();
                c.FirstName = reader["firstName"].ToString();
                c.LastName = reader["lastName"].ToString();
                customers.Add(c);
            }
            conn.Close();


            return customers;

        }

        public List<Car> GetAllCars()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Car");
            SqlDataReader reader = ExecuteCommand(cmd);

            List<Car> cars = new List<Car>();

            while (reader.Read())
            {
                Car c = new Car();
                c.RegNbr = reader["regNbr"].ToString();
                c.Color = reader["color"].ToString();
                c.Model = new Model.Model();
                c.Model.Name = reader["model"].ToString();
                c.Garage = new Garage();
                c.Garage.Address = reader["address"].ToString();
                cars.Add(c);
            }

            conn.Close();
            conn.Dispose();

            return CompleteCars(cars);

            


        }

        public List<Garage> GetAllGarages()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Garage");
            SqlDataReader reader = ExecuteCommand(cmd);
            List<Garage> garages = new List<Garage>();

            while (reader.Read())
            {
                Garage g = new Garage();
                g.Address = reader["address"].ToString();
                g.Size = (int)reader["size"];
                garages.Add(g);
            }
            conn.Close();


            return garages;
        }

        public List<Model.Model> GetAllModels()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Model");
            SqlDataReader reader = ExecuteCommand(cmd);
            List<Model.Model> models = new List<Model.Model>();

            while(reader.Read())
            {
                Model.Model m = new Model.Model();
                m.Name = reader["name"].ToString();
                m.Brand = reader["brand"].ToString();
                m.Price = (int) reader["price"];
                m.Seats = (int) reader["seats"];
                models.Add(m);
            }
            conn.Close();


            return models;
        }

        public List<Car> GetSpecifiedCars(Car cIn)
        {
            if(cIn.Model == null)
            {
                cIn.Model = new Model.Model();
            }
            
            if(cIn.Garage == null)
            {
                cIn.Garage = new Garage();
            }
            String cmdString = "SELECT * FROM Car c " +
                "WHERE c.regNbr LIKE '%"+ NullCheck(cIn.RegNbr) +"%' " +
                    "AND c.model IN (SELECT name FROM Model WHERE name LIKE '%" + NullCheck(cIn.Model.Name) 
                    + "%' AND brand LIKE '%" + NullCheck(cIn.Model.Brand) + "%' AND price <= " + NullCheck(cIn.Model.Price) + 
                    " AND seats >= " + NullCheck(cIn.Model.Seats) + " ) " +
                    "AND c.color LIKE '%" + NullCheck(cIn.Color) + "%' " +
                    "AND c.address LIKE '%" + NullCheck(cIn.Garage.Address) + "%';";
            SqlCommand cmd = new SqlCommand(cmdString);
            SqlDataReader reader = ExecuteCommand(cmd);
            List<Car> cars = new List<Car>();

                while (reader.Read())
            {
                Car c = new Car();
                c.RegNbr = reader["regNbr"].ToString();
                c.Color = reader["color"].ToString();
                c.Model = new Model.Model();
                c.Model.Name = reader["model"].ToString();
                c.Garage = new Garage();
                c.Garage.Address = reader["address"].ToString();
                cars.Add(c);
            }
            conn.Close();
            conn.Dispose();
            return CompleteCars(cars);
        }

        public List<Model.Model> GetSpecifiedModels(Model.Model m)
        {
            String cmdString = "SELECT * FROM Model m WHERE name LIKE '%"+ m.Name +"%' AND brand LIKE '%" + m.Brand + "%';";
            SqlCommand cmd = new SqlCommand(cmdString);
            SqlDataReader reader = ExecuteCommand(cmd);

            List<Model.Model> models = new List<Model.Model>();

            while (reader.Read())
            {
                Model.Model tmpModel = new Model.Model();
                tmpModel.Name = reader["name"].ToString();
                tmpModel.Brand = reader["brand"].ToString();
                tmpModel.Price = Int32.Parse(reader["price"].ToString());
                tmpModel.Seats = Int32.Parse(reader["seats"].ToString());
                models.Add(tmpModel);

            }
            conn.Close();
            conn.Dispose();

            return models;
        }

        public void InsertCar(Car c)
        {
            String cmdString = "INSERT INTO Car VALUES: ('" + c.RegNbr +"','" 
                + c.Model.Name  +"','" + c.Color +"','" + c.Garage.Address + "')";
            SqlCommand cmd = new SqlCommand(cmdString);
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();
        }

        public void InsertGarage(Garage g)
        {
            String cmdString = "INSERT INTO Garage VALUES: ('" + g.Address + "','"
                + g.Size + "')";
            SqlCommand cmd = new SqlCommand(cmdString);
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();
        }

        public void InsertModel(Model.Model m)
        {
            String cmdString = "INSERT INTO Model VALUES: ('" + m.Name + "','"
                + m.Brand + "','" + m.Price + "','" + m.Seats + "')";
            SqlCommand cmd = new SqlCommand(cmdString);
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();
        }

        public String NullCheck(object o)
        {
            if(o == null)
            {
                return "";
            }
            return o.ToString();
        }
    }
}
