using Microsoft.AspNetCore.Mvc;
using PurpleApp.DAL;
using PurpleApp.Models;
using PurpleApp.ViewModels;

namespace PurpleApp.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SingleWork(int id)
        {
            return View();
        }
    }
}
