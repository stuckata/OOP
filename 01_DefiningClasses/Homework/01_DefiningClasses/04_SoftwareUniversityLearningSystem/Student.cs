using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftwareUniversityLearningSystem
{
    public class Student : Person
    {
        private string studentNumber;
        private string averageGrade;

        public Student(string firstName, string lastName, int age, string studentNumber, string averageGrade)
            : base(firstName, lastName, age)
        {
            this.StudentNumber = studentNumber;
            this.AverageGrade = averageGrade;
        }

        public string StudentNumber
        {
            get
            {
                return this.studentNumber;
            }
            set
            {
                this.studentNumber = value;
            }
        }

        public string AverageGrade
        {
            get
            {
                return this.averageGrade;
            }
            set
            {
                this.averageGrade = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Student: {0}; Student Number: {1}; Average Grade: {2}", 
                base.ToString(), this.StudentNumber, this.AverageGrade);
        }
    }
}
