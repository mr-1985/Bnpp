using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.BasicData;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IEventService
    {
        List<Events> GetAllEvents();
        int AddEvents(Events events, IFormFile imgEvents);
        void UpdateEvents(Events events, IFormFile imgEvents);
        Events GetEventsById(int eventsId);

        void DeleteEvents(int eventsId);
    }
}
