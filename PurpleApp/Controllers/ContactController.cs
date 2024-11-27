using Microsoft.AspNetCore.Mvc;

namespace PurpleApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
