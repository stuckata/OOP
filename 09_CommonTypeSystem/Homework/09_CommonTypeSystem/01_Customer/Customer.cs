using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Customer
{
    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string id;
        private string permanetAddress;
        private string phoneNumber;
        private string email;
        private List<Payment> payments;
        private CustomerType type;

        public Customer(string firstName, string middleName, string lastName, string id, string permanetAddress,
            string phoneNumber, string email, List<Payment> payments, CustomerType type)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.PermanetAddress = permanetAddress;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Payments = payments;
            this.Type = type;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string PermanetAddress
        {
            get
            {
                return this.permanetAddress;
            }
            set
            {
                this.permanetAddress = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return this.phoneNumber;
            }
            set
            {
                this.phoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }

        public List<Payment> Payments
        {
            get
            {
                return this.payments;
            }
            set
            {
                this.payments = value;
            }
        }

        public CustomerType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Customer other)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            Customer customer = obj as Customer;
            if ((System.Object)customer == null)
            {
                return false;
            }

            // Return true if the fields match:
            return (this.FirstName == customer.FirstName) && 
                    (this.MiddleName == customer.MiddleName) && 
                    (this.LastName == customer.LastName) &&
                    (this.Id == customer.Id) &&
                    (this.PermanetAddress == customer.PermanetAddress) &&
                    (this.PhoneNumber == customer.PhoneNumber) &&
                    (this.Email == customer.Email) &&
                    (this.Payments == customer.Payments) &&
                    (this.Type == customer.Type);
        }

        public override int GetHashCode()
        {
            return ;
        }
    }
}
