using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKDataBase.Model
{
    class Booking
    {
        private String bookingNbr;
        private Customer customer;
        private Car car;
        private DateTime startDate;
        private DateTime endDate;

        public string BookingNbr
        {
            get
            {
                return bookingNbr;
            }

            set
            {
                bookingNbr = value;
            }
        }

        internal Customer Customer
        {
            get
            {
                return customer;
            }

            set
            {
                customer = value;
            }
        }

        public Car Car
        {
            get
            {
                return car;
            }

            set
            {
                car = value;
            }
        }

        public DateTime StartDate
        {
            get
            {
                return startDate;
            }

            set
            {
                startDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }
    }
}
