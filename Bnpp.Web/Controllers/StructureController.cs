using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System.Data.OleDb;
using System.IO;



namespace Bnpp.Web.Controllers
{
    public class StructureController : Controller
    {
        private IStructureService _structure;
       

        public StructureController(IStructureService structure)
        {
            _structure = structure;
           
        }

        [Route("Structure")]
        public IActionResult Index()
        {
            return View(_structure.GetAllStructures());
        }


        public IActionResult CreateNewStructure()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewStructure(StructureListViewModel structure)
        {
            if (!ModelState.IsValid)
            {
                return View(structure);
            }

            Strcture structures = new Strcture()
            {
                ConstructionName = structure.ConstructionName,
                Azk = structure.Azk,
                CreateDate = DateTime.Now,
            };

            _structure.AddStructure(structures);

            return RedirectToAction("Index");
        }


        public IActionResult EditStructure(int id)
        {
            return View(_structure.GetStructureById(id));
        }

        [HttpPost]
        public IActionResult EditStructure(Strcture structure)
        {
            if (!ModelState.IsValid)
            {
                return View(structure);
            }
            _structure.UpdateStructure(structure);
            return RedirectToAction("Index");
        }

        public IActionResult DeletStructure(string [] structureId)
        {
            foreach (string id in structureId)
            {
                _structure.DeleteStructure(Convert.ToInt32(id));
            }

            return Json("Structures Successfully Deleted.");
        }

        


    }
}
