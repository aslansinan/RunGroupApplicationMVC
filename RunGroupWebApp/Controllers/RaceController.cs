using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data.Interfaces;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Data.Enum
{
    public class RaceController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IRaceRepository _raceRepository;

        public RaceController(/*ApplicationDbContext context,*/ IRaceRepository raceRepository)
        {
            //_context = context;
            _raceRepository = raceRepository;
        }


        public async Task<IActionResult> Index()
        {
            IEnumerable<Race> races = await _raceRepository.GetAll();
            return View(races);
        }

        public async Task<IActionResult> Detail(int id)
        {
            var race = await _raceRepository.GetByIdAsync(id);
            return View(race);
        }
    }
}
