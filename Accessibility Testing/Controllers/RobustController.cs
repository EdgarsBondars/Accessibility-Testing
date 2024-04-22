using Microsoft.AspNetCore.Mvc;

namespace Accessibility_Testing.Controllers
{
    public class RobustController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
