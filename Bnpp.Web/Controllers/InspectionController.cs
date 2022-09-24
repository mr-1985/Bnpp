using System;
using System.Globalization;
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
            return View(_inspectionService.GetAlTypicalPrograms());
        }


        #region Visual Control
        [BindProperty]
        public TestResults Results { get; set; }

        public IActionResult InspectionResults()
        {
            return View(_inspectionService.GetAllVisualControl());
        }

        public IActionResult CraeteVisualControl()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CraeteVisualControl(string TestDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (TestDate != "")
            {
                string[] std = TestDate.Split('/');
                Results.TestingDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.AddVisualControl(Results);

            return new JsonResult("success");
        }

        public IActionResult EditVisualControl(int id)
        {
            return View(_inspectionService.GetVisualControlById(id));
        }

        [HttpPost]
        public IActionResult EditVisualControl(string TestDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (TestDate != "")
            {
                string[] std = TestDate.Split('/');
                Results.TestingDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.UpdateVisualControl(Results);

            return new JsonResult("success");
        }


        public IActionResult DeleteVisualControl(string[] visualId)
        {
            foreach (string id in visualId)
            {
                _inspectionService.DeleteVisualControl(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region TypicalPrograms

        [BindProperty]
        public TypicalPrograms Programs { get; set; }

        public IActionResult TypicalPrograms()
        {
            return View();
        }

        public IActionResult CreateTypicalPrograms()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTypicalPrograms(TypicalPrograms typicalPrograms)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            _inspectionService.AddTypicalPrograms(Programs);

            return new JsonResult("success");
        }

        public IActionResult EditTypicalPrograms(int id)
        {
            return View(_inspectionService.GetTypicalProgramsById(id));
        }

        [HttpPost]
        public IActionResult EditTypicalPrograms()
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _inspectionService.UpdateTypicalPrograms(Programs);

            return new JsonResult("success");
        }

        public IActionResult DeletTypicalPrograms(string[] typicalsId)
        {
            foreach (string id in typicalsId)
            {
                _inspectionService.DeleteTypicalPrograms(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Working Programs

        [BindProperty]
        public WorkingPrograms Working { get; set; }


        public IActionResult WorkingPrograms()
        {
            return View(_inspectionService.GetAlWorkingPrograms());
        }

        public IActionResult CraeteWorkingPrograms()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CraeteWorkingPrograms(WorkingPrograms workingPrograms)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            _inspectionService.AddWorkingPrograms(Working);

            return new JsonResult("success");
        }

        public IActionResult EditWorkingPrograms(int id)
        {
            return View(_inspectionService.GetWorkingProgramsById(id));
        }

        [HttpPost]
        public IActionResult EditWorkingPrograms()
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            _inspectionService.UpdateWorkingPrograms(Working);

            return new JsonResult("success");
        }

        public IActionResult DeletWorkingPrograms(string[] workingId)
        {
            foreach (string id in workingId)
            {
                _inspectionService.DeleteWorkingPrograms(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        
        #endregion

    }
}
