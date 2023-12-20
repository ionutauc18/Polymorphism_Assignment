using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Employee class implementing the IQuittable interface
    class Employee : IQuittable
    {
        // Properties of the Employee class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor for the Employee class
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Method to display employee information
        public void SayName()
        {
            Console.WriteLine("Employee Name: " + FirstName + " " + LastName);
        }

        // Implement the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine(FirstName + " " + LastName + " is quitting...");
        }
    }
}
