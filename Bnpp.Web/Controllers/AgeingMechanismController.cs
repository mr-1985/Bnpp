using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.AgeingMechanism;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class AgeingMechanismController : Controller
    {
        private IMechanismService _mechanismService;

        public AgeingMechanismController(IMechanismService mechanismService)
        {
            _mechanismService = mechanismService;
        }
        [Route("AgeingMechanism")]
        public IActionResult Index()
        {
            return View();
        }

        #region Mechanism
        [BindProperty] public Mechanism Mechanisms { get; set; }


        public IActionResult Mechanism()
        {
            return View(_mechanismService.GetAllMechanism());
        }

        public IActionResult CreateMechanism()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMechanism(Mechanism design)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _mechanismService.AddMechanism(Mechanisms);
            return new JsonResult("success");
        }

        public IActionResult EditMechanism(int id)
        {
            return View(_mechanismService.GetMechanismById(id));
        }

        [HttpPost]
        public IActionResult EditMechanism()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _mechanismService.UpdateMechanism(Mechanisms);
            return new JsonResult("success");
        }

        public IActionResult DleteMechanism(string[] mechanismId)
        {
            foreach (string id in mechanismId)
            {
                _mechanismService.DeleteMechanism(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        public IActionResult Documents()
        {
            return View();
        }
    }
}
