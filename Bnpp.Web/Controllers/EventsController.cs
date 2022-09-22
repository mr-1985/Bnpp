using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.BasicData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System;
using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.ViewModels;

namespace Bnpp.Web.Controllers
{
    public class EventsController : Controller
    {
        private IEventService _eventService;

        public EventsController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [BindProperty] 
        public Events Events { get; set; }

        [Route("Events")]
        public IActionResult Index()
        {
            return View(_eventService.GetAllEvents());
        }

        public IActionResult CraeteEvents()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CraeteEvents(IFormFile fileEvents, string EventDate = "",string ReportDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            if (EventDate != "")
            {
                string[] std = EventDate.Split('/', ' ', ':');
                Events.EventDate = new DateTime(
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    int.Parse(std[3]),
                    int.Parse(std[4]),
                    int.Parse(std[5]),
                    new GregorianCalendar()
                );
            }

            if (ReportDate != "")
            {
                string[] std = ReportDate.Split('/', ' ', ':');
                Events.ReportDate = new DateTime(
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    int.Parse(std[3]),
                    int.Parse(std[4]),
                    int.Parse(std[5]),
                    new GregorianCalendar()
                );
            }

            _eventService.AddEvents(Events, fileEvents);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditEvents(int id)
        {
            return View(_eventService.GetEventsById(id));
        }

        [HttpPost]
        public IActionResult EditEvents(IFormFile fileEvents, string EventDate = "", string ReportDate = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            if (EventDate != "")
            {
                string[] std = EventDate.Split('/', ' ', ':');
                Events.EventDate = new DateTime(
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    int.Parse(std[3]),
                    int.Parse(std[4]),
                    int.Parse(std[5]),
                    new GregorianCalendar()
                );
            }

            if (ReportDate != "")
            {
                string[] std = ReportDate.Split('/', ' ', ':');
                Events.ReportDate = new DateTime(
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    int.Parse(std[3]),
                    int.Parse(std[4]),
                    int.Parse(std[5]),
                    new GregorianCalendar()
                );
            }

            _eventService.UpdateEvents(Events, fileEvents);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteEvents(string[] eventId)
        {
            foreach (string id in eventId)
            {
                _eventService.DeleteEvents(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }

        #region After Before

        public IActionResult BeforeStatus(int id)
        {
            
            ViewData["eventId"] = id;
            return View(_eventService.GetBeforStatusForShow(id));
        }

        [HttpPost]
        public IActionResult BeforeStatus(int id,BeforeStatusViewModel before)
        {
            _eventService.BeforeStatusEvents(before, id);
            return Json(" Electormotors Successfully Deleted.");
        }


        public IActionResult AfterStatus(int id)
        {
            ViewData["eventId"] = id;
            return View(_eventService.GetAfterStatusForShow(id));
        }

        [HttpPost]
        public IActionResult AfterStatus(int id, AfterStatusViewModel after)
        {
            _eventService.AfterStatusEvents(after, id);
            return Json(" Electormotors Successfully Deleted.");
        }
        #endregion
    }
}
