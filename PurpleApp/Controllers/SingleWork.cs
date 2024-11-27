using Microsoft.AspNetCore.Mvc;

namespace PurpleApp.Controllers
{
    public class SingleWork : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
