using Microsoft.AspNetCore.Mvc;

namespace ERP_system.Controllers
{
    public class LandingPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
