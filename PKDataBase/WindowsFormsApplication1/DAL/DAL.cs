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
                conn.Close();
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

            foreach (Car c in cars)
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

            while (reader.Read())
            {
                Model.Model m = new Model.Model();
                m.Name = reader["name"].ToString();
                m.Brand = reader["brand"].ToString();
                m.Price = (int)reader["price"];
                m.Seats = (int)reader["seats"];
                models.Add(m);
            }
            conn.Close();


            return models;
        }

        public List<Booking> GetSpecifiedBookings(Booking b)
        {
            if(b.Car == null)
            {
                b.Car = new Car();
            }
            if(b.Customer == null)
            {
                b.Customer = new Customer();
            }
            String cmdString = "SELECT * FROM Booking b WHERE b.bookingNbr LIKE '%" + NullCheck(b.BookingNbr) +
                "%' AND b.customerID LIKE '%" + NullCheck(b.Customer.CustomerID) +
                "%' AND b.regNbr LIKE '%" + NullCheck(b.Car.RegNbr);

            if (b.StartDate != new DateTime())
            {
                cmdString += ("%' AND b.startDate LIKE '%" + b.StartDate.ToString("yyyy-MM-dd"));
            }
            if(b.EndDate != new DateTime())
            {
                cmdString += ("%' AND b.endDate LIKE '%" + b.EndDate.ToString("yyyy-MM-dd"));
            }

            cmdString += "%'";

            List<Booking> bookings = new List<Booking>();
            SqlCommand cmd = new SqlCommand(cmdString);
            SqlDataReader reader = ExecuteCommand(cmd);

            while (reader.Read())
            {
                Booking tmpBooking = new Booking();
                tmpBooking.BookingNbr = reader["bookingNbr"].ToString();
                Car car = new Car();
                car.RegNbr = reader["regNbr"].ToString();
                tmpBooking.Car = car;
                Customer customer = new Customer();
                customer.CustomerID = reader["customerID"].ToString();
                tmpBooking.Customer = customer;
                tmpBooking.StartDate = (DateTime)reader["startDate"];
                tmpBooking.EndDate = (DateTime)reader["endDate"];

                bookings.Add(tmpBooking);
            }
            conn.Close();
            conn.Dispose();

            return bookings;
        }

        public List<Car> GetSpecifiedCars(Car cIn)
        {
            if (cIn.Model == null)
            {
                cIn.Model = new Model.Model();
                cIn.Model.Price = Int32.MaxValue;
                cIn.Model.Seats = 0;
            }

            if (cIn.Garage == null)
            {
                cIn.Garage = new Garage();
            }
            String cmdString = "SELECT * FROM Car c " +
                "WHERE c.regNbr LIKE '%" + NullCheck(cIn.RegNbr) + "%' " +
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

        public List<Customer> GetSpecifiedCustomers(Customer c)
        {
            String cmdString = "SELECT * FROM Customer WHERE customerID LIKE '%" + NullCheck(c.CustomerID) +
                "%' AND phoneNbr LIKE '%" + NullCheck(c.PhoneNbr) + "%' AND address LIKE '%" + NullCheck(c.Address) +
                "%' AND firstName LIKE '%" + NullCheck(c.FirstName) + "%' AND lastName LIKE '%" + NullCheck(c.LastName) + "%'";

            SqlCommand cmd = new SqlCommand(cmdString);
            SqlDataReader reader = ExecuteCommand(cmd);
            List<Customer> customers = new List<Customer>();

            while (reader.Read()) {
                Customer tmpCustomer = new Customer();
                tmpCustomer.CustomerID = reader["customerID"].ToString();
                tmpCustomer.PhoneNbr = reader["phoneNbr"].ToString();
                tmpCustomer.Address = reader["address"].ToString();
                tmpCustomer.FirstName = reader["firstName"].ToString();
                tmpCustomer.LastName = reader["lastName"].ToString();
                customers.Add(tmpCustomer);
            }
            conn.Close();
            conn.Dispose();

            return customers;
        }

        public List<Garage> GetSpecifiedGarages(Garage g)
        {
            String cmdString = "SELECT * FROM Garage g WHERE address LIKE '%" + g.Address + "%'";
            SqlCommand cmd = new SqlCommand(cmdString);
            SqlDataReader reader = ExecuteCommand(cmd);

            List<Garage> garages = new List<Garage>();

            while (reader.Read())
            {
                Garage tmpGarage = new Garage();
                tmpGarage.Address = reader["address"].ToString();
                tmpGarage.Size = Int32.Parse(reader["size"].ToString());
                garages.Add(tmpGarage);
            }
            return garages;
        }

        public List<Model.Model> GetSpecifiedModels(Model.Model m)
        {
            String cmdString = "SELECT * FROM Model m WHERE name LIKE '%" + m.Name + "%' AND brand LIKE '%" + m.Brand + "%';";
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

        public Booking InsertBooking(Booking b)
        {
            if(GetSpecifiedBookings(b).Count == 0)
            {
                if(GetSpecifiedCars(b.Car).Count ==1 && GetSpecifiedCustomers(b.Customer).Count == 1)
                {
                    String cmdString = "INSERT INTO Booking VALUES ('" + b.BookingNbr + "' , '" + b.Customer.CustomerID +
                        "' , '" + b.Car.RegNbr + "' , '" + b.StartDate.Date + "' , '" + b.EndDate.Date + "')";
                    SqlCommand cmd = new SqlCommand(cmdString);
                    ExecuteCommand(cmd);
                    conn.Close();
                    conn.Dispose();
                    return b;
                }
            }
            return null;
        }

        public Car InsertCar(Car c)
        {
            conn.Close();
            if (GetSpecifiedCars(c).Count == 0)
            {
                conn.Close();
                Model.Model m = c.Model;
                if (GetSpecifiedModels(m).Count == 0)
                {
                    conn.Close();
                    InsertModel(m);
                }
                Garage g = c.Garage;
                if(GetSpecifiedGarages(g).Count == 1)
                {

                    String cmdString = "INSERT INTO Car VALUES ('" + c.RegNbr + "','"
                    + c.Model.Name + "','" + c.Color + "','" + c.Garage.Address + "')";
                    SqlCommand cmd = new SqlCommand(cmdString);
                    conn.Close();
                    ExecuteCommand(cmd);
                    conn.Close();
                    conn.Dispose();
                    return c;
                }
               
            }
            return null;
        }

        public Customer InsertCustomer(Customer c)
        {
            if(GetSpecifiedCustomers(c).Count == 0)
            {
                String cmdString = "INSERT INTO Customer VALUES ('" + c.CustomerID + "' , '" + c.PhoneNbr + "' , '" +
                    c.Address + "' , '" + c.FirstName + "' , '" + c.LastName + "')";
                SqlCommand cmd = new SqlCommand(cmdString);
                ExecuteCommand(cmd);
                conn.Close();
                conn.Dispose();
                return c;
            }
            return null;
        }

        public Garage InsertGarage(Garage g)
        {
            if (GetSpecifiedGarages(g).Count == 0)
            {
                String cmdString = "INSERT INTO Garage VALUES ('" + g.Address + "','" 
                + g.Size + "')";
                SqlCommand cmd = new SqlCommand(cmdString);
                ExecuteCommand(cmd);
                conn.Close();
                conn.Dispose();
                return g;
            }
            return null;
        }

        public Model.Model InsertModel(Model.Model m)
        {
            if (GetSpecifiedModels(m).Count == 0)
            {
                String cmdString = "INSERT INTO Model VALUES ('" + m.Name + "','"
                + m.Brand + "','" + m.Price + "','" + m.Seats + "')";
                SqlCommand cmd = new SqlCommand(cmdString);
                ExecuteCommand(cmd);
                conn.Close();
                conn.Dispose();
                return m;
            }
            return null;
        }

        public void DeleteBooking(Booking b)
        {
            String cmdString = "DELETE FROM Booking WHERE bookingNbr = '" + b.BookingNbr + "'";
            SqlCommand cmd = new SqlCommand(cmdString);
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();
        }

        public void DeleteCar(Car c)
        {
            List<Booking> bookings = GetAllBookings();
            foreach(Booking b in bookings)
            {
                if (b.Car.RegNbr.Equals(c.RegNbr))
                {
                    DeleteBooking(b);
                }
            }

            String cmdString = "DELETE FROM Car WHERE regNbr = '" + c.RegNbr + "'";
            SqlCommand cmd = new SqlCommand(cmdString);
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();

            Model.Model m = c.Model;
            Car tmpCar = new Car();
            tmpCar.Model = m;
            if(GetSpecifiedCars(tmpCar).Count == 0)
            {
                DeleteModel(m);
            }
        }

        public void DeleteCustomer(Customer c)
        {
            Booking b = new Booking();
            b.Customer = c;
            List<Booking> bookings = GetSpecifiedBookings(b);
            foreach(Booking tmpBooking in bookings)
            {
                if (tmpBooking.Customer.CustomerID.Equals(c.CustomerID))
                {
                    DeleteBooking(tmpBooking);
                }
            }

            String cmdString = "DELETE FROM Customer WHERE customerID = '" + c.CustomerID + "'";
            SqlCommand cmd = new SqlCommand(cmdString);
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();
        }

        public void DeleteGarage(Garage g)
        {
            Car c = new Car();
            c.Garage = g;
            SqlCommand cmd = new SqlCommand("DELETE FROM Car WHERE address = '" + g.Address + "'");
            ExecuteCommand(cmd);
            conn.Close();
            String cmdString = "DELETE FROM Garage WHERE address = '" + g.Address + "'";
            cmd = new SqlCommand(cmdString);
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();
        }

        public void DeleteModel(Model.Model m)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM Car WHERE model = '" + m.Name + "'");
            ExecuteCommand(cmd);
            conn.Close();

            cmd.CommandText = "DELETE FROM Model WHERE name = '" + m.Name + "'";
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose(); 
        }

        public void UpdateBooking(Booking b)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Booking SET customerID='" + b.Customer.CustomerID +
                "', regNbr='" + b.Car.RegNbr + "', startDate='" + b.StartDate.Date + "', endDate='" + b.EndDate.Date +
                "' WHERE bookingNbr='" + b.BookingNbr + "'");
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();
        }

        public void UpdateCar(Car c)
        {
            Model.Model m = new Model.Model();
            m.Name = c.Model.Name;
            List<Model.Model> models = GetSpecifiedModels(m);
            if(models.Count == 0)
            {
                InsertModel(c.Model);
            }
            else if (!models[0].Equals(c.Model))
            {
                UpdateModel(c.Model);
            }
            SqlCommand cmd = new SqlCommand("UPDATE Car SET model='" + c.Model.Name + "', color='" + c.Color +
            "', address='" + c.Garage.Address + "' WHERE regNbr='" + c.RegNbr + "'");
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();
        }

        public void UpdateCustomer(Customer c)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Customer SET phoneNbr='" + c.PhoneNbr + "', address='" + c.Address +
                "', firstName='" + c.FirstName + "', lastName='" + c.LastName + "' WHERE customerID='" + c.CustomerID + "'");
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();
        }

        public void UpdateGarage(Garage g)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Garage SET size=" + g.Size + " WHERE address='" + g.Address + "'");
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();
        }

        public void UpdateModel(Model.Model m)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Model SET brand='" + m.Brand + "', price=" +
                m.Price + ", seats=" + m.Seats + " WHERE name='" + m.Name + "'");
            ExecuteCommand(cmd);
            conn.Close();
            conn.Dispose();
        }

        private String NullCheck(object o)
        {
            if (o == null)
            {
                return "";
            }
            return o.ToString();
        }
    }
}
