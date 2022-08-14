using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities.Electrical;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class GeneratorController : Controller
    {
        private IElectricalService _electrical;

        public GeneratorController(IElectricalService electrical)
        {
            _electrical = electrical;
        }

        [Route("Generator")]
        public IActionResult Index()
        {
            return View(_electrical.GetAllGenerators());
        }

        public IActionResult CreateNewGenerator()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewGenerator(GeneratorListViewModel generator)
        {
            if (!ModelState.IsValid)
            {
                return View(generator);
            }

            Generator generators = new Generator()
            {
                Name = generator.Name,
                Position = generator.InstalationPosition,
                Azk = generator.Azk,
                CreateDate = DateTime.Now
            };
            _electrical.AddGenerator(generators);

            return RedirectToAction("Index");
        }

        public IActionResult EditGenerator(int id)
        {
            return View(_electrical.GetGeneratorById(id));
        }

        [HttpPost]
        public IActionResult EditGenerator(Generator generator)
        {
            if (!ModelState.IsValid)
            {
                return View(generator);
            }
            _electrical.UpdateGenerator(generator);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteGenerator(string [] generatorId)
        {
            foreach (string id in generatorId)
            {
                _electrical.DeleteGenerator(Convert.ToInt32(id));
            }

            return Json(" Generators Successfully Deleted.");
        }
    }
}
