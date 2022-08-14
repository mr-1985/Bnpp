using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities;
using Microsoft.AspNetCore.Authorization;

namespace Bnpp.Web.Controllers
{
    [Authorize]
    public class EquipmentsController : Controller
    {
        private IMechanicalService _mechanical;

        public EquipmentsController(IMechanicalService mechanical)
        {
            _mechanical = mechanical;
        }

        [Route("Equipments")]
        public IActionResult Index()
        {
            return View(_mechanical.GetAllMechanicalEquipments());
        }

        public IActionResult CreateNewMechanicalEquipment()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateNewMechanicalEquipment(MechanicalListViewModel mechanical)
        {
            if (!ModelState.IsValid)
            {
                return View(mechanical);
            }

            MechanicalEquipment mechanicals = new MechanicalEquipment()
            {
                Name = mechanical.Name,
                Azk = mechanical.Azk,
                CreateDate = DateTime.Now,
            };

            _mechanical.AddMechanicalEquipment(mechanicals);

            return RedirectToAction("Index");
        }

        public IActionResult MechanicalEquipment()
        {
            return View();
        }

        public IActionResult EditEquipment(int id)
        {

            return View(_mechanical.GetEquipmentById(id));
        }

        [HttpPost]
        public IActionResult EditEquipment(MechanicalEquipment mechanical)
        {
            if (!ModelState.IsValid)
            {
                return View(mechanical);
            }
            _mechanical.UpdateMechanicalEquipment(mechanical);
            return RedirectToAction("Index");
        }

       

        [HttpPost]
        public IActionResult DeleteEquipment(string[] mechanicalId)
        {
            foreach (string id in mechanicalId)
            {
                _mechanical.DeleteMechanicalEquipment(Convert.ToInt32(id));
            }

            return Json(" Equipments Successfully Deleted.");
        }

    }
}
