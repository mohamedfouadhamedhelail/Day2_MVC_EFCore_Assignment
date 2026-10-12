using Microsoft.EntityFrameworkCore;
using Day2_MVC_EFCore_Assignment.Models;

namespace Day2_MVC_EFCore_Assignment.Data
{
  public class SchoolDbContext : DbContext
  {
    public SchoolDbContext(DbContextOptions<SchoolDbContext> options)
        : base(options)
    {
    }

    public DbSet<Department> Departments { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<StuCrsRes> StuCrsResults { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      // Teacher Salary
      modelBuilder.Entity<Teacher>()
          .Property(t => t.Salary)
          .HasColumnType("decimal(18,2)");

      // Department - Student
      modelBuilder.Entity<Student>()
          .HasOne(s => s.Department)
          .WithMany(d => d.Students)
          .HasForeignKey(s => s.DepartmentId);

      // Department - Course
      modelBuilder.Entity<Course>()
          .HasOne(c => c.Department)
          .WithMany(d => d.Courses)
          .HasForeignKey(c => c.DepartmentId);

      // Department - Teacher
      modelBuilder.Entity<Teacher>()
          .HasOne(t => t.Department)
          .WithMany(d => d.Teachers)
          .HasForeignKey(t => t.DepartmentId)
          .OnDelete(DeleteBehavior.NoAction);

      // Course - Teacher
      modelBuilder.Entity<Teacher>()
          .HasOne(t => t.Course)
          .WithMany(c => c.Teachers)
          .HasForeignKey(t => t.CourseId);

      // Student - Course Results
      modelBuilder.Entity<StuCrsRes>()
          .HasKey(x => new { x.StudentId, x.CourseId });

      modelBuilder.Entity<StuCrsRes>()
          .HasOne(r => r.Student)
          .WithMany(s => s.StuCrsResults)
          .HasForeignKey(r => r.StudentId)
          .OnDelete(DeleteBehavior.NoAction); // التعديل الأول

      modelBuilder.Entity<StuCrsRes>()
          .HasOne(r => r.Course)
          .WithMany(c => c.StuCrsResults)
          .HasForeignKey(r => r.CourseId)
          .OnDelete(DeleteBehavior.NoAction); // التعديل الثاني
    }
  }
}
