using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
        {
            // Print the name of the institution
            Console.WriteLine("Academy of Learning Career College");

            // Print the title of the report
            Console.WriteLine("Student Daily Report");

            // Ask for the student's name and store the answer in a variable
            Console.Write("What is your name? ");
            string studentName = Console.ReadLine(); // This stores the student's name as a string

            // Ask which course the student is enrolled in and store the answer
            Console.Write("What course are you on? ");
            string courseName = Console.ReadLine(); // This stores the course name as a string

            // Ask for the current page number in the course material
            Console.Write("What page number? ");
            int pageNumber = int.Parse(Console.ReadLine()); // This stores the page number as an integer

            // Ask if the student needs help and store the answer (true/false)
            Console.Write("Do you need help with anything? Please answer 'true' or 'false': ");
            bool needsHelp = bool.Parse(Console.ReadLine()); // This stores a boolean value (true or false)

            // Ask for any positive experiences the student wants to share
            Console.Write("Were there any positive experiences you’d like to share? Please give specifics: ");
            string positiveExperience = Console.ReadLine(); // This stores the positive experience as a string

            // Ask for additional feedback from the student
            Console.Write("Is there any other feedback you’d like to provide? Please be specific: ");
            string additionalFeedback = Console.ReadLine(); // This stores any additional feedback as a string

            // Ask how many hours the student studied that day
            Console.Write("How many hours did you study today? ");
            double studyHours = double.Parse(Console.ReadLine()); // This stores the study hours as a double (allows for decimals)

            // Thank the student and display the end message
            Console.WriteLine("Thank you for your answers. An Instructor will respond shortly. Have a great day!");

        }
    }
}
