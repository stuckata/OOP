using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Models;
using _04_CompanyHierarchy.Enumerations;

namespace _04_CompanyHierarchy
{
    class CompanyHierarchyTest
    {
        static void Main(string[] args)
        {
            string separator = "===============================================================================";

            List<Sale> sales = new List<Sale>()
            {
                new Sale("My Grandmother's vacuum cleaner", new DateTime(1/1/2015), 150m),
                new Sale("The best laptop you could buy", new DateTime(9/24/2014), 150m),
                new Sale("The TV you should watch", new DateTime(6/13/2013), 150m),
            };

            List<Project> projects = new List<Project>()
            {
                new Project("SoftUni Homework", new DateTime(1/30/2015), "Not Ready Yet", StateType.State.Open),
                new Project("Open Source OS", new DateTime(9/10/2014), "New Linux based OS", StateType.State.Open),
                new Project("Android Media Player", new DateTime(04/1/2013), "Media Player for Android", StateType.State.Closed),
            };

            List<Employee> employeesOfSasho = new List<Employee>()
            {
                new SalesEmployee("SHK789", "Gosho", "Borisov", 1000m, DepartmentType.Department.Sales, sales),
                new Developer("DGJ456", "Bill", "Gates", 1500m, DepartmentType.Department.Production, projects),
                new Developer("DGG123", "Smell", "Gipsov", 1350m, DepartmentType.Department.Production, projects),
                new SalesEmployee("SHY482", "Brumo", "Gyzov", 1120m, DepartmentType.Department.Sales, sales),
            };

            List<Employee> employees = new List<Employee>()
            {
                new Manager("FGH123", "Sasho", "Petkov", 2000m, DepartmentType.Department.Accounting, employeesOfSasho),
                new SalesEmployee("SHK789", "Gosho", "Borisov", 1000m, DepartmentType.Department.Sales, sales),
                new Developer("DGJ456", "Bill", "Gates", 1500m, DepartmentType.Department.Production, projects),
                new Developer("DGG123", "Smell", "Gipsov", 1350m, DepartmentType.Department.Production, projects),
                new SalesEmployee("SHY482", "Brumo", "Gyzov", 1120m, DepartmentType.Department.Sales, sales),
            };

            foreach (var employee in employees)
            {
                Console.WriteLine(separator);
                Console.WriteLine(employee);
                Console.WriteLine(separator);
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}
