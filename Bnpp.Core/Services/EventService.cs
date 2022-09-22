using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public void DeleteEvents(int eventsId)
        {
            throw new NotImplementedException();
        }

        public List<Events> GetAllEvents()
        {
           return _context.Events.Where(e=>e.IsDelete==false).ToList();
        }

        public Events GetEventsById(int eventsId)
        {
            throw new NotImplementedException();
        }

        public void UpdateEvents(Events events, IFormFile imgEvents)
        {
            throw new NotImplementedException();
        }
    }
}
