﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_HumanStudentAndWorker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;
        public decimal PaymentPerHour;

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.PaymentPerHour = MoneyPerHour(this.WeekSalary, this.WorkHoursPerDay);
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour(decimal weekSalary, decimal workHoursPerDay)
        {
            decimal moneyPerHour = (weekSalary / 5) / workHoursPerDay;
            return moneyPerHour;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string separator = "===============================================================================";
            string workerData = String.Format("Worker: {0}; Payment Per Hour: ${1}", base.ToString(), this.PaymentPerHour);
            result.AppendLine(workerData);
            result.AppendLine(separator);
            return result.ToString();
        }
    }
}
