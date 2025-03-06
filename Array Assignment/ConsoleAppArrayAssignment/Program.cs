using System;
using System.Collections.Generic;

namespace ConsoleAppArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array of Strings
            string[] fruitArray = { "Apple", "Grapes", "Pear", "Strawberry", "Orange", "Pineapple", "Watermelon", "Banana", "Cherry", "Mango" };
            Console.WriteLine("Select a number between 0 to 9:");
            int stringSelect;
            bool validString = false;

            while (!validString)
            {
                try
                {
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your favorite fruit is " + fruitArray[stringSelect]);
                    validString = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, that fruit selection is invalid. Please select a number between 0 and 9.");
                }
            }

            // List of Strings
            List<string> toolList = new List<string>
            {
                "Hammer",
                "Screwdriver",
                "Saw",
                "Pliers",
                "Chisel",
                "File",
                "Wrench",
                "Tape Measure",
                "Level",
                "Drill"
            };
            Console.WriteLine("\nSelect another number between 0 to 9:");
            int listSelect;
            bool validList = false;

            while (!validList)
            {
                try
                {
                    listSelect = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your new tool is: " + toolList[listSelect]);
                    validList = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Select a number between 0 and 9.");
                }
            }

            // Array of Integers
            int[] intArray = { 17, 22, 3, 67, 5, 91, 11, 42, 23, 6 };
            Console.WriteLine("\nSelect a third number between 0 and 9:");
            int intSelect;
            bool validInt = false;

            while (!validInt)
            {
                try
                {
                    intSelect = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Your lucky number is " + intArray[intSelect]);
                    validInt = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Select a number between 0 and 9.");
                }
            }
        }
    }
}

