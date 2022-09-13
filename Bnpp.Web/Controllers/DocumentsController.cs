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
