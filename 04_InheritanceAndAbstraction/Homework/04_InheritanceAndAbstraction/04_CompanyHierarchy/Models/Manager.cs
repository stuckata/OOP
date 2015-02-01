﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;
using _04_CompanyHierarchy.Enumerations;
using _04_CompanyHierarchy.Models;

namespace _04_CompanyHierarchy.Models
{
    class Manager : Employee, IManager
    {
        private List<Employee> employees;

        public Manager(string id, string firstName, string lastName, decimal salary,
            DepartmentType.Department department, List<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
            this.Employees = employees;
        }

        public List<Employee> Employees
        {
            get
            {
                return this.employees;
            }
            set
            {
                this.employees = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string separator = "************************************************************";
            string separator2 = "------------------------------------------------------------";
            result.AppendLine(base.ToString());
            string employeePosition = String.Format("***Manager*** Employees:");
            result.AppendLine(employeePosition);
            result.AppendLine(separator);

            foreach (var employee in this.Employees)
            {
                result.AppendLine(separator2);
                result.AppendLine(employee.ToString());
                result.AppendLine(separator2);
            }
            return result.ToString();
        }
    }
}
