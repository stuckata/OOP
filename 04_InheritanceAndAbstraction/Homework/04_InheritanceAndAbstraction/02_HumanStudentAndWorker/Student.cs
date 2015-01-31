using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_HumanStudentAndWorker
{
    class Student : Human
    {
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
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

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string separator = "==============================================================";
            string studentData = String.Format("Student: {0}; {1}", base.ToString(), this.FacultyNumber);
            result.AppendLine(studentData);
            result.AppendLine(separator);
            return result.ToString();
        }
    }
}
