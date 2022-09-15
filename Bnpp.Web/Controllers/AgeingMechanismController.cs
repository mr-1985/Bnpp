using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.AgeingMechanism;
using Microsoft.AspNetCore.Http;
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

        #region Documents

        [BindProperty]
        public MechanismDocuments MechanismDocument { get; set; }

        public IActionResult Documents()
        {
            return View(_mechanismService.GetAllMechanismDocuments());
        }

        public IActionResult CreateMechanismDocuments()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMechanismDocuments(IFormFile mechanismDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _mechanismService.AddMechanismDocuments(MechanismDocument, mechanismDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditMechanismDocuments(int id)
        {
            return View(_mechanismService.GetMechanismDocumentsById(id));
        }

        [HttpPost]
        public IActionResult EditMechanismDocuments(IFormFile mechanismDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _mechanismService.UpdateMechanismDocuments(MechanismDocument, mechanismDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        
        public IActionResult DeleteMechanismDocuments(string[] mechanismDocumentsId)
        {
            foreach (string id in mechanismDocumentsId)
            {
                _mechanismService.DeleteMechanismDocuments(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion
    }
}
