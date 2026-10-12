namespace Day2_MVC_EFCore_Assignment.Models
{
  public class Teacher
  {
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Salary { get; set; }

    public string Address { get; set; } = string.Empty;

    // Foreign Keys
    public int CourseId { get; set; }

    public int DepartmentId { get; set; }

    // Navigation Properties
    public Course Course { get; set; } = null!;

    public Department Department { get; set; } = null!;
  }
}
