namespace Day2_MVC_EFCore_Assignment.Models
{
  public class Student
  {
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Age { get; set; }

    // Foreign Key
    public int DepartmentId { get; set; }

    // Navigation Properties
    public Department Department { get; set; } = null!;

    public ICollection<StuCrsRes> StuCrsResults { get; set; } = new List<StuCrsRes>();
  }
}
