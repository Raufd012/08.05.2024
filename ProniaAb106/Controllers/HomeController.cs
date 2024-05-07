using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaAb106.DataAccesLayer;
using ProniaAb106.ViewModels.Categories;

namespace ProniaAb106.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaContext _context;
        public HomeController(ProniaContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Categories
            .Where(x => x.IsDeleted == false)
            .Select(x => new GetCategoryVM
            {
                Id = x.Id,
                Name = x.Name

            })
            .ToListAsync();
            return View(data);
            
        }
        public async Task<IActionResult> Test(int? id)
        {
            if (id == null || id < 1) return BadRequest();
            var cat = await _context.Categories.FindAsync(id);
            if (cat == null) return NotFound();
            _context.Remove(cat);
            await _context.SaveChangesAsync();
            return Content(cat.Name);
            
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Shop()
        {
            return View();
        }
        public IActionResult Blog()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}
