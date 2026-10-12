namespace Day2_MVC_EFCore_Assignment.Models
{
  public class StuCrsRes
  {
    // Composite Primary Key
    public int StudentId { get; set; }

    public int CourseId { get; set; }

    public int Grade { get; set; }

    // Navigation Properties
    public Student Student { get; set; } = null!;

    public Course Course { get; set; } = null!;
  }
}
