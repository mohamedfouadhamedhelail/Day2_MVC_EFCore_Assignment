namespace Day2_MVC_EFCore_Assignment.Models
{
  public class Course
  {
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public int Degree { get; set; }

    public int MinDegree { get; set; }

    // Foreign Key
    public int DepartmentId { get; set; }

    // Navigation Properties
    public Department Department { get; set; } = null!;

    public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();

    public ICollection<StuCrsRes> StuCrsResults { get; set; } = new List<StuCrsRes>();
  }
}
