using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Courses()
        {
            return this.View();
        }
    }
}
