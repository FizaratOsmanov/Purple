using Microsoft.AspNetCore.Mvc;
using PurpleApp.DAL;
using PurpleApp.Models;
using PurpleApp.ViewModels;

namespace PurpleApp.Controllers
{
    public class HomeController : Controller
    {
        readonly AppDbContext _context;
        public HomeController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public IActionResult Index()
        {
            IEnumerable<Service> services = _context.Services.ToList();
            IEnumerable<Work> works = _context.Works.OrderByDescending(w => w.Id).Take(3).ToList();

            HomeViewModel homeViewModel = new HomeViewModel()
            {
                Services = services,
                Works = works
            };

            return View(homeViewModel);
        }
    }
}
 