using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;
using _04_CompanyHierarchy.Enumerations;
using _04_CompanyHierarchy.Models;

namespace _04_CompanyHierarchy.Models
{
    class SalesEmployee : RegularEmployee, ISalesEmployee
    {
        private List<Sale> sales;

        public SalesEmployee(string id, string firstName, string lastName, decimal salary,
            DepartmentType.Department department, List<Sale> sales)
                : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales
        {
            get
            {
                return this.sales;
            }
            set
            {
                this.sales = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string separator = "------------------------------------------------------------";
            result.AppendLine(base.ToString());
            string employeePosition = String.Format("***Sales Employee*** Sales:");
            result.AppendLine(employeePosition);
            result.AppendLine(separator);

            foreach (var sale in this.Sales)
            {
                result.AppendLine(sale.ToString());
            }
            return result.ToString();
        }
    }
}
