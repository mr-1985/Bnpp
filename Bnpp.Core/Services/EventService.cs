using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.ViewModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services
{
    public class EventService : IEventService
    {
        private BnppContext _context;

        public EventService(BnppContext context)
        {
            _context = context;
        }
        public int AddEvents(Events events, IFormFile imgEvents)
        {
            events.CreateDate = DateTime.Now;

            if (imgEvents != null)
            {
                events.EventsImage = Guid.NewGuid() + Path.GetExtension(imgEvents.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", events.EventsImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgEvents.CopyTo(stream);
                }
            }

            _context.Add(events);
            _context.SaveChanges();
            return events.EventsId;
        }

        public void AfterStatusEvents(AfterStatusViewModel afterEvents, int eventsId)
        {
            var afterEvnt = GetEventsById(eventsId);
            afterEvnt.AfterHeatPower = afterEvents.AfterPressureWater;
            afterEvnt.AfterElectricalPower = afterEvents.AfterElectricalPower;
            afterEvnt.AfterEffectiveWorkingDays = afterEvents.AfterEffectiveWorkingDays;
            afterEvnt.AfterPressureWater = afterEvents.AfterPressureWater;
            afterEvnt.AfterPressureinFirstCircuit = afterEvents.AfterPressureinFirstCircuit;
            afterEvnt.AfterPressureinSecondCircuit = afterEvents.AfterPressureinSecondCircuit;
            afterEvnt.AfterVaccuminCondensor = afterEvents.AfterVaccuminCondensor;

            _context.Update(afterEvnt);
            _context.SaveChanges();
        }

        public void BeforeStatusEvents(BeforeStatusViewModel beforeEvents, int eventsId)
        {
            var beforeEvnt = GetEventsById(eventsId);
            beforeEvnt.BeforeHeatPower = beforeEvents.BeforeHeatPower;
            beforeEvnt.BeforeElectricalPower = beforeEvents.BeforeElectricalPower;
            beforeEvnt.BeforeEffectiveWorkingDays = beforeEvents.BeforeEffectiveWorkingDays;
            beforeEvnt.BeforePressureWater = beforeEvents.BeforePressureWater;
            beforeEvnt.BeforePressureinFirstCircuit = beforeEvents.BeforePressureinFirstCircuit;
            beforeEvnt.BeforePressureinSecondCircuit = beforeEvents.BeforePressureinSecondCircuit;
            beforeEvnt.BeforeVaccuminCondensor = beforeEvents.BeforeVaccuminCondensor;
            _context.Update(beforeEvnt);
            _context.SaveChanges();
        }

        public void DeleteEvents(int eventsId)
        {
            throw new NotImplementedException();
        }

        public AfterStatusViewModel GetAfterStatusForShow(int eventsId)
        {
            return _context.Events.Where(e => e.EventsId == eventsId).Select(e => new AfterStatusViewModel()
            {
                AfterEffectiveWorkingDays = e.AfterEffectiveWorkingDays,
                AfterPressureWater = e.AfterPressureWater,
                AfterPressureinFirstCircuit = e.AfterPressureinFirstCircuit,
                AfterPressureinSecondCircuit = e.AfterPressureinSecondCircuit,
                AfterElectricalPower = e.AfterElectricalPower,
                AfterVaccuminCondensor = e.AfterVaccuminCondensor,
                AfterHeatPower = e.AfterHeatPower,
                EventsId = e.EventsId
            }).Single();
        }

        public List<Events> GetAllEvents()
        {
            return _context.Events.Where(e => e.IsDelete == false).ToList();
        }

        public BeforeStatusViewModel GetBeforStatusForShow(int eventsId)
        {
            return _context.Events.Where(e => e.EventsId == eventsId).Select(e => new BeforeStatusViewModel()
            {
                EventsId = e.EventsId,
                BeforeHeatPower = e.BeforeHeatPower,
                BeforePressureWater = e.BeforePressureWater,
                BeforePressureinFirstCircuit = e.BeforePressureinFirstCircuit,
                BeforePressureinSecondCircuit = e.BeforePressureinSecondCircuit,
                BeforeVaccuminCondensor = e.BeforeVaccuminCondensor,
                BeforeEffectiveWorkingDays = e.BeforeEffectiveWorkingDays,
                BeforeElectricalPower = e.BeforeElectricalPower
            }).Single();
        }

        public Events GetEventsById(int eventsId)
        {
            return _context.Events.Find(eventsId);
        }

        public void UpdateEvents(Events events, IFormFile imgEvents)
        {
            throw new NotImplementedException();
        }
    }
}
