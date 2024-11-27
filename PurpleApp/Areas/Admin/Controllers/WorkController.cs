using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PurpleApp.DAL;
using PurpleApp.Models;

namespace PurpleApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;
        public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Work> works = _context.Works.ToList();

            return View(works);
        }
        public IActionResult Delete(int Id)
        {
            Work? work= _context.Works.FirstOrDefault(w => w.Id == Id);
            _context.Works.Remove(work);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Create()
        {
            ViewBag.Services = _context.Services;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Work work)
        {
            if (!ModelState.IsValid)
            {
                var services = _context.Services.ToList();
                ViewBag.Services = new SelectList(services, "Id", "Name");

                return View(work);
            }

            work.CreateAt = DateTime.Now;

            _context.Works.Add(work);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Update(int Id)
        {
            Work? work = _context.Works.Find(Id);
            if (work is null)
            {
                return NotFound("No such service");
            }
            return View(work);
        }

        [HttpPost]
        public IActionResult Update(Work work)
        {
            Work? updatedWork = _context.Works.AsNoTracking().FirstOrDefault(x => x.Id == work.Id);
            if (updatedWork is null)
            {
                return NotFound("No such service");
            }
            _context.Works.Update(work);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
