using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftwareUniversityLearningSystem
{
    public class OnlineStudent : CurrentSudent
    {
        public OnlineStudent(string firstName, string lastName, int age, string studentNumber, decimal averageGrade,
            string currentCourse)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
        }

        public override string ToString()
        {
            return String.Format("Online " + base.ToString());
        }
    }
}
