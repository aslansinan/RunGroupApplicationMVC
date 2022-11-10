using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Data.Enum
{
    public class RaceController : Controller
    {
        private readonly ApplicationDbContext _context;
        public RaceController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            List<Race> races = _context.Races.ToList();
            return View(races);
        }

        public IActionResult Detail(int id)
        {
            var race = _context.Races.Include(a => a.Address).FirstOrDefault(x => x.Id == id);
            return View(race);
        }
    }
}
