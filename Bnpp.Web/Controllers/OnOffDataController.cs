using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class OnOffDataController : Controller
    {
        [Route("OnOffData")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
