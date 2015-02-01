using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;

namespace _04_CompanyHierarchy.Models
{
    abstract class Person : IPerson
    {
        private string id;
        private string firstName;
        private string lastName;

        public Person(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                Validators.AssertNotEmpty(value, "ID");
                this.id = value;
            }
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                Validators.AssertNotEmpty(value, "First Name");
                Validators.AssertStringSize(value, 2, "First Name");
                this.firstName = value;
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
                Validators.AssertNotEmpty(value, "Last Name");
                Validators.AssertStringSize(value, 2, "Last Name");
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return String.Format("***Perosnal Data*** ID: {0}; First Name: {1}, Last Name: {2}", 
                this.Id, this.FirstName, this.LastName);
        }
    }
}
