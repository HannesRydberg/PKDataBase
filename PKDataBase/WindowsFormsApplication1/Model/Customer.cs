using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PKDataBase.Model
{
    class Customer
    {
        private String customerID;
        private String phoneNbr;
        private String address;
        private String firstName;
        private String lastName;
        private List<Booking> bookings = new List<Booking>();



        public string CustomerID
        {
            get
            {
                return customerID;
            }

            set
            {
                customerID = value;
            }
        }

        public string PhoneNbr
        {
            get
            {
                return phoneNbr;
            }

            set
            {
                phoneNbr = value;
            }
        }

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

        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }

        public List<Booking> Bookings
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
