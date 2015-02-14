using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ClassStudent
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phone;
        private string email;
        private IList<int> marks;
        private string groupNumber;

        public Student(string firstName, string lastName, int age, string facultyNumber, 
            string phone, string email, IList<int> marks, string groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
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

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                this.facultyNumber = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
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

        public IList<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }

        public string GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }

        public override string ToString()
        {
            return String.Format(
                "STUDENT: {0} {1} | AGE: {2} | FAC. NUMBER: {3} | PHONE: {4} | EMAIL: {5} | MARKS: [ {6} ] | GROUP: {7}", this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.Phone, this.Email, 
                  string.Join(", ", this.Marks), this.GroupNumber);
        }
    }
}
