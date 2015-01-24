using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftwareUniversityLearningSystem
{
    public class Student : Person
    {
        private string currentCurse;
        private string averageGrade;

        public Student(string firstName, string lastName, int age, string currentCurse, string averageGrade)
            : base(firstName, lastName, age)
        {
            this.CurrentCurse = currentCurse;
            this.AverageGrade = averageGrade;
        }

        public string CurrentCurse
        {
            get
            {
                return this.currentCurse;
            }
            set
            {
                this.currentCurse = value;
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
    }
}
