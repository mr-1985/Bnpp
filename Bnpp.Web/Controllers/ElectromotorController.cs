using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities.Electrical;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class ElectromotorController : Controller
    {
        private IElectricalService _electrical;

        public ElectromotorController(IElectricalService electrical)
        {
            _electrical = electrical;
        }

        [Route("Electromotors")]
        public IActionResult Index()
        {
            return View(_electrical.GetAllElectromotos());
        }

        public IActionResult CreateNewElectromotor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewElectromotor(ElectromotorsListViewModel electromotor)
        {
            if (!ModelState.IsValid)
            {
                return View(electromotor);
            }

            Electromotors motors = new Electromotors()
            {
                Name = electromotor.Name,
                Azk = electromotor.Azk,
                Position = electromotor.InstalationPosition,
                CreateDate = DateTime.Now
            };

            _electrical.AddElectromotor(motors);

            return RedirectToAction("Index");
        }

        public IActionResult EditElectromotor(int id)
        {
            return View(_electrical.GetElectromotorById(id));
        }

        [HttpPost]
        public IActionResult EditElectromotor(Electromotors electromotor)
        {
            if (!ModelState.IsValid)
            {
                return View(electromotor);
            }
            _electrical.UpdateElectromotor(electromotor);
            return RedirectToAction("Index");
        }

        public IActionResult DeletElectromotor(string[] electromotorId)
        {
            foreach (string id in electromotorId)
            {
                _electrical.DeleteElectromotor(Convert.ToInt32(id));
            }

            return Json(" Electormotors Successfully Deleted.");
        }
    }
}
