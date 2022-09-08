using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class AgeingMechanismController : Controller
    {
        [Route("AgeingMechanism")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Mechanism()
        {
            return View();
        }

        public IActionResult Documents()
        {
            return View();
        }
    }
}
