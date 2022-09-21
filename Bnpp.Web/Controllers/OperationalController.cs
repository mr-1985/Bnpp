using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.OperationalDatas;
using Microsoft.AspNetCore.Mvc;
using System;

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

        #region

        [BindProperty]
        public Operational Operational { get; set; }

        public IActionResult Sensors()
        {
            return View(_sensor.GetAllSensors());
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

        public IActionResult ChemicalWater()
        {
            return View();
        }

        public IActionResult Environmental()
        {
            return View();
        }


    }
}
