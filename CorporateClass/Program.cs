using System;
using System.Collections.Generic;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var poo = new Company("Poo", new DateTime(1990, 3, 9));
            Employees jo = new Employees();
            jo.Name = "Jo";
            jo.JobTitle = "Teller";
            jo.StartDate = DateTime.Today;

            List<Employees> Employees = new List<Employees>();
            Employees.Add(jo);

            Employees.Add(
                new Employees()
                {
                    Name = "Scarlett",
                    JobTitle = "VP",
                    StartDate = new DateTime(1990, 2, 3)
                }
            );

            Employees.Add(
                new Employees()
                {
                    Name = "Co",
                    JobTitle = "Secretary",
                    StartDate = new DateTime(2020, 2, 3)
                }
            );
        }
    }
}
