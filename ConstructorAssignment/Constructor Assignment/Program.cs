using System;  // Ensure this is at the very top of the file

namespace ConstructorAssignment
{
    public class Chain
    {
        // Constructor that takes a float and calls the constructor with both a float and a string
        public Chain(float num1) : this(num1, "Bob")  // Chaining constructor, default name is "Bob"
        {
            // Output the number and default name when this constructor is called
            Console.WriteLine(num1 + " and your default name is " + Name);
        }

        // Constructor that takes a string and a float as parameters
        public Chain(float num, string name)  // Chaining constructor to handle both parameters
        {
            // Assign the passed values to the properties
            Name = name;
            Num = num;
        }

        // Properties to hold the name and number
        public string Name { get; set; }
        public float Num { get; set; }
    }
}


namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create two constants
            const string const1 = "Your name is: ";
            const string const2 = "Your favorite number is: ";

            // Ask the user to enter a name or a number
            Console.WriteLine("Enter your name or favorite number");

            // Create a variable using the 'var' keyword, which will infer the type of the variable
            var answer = Console.ReadLine();

            // Check if the input is a valid float (for favorite number)
            if (float.TryParse(answer, out float x))
            {
                // If it is a number, create a Chain object using the number and print a message
                Console.WriteLine(const2);
                Chain newChain = new Chain(x);  // Chain object is created using the number
            }
            else
            {
                // If it's not a number, create a Chain object using the name input
                Console.WriteLine(const1 + answer);
                Chain newChain = new Chain(42);  // Using default number (42) with provided name
            }

            Console.ReadLine();  // Pause the console to let the user see the result
        }
    }
}
