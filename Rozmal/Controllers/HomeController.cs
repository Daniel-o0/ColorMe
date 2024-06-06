using Microsoft.AspNetCore.Mvc;

namespace Rozmal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Rozmal()
        {
            return View("rozmal");
        }
    }
}
