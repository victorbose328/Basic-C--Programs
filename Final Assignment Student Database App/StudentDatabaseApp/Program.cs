using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create the database if it doesn't exist
        using (var context = new StudentContext())
        {
            // Automatically create the database if it doesn't exist (based on the model)
            context.Database.Initialize(force: false);

            // Check if there's already a student, to avoid adding duplicates
            if (!context.Students.Any())
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(1998, 5, 23)
                };

                // Add the student to the context
                context.Students.Add(student);

                // Save changes to the database
                context.SaveChanges();

                Console.WriteLine("Student added to the database.");
            }
            else
            {
                Console.WriteLine("Student already exists in the database.");
            }
        }

        Console.ReadLine();  // Pause to see the message
    }
}
