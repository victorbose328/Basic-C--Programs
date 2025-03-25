using System;

namespace StructsAssignment
{
    // Define a struct called 'Number' with a property 'Amount' of type decimal
    public struct Number
    {
        // The 'Amount' property holds the value of type decimal
        public decimal Amount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of data type 'Number' and assign a value to the 'Amount' property
            Number numberInstance = new Number();
            numberInstance.Amount = 100.50m; // Assign a decimal value to the Amount property

            // Print the value of 'Amount' to the console
            Console.WriteLine("The amount is: " + numberInstance.Amount);

            // Pause the console to allow the user to view the output
            Console.ReadLine();
        }
    }
}
