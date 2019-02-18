using AnimalFarm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AnimalFarm.Controllers
{
    public class AnimalController : Controller
    {
        private readonly DatabaseContext _context;

        public AnimalController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            //Recreate();
            Migrate();
            return View(_context.Animals);
        }

        public IActionResult Migrate()
        {
            _context.Database.Migrate();
            ViewData["Message"] = "Database migrated";
            return Ok("Funkar!");
        }

        public IActionResult Recreate()
        {
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            ViewData["Message"] = "Database recreated";
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Add(Animal animal)
        {
            _context.Add(animal);
            _context.SaveChanges();
            
            return RedirectToAction("Index");
        }
    }
}
