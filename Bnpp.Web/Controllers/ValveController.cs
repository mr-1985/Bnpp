using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities.Electrical;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class ValveController : Controller
    {
        private IElectricalService _electrical;

        public ValveController(IElectricalService electrical)
        {
            _electrical = electrical;
        }

        [Route("Valves")]
        public IActionResult Index()
        {
            return View(_electrical.GetAllValves());
        }

        public IActionResult CreateNewValve()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewValve(ValvesListViewModel valve)
        {
            if (!ModelState.IsValid)
            {
                return View(valve);
            }

            ElectroValve electro = new ElectroValve()
            {
                Name = valve.Name,
                Position = valve.InstalationPosition,
                Azk = valve.Azk,
                CreateDate = DateTime.Now,
            };
            _electrical.AddValve(electro);

            return RedirectToAction("Index");
        }

        public IActionResult EditValve(int id)
        {
            return View(_electrical.GetValveById(id));
        }

        [HttpPost]
        public IActionResult EditValve(ElectroValve valve)
        {
            if (!ModelState.IsValid)
            {
                return View(valve);
            }
            _electrical.UpdateValve(valve);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteValve(string[] valveId)
        {
            foreach (string id in valveId)
            {
                _electrical.DeleteValve(Convert.ToInt32(id));
            }

            return Json(" Valves Successfully Deleted.");
        }
    }
}
