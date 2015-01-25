using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftwareUniversityLearningSystem
{
    public class OnsiteStudent : CurrentSudent
    {
        private int numberOfVisits;

        public OnsiteStudent(string firstName, string lastName, int age, string studentNumber, string averageGrade,
            string currentCourse, int numberOfVisits)
            : base(firstName, lastName, age, studentNumber, averageGrade, currentCourse)
        {
            this.NumberOfVisits = numberOfVisits;
        }

        public int NumberOfVisits
        {
            get
            {
                return this.numberOfVisits;
            }
            set
            {
                this.numberOfVisits = value;
            }
        }

        public override string ToString()
        {
            return String.Format("{0}; Number of Visits: {1}", base.ToString(), this.CurrentCourse);
        }
    }
}
