using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class InstallationController : Controller
    {
        [Route("Installation")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
