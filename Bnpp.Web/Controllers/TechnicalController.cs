using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.BasicData;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class TechnicalController : Controller
    {
        private IBasicDataService _dataService;

        public TechnicalController(IBasicDataService dataService)
        {
            _dataService = dataService;
        }

        [Route("Technical")]
        public IActionResult Index()
        {
            return View();
        }

        #region General Data

        [BindProperty] 
        public GeneralData data { get; set; }


        public IActionResult GeneralData()
        {
            return View(_dataService.GetAllGeneralData());
        }

        public IActionResult CreateGeneralData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateGeneralData(GeneralData generalData)
        {
            if (!ModelState.IsValid)
                return View();

            _dataService.AddGeneralData(data);
            return new JsonResult("success");
        }

        public IActionResult EditGeneralData(int id)
        {
            return View(_dataService.GetGeneralDataById(id));
        }

        [HttpPost]
        public IActionResult EditGeneralData()
        {
            if (!ModelState.IsValid)
                return View();

            _dataService.UpdateGeneralData(data);
            return new JsonResult("success");
        }


        public IActionResult DeleteGeneralData(string[] generalId)
        {
            foreach (string id in generalId)
            {
                _dataService.DeleteGeneralData(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion


        public IActionResult DesignData()
        {
            return View();
        }



        public IActionResult Documents()
        {
            return View();
        }

        public IActionResult Safety()
        {
            return View();
        }

        public IActionResult Components()
        {
            return View();
        }

        public IActionResult ChemicalNorms()
        {
            return View();
        }

        public IActionResult TechnicalPrograms()
        {
            return View();
        }

        public IActionResult Sensors()
        {
            return View();
        }

        public IActionResult ControlPoints()
        {
            return View();
        }

        public IActionResult HForms()
        {
            return View();
        }
    }
}
