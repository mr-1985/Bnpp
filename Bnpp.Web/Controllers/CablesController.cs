using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class CablesController : Controller
    {
        private IElectricalService _electrical;

        public CablesController(IElectricalService electrical)
        {
            _electrical = electrical;
        }
        [Route("Cables")]
        public IActionResult Index()
        {
            return View(_electrical.GetAllCables());
        }

        public IActionResult CreateNewCables()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewCables(CableListViewModel cable)
        {
            if (!ModelState.IsValid)
            {
                return View(cable);
            }

            Cable cables = new Cable()
            {
                Name = cable.Name,
                Azk = cable.Azk,
                Position = cable.InstalationPosition,
                CreateDate = DateTime.Now,
            };

            _electrical.AddCables(cables);

            return RedirectToAction("Index");
        }

        public IActionResult EditCables(int id)
        {
            return View(_electrical.GetCableById(id));
        }

        [HttpPost]
        public IActionResult EditCables(Cable cable)
        {
            if (!ModelState.IsValid)
            {
                return View(cable);
            }
            _electrical.UpdateCables(cable);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteCable(string[] cableId)
        {
            foreach (string id in cableId)
            {
                _electrical.DeleteCable(Convert.ToInt32(id));
            }

            return Json(" Equipments Successfully Deleted.");
        }
    }
}
