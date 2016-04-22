using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKDataBase.Model
{
    class Model
    {
        private String name;
        private String brand;
        private int price;
        private int seats;
        private List<Car> cars;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Brand
        {
            get
            {
                return brand;
            }

            set
            {
                brand = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public int Seats
        {
            get
            {
                return seats;
            }

            set
            {
                seats = value;
            }
        }

        internal List<Car> Cars
        {
            get
            {
                return cars;
            }

            set
            {
                cars = value;
            }
        }
    }
}
