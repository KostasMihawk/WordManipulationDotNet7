using Microsoft.AspNetCore.Mvc;

namespace WordManipulationDotNet7.Controllers
{
    public class DiagnosticsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Diagnostics controller is working. Routes are OK.");
        }

        public IActionResult TestView()
        {
            return View();
        }
    }
}
