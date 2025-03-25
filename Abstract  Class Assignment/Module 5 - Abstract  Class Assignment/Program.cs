using System;

namespace AbstractClassesAssignment
{
    // Abstract class to ensure that it cannot be instantiated directly.
    // This class will define common properties and behavior for derived classes.
    public abstract class Person
    {
        // Properties to store the first name and last name of the person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Abstract method SayName() that will be implemented by any class inheriting from Person
        public abstract void SayName();
    }
}

namespace AbstractClassesAssignment
{
    // Employee class inherits from the Person class.
    // This class must implement the SayName() method, as it's abstract in the base class.
    public class Employee : Person
    {
        // Implementing the SayName() method for the Employee class.
        // This method will display the full name of the employee.
        public override void SayName()
        {
            // Using string interpolation for better readability and performance.
            Console.WriteLine($"Name: {this.FirstName} {this.LastName}");
        }
    }
}

namespace AbstractClassesAssignment
{
    // Main class containing the entry point of the program.
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with the first name "Sample" and last name "Student".
            // This initializes the Employee object using object initializers.
            Employee sam = new Employee { FirstName = "Sample", LastName = "Student" };

            // Call the SayName() method to display the full name of the employee.
            sam.SayName();

            // Pause the console to allow the user to see the output.
            Console.ReadLine();
        }
    }
}
