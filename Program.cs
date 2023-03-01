using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company myCompany = new Company("Acme, Inc", DateTime.Now);
            // Create three employees
            Employee joey = new Employee
            {
                FirstName = "Joey",
                LastName = "Tribbiani",
                Title = "Chief Medical Officer",
                StartDate = DateTime.Now
            };
            Employee chandler = new Employee
            {
                FirstName = "Chandler",
                LastName = "Bing",
                Title = "IT Procurements Manager",
                StartDate = DateTime.Now
            };
            Employee rachael = new Employee
            {
                FirstName = "Rachael",
                LastName = "Green",
                Title = "Chief Fashion Office",
                StartDate = DateTime.Now
            };
            // Assign the employees to the company
            myCompany.Employees.Add(joey);
            myCompany.Employees.Add(chandler);
            myCompany.Employees.Add(rachael);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            myCompany.ListEmployees();
        }
    }
}