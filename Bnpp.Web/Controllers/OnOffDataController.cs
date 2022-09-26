using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.ONOFF;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Bnpp.Web.Controllers
{
    public class OnOffDataController : Controller
    {
        private IChangeService _changeService;
        public OnOffDataController(IChangeService changeService)
        {
            _changeService = changeService;
        }

        [BindProperty]
        public ChangeState Change { get; set; }

        [Route("OnOffData")]
        public IActionResult Index()
        {
            ViewData["States"] = _changeService.GetAllStates();
            return View(_changeService.GetAllChangeState());
        }

        public IActionResult CreateOnOffData()
        {
            ViewData["States"] = _changeService.GetAllStates();
            return View();
        }

        [HttpPost]
        public IActionResult CreateOnOffData(List<int> SelectedStates, string Dateofchangestate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            if (Dateofchangestate != "")
            {
                string[] std = Dateofchangestate.Split('/', ' ', ':');
                Change.ChangeStateDate = new DateTime(
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    int.Parse(std[3]),
                    int.Parse(std[4]),
                    int.Parse(std[5]),
                    new GregorianCalendar()
                );
            }

           int changestateId= _changeService.AddChangeState(Change);

            _changeService.AddStateToStaeChanges(changestateId, SelectedStates);



            return RedirectToAction("Index");
        }

        public IActionResult EditOnOffData(int id)
        {
            ViewData["States"] = _changeService.GetAllStates();
            return View(_changeService.GetChangeStateById(id));
        }

        [HttpPost]
        public IActionResult EditOnOffData(int ChangeStateId, List<int> SelectedStates, string Dateofchangestate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            if (Dateofchangestate != "")
            {
                string[] std = Dateofchangestate.Split('/', ' ', ':');
                Change.ChangeStateDate = new DateTime(
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    int.Parse(std[3]),
                    int.Parse(std[4]),
                    int.Parse(std[5]),
                    new GregorianCalendar()
                );
            }

             _changeService.UpdateChangeState(Change);

            _changeService.EDitStateToStaeChanges(ChangeStateId, SelectedStates);



            return RedirectToAction("Index");
        }

        public IActionResult DeleteOnOffData(string[] operationalId)
        {
            foreach (string id in operationalId)
            {
                _changeService.DeleteChangeState(Convert.ToInt32(id));
            }

            return Json(" Diesel Generators Successfully Deleted.");
        }
    }
}
