using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAssignment
{
    // Employee class with properties: Id, FirstName, and LastName
    public class Employee
    {
        public int Id { get; set; }         // Employee ID
        public string FirstName { get; set; } // Employee's first name
        public string LastName { get; set; }  // Employee's last name
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Employee objects
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
                new Employee { Id = 2, FirstName = "Alice", LastName = "Johnson" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Williams" },
                new Employee { Id = 4, FirstName = "Bob", LastName = "Brown" },
                new Employee { Id = 5, FirstName = "Jane", LastName = "Davis" },
                new Employee { Id = 6, FirstName = "Sue", LastName = "Moore" },
                new Employee { Id = 7, FirstName = "Charlie", LastName = "Taylor" },
                new Employee { Id = 8, FirstName = "Joe", LastName = "Martin" },
                new Employee { Id = 9, FirstName = "Emily", LastName = "Clark" },
                new Employee { Id = 10, FirstName = "David", LastName = "Lewis" }
            };

            // List employees with the first name "Joe" using a foreach loop
            List<Employee> employeesWithJoe = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")  // Compare the FirstName property
                {
                    employeesWithJoe.Add(employee);  // Add employee to the new list if first name is "Joe"
                }
            }

            // Print the employees with the first name "Joe" using foreach
            Console.WriteLine("Employees with first name 'Joe' using foreach loop:");
            foreach (var emp in employeesWithJoe)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            // List employees with the first name "Joe" using a lambda expression
            var employeesWithJoeLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            // Print the employees with the first name "Joe" using lambda expression
            Console.WriteLine("\nEmployees with first name 'Joe' using lambda expression:");
            foreach (var emp in employeesWithJoeLambda)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            // List employees with Id greater than 5 using a lambda expression
            var employeesWithIdGreaterThan5 = employees.Where(e => e.Id > 5).ToList();

            // Print the employees with Id greater than 5 using lambda expression
            Console.WriteLine("\nEmployees with Id greater than 5:");
            foreach (var emp in employeesWithIdGreaterThan5)
            {
                Console.WriteLine($"Id: {emp.Id}, Name: {emp.FirstName} {emp.LastName}");
            }

            // Pause the console to view the output
            Console.ReadLine();
        }
    }
}
