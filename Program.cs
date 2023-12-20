using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main()
        {
            // Create an instance of the Employee class
            Employee employee = new Employee("Adrianna", "Matuszak");

            // Display employee information
            Console.WriteLine("Employee information before quitting:");
            employee.SayName();

            // Use polymorphism to create an object of type IQuittable
            // and call the Quit() method on it
            IQuittable quittableEmployee = employee;
            quittableEmployee.Quit();

            // Display employee information after quitting
            Console.WriteLine("Employee information after quitting:");
            employee.SayName();

            // Keeping the console window open
            Console.ReadLine();
        }
    }
}
