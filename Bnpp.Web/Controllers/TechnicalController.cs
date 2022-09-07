using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class TechnicalController : Controller
    {
        [Route("Technical")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GeneralData()
        {
            return View();
        }
        

        public IActionResult DesignData()
        {
            return View();
        }

        

        public IActionResult Documents()
        {
            return View();
        }

        

        public IActionResult Safety()
        {
            return View();
        }

        public IActionResult Components()
        {
            return View();
        }
        
    }
}
