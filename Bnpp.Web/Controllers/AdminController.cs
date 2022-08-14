using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Bnpp.Web.Controllers
{
    public class AdminController : Controller
    {
        [Authorize]
        [Route("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
