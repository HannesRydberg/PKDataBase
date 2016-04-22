using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKDataBase.Model
{
    class Garage
    {
        private String address;
        private int size;
        private List<Car> cars;

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public int Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
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
