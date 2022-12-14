using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.Maintenance;
using Bnpp.DataLayer.Entities.OperationalDatas;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System;
using Bnpp.Core.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Bnpp.Core.Convertors;
using Bnpp.Core.Services;
using ClosedXML.Excel;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Office2010.Excel;
using static System.Net.WebRequestMethods;

namespace Bnpp.Web.Controllers
{
    public class MaintenanceController : Controller
    {
        private IMaintenanceService _maintenanceService;
        public MaintenanceController(IMaintenanceService maintenanceService)
        {
            _maintenanceService = maintenanceService;
        }

        [Route("Maintenance")]
        public IActionResult Index()
        {
            return View();
        }

      
        #region List of Defections

        [BindProperty]
        public DefectList DefectList { get; set; }


        public IActionResult Defections()
        {
            return View(_maintenanceService.GetAllDefectList());
        }

        [HttpPost]
        public IActionResult ExportDefections()
        {
            var defections = _maintenanceService.GetAllDefectList().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(defections.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ListofDefections.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateDefections()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDefections(string CorrectionDate = "", string DetectionDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (CorrectionDate != "")
            {
                string[] std = CorrectionDate.Split('/');
                DefectList.CorrectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            if (DetectionDate != "")
            {
                string[] std = DetectionDate.Split('/');
                DefectList.DetectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }


            _maintenanceService.AddDefectList(DefectList);

            return new JsonResult("success");
        }

        public IActionResult EditDefections(int id)
        {
            return View(_maintenanceService.GetDefectListById(id));
        }

        [HttpPost]
        public IActionResult EditDefections(string CorrectionDate = "", string DetectionDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (CorrectionDate != "")
            {
                string[] std = CorrectionDate.Split('/');
                DefectList.CorrectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            if (DetectionDate != "")
            {
                string[] std = DetectionDate.Split('/');
                DefectList.DetectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }


            _maintenanceService.UpdateDefectList(DefectList);

            return new JsonResult("success");
        }

        public IActionResult DeleteDefections(string[] defectionId)
        {
            foreach (string id in defectionId)
            {
                _maintenanceService.DeleteDefectList(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }
        #endregion

        #region MaintenanceForms

        [BindProperty]
        public MaintenanceForm Form { get; set; }


        public IActionResult MaintenanceForms()
        {
            return View(_maintenanceService.GetAllMaintenanceForm());
        }

        [HttpPost]
        public IActionResult ExportMaintenanceForms()
        {
            var maintenanceForms = _maintenanceService.GetAllMaintenanceForm().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(maintenanceForms.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MaintenanceForms.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateMaintenanceForms()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMaintenanceForms(IFormFile fileforms,string DateofMaintenance = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (DateofMaintenance != "")
            {
                string[] std = DateofMaintenance.Split('/');
                Form.DateofMaintenance = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _maintenanceService.AddMaintenanceForm(Form,fileforms);

            return new JsonResult("success");
        }

        public IActionResult EditMaintenanceForms(int id)
        {
            return View(_maintenanceService.GetMaintenanceFormById(id));
        }

        [HttpPost]
        public IActionResult EditMaintenanceForms(IFormFile fileforms, string DateofMaintenance = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (DateofMaintenance != "")
            {
                string[] std = DateofMaintenance.Split('/');
                Form.DateofMaintenance = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _maintenanceService.UpdateMaintenanceForm(Form, fileforms);

            return new JsonResult("success");
        }

        public IActionResult DeleteMaintenanceForms(string[] formId)
        {
            foreach (string id in formId)
            {
                _maintenanceService.DeleteMaintenanceForm(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region  Spare Parts


        [BindProperty]
        public SpareParts Spare { get; set; }


        public IActionResult SpareParts()
        {
            return View(_maintenanceService.GetAllSpareParts());
        }

        [HttpPost]
        public IActionResult ExportSpareParts()
        {
            var spareParts = _maintenanceService.GetAllSpareParts().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(spareParts.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "SparePartsList.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateSpareParts()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSpareParts(SpareParts parts)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _maintenanceService.AddSpareParts(Spare);

            return new JsonResult("success");
        }

        public IActionResult EditSpareParts(int id)
        {
            return View(_maintenanceService.GetSparePartsById(id));
        }

        [HttpPost]
        public IActionResult EditSpareParts()
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _maintenanceService.UpdateSpareParts(Spare);

            return new JsonResult("success");
        }

        public IActionResult DeleteSpareParts(string[] sprlistId)
        {
            foreach (string id in sprlistId)
            {
                _maintenanceService.DeleteSpareParts(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Maintenance Programs

        [BindProperty]
        public MaintenancePrograms Programs { get; set; }

        public IActionResult MaintenancePrograms()
        {
            ViewData["Documents"] = _maintenanceService.GetAllProgramsDocument();
            return View(_maintenanceService.GetAllMaintenancePrograms());
        }

        [HttpPost]
        public IActionResult ExportMaintenancePrograms()
        {
            var maintenancePrograms = _maintenanceService.GetAllMaintenancePrograms().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(maintenancePrograms.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "MaintenancePrograms.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateMaintenancePrograms()
        {
            
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem { Value = "Oil system", Text = "Oil system"},
                new SelectListItem { Value = "Component cooling circuit system", Text = "Component cooling circuit system" },
                new SelectListItem { Value = "Sealing unit cooling system", Text = "Sealing unit cooling system" },
                new SelectListItem { Value = "RAB cooling system", Text = "RAB cooling system" },
                new SelectListItem { Value = "Isolated circuit system", Text = "Isolated circuit system" },
                new SelectListItem { Value = "Torsion", Text = "Torsion" },
                new SelectListItem { Value = "VACDSM system", Text = "VACDSM system" },
                new SelectListItem { Value = "Removable part", Text = "Removable part" },
                new SelectListItem { Value = "Support structures", Text = "Support structures" },
                new SelectListItem { Value = "Spherical casing", Text = "Spherical casing" }
            };
           

            ViewData["Types"] = new SelectList(list, "Value", "Text");

            return View();
        }

        [HttpPost]
        public IActionResult CreateMaintenancePrograms(MaintenancePrograms parts)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _maintenanceService.AddMaintenancePrograms(Programs);

            return new JsonResult("success");
        }

        public IActionResult EditMaintenancePrograms(int id)
        {
            List<SelectListItem> list = new List<SelectListItem>()
            {
                new SelectListItem { Value = "Oil system", Text = "Oil system"},
                new SelectListItem { Value = "Component cooling circuit system", Text = "Component cooling circuit system" },
                new SelectListItem { Value = "Sealing unit cooling system", Text = "Sealing unit cooling system" },
                new SelectListItem { Value = "RAB cooling system", Text = "RAB cooling system" },
                new SelectListItem { Value = "Isolated circuit system", Text = "Isolated circuit system" },
                new SelectListItem { Value = "Torsion", Text = "Torsion" },
                new SelectListItem { Value = "VACDSM system", Text = "VACDSM system" },
                new SelectListItem { Value = "Removable part", Text = "Removable part" },
                new SelectListItem { Value = "Support structures", Text = "Support structures" },
                new SelectListItem { Value = "Spherical casing", Text = "Spherical casing" }
            };


            ViewData["Types"] = new SelectList(list, "Value", "Text");

            return View(_maintenanceService.GetMaintenanceProgramsById(id));
        }

        [HttpPost]
        public IActionResult EditMaintenancePrograms()
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _maintenanceService.UpdateMaintenancePrograms(Programs);

            return new JsonResult("success");
        }

        public IActionResult DeleteMaintenancePrograms(string[] programId)
        {
            foreach (string id in programId)
            {
                _maintenanceService.DeleteMaintenancePrograms(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #region Program Documents
        [BindProperty]
        public ProgramsDocument programsDocument { get; set; }

        public IActionResult CreateProgramDocuments()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProgramDocuments(IFormFile programsdoc)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _maintenanceService.AddProgramsDocument(programsDocument, programsdoc);

            return new JsonResult("success");
        }

        public IActionResult EditProgramDocuments(int id)
        {
            return View(_maintenanceService.GetProgramsDocumentById(id));
        }

        [HttpPost]
        public IActionResult EditProgramDocuments(IFormFile programsdoc)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _maintenanceService.UpdateProgramsDocument(programsDocument, programsdoc);

            return new JsonResult("success");
        }

        public IActionResult DeleteProgramDocuments(string[] documentId)
        {
            foreach (string id in documentId)
            {
                _maintenanceService.DeleteProgramsDocument(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion
        #endregion

        #region  Measurements

        [BindProperty]
        public Measurements Measureing { get; set; }

        public IActionResult Measurements()
        {
            return View(_maintenanceService.GetAllMeasurements());
        }

        [HttpPost]
        public IActionResult ExportMeasurements()
        {
            var measurements = _maintenanceService.GetAllMeasurements().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(measurements.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ResultofMeasurementsbefore&afterMaintenance.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateMeasurements()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateMeasurements(string Dateofmeasurement = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (Dateofmeasurement != "")
            {
                string[] std = Dateofmeasurement.Split('/');
                Measureing.Dateofmeasurement = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _maintenanceService.AddMeasurements(Measureing);

            return new JsonResult("success");
        }

        public IActionResult EditMeasurements(int id)
        {
            return View(_maintenanceService.GetMeasurementsById(id));
        }

        [HttpPost]
        public IActionResult EditMeasurements(string Dateofmeasurement = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (Dateofmeasurement != "")
            {
                string[] std = Dateofmeasurement.Split('/');
                Measureing.Dateofmeasurement = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _maintenanceService.UpdateMeasurements(Measureing);

            return new JsonResult("success");
        }

        public IActionResult DeleteMeasurements(string[] measureId)
        {
            foreach (string id in measureId)
            {
                _maintenanceService.DeleteMeasurements(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region  Defects Report

        [BindProperty]
        public DefectionReports Reports { get; set; }


        public IActionResult DefectsReport()
        {
            return View(_maintenanceService.GetAllDefectionReports());
        }

        [HttpPost]
        public IActionResult ExportDefectsReport()
        {
            var defectsReport = _maintenanceService.GetAllDefectionReports().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(defectsReport.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DefectionReports.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateDefectsReport()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDefectsReport(IFormFile filereports)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            

            _maintenanceService.AddDefectionReports(Reports, filereports);

            return new JsonResult("success");
        }

        public IActionResult EditDefectsReport(int id)
        {
            return View(_maintenanceService.GetDefectionReportsById(id));
        }

        [HttpPost]
        public IActionResult EditDefectsReport(IFormFile filereports)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _maintenanceService.UpdateDefectionReports(Reports, filereports);

            return new JsonResult("success");
        }

        public IActionResult DeleteDefectsReport(string[] reportsId)
        {
            foreach (string id in reportsId)
            {
                _maintenanceService.DeleteDefectionReports(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion
    }
}
