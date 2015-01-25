﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftwareUniversityLearningSystem
{
    public class DropoutStudent : Student
    {
        private string dropoutReason;

        public DropoutStudent(string firstName, string lastName, int age, string studentNumber, decimal averageGrade, 
            string dropoutReason)
                : base(firstName, lastName, age, studentNumber, averageGrade)
        {
            this.DropoutReason = dropoutReason;
        }

        public string DropoutReason
        {
            get
            {
                return this.dropoutReason;
            }
            set
            {
                this.dropoutReason = value;
            }
        }

        public string Reaply()
        {
            return ToString();
        }

        public override string ToString()
        {
            return String.Format("Dropout {0}; Dropout Reason: {1}",
                base.ToString(),this.DropoutReason);
        }
    }
}
