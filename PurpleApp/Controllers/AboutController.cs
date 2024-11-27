using Microsoft.AspNetCore.Mvc;

namespace PurpleApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
