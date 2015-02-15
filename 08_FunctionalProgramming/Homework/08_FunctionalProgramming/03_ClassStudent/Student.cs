using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace _03_ClassStudent
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;
        private string facultyNumber;
        private string phone;
        private MailAddress email;
        private IList<int> marks;
        private string groupNumber;
        private string groupName;

        public Student(string firstName, string lastName, int age, string facultyNumber, 
            string phone, MailAddress email, IList<int> marks, string groupNumber, string groupName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FacultyNumber = facultyNumber;
            this.Phone = phone;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.groupName = groupName;
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

        public MailAddress Email
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

        public string GroupName
        {
            get
            {
                return this.groupName;
            }
            set
            {
                this.groupName = value;
            }
        }

        public override string ToString()
        {
            return String.Format(
                "STUDENT: {0} {1} | AGE: {2} | FAC. NUMBER: {3} | PHONE: {4} | EMAIL: {5} | MARKS: [ {6} ] | GROUP: {7} | GROUP NAME: {8}", 
                    this.FirstName, this.LastName, this.Age, this.FacultyNumber, this.Phone, this.Email, 
                    string.Join(", ", this.Marks), this.GroupNumber, this.groupName);
        }
    }
}
