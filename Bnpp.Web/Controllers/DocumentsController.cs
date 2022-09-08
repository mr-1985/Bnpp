using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class DocumentsController : Controller
    {
        [Route("Documents")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult OperationalDocuments()
        {
            return View();
        }

        public IActionResult Drawing()
        {
            return View();
        }

        public IActionResult Standards()
        {
            return View();
        }

        public IActionResult ManufacturerDocuments()
        {
            return View();
        }

        public IActionResult InstallationDocuments()
        {
            return View();
        }

        public IActionResult MaintenanceDocuments()
        {
            return View();
        }

        public IActionResult AgeingDocuments()
        {
            return View();
        }
    }
}
