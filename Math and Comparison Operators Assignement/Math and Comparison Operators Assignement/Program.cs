using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine();
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;
            Console.WriteLine("Annual Salary of Person 1:");
            Console.WriteLine(salary1);
            Console.WriteLine("Annual Salary of Person 2:");
            Console.WriteLine(salary2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = salary1 > salary2;
            Console.WriteLine(isMore);
            Console.ReadLine();

        }
    }
}
