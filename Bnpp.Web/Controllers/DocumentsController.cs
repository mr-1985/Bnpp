using System;
using Bnpp.Core.Convertors;
using System.IO;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.AgeingDocuments;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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

        [HttpPost]
        public IActionResult ExportOperationalDocuments()
        {
            var operationalDocuments = _document.GetAllOperationalDocuments().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(operationalDocuments.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "OperationalDocuments.xlsx");
                }
            }
            //return View();
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

        [HttpPost]
        public IActionResult ExportDrawing()
        {
            var drawing = _document.GetAllDrawing().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(drawing.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Drawing.xlsx");
                }
            }
            //return View();
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

        [HttpPost]
        public IActionResult ExportStandards()
        {
            var standards = _document.GetAllStandard().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(standards.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Standards.xlsx");
                }
            }
            //return View();
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

        [HttpPost]
        public IActionResult ExportManufacturerDocuments()
        {
            var manufacturerDocuments = _document.GetAllManufacturer().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(manufacturerDocuments.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ManufacturerDocuments.xlsx");
                }
            }
            //return View();
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

        #region InstallationDocuments
        [BindProperty] public Installation Installation { get; set; }


        public IActionResult InstallationDocuments()
        {
            return View(_document.GetAllInstallation());
        }

        [HttpPost]
        public IActionResult ExportInstallationDocuments()
        {
            var installationDocuments = _document.GetAllInstallation().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(installationDocuments.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "InstallationDocuments.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CraeteInstallationDocuments()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CraeteInstallationDocuments(IFormFile instalationDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.AddInstallation(Installation, instalationDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditInstallationDocuments(int id)
        {
            return View(_document.GetInstallationById(id));
        }

        [HttpPost]
        public IActionResult EditInstallationDocuments(IFormFile instalationDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.UpdateInstallation(Installation, instalationDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteInstallationDocuments(string[] instalationId)
        {
            foreach (string id in instalationId)
            {
                _document.DeleteInstallation(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region Maintenance Documents
        [BindProperty] public MaintenanceDocument Maintenance { get; set; }


        public IActionResult MaintenanceDocuments()
        {
            return View(_document.GetAllMaintenanceDocument());
        }

        [HttpPost]
        public IActionResult ExportMaintenanceDocuments()
        {
            var maintenanceDocuments = _document.GetAllMaintenanceDocument().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(maintenanceDocuments.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MaintenanceDocuments.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateMaintenanceDocuments()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMaintenanceDocuments(IFormFile maintenanceDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.AddMaintenanceDocument(Maintenance, maintenanceDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditMaintenanceDocuments(int id)
        {
            return View(_document.GetMaintenanceDocumentById(id));
        }

        [HttpPost]
        public IActionResult EditMaintenanceDocuments(IFormFile maintenanceDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.UpdateMaintenanceDocument(Maintenance, maintenanceDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteMaintenanceDocuments(string[] maintenanceId)
        {
            foreach (string id in maintenanceId)
            {
                _document.DeleteMaintenanceDocument(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }

        #endregion

        #region AgeingDocuments
        [BindProperty]
        public Ageing Ageing { get; set; }


        public IActionResult AgeingDocuments()
        {
            return View(_document.GetAllAgeing());
        }


        [HttpPost]
        public IActionResult ExportAgeingDocuments()
        {
            var ageingDocuments = _document.GetAllAgeing().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(ageingDocuments.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "AgeingDocuments.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateAgeingDocuments()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAgeingDocuments(IFormFile ageingDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.AddAgeing(Ageing, ageingDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditAgeingDocuments(int id)
        {
            return View(_document.GetAgeingById(id));
        }

        [HttpPost]
        public IActionResult EditAgeingDocuments(IFormFile ageingDocuments)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _document.UpdateAgeing(Ageing, ageingDocuments);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteAgeingDocuments(string[] ageingId)
        {
            foreach (string id in ageingId)
            {
                _document.DeleteAgeing(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion
    }
}
