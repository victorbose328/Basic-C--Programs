using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Part 1: Create a list of integers
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

        // Ask the user for a number to divide by
        Console.Write("Enter a number to divide each number in the list by: ");
        string userInput = Console.ReadLine();

        try
        {
            // Convert user input to an integer
            int divisor = int.Parse(userInput);

            // Check for division by zero
            if (divisor == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }

            // Loop through the list and divide each number by the user's input
            Console.WriteLine("\nResults:");
            foreach (int num in numbers)
            {
                Console.WriteLine($"{num} / {divisor} = {num / divisor}");
            }
        }
        catch (FormatException ex)
        {
            // Catch non-numeric input errors
            Console.WriteLine("Error: Invalid input. Please enter a numeric value.");
            Console.WriteLine($"Details: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            // Catch division by zero errors
            Console.WriteLine("Error: Cannot divide by zero.");
            Console.WriteLine($"Details: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Catch any other unexpected errors
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Details: {ex.Message}");
        }
        finally
        {
            // Message to indicate program execution continues
            Console.WriteLine("\nProgram has exited the try/catch block and is continuing execution.");
        }
    }
}
