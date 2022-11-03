using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Bnpp.Core.Convertors;
using Bnpp.Core.Services;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.InspectionData;
using Bnpp.DataLayer.Entities.Maintenance;
using Bnpp.DataLayer.Entities.OperationalDatas;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

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

        [HttpPost]
        public IActionResult ExportInspectionReports()
        {
            var inspectionReports = _inspectionService.GetAllInspectionReports().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(inspectionReports.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "InspectionReports.xlsx");
                }
            }
            //return View();
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


        #region Visual Inspection Form


        public IActionResult VisualForm()
        {
            return View(_inspectionService.GetAllVisualInspectionForm());
        }


        [HttpPost]
        public IActionResult ExportVisualForm()
        {
            var visualForm = _inspectionService.GetAllVisualInspectionForm().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(visualForm.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Visual Inspection Form.xlsx");
                }
            }
            //return View();
        }


        public IActionResult CreateVisualForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateVisualForm(IFormFile fileVisual, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.AddVisualInspectionForm(Document, fileVisual);

            return new JsonResult("success");
        }

        public IActionResult EditVisualForm(int id)
        {
            return View(_inspectionService.GetVisualInspectionFormById(id));
        }

        [HttpPost]
        public IActionResult EditVisualForm(IFormFile fileVisual, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.UpdateVisualInspectionForm(Document, fileVisual);

            return new JsonResult("success");
        }

        public IActionResult DeleteVisualForm(string[] visualformId)
        {
            foreach (string id in visualformId)
            {
                _inspectionService.DeleteVisualInspectionForm(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }


        #endregion


        #region Leakage Test Form

        public IActionResult LeakageForm()
        {
            return View(_inspectionService.GetAllLeakageForm());
        }

        [HttpPost]
        public IActionResult ExportLeakageForm()
        {
            var leakageForm = _inspectionService.GetAllLeakageForm().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(leakageForm.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Leakage Test Form.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateLeakageForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateLeakageForm(IFormFile fileLeakage, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.AddLeakageForm(Document, fileLeakage);

            return new JsonResult("success");
        }

        public IActionResult EditLeakageForm(int id)
        {
            return View(_inspectionService.GetLeakageFormById(id));
        }

        [HttpPost]
        public IActionResult EditLeakageForm(IFormFile fileLeakage, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.UpdateLeakageForm(Document, fileLeakage);

            return new JsonResult("success");
        }


        public IActionResult DeleteLeakageForm(string[] lekageId)
        {
            foreach (string id in lekageId)
            {
                _inspectionService.DeleteLeakageForm(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }
        #endregion


        #region Liquid Penetration Test Form

        public IActionResult PenetrationForm()
        {
            return View(_inspectionService.GetAllPenetrationForm());
        }


        [HttpPost]
        public IActionResult ExportPenetrationForm()
        {
            var penetrationForm = _inspectionService.GetAllPenetrationForm().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(penetrationForm.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Liquid Penetration Test Form.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreatePenetrationForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePenetrationForm(IFormFile fileLiquid, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.AddPenetrationForm(Document, fileLiquid);

            return new JsonResult("success");
        }

        public IActionResult EditPenetrationForm(int id)
        {
            return View(_inspectionService.GetPenetrationFormById(id));
        }

        [HttpPost]
        public IActionResult EditPenetrationForm(IFormFile fileLiquid, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.UpdatePenetrationForm(Document, fileLiquid);

            return new JsonResult("success");
        }

        public IActionResult DeletePenetrationForm(string[] liquidId)
        {
            foreach (string id in liquidId)
            {
                _inspectionService.DeletePenetrationForm(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Magnetic Powder Test Form

        public IActionResult MagneticForm()
        {
            return View(_inspectionService.GetAllMagneticForm());
        }

        [HttpPost]
        public IActionResult ExportMagneticForm()
        {
            var magneticForm = _inspectionService.GetAllMagneticForm().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(magneticForm.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Magnetic Powder Test Form.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateMagneticForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMagneticForm(IFormFile fileMagnetic, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.AddMagneticForm(Document, fileMagnetic);

            return new JsonResult("success");
        }

        public IActionResult EditMagneticForm(int id)
        {
            return View(_inspectionService.GetMagneticFormById(id));
        }

        [HttpPost]
        public IActionResult EditMagneticForm(IFormFile fileMagnetic, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.UpdateMagneticForm(Document, fileMagnetic);

            return new JsonResult("success");
        }


        public IActionResult DeleteMagneticForm(string[] magnetId)
        {
            foreach (string id in magnetId)
            {
                _inspectionService.DeleteMagneticForm(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Radiographics Test Form

        public IActionResult RadiographicsForm()
        {
            return View(_inspectionService.GetAllRadiographicsForm());
        }


        [HttpPost]
        public IActionResult ExportRadiographicsForm()
        {
            var radiographicsForm = _inspectionService.GetAllRadiographicsForm().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(radiographicsForm.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Radiographics Test Form.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateRadiographicsForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateRadiographicsForm(IFormFile fileRadiograph, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.AddRadiographicsForm(Document, fileRadiograph);

            return new JsonResult("success");
        }

        

        public IActionResult EditRadiographicsForm(int id)
        {
            return View(_inspectionService.GetRadiographicsFormById(id));
        }

        [HttpPost]
        public IActionResult EditRadiographicsForm(IFormFile fileRadiograph, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.UpdateRadiographicsForm(Document, fileRadiograph);

            return new JsonResult("success");
        }

        
        public IActionResult DeleteRadiographicsForm(string[] rdioId)
        {
            foreach (string id in rdioId)
            {
                _inspectionService.DeleteRadiographicsForm(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Ultrasonic Test Form

        public IActionResult UltrasonicForm()
        {
            return View(_inspectionService.GetAllUltrasonicForm());
        }

        [HttpPost]
        public IActionResult ExportUltrasonicForm()
        {
            var ultrasonicForm = _inspectionService.GetAllUltrasonicForm().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(ultrasonicForm.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Ultrasonic Test Form.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CraeteUltrasonicForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CraeteUltrasonicForm(IFormFile fileSonic, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.AddUltrasonicForm(Document, fileSonic);

            return new JsonResult("success");
        }
        
        public IActionResult EditUltrasonicForm(int id)
        {
            return View(_inspectionService.GetUltrasonicFormById(id));
        }

        [HttpPost]
        public IActionResult EditUltrasonicForm(IFormFile fileSonic, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.UpdateUltrasonicForm(Document, fileSonic);

            return new JsonResult("success");
        }

        public IActionResult DeleteUltrasonicForm(string[] sonicId)
        {
            foreach (string id in sonicId)
            {
                _inspectionService.DeleteUltrasonicForm(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Metal thickness ultrasonic Test Form

        public IActionResult MetalForm()
        {
            return View(_inspectionService.GetAllMetalForm());
        }

        [HttpPost]
        public IActionResult ExportMetalForm()
        {
            var metalForm = _inspectionService.GetAllMetalForm().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(metalForm.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Metal thickness ultrasonic Test Form.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateMetalForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMetalForm(IFormFile fileMetal, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.AddMetalForm(Document, fileMetal);

            return new JsonResult("success");
        }

        

        public IActionResult EditMetalForm(int id)
        {
            return View(_inspectionService.GetMetalFormById(id));
        }

        [HttpPost]
        public IActionResult EditMetalForm(IFormFile fileMetal, string VisualDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            if (VisualDate != "")
            {
                string[] std = VisualDate.Split('/');
                Document.InspectionDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _inspectionService.UpdateMetalForm(Document, fileMetal);

            return new JsonResult("success");
        }

        public IActionResult DeleteMetalForm(string[] mtalId)
        {
            foreach (string id in mtalId)
            {
                _inspectionService.DeleteMetalForm(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }
        #endregion


        #region Inspection Instructions

        public IActionResult InspectionInstructions()
        {
            return View(_inspectionService.GetAllInspectionInstructions());
        }

        [HttpPost]
        public IActionResult ExportInspectionInstructions()
        {
            var inspectionInstructions = _inspectionService.GetAllInspectionInstructions().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(inspectionInstructions.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "InspectionInstructions.xlsx");
                }
            }
            //return View();
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
            ViewData["TypicalDocuments"] = _inspectionService.GetAllTypicalDocument();
            return View(_inspectionService.GetAlTypicalPrograms());
        }

        [HttpPost]
        public IActionResult ExportInspectionPrograms()
        {
            var inspectionPrograms = _inspectionService.GetAlTypicalPrograms().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(inspectionPrograms.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Typical Programs.xlsx");
                }
            }
            //return View();
        }

        #region Visual Control
        [BindProperty]
        public TestResults Results { get; set; }

        public IActionResult InspectionResults()
        {
            return View(_inspectionService.GetAllVisualControl());
        }


        [HttpPost]
        public IActionResult ExportVisualControl()
        {
            var visualControl = _inspectionService.GetAllVisualControl().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(visualControl.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Visual Control.xlsx");
                }
            }
            //return View();
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

        #region  Leakage Test

        public IActionResult LeakageTest()
        {
            return View(_inspectionService.GetAllLeakageTest());
        }

        [HttpPost]
        public IActionResult ExportLeakageTest()
        {
            var leakageTest = _inspectionService.GetAllLeakageTest().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(leakageTest.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Leakage Test of Weld.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateLeakageTest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateLeakageTest(string TestDate = "")
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

            _inspectionService.AddLeakageTest(Results);

            return new JsonResult("success");
        }

        public IActionResult EditLeakageTest(int id)
        {
            return View(_inspectionService.GetLeakageTestById(id));
        }

        [HttpPost]
        public IActionResult EditLeakageTest(string TestDate = "")
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

            _inspectionService.UpdateLeakageTest(Results);

            return new JsonResult("success");
        }

        public IActionResult DeleteLeakageTest(string[] leakageId)
        {
            foreach (string id in leakageId)
            {
                _inspectionService.DeleteLeakageTest(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Liquid Penetrated Test

        public IActionResult LiquidPenetrated()
        {
            return View(_inspectionService.GetAllLiquidPenetrated());
        }

        [HttpPost]
        public IActionResult ExportLiquidPenetrated()
        {
            var liquidPenetrated = _inspectionService.GetAllLiquidPenetrated().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(liquidPenetrated.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Liquid Penetrated Test.xlsx");
                }
            }
            //return View();
        }
        public IActionResult CreateLiquidPenetrated()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateLiquidPenetrated(string TestDate = "")
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

            _inspectionService.AddLiquidPenetrated(Results);

            return new JsonResult("success");
        }

        public IActionResult EditLiquidPenetrated(int id)
        {
            return View(_inspectionService.GetLiquidPenetratedById(id));
        }

        [HttpPost]
        public IActionResult EditLiquidPenetrated(string TestDate = "")
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

            _inspectionService.UpdateLiquidPenetrated(Results);

            return new JsonResult("success");
        }

        public IActionResult DeleteLiquidPenetrated(string[] liquidId)
        {
            foreach (string id in liquidId)
            {
                _inspectionService.DeleteLiquidPenetrated(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Magnetic Powder test

        public IActionResult MagneticPowder()
        {
            return View(_inspectionService.GetAllMagneticPowder());
        }

        [HttpPost]
        public IActionResult ExportMagneticPowder()
        {
            var magneticPowder = _inspectionService.GetAllMagneticPowder().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(magneticPowder.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Magnetic Powder test.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateMagneticPowder()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMagneticPowder(string TestDate = "")
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

            _inspectionService.AddMagneticPowder(Results);

            return new JsonResult("success");
        }

        public IActionResult EditMagneticPowder(int id)
        {
            return View(_inspectionService.GetMagneticPowderById(id));
        }

        [HttpPost]
        public IActionResult EditMagneticPowder(string TestDate = "")
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

            _inspectionService.UpdateMagneticPowder(Results);

            return new JsonResult("success");
        }

        public IActionResult DeleteMagneticPowder(string[] magneticId)
        {
            foreach (string id in magneticId)
            {
                _inspectionService.DeleteMagneticPowder(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Radiographics Test


        public IActionResult RadiographicsTest()
        {
            return View(_inspectionService.GetAllRadiographics());
        }



        [HttpPost]
        public IActionResult ExportRadiographicsTest()
        {
            var radiographicsTest = _inspectionService.GetAllRadiographics().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(radiographicsTest.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "radiographics Test.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateRadiographicsTest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateRadiographicsTest(string TestDate = "")
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

            _inspectionService.AddRadiographics(Results);

            return new JsonResult("success");
        }

        public IActionResult EditRadiographicsTest(int id)
        {
            return View(_inspectionService.GetRadiographicsById(id));
        }

        [HttpPost]
        public IActionResult EditRadiographicsTest(string TestDate = "")
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

            _inspectionService.UpdateRadiographics(Results);

            return new JsonResult("success");
        }

        public IActionResult DeleteRadiographics(string[] radiograId)
        {
            foreach (string id in radiograId)
            {
                _inspectionService.DeleteRadiographics(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Ultrasonic Tests

        public IActionResult UltrasonicTests()
        {
            return View(_inspectionService.GetAllUltrasonic());
        }

        [HttpPost]
        public IActionResult ExportUltrasonicTests()
        {
            var ultrasonicTests = _inspectionService.GetAllUltrasonic().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(ultrasonicTests.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Ultrasonic Tests.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateUltrasonicTests()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUltrasonicTests(string TestDate = "")
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

            _inspectionService.AddUltrasonic(Results);

            return new JsonResult("success");
        }

        public IActionResult EditUltrasonicTests(int id)
        {
            return View(_inspectionService.GetUltrasonicById(id));
        }

        [HttpPost]
        public IActionResult EditUltrasonicTests(string TestDate = "")
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

            _inspectionService.UpdateUltrasonic(Results);

            return new JsonResult("success");
        }

        public IActionResult DeleteUltrasonicTests(string[] sonicId)
        {
            foreach (string id in sonicId)
            {
                _inspectionService.DeleteUltrasonic(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Metal thickness ultrasonic measurement


        public IActionResult MetalThickness()
        {
            return View(_inspectionService.GetAllMetalThickness());
        }

        [HttpPost]
        public IActionResult ExportMetalThickness()
        {
            var metalThickness = _inspectionService.GetAllMetalThickness().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(metalThickness.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Metal thickness ultrasonic measurement.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateMetalThickness()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMetalThickness(string TestDate = "")
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

            _inspectionService.AddMetalThickness(Results);

            return new JsonResult("success");
        }

        public IActionResult EditMetalThickness(int id)
        {
            return View(_inspectionService.GetMetalThicknessById(id));
        }


        [HttpPost]
        public IActionResult EditMetalThickness(string TestDate = "")
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

            _inspectionService.UpdateMetalThickness(Results);

            return new JsonResult("success");
        }

        public IActionResult DeleteMetalThickness(string[] thicknessId)
        {
            foreach (string id in thicknessId)
            {
                _inspectionService.DeleteMetalThickness(Convert.ToInt32(id));
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
            ViewData["WorkingDocuments"] = _inspectionService.GetAllWorkingDocument();
            return View(_inspectionService.GetAlWorkingPrograms());
        }


        [HttpPost]
        public IActionResult ExportWorkingPrograms()
        {
            var workingPrograms = _inspectionService.GetAlWorkingPrograms().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(workingPrograms.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Working Programs.xlsx");
                }
            }
            //return View();
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

        #region Typical Document

        public IActionResult CreateTypicalDocument()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateTypicalDocument(IFormFile typicalyDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _inspectionService.AddTypicalDocument(Document, typicalyDocs);

            return new JsonResult("success");
        }

        public IActionResult EditTypicalDocument(int id)
        {
            return View(_inspectionService.GetTypicalDocumentById(id));
        }

        [HttpPost]
        public IActionResult EditTypicalDocument(IFormFile typicalyDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _inspectionService.UpdateTypicalDocument(Document, typicalyDocs);

            return new JsonResult("success");
        }

        public IActionResult DeletTypicalDocument(string[] typicalsId)
        {
            foreach (string id in typicalsId)
            {
                _inspectionService.DeleteTypicalDocument(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Working Programs Document

        public IActionResult CreateWorkingDocument()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWorkingDocument(IFormFile workingyDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _inspectionService.AddWorkingDocument(Document, workingyDocs);

            return new JsonResult("success");
        }

        public IActionResult EditWorkingDocument(int id)
        {
            return View(_inspectionService.GetWorkingDocumentById(id));
        }

        [HttpPost]
        public IActionResult EditWorkingDocument(IFormFile workingyDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _inspectionService.UpdateWorkingDocument(Document, workingyDocs);

            return new JsonResult("success");
        }

        public IActionResult DeletWorkingDocument(string[] workingsId)
        {
            foreach (string id in workingsId)
            {
                _inspectionService.DeleteWorkingDocument(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

    }
}
