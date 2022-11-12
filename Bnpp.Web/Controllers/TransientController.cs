using System;
using System.Globalization;
using Bnpp.Core.Convertors;
using System.IO;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Bnpp.DataLayer.Entities.InspectionData;
using Bnpp.Core.Services;
using Bnpp.DataLayer.Entities.Maintenance;
using Microsoft.AspNetCore.Http;

namespace Bnpp.Web.Controllers
{
    public class TransientController : Controller
    {
        private IElectricalService _electrical;
        private IOperationalService _operational;

        public TransientController(IElectricalService electrical, IOperationalService operational)
        {
            _electrical = electrical;
            _operational = operational;
        }

        [Route("Transient")]
        public IActionResult Index()
        {
            return View();
        }

        #region NormalOperations

        public IActionResult NormalOperations()
        {
            ViewData["NormalDocuments"] = _operational.GetAllNormalOperationDocument();
            return View(_operational.GetAllNormalOperations());
        }


        [HttpPost]
        public IActionResult ExportNormalOperations()
        {
            var normalOperations = _operational.GetAllNormalOperations().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(normalOperations.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "NormalOperations.xlsx");
                }
            }
            return View();
        }


        [BindProperty]
        public OperationalData NormalOperation { get; set; }
        public IActionResult CreateNormalOperations()
        {
            

            return View();
        }


        [HttpPost]
        public IActionResult CreateNormalOperations(string StartDates = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            //if (StartDates != "")
            //{
            //    string[] std = StartDates.Split('/');
            //    NormalOperation.NormalDate = new DateTime(int.Parse(std[2]),
            //        int.Parse(std[0]),
            //        int.Parse(std[1]),
            //        new GregorianCalendar()
            //    );
            //}


            _operational.AddNormalOperation(NormalOperation);

            return new JsonResult("success");
        }

        public IActionResult EditNormalOperations(int id)
        {
            return View(_operational.GetNormalOperationalById(id));
        }

        [HttpPost]
        public IActionResult EditNormalOperations(string StartDates = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(NormalOperation);
            //}

            //if (StartDates != "")
            //{
            //    string[] std = StartDates.Split('/');
            //    NormalOperation.NormalDate = new DateTime(int.Parse(std[2]),
            //        int.Parse(std[0]),
            //        int.Parse(std[1]),
            //        new GregorianCalendar()
            //    );
            //}


            _operational.UpdateNormalOperational(NormalOperation);

            return Json(" Diesel Generators Successfully Deleted.");
        }

        public IActionResult DeleteNormalOperations(string[] operationalId)
        {
            foreach (string id in operationalId)
            {
                _operational.DeleteNormalOperational(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region OperationalOccurence

        public IActionResult OperationalOccurence()
        {
            ViewData["OccurenceDocuments"] = _operational.GetAllOccuranceDocument();
            return View(_operational.GetAllOccurances());
        }

        [HttpPost]
        public IActionResult ExportOperationalOccurence()
        {
            var operationalOccurence = _operational.GetAllOccurances().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(operationalOccurence.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "OperationalOccurence.xlsx");
                }
            }
            return View();
        }

        [BindProperty]
        public Occurance Occurance { get; set; }

        public IActionResult CreateOccurence()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOccurence(string StartDates = "")
        {
            if (StartDates != "")
            {
                string[] std = StartDates.Split('/');
                Occurance.OccuranceDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _operational.AddOccurance(Occurance);

            return new JsonResult("success");
        }

        public IActionResult EditOccurence(int id)
        {
            return View(_operational.GetOccuranceById(id));
        }
        
        [HttpPost]
        public IActionResult EditOccurence(string StartDates = "")
        {
            if (!ModelState.IsValid)
            {
                return View(Occurance);
            }

            if (StartDates != "")
            {
                string[] std = StartDates.Split('/');
                Occurance.OccuranceDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }
            _operational.UpdateOccurance(Occurance);

            return Json(" Diesel Generators Successfully Deleted.");
        }
        

        public IActionResult DeleteOccurence(string[] occurenceId)
        {
            foreach (string id in occurenceId)
            {
                _operational.DeleteOccurance(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }
        #endregion

        #region DesignBasisAccidents
        [BindProperty]
        public DesignBasis Basis { get; set; }
        public IActionResult DesignBasisAccidents()
        {

            ViewData["BasisDocuments"] = _operational.GetAllBasisDocument();
            return View(_operational.GetAllBasisAccident());
        }

        [HttpPost]
        public IActionResult ExportDesignBasisAccidents()
        {
            var designBasisAccidents = _operational.GetAllBasisAccident().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(designBasisAccidents.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DesignBasisAccidents.xlsx");
                }
            }
            return View();
        }

        public IActionResult CreateDesignBasisAccidents()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDesignBasisAccidents(string StartDates = "")
        {
            if (StartDates != "")
            {
                string[] std = StartDates.Split('/');
                Basis.DesignBasisDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _operational.AddBasisAccident(Basis);

            return new JsonResult("success");
        }

        public IActionResult EditDesignBasisAccidents(int id)
        {

            return View(_operational.GetBasisAccidentById(id));
        }

        [HttpPost]
        public IActionResult EditDesignBasisAccidents(string StartDates = "")
        {
            if (!ModelState.IsValid)
            {
                return View(Basis);
            }

            if (StartDates != "")
            {
                string[] std = StartDates.Split('/');
                Basis.DesignBasisDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }
            _operational.UpdateBasisAccident(Basis);

            return Json(" Diesel Generators Successfully Deleted.");
        }

        public IActionResult DeleteDesignBasisAccidents(string[] basisId)
        {
            foreach (string id in basisId)
            {
                _operational.DeleteBasisAccident(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }





        [BindProperty]
        public InspectionDocument Document { get; set; }
        #endregion

        #region NormalOperations Document

        public IActionResult CreateNormalOperationsDocument()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNormalOperationsDocument(IFormFile normalDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _operational.AddNormalOperationDocument(Document, normalDocs);

            return new JsonResult("success");
        }

        public IActionResult EditNormalOperationsDocument(int id)
        {
            return View(_operational.GetNormalOperationDocumentById(id));
        }

        [HttpPost]
        public IActionResult EditNormalOperationsDocument(IFormFile normalDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _operational.UpdateNormalOperationDocument(Document, normalDocs);

            return new JsonResult("success");
        }

        public IActionResult DeleteNormalOperationsDocuments(string[] normalDocId)
        {
            foreach (string id in normalDocId)
            {
                _operational.DeleteNormalOperationDocument(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Occurences Document

        public IActionResult CreateOccurenceDocument()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateOccurenceDocument(IFormFile occurenceDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _operational.AddOccuranceDocument(Document, occurenceDocs);

            return new JsonResult("success");
        }

        public IActionResult EditOccurenceDocument(int id)
        {
            return View(_operational.GetOccuranceDocumentById(id));
        }

        [HttpPost]
        public IActionResult EditOccurenceDocument(IFormFile occurenceDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _operational.UpdateOccuranceDocument(Document, occurenceDocs);

            return new JsonResult("success");
        }

        public IActionResult DeleteOccurenceDocuments(string[] occurenceId)
        {
            foreach (string id in occurenceId)
            {
                _operational.DeleteOccuranceDocument(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region DesignBasisAccidents Document

        public IActionResult CreateBasisDocument()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateBasisDocument(IFormFile basisDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _operational.AddBasisDocument(Document, basisDocs);

            return new JsonResult("success");
        }


        public IActionResult EditBasisDocument(int id)
        {
            return View(_operational.GetBasisDocumentById(id));
        }

        [HttpPost]
        public IActionResult EditBasisDocument(IFormFile basisDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _operational.UpdateBasisDocument(Document, basisDocs);

            return new JsonResult("success");
        }


        public IActionResult DeleteBasisAccidentDocument(string[] basisId)
        {
            foreach (string id in basisId)
            {
                _operational.DeleteBasisDocument(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

    }
}
