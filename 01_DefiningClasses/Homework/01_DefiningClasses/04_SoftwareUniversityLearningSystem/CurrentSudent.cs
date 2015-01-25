using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftwareUniversityLearningSystem
{
    public class CurrentSudent : Student
    {
        private string currentCourse;

        public CurrentSudent(string firstName, string lastName, int age, string studentNumber, string averageGrade, 
            string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.CurrentCourse = currentCourse;
        }

        public string CurrentCourse
        {
            get
            {
                return this.currentCourse;
            }
            set
            {
                this.currentCourse = value;
            }
        }
    }
}
