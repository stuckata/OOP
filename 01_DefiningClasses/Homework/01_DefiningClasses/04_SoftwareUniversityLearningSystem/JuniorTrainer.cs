using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftwareUniversityLearningSystem
{
    public class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string firstName, string lastName, int age)
            : base(firstName, lastName, age)
        {
        }

        public override string ToString()
        {
            return String.Format("Junior {0}", base.ToString());
        }
    }
}
