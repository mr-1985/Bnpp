using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.Maintenance;
using Bnpp.DataLayer.Entities.OperationalDatas;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System;
using Bnpp.Core.Services.Interfaces;

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

        public IActionResult MaintenancePrograms()
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


        public IActionResult MaintenanceForms()
        {
            return View();
        }


        #region  Spare Parts


        [BindProperty]
        public SpareParts Spare { get; set; }


        public IActionResult SpareParts()
        {
            return View(_maintenanceService.GetAllSpareParts());
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


        #region  Measurements

        [BindProperty]
        public Measurements Measureing { get; set; }

        public IActionResult Measurements()
        {
            return View(_maintenanceService.GetAllMeasurements());
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
        public IActionResult DefectsReport()
        {
            return View();
        }
    }
}
