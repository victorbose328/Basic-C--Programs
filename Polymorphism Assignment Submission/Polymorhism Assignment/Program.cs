using System;

namespace PolymorphismAssignment
{
    // Define the IQuittable interface with a void method called Quit().
    // This interface can be implemented by any class that needs the Quit behavior.
    public interface IQuittable
    {
        void Quit();  // Method signature to be implemented by classes that use this interface.
    }
}

namespace PolymorphismAssignment
{
    // Define the Person class with FirstName and LastName properties and a SayName method.
    public class Person
    {
        // Properties to hold the first and last names of the person.
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to display the person's full name.
        public virtual void SayName()
        {
            Console.WriteLine($"Name: {this.FirstName} {this.LastName}");
        }
    }
}

namespace PolymorphismAssignment
{
    // Employee class inherits from Person and implements the IQuittable interface.
    public class Employee : Person, IQuittable
    {
        // Implementing the SayName() method from the Person class.
        public override void SayName()
        {
            // Displaying the full name of the employee.
            Console.WriteLine($"Name: {this.FirstName} {this.LastName}");
        }

        // Implementing the Quit() method from the IQuittable interface.
        // This method simulates the employee quitting their job by displaying a message.
        public void Quit()
        {
            // Simple message indicating that the employee has quit.
            Console.WriteLine($"{this.FirstName} {this.LastName} has quit the job.");
        }
    }
}

namespace PolymorphismAssignment
{
    // Main class containing the entry point of the program.
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object and set first name and last name.
            Employee sam = new Employee { FirstName = "Sample", LastName = "Student" };

            // Using polymorphism to create an IQuittable object and assign the Employee object to it.
            // The Employee class implements the IQuittable interface, so this is valid.
            IQuittable quitter = sam;

            // Call the Quit() method on the IQuittable object, which will execute the method defined in the Employee class.
            quitter.Quit();

            // Pause the console to allow the user to see the output.
            Console.ReadLine();
        }
    }
}
