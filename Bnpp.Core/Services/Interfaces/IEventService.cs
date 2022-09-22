using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.BasicData;
using Bnpp.DataLayer.ViewModels;
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

        #region Before After

        BeforeStatusViewModel GetBeforStatusForShow(int eventsId);
        void BeforeStatusEvents(BeforeStatusViewModel beforeEvents, int eventsId);

        AfterStatusViewModel GetAfterStatusForShow(int eventsId);
        void AfterStatusEvents(AfterStatusViewModel afterEvents, int eventsId);

        #endregion


    }
}
