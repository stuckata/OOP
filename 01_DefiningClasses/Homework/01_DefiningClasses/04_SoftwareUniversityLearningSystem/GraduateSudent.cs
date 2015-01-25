using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftwareUniversityLearningSystem
{
    public class GraduateSudent : Student
    {
        public GraduateSudent(string firstName, string lastName, int age, string studentNumber, decimal averageGrade)
            : base(firstName, lastName, age, studentNumber, averageGrade)
        {
        }

        public override string ToString()
        {
            return String.Format("Graduate " + base.ToString());
        }
    }
}
