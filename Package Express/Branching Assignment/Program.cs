using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            // Display the welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask for the package weight and store the input in a variable
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the weight is greater than 50
            if (weight > 50)
            {
                // Display an error message and terminate the program if weight is too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program
            }

            // Ask for the package dimensions (width, height, and length)
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Check if the total dimensions (width + height + length) exceed 50
            if ((width + height + length) > 50)
            {
                // Display an error message and terminate the program if dimensions are too big
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program
            }

            // Calculate the shipping quote: (width * height * length * weight) / 100
            double quote = (width * height * length * weight) / 100;

            // Display the shipping quote to the user
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

            // Thank the user for using Package Express
            Console.WriteLine("Thank you!");
        }
    }
}
