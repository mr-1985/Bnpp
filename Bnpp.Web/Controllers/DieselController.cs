using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities.Electrical;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class DieselController : Controller
    {
        private IElectricalService _electrical;

        public DieselController(IElectricalService electrical)
        {
            _electrical = electrical;
        }
        [Route("Diesel")]
        public IActionResult Index()
        {
            return View(_electrical.GetAllDiesels());
        }

        public IActionResult CreateNewDiesel()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewDiesel(DieselListViewModel diesel)
        {
            if (!ModelState.IsValid)
            {
                return View(diesel);
            }

            Dieselgenerator diesels = new Dieselgenerator()
            {
                Name = diesel.Name,
                Azk = diesel.Azk,
                Position = diesel.InstalationPosition,
                CreateDate = DateTime.Now
            };

            _electrical.AddDiesel(diesels);

            return RedirectToAction("Index");
        }

        public IActionResult EditDiesel(int id)
        {
            return View(_electrical.GetDieselById(id));
        }

        [HttpPost]
        public IActionResult EditDiesel(Dieselgenerator diesel)
        {
            if (!ModelState.IsValid)
            {
                return View(diesel);
            }
            _electrical.UpdateDiesel(diesel);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteDiesel(string[] dieselId)
        {
            foreach (string id in dieselId)
            {
                _electrical.DeleteDiesel(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }
    }
}
