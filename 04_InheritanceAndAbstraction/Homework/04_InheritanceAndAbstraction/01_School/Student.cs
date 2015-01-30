using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_School
{
    class Student : Person
    {
        private string classNumber;

        public Student(string details, string name, string classNumber)
            : base(details, name)
        {
            this.ClassNumber = classNumber;
        }

        public string ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                this.classNumber = value;
            }
        }     
    }
}
