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

        public List<Car> GetSpecifiedCars(Car cIn)
        {
            return dal.GetSpecifiedCars(cIn);
        }

        public List<Model.Model> GetSpecifiedModels(Model.Model m)
        {
            return dal.GetSpecifiedModels(m);
        }

        public void InsertCar(Car c)
        {
            dal.InsertCar(c);
        }

        public void InsertGarage(Garage g)
        {
            dal.InsertGarage(g);
        }

        public void InsertModel(Model.Model m)
        {
            dal.InsertModel(m);
        }
    }
}
