using DBFirstDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace DBFirstDemo.Controllers
{
    public class StudentController : Controller
   
    {
        private readonly CodeFirstDbContext _context;

        public StudentController(CodeFirstDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var list = _context.Students.ToList();
            return View(list);
        }
    }
}
}
