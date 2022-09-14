using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.AgeingDocuments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class DocumentsController : Controller
    {
        private IDocumentService _document;

        public DocumentsController(IDocumentService document)
        {
            _document = document;
        }

        [Route("Documents")]
        public IActionResult Index()
        {
            return View();
        }

        #region Operational Documents
        [BindProperty] 
        public OperationalDocuments Documents { get; set; }


        public IActionResult OperationalDocuments()
        {
            return View(_document.GetAllOperationalDocuments());
        }

        public IActionResult CreateOperationalDocuments()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOperationalDocuments(IFormFile fileDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.AddOperationalDocuments(Documents, fileDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditOperationalDocuments(int id)
        {
            return View(_document.GetOperationalDocumentsById(id));
        }

        [HttpPost]
        public IActionResult EditOperationalDocuments(IFormFile fileDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.UpdateOperationalDocuments(Documents, fileDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteOperationalDocument(string[] operationalId)
        {
            foreach (string id in operationalId)
            {
                _document.DeleteOperationalDocuments(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region Drawing

        [BindProperty] public Drawing Drawings { get; set; }

        public IActionResult Drawing()
        {
            return View(_document.GetAllDrawing());
        }

        public IActionResult CraeteDrawing()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult CraeteDrawing(IFormFile drawingDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.AddDrawing(Drawings, drawingDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditDrawings(int id)
        {
            return View(_document.GetDrawingById(id));
        }

        [HttpPost]
        public IActionResult EditDrawings(IFormFile drawingDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.UpdateDrawing(Drawings, drawingDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteDrawing(string[] drawingsId)
        {
            foreach (string id in drawingsId)
            {
                _document.DeleteDrawing(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region Standards
        [BindProperty] 
        public Standard Standard { get; set; }


        public IActionResult Standards()
        {
            return View(_document.GetAllStandard());
        }

        public IActionResult CraeteStandards()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CraeteStandards(IFormFile standardDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.AddStandard(Standard, standardDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditStandard(int id)
        {
            return View(_document.GetimgStandardById(id));
        }

        [HttpPost]
        public IActionResult EditStandard(IFormFile standardDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.UpdateimgStandard(Standard, standardDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteStandard(string[] standardId)
        {
            foreach (string id in standardId)
            {
                _document.DeleteimgStandard(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region  Manufacturer

        [BindProperty] public Manufacturer Manufacturer { get; set; }


        public IActionResult ManufacturerDocuments()
        {
            return View(_document.GetAllManufacturer());
        }

        public IActionResult CreateManufacturerDocuments()
        {
            return View();
        }
        

        [HttpPost]
        public IActionResult CreateManufacturerDocuments(IFormFile ManufacturDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.AddManufacturer(Manufacturer, ManufacturDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditManufacturer(int id)
        {
            return View(_document.GetManufacturerById(id));
        }

        [HttpPost]
        public IActionResult EditManufacturer(IFormFile ManufacturDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.UpdateManufacturer(Manufacturer, ManufacturDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteManufacturers(string[] manufacturerId)
        {
            foreach (string id in manufacturerId)
            {
                _document.DeleteManufacturer(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        public IActionResult InstallationDocuments()
        {
            return View();
        }

        public IActionResult MaintenanceDocuments()
        {
            return View();
        }

        public IActionResult AgeingDocuments()
        {
            return View();
        }
    }
}
