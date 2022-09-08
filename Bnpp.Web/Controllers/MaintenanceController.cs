using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class MaintenanceController : Controller
    {
        [Route("Maintenance")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MaintenancePrograms()
        {
            return View();
        }

        public IActionResult Defections()
        {
            return View();
        }

        public IActionResult MaintenanceForms()
        {
            return View();
        }

        public IActionResult SpareParts()
        {
            return View();
        }

        public IActionResult Measurements()
        {
            return View();
        }

        public IActionResult DefectsReport()
        {
            return View();
        }
    }
}
