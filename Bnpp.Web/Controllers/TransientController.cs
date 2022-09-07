using System;
using System.Globalization;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class TransientController : Controller
    {
        private IElectricalService _electrical;
        private IOperationalService _operational;

        public TransientController(IElectricalService electrical, IOperationalService operational)
        {
            _electrical = electrical;
            _operational = operational;
        }

        [Route("Transient")]
        public IActionResult Index()
        {
            return View();
        }

        #region NormalOperations

        public IActionResult NormalOperations()
        {
            return View(_operational.GetAllNormalOperations());
        }

        //public IActionResult ShowListOfNormalOperations()
        //{
        //    return View(_electrical.GetAllDiesels());
        //}
        [BindProperty]
        public OperationalData NormalOperation { get; set; }
        public IActionResult CreateNormalOperations()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CreateNormalOperations(string StartDates = "")
        {
            if (StartDates != "")
            {
                string[] std = StartDates.Split('/');
                NormalOperation.CreateDate= new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            
            _operational.AddNormalOperation(NormalOperation);

            return new JsonResult("success");
        }

        public IActionResult EditNormalOperations(int id)
        {
            

            return View(_operational.GetNormalOperationalById(id));
        }

        [HttpPost]
        public IActionResult EditNormalOperations(string StartDates = "")
        {
            if (!ModelState.IsValid)
            {
                return View(NormalOperation);
            }

            if (StartDates != "")
            {
                string[] std = StartDates.Split('/');
                NormalOperation.CreateDate = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }


            _operational.UpdateNormalOperational(NormalOperation);

            return Json(" Diesel Generators Successfully Deleted.");
        }

        public IActionResult DeleteNormalOperations(string[] operationalId)
        {
            foreach (string id in operationalId)
            {
                _operational.DeleteNormalOperational(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }

        #endregion

            #region OperationalOccurence

            public IActionResult OperationalOccurence()
        {
            return View();
        }

        #endregion

        #region DesignBasisAccidents

        public IActionResult DesignBasisAccidents()
        {
            return View();
        }

        #endregion

    }
}
