using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKDataBase.Model
{
    class Car
    {
        private String regNbr;
        private Model model;
        private String color;
        private Garage garage;
        private List<Booking> bookings;

        public string RegNbr
        {
            get
            {
                return regNbr;
            }

            set
            {
                regNbr = value;
            }
        }

        internal Model Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }

            set
            {
                color = value;
            }
        }

        internal Garage Garage
        {
            get
            {
                return garage;
            }

            set
            {
                garage = value;
            }
        }

        internal List<Booking> Bookings
        {
            get
            {
                return bookings;
            }

            set
            {
                bookings = value;
            }
        }
    }
}
