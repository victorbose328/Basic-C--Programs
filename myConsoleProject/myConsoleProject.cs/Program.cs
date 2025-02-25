using System;  // Keep only the System namespace

namespace myConsoleProject  // Define the namespace matching your project name
{
    class Program  // Define the main class
    {
        static void Main()  // Define the Main method
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.Read();
        }
    }
}
