using Microsoft.AspNetCore.Mvc;

namespace Accessibility_Testing.Controllers
{
    public class OperableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
