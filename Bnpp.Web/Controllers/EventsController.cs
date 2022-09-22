using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.BasicData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System;
using Bnpp.DataLayer.Entities;

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
    }
}
