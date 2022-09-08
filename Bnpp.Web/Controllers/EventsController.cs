using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class EventsController : Controller
    {
        [Route("Events")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
