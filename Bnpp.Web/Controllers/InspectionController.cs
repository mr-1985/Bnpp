using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class InspectionController : Controller
    {
        [Route("Inspection")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubMenu()
        {
            return View();
        }

        public IActionResult InspectionReports()
        {
            return View();
        }

        public IActionResult InspectionInstructions()
        {
            return View();
        }

        public IActionResult InspectionPrograms()
        {
            return View();
        }


        #region SubMenu

        public IActionResult TypicalPrograms()
        {
            return View();
        }

        public IActionResult WorkingPrograms()
        {
            return View();
        }

        #endregion
    }
}
