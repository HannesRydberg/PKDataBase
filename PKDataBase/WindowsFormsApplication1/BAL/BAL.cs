using PKDataBase.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKDataBase.BAL
{
    class BAL
    {
        private DAL.DAL dal;

        public BAL()
        {
            dal = new DAL.DAL();
        }

        public List<Booking> GetAllBookings()
        {
            return dal.GetAllBookings();
        }

        public List<Customer> GetAllCustomers()
        {
            return dal.GetAllCustomers();
        }

        public List<Car> GetAllCars()
        {     
            return dal.GetAllCars();
        }

        public List<Garage> GetAllGarages()
        {
            return dal.GetAllGarages();
        }

        public List<Model.Model> GetAllModels()
        {
            return dal.GetAllModels();
        }

        public List<Booking> GetSpecifiedBookings(Booking b)
        {
            return dal.GetSpecifiedBookings(b);
        }

        public List<Car> GetSpecifiedCars(Car c)
        {
            return dal.GetSpecifiedCars(c);
        }

        public List<Customer> GetSpecifiedCustomers(Customer c)
        {
            return dal.GetSpecifiedCustomers(c);
        }

        public List<Garage> GetSpecifiedGarages(Garage g)
        {
            return dal.GetSpecifiedGarages(g);
        }

        public List<Model.Model> GetSpecifiedModels(Model.Model m)
        {
            return dal.GetSpecifiedModels(m);
        }

        public Booking InsertBooking(Booking b)
        {
            return dal.InsertBooking(b);
        }

        public Car InsertCar(Car c)
        {
            return dal.InsertCar(c);
        }

        public Customer InsertCustomer(Customer c)
        {
            return dal.InsertCustomer(c);
        }

        public Garage InsertGarage(Garage g)
        {
           return  dal.InsertGarage(g);
        }

        public Model.Model InsertModel(Model.Model m)
        {
            return dal.InsertModel(m);
        }

        public void DeleteBooking(Booking b)
        {
            dal.DeleteBooking(b);
        }

        public void DeleteCar(Car c)
        {
            dal.DeleteCar(c);
        }

        public void DeleteCustomer(Customer c)
        {
            dal.DeleteCustomer(c);
        }

        public void DeleteGarage(Garage g)
        {
            dal.DeleteGarage(g);
        }

        public void DeleteModel(Model.Model m)
        {
            dal.DeleteModel(m);
        }

        public void UpdateBooking(Booking b)
        {
            dal.UpdateBooking(b);
        }

        public void UpdateCar(Car c)
        {
            dal.UpdateCar(c);
        }

        public void UpdateCustomer(Customer c)
        {
            dal.UpdateCustomer(c);
        }

        public void UpdateGarage(Garage g)
        {
            dal.UpdateGarage(g);
        }

        public void UpdateModel(Model.Model m)
        {
            dal.UpdateModel(m);
        }
    }
}
