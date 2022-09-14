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

        public IActionResult Drawing()
        {
            return View();
        }

        public IActionResult Standards()
        {
            return View();
        }

        public IActionResult ManufacturerDocuments()
        {
            return View();
        }

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
