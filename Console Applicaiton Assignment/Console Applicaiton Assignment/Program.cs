using System;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main()
        {
            // Step 1: Multiply input by 50 and print the result
            Console.Write("Enter a number: ");
            // Read the user's input and store it in a variable
            double userInput1 = Convert.ToDouble(Console.ReadLine());
            // Multiply the input by 50
            double result1 = userInput1 * 50;
            // Print the result to the console
            Console.WriteLine("Result of multiplying by 50: " + result1);

            // Step 2: Add 25 to the input and print the result
            Console.Write("Enter another number: ");
            // Read the user's second input and store it
            double userInput2 = Convert.ToDouble(Console.ReadLine());
            // Add 25 to the second input
            double result2 = userInput2 + 25;
            // Print the result to the console
            Console.WriteLine("Result of adding 25: " + result2);

            // Step 3: Divide input by 12.5 and print the result
            Console.Write("Enter a number to divide by 12.5: ");
            // Read the user's third input
            double userInput3 = Convert.ToDouble(Console.ReadLine());
            // Divide the input by 12.5
            double result3 = userInput3 / 12.5;
            // Print the result to the console
            Console.WriteLine("Result of dividing by 12.5: " + result3);

            // Step 4: Check if input is greater than 50 and print true/false
            Console.Write("Enter a number to check if it's greater than 50: ");
            // Read the user's fourth input
            double userInput4 = Convert.ToDouble(Console.ReadLine());
            // Check if the input is greater than 50
            bool isGreaterThan50 = userInput4 > 50;
            // Print the true/false result
            Console.WriteLine("Is the number greater than 50? " + isGreaterThan50);

            // Step 5: Divide input by 7 and print the remainder
            Console.Write("Enter a number to find the remainder when divided by 7: ");
            // Read the user's fifth input
            double userInput5 = Convert.ToDouble(Console.ReadLine());
            // Calculate the remainder using the modulus operator
            double remainder = userInput5 % 7;
            // Print the remainder to the console
            Console.WriteLine("Remainder when divided by 7: " + remainder);

            // End of the program
            Console.WriteLine("Thank you for using the console application.");
        }
    }
}
