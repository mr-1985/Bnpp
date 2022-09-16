using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class InstallationController : Controller
    {
        private ICommissioningService _commissioning;

        public InstallationController(ICommissioningService commissioning)
        {
            _commissioning = commissioning;
        }


        [BindProperty] public Commissioning Commission { get; set; }

        [Route("Installation")]
        public IActionResult Index()
        {
            return View(_commissioning.GetAllCommissioning());
        }

        public IActionResult CreateCommissioning()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCommissioning(Commissioning comm)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _commissioning.AddCommissioning(Commission);
            return new JsonResult("success");
        }

        public IActionResult EditCommissioning(int id)
        {
            return View(_commissioning.GetCommissioningById(id));
        }

        [HttpPost]
        public IActionResult EditCommissioning()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _commissioning.UpdateCommissioning(Commission);
            return new JsonResult("success");
        }

        public IActionResult DeleteCommissioning(string[] commissioningId)
        {
            foreach (string id in commissioningId)
            {
                _commissioning.DeleteCommissioning(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
    }
}
