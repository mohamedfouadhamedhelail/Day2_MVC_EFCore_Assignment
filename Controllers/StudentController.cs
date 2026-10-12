using Day2_MVC_EFCore_Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day2_MVC_EFCore_Assignment.Controllers
{
  public class StudentController : Controller
  {
    private readonly SchoolDbContext _context;

    public StudentController(SchoolDbContext context)
    {
      _context = context;
    }

    public IActionResult ShowAll()
    {
      var students = _context.Students
          .Include(s => s.Department)
          .ToList();

      return View(students);
    }

    public IActionResult ShowDetails(int id)
    {
      var student = _context.Students
          .Include(s => s.Department)
          .FirstOrDefault(s => s.Id == id);

      if (student == null)
      {
        return NotFound();
      }

      return View(student);
    }
  }
}
