using System.Data.Entity;

public class StudentContext : DbContext
{
    // Constructor to ensure it uses the connection string defined in App.config
    public StudentContext() : base("name=StudentContext")
    {
    }

    public DbSet<Student> Students { get; set; }  // Table for Student
}
