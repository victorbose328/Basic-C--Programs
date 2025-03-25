using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the current date and time to the console
            Console.WriteLine("Current Date and Time: " + DateTime.Now);

            // Ask the user for a number (representing hours)
            Console.WriteLine("Please enter a number of hours:");

            // Read the input from the user (it will be a string)
            string userInput = Console.ReadLine();

            // Try to convert the user's input to an integer
            if (int.TryParse(userInput, out int hoursToAdd))
            {
                // If the input is a valid integer, calculate the new time by adding the specified number of hours
                DateTime newTime = DateTime.Now.AddHours(hoursToAdd);

                // Print the new time (current time + the entered number of hours)
                Console.WriteLine($"In {hoursToAdd} hours, it will be: {newTime}");
            }
            else
            {
                // If the input is not a valid integer, print an error message
                Console.WriteLine("Please enter a valid number.");
            }

            // Wait for the user to press a key before closing the application
            Console.ReadLine();
        }
    }
}
