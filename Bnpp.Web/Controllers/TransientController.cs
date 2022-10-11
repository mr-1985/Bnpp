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
            if (StartDates != "")
            {
                string[] std = StartDates.Split('/');
                NormalOperation.CreateDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }


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

            if (StartDates != "")
            {
                string[] std = StartDates.Split('/');
                NormalOperation.CreateDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }


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
                Occurance.CreateDate = new DateTime(int.Parse(std[2]),
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
                Occurance.CreateDate = new DateTime(int.Parse(std[2]),
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
                Basis.CreateDate = new DateTime(int.Parse(std[2]),
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
                Basis.CreateDate = new DateTime(int.Parse(std[2]),
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


        

        #endregion

    }
}
