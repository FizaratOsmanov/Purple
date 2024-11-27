using Microsoft.AspNetCore.Mvc;

namespace PurpleApp.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
