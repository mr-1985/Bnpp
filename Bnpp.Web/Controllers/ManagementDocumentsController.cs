using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class ManagementDocumentsController : Controller
    {

        [Route("ManagementDocuments")]
        public IActionResult Index()
        {
            return View();
        }


        #region Methodology

        public IActionResult Methodology()
        {
            return View();
        }

        public IActionResult CreateMethodology()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMethodology(IFormFile imgMetholodyUp)
        {
            return View();
        }

        #endregion



        public IActionResult OtherDocuments()
        {
            return View();
        }

         

        public IActionResult ManagementReviews()
        {
            return View();
        }
    }
}
