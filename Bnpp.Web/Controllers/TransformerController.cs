using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities.Electrical;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class TransformerController : Controller
    {
        private IElectricalService _electrical;

        public TransformerController(IElectricalService electrical)
        {
            _electrical = electrical;
        }


        [Route("Transformer")]
        public IActionResult Index()
        {
            return View(_electrical.GetAllTransformers());
        }

        public IActionResult CreateNewTransformer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewTransformer(TransformerListViewModel transformer)
        {

            if (!ModelState.IsValid)
            {
                return View(transformer);
            }

            Transformer transformers = new Transformer()
            {
                Name = transformer.Name,
                Position = transformer.InstalationPosition,
                Azk = transformer.Azk,
                CreateDate = DateTime.Now,
            };
            _electrical.AddTransformer(transformers);

            return RedirectToAction("Index");
        }

        public IActionResult EditTransformer(int id)
        {
            return View(_electrical.GetTransformerById(id));
        }

        [HttpPost]
        public IActionResult EditTransformer(Transformer transformer)
        {
            if (!ModelState.IsValid)
            {
                return View(transformer);
            }
            _electrical.UpdateTransformer(transformer);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteTransformer(string[] transformerId)
        {
            foreach (string id in transformerId)
            {
                _electrical.DeleteTransformer(Convert.ToInt32(id));
            }

            return Json(" Generators Successfully Deleted.");
        }
    }
}
