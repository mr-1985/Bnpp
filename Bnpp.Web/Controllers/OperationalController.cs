using Bnpp.Core.Convertors;
using Bnpp.Core.Services;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.InspectionData;
using Bnpp.DataLayer.Entities.OperationalDatas;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Linq;

namespace Bnpp.Web.Controllers
{
    public class OperationalController : Controller
    {
        private ISensorService _sensor;

        public OperationalController(ISensorService sensor)
        {
            _sensor = sensor;
        }


        [Route("Operational")]
        public IActionResult Index()
        {
            return View();
        }

        #region Sensors

        [BindProperty]
        public Operational Operational { get; set; }

        public IActionResult Sensors()
        {
            return View(_sensor.GetAllSensors());
        }


        [HttpPost]
        public IActionResult ExportSensors()
        {
            var sensors = _sensor.GetAllSensors().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(sensors.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "OperationalSensors.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CraeteSensors()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CraeteSensors(Operational sensor)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _sensor.AddSensor(Operational);
            return new JsonResult("success");
        }

        public IActionResult EditSensors(int id)
        {
            return View(_sensor.GetSensorById(id));
        }

        [HttpPost]
        public IActionResult EditSensors()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _sensor.UpdateSensor(Operational);
            return new JsonResult("success");
        }

        public IActionResult DeleteSensors(string[] sensorId)
        {
            foreach (string id in sensorId)
            {
                _sensor.DeleteSensor(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region Chemical Water


        public IActionResult ChemicalWater()
        {
            return View(_sensor.GetAllChemicalWater());
        }

        [HttpPost]
        public IActionResult ExportChemicalWater()
        {
            var chemicalWater = _sensor.GetAllChemicalWater().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(chemicalWater.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ChemicalWater.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CraeteChemicalWater()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CraeteChemicalWater(Operational sensor)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _sensor.AddChemicalWater(Operational);
            return new JsonResult("success");
        }

        public IActionResult EditChemicalWater(int id)
        {
            return View(_sensor.GetChemicalWaterById(id));
        }

        [HttpPost]
        public IActionResult EditChemicalWater()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _sensor.UpdateChemicalWater(Operational);
            return new JsonResult("success");
        }

        public IActionResult DeleteChemicalWater(string[] chemicalId)
        {
            foreach (string id in chemicalId)
            {
                _sensor.DeleteChemicalWater(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region Environmental

        public IActionResult Environmental()
        {
            return View(_sensor.GetAllEnvironmental());
        }

        [HttpPost]
        public IActionResult ExportEnvironmental()
        {
            var environmental = _sensor.GetAllEnvironmental().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(environmental.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "EnvironmentalData.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CraeteEnvironmental()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CraeteEnvironmental(Operational sensor)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _sensor.AddEnvironmental(Operational);
            return new JsonResult("success");
        }

        public IActionResult EditEnvironmental(int id)
        {
            return View(_sensor.GetEnvironmentalById(id));
        }

        [HttpPost]
        public IActionResult EditEnvironmental()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _sensor.UpdateEnvironmental(Operational);
            return new JsonResult("success");
        }

        public IActionResult DeleteEnvironmental(string[] environmentalId)
        {
            foreach (string id in environmentalId)
            {
                _sensor.DeleteEnvironmental(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }

        #endregion


        [BindProperty]
        public InspectionDocument Document { get; set; }

        #region Sensor Document

        public IActionResult SensorDocument()
        {
            return View(_sensor.GetAllSensorDocument());
        }

        public IActionResult CreateSensorDocument()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult CreateSensorDocument(IFormFile sensorDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _sensor.AddSensorDocument(Document, sensorDocs);

            return new JsonResult("success");
        }

        public IActionResult EditSensorDocument(int id)
        {
            return View(_sensor.GetSensorDocumentById(id));
        }

        [HttpPost]
        public IActionResult EditSensorDocument(IFormFile sensorDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _sensor.UpdateSensorDocument(Document, sensorDocs);

            return new JsonResult("success");
        }

        public IActionResult DeleteSensorDocument(string[] sensorId)
        {
            foreach (string id in sensorId)
            {
                _sensor.DeleteSensorDocument(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

        #region Water Sensor Document

        public IActionResult WaterSensorDocument()
        {
            return View(_sensor.GetAllChemicalWaterDocument());
        }

        public IActionResult CreateWaterSensorDocument()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWaterSensorDocument(IFormFile waterDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _sensor.AddChemicalWaterDocument(Document, waterDocs);

            return new JsonResult("success");
        }

        public IActionResult EditWaterSensorDocument(int id)
        {
            return View(_sensor.GetChemicalWaterDocumentById(id));
        }

        [HttpPost]
        public IActionResult EditWaterSensorDocument(IFormFile waterDocs)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            _sensor.UpdateChemicalWaterDocument(Document, waterDocs);

            return new JsonResult("success");
        }

        
             public IActionResult DeleteWaterSensorDocument(string[] watersensorId)
        {
            foreach (string id in watersensorId)
            {
                _sensor.DeleteChemicalWaterDocument(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }
        #endregion
    }
}
