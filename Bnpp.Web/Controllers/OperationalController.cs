using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class OperationalController : Controller
    {
        [Route("Operational")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Sensors()
        {
            return View();
        }

        public IActionResult ChemicalWater()
        {
            return View();
        }

        public IActionResult Environmental()
        {
            return View();
        }


    }
}
