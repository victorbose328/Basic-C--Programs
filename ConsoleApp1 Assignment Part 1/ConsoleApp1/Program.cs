using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Part 1: Initialize a one-dimensional array of strings
        string[] words = { "Hello", "Welcome", "Goodbye", "Thank you" };

        // Ask the user for input
        Console.Write("Enter some text to append: ");
        string userInput = Console.ReadLine();

        // First loop: Append user input to each string in the array
        for (int i = 0; i < words.Length; i++)
        {
            words[i] += " " + userInput;
        }

        // Part 2: Loop using '<' operator
        Console.WriteLine("\nLoop with '<' operator:");
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine(words[i]);
        }

        // Part 3: Infinite loop with an exit condition
        while (true)
        {
            Console.Write("Type 'exit' to stop or press Enter to continue: ");
            string exitCommand = Console.ReadLine();

            // Fixing infinite loop: Allow user to exit
            if (exitCommand.ToLower() == "exit")
            {
                break; // Exit the loop
            }
        }

        // Part 4: Loop using '<=' operator
        Console.WriteLine("\nLoop with '<=' operator:");
        for (int i = 0; i <= words.Length - 1; i++) // Using '<=' correctly
        {
            Console.WriteLine(words[i]);
        }

        // Part 5: Initialize a list with duplicate strings
        List<string> duplicateWords = new List<string> { "Apple", "Banana", "Cherry", "Banana", "Date", "Apple" };

        // Ask the user for input to search in the list
        Console.Write("\nEnter text to search for: ");
        string searchText = Console.ReadLine();

        // Search loop to find all indices of the matching text
        bool found = false;
        for (int i = 0; i < duplicateWords.Count; i++)
        {
            if (duplicateWords[i].IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"Match found at index {i}: {duplicateWords[i]}");
                found = true;
            }
        }

        // Inform user if no match is found
        if (!found)
        {
            Console.WriteLine("Input text not found in the list.");
        }

        // Part 6: Track occurrences of each string and check for duplicates
        HashSet<string> seenItems = new HashSet<string>();

        // Iterate through the list and display whether each item is unique or a duplicate
        Console.WriteLine("\nChecking for duplicates:");
        foreach (string item in duplicateWords)
        {
            if (seenItems.Contains(item))
            {
                Console.WriteLine($"{item} - this item is a duplicate");
            }
            else
            {
                Console.WriteLine($"{item} - this item is unique");
                seenItems.Add(item); // Mark as seen
            }
        }
    }
}
