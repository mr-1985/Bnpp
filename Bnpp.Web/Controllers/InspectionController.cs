using System;
using System.Security.Cryptography;
using Bnpp.Core.Services;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.InspectionData;
using Bnpp.DataLayer.Entities.Maintenance;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class InspectionController : Controller
    {
        private IInspectionService _inspectionService;
        public InspectionController(IInspectionService inspectionService)
        {
            _inspectionService = inspectionService;
        }

        [Route("Inspection")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SubMenu()
        {
            return View();
        }

        #region  InspectionReports

        [BindProperty]
        public InspectionDocument Document { get; set; }


        public IActionResult InspectionReports()
        {
            return View(_inspectionService.GetAllInspectionReports());
        }

        public IActionResult CretaeInspectionReports()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CretaeInspectionReports(IFormFile fileReports)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _inspectionService.AddInspectionReports(Document, fileReports);

            return new JsonResult("success");
        }

        public IActionResult EditInspectionReports(int id)
        {
            return View(_inspectionService.GetInspectionReportsById(id));
        }

        [HttpPost]
        public IActionResult EditInspectionReports(IFormFile fileReports)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _inspectionService.UpdateInspectionReports(Document, fileReports);

            return new JsonResult("success");
        }

        public IActionResult DeleteInspectionReports(string[] rportId)
        {
            foreach (string id in rportId)
            {
                _inspectionService.DeleteInspectionReports(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Inspection Instructions

        public IActionResult InspectionInstructions()
        {
            return View(_inspectionService.GetAllInspectionInstructions());
        }

        public IActionResult CretaeInspectionInstructions()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CretaeInspectionInstructions(IFormFile fileInstructions)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _inspectionService.AddInspectionInstructions(Document, fileInstructions);

            return new JsonResult("success");
        }

        public IActionResult EditInspectionInstructions(int id)
        {
            return View(_inspectionService.GetInspectionInstructionsById(id));
        }

        [HttpPost]
        public IActionResult EditInspectionInstructions(IFormFile fileInstructions)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _inspectionService.UpdateInspectionInstructions(Document, fileInstructions);

            return new JsonResult("success");
        }

        public IActionResult DeleteInspectionInstructions(string[] instructionslId)
        {
            foreach (string id in instructionslId)
            {
                _inspectionService.DeleteInspectionInstructions(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }
        #endregion
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
