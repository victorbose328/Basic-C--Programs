using System;

namespace OperatorsAssignment
{
    // Define the Employee class with Id, FirstName, and LastName properties.
    public class Employee
    {
        // Property for the Employee's Id.
        public int Id { get; set; }

        // Property for the Employee's First Name.
        public string FirstName { get; set; }

        // Property for the Employee's Last Name.
        public string LastName { get; set; }

        // Overload the "==" operator to compare two Employee objects based on their Id property.
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Return true if both Employee objects have the same Id.
            return emp1.Id == emp2.Id;
        }

        // Overload the "!=" operator to compare two Employee objects based on their Id property.
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return true if the Employee objects have different Ids.
            return emp1.Id != emp2.Id;
        }

        // Override the Equals method to ensure consistency with "==" and "!=" operators.
        public override bool Equals(object obj)
        {
            // Check if the obj is an Employee, then compare the Id properties.
            return obj is Employee employee && this.Id == employee.Id;
        }

        // Override the GetHashCode method to maintain the consistency with the Equals method.
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties.
            Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee employee2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded "==" operator.
            if (employee1 == employee2)
            {
                // If the Ids are equal, display this message.
                Console.WriteLine("Both employees have the same Id.");
            }
            else
            {
                // If the Ids are not equal, display this message.
                Console.WriteLine("The employees have different Ids.");
            }

            // Instantiate a third Employee object with the same Id as the first one.
            Employee employee3 = new Employee { Id = 1, FirstName = "Mike", LastName = "Johnson" };

            // Compare the first and third Employee objects using the overloaded "==" operator.
            if (employee1 == employee3)
            {
                // If the Ids are equal, display this message.
                Console.WriteLine("Both employees have the same Id.");
            }
            else
            {
                // If the Ids are not equal, display this message.
                Console.WriteLine("The employees have different Ids.");
            }

            // Pause the console to allow the user to see the output.
            Console.ReadLine();
        }
    }
}
