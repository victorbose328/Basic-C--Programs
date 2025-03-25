using System;

namespace ParsingEnumsAssignment
{
    // Define an enum for the days of the week
    public enum DaysOfWeek
    {
        Sunday,    // Enum value for Sunday
        Monday,    // Enum value for Monday
        Tuesday,   // Enum value for Tuesday
        Wednesday, // Enum value for Wednesday
        Thursday,  // Enum value for Thursday
        Friday,    // Enum value for Friday
        Saturday   // Enum value for Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user to input the current day of the week
            Console.WriteLine("Please enter the current day of the week (e.g., Monday, Tuesday):");

            // Read the user input as a string
            string userInput = Console.ReadLine();

            // Initialize a variable of type DaysOfWeek to store the parsed enum value
            DaysOfWeek day;

            try
            {
                // Attempt to parse the user input string to the DaysOfWeek enum
                // If the input matches one of the enum values, it will be assigned to the 'day' variable
                day = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput, true); // 'true' allows case-insensitive parsing

                // If successful, print the valid enum value
                Console.WriteLine("You entered: " + day);
            }
            catch (ArgumentException)
            {
                // If an error occurs (e.g., invalid day name), catch the exception and print an error message
                Console.WriteLine("Please enter an actual day of the week.");
            }

            // Pause to keep the console window open and allow the user to see the output
            Console.ReadLine();
        }
    }
}
