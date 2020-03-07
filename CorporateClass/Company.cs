using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass
{
    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a private property for holding an array of current employees       
        // Create a method that allows a caller to add an employee

        // Create a method that allows a caller to remove an employee

        // Create a method that allows a caller to retrieve the list of employees

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public List<Employees> employees { get; set; }
        public Company(string name, DateTime dateTime)
        {
            Name = name;
            CreatedOn = dateTime;
        }
    }

}
