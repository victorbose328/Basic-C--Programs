using System;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        //Create a class called Person and give it two properties, each of data type string
        //One called FirstName, the other LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Give the class a void method called SayName() that takes no parameters and simply writes
        //the person's full name to the console in the format of: "Name: [full name]"
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}

namespace MethodsAndObjectsAssignment
{
    //Create another class called Employee and have it inherit from the Person class
    public class Employee : Person
    {
        //Give the Employee class a property called Id and have it be of data type int
        public int Id { get; set; }
    }
}

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside of the Main method, instantiate and initialize an Employee object with
            //the first name "Sample" and the last name "Student"
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };

            //Call the superclass method SayName() on the Employee object
            sam.SayName();

            Console.ReadLine();
        }
    }
}
