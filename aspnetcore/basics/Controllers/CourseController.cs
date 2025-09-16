using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var kurs = new Course();
        
        kurs.Id = 1;
        kurs.Title = "Aspnet core kursu";
        kurs.Description = "Güzel bir kurs";
        kurs.Image = "1.jpg";

        return View(kurs);
    }

    public IActionResult List()
    {
        var kurslar = new List<Course>()
        {
            new Course() { Id = 1, Title = "aspnet kursu", Description = "güzel bir kurs", Image = "1.jpg"},
            new Course() { Id = 2, Title = "php kursu", Description = "iyi bir kurs", Image = "2.jpg"},
            new Course() { Id = 3, Title = "django kursu", Description = "yetersiz bir kurs", Image = "3.png"},
            new Course() { Id = 4, Title = "javascript kursu", Description = "orta bir kurs", Image = "4.jpeg"},
        };
        return View("CourseList", kurslar);
    }
}
