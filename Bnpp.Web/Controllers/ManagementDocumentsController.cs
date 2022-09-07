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


        public IActionResult Methodology()
        {
            return View();
        }

        

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
