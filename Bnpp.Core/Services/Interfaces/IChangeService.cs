using Bnpp.DataLayer.Entities.BasicData;
using Bnpp.DataLayer.Entities.ONOFF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IChangeService
    {

        List<ChangeState> GetAllGeneralData();
        int AddChangeState(ChangeState change);
        void UpdateChangeState(ChangeState change);
        ChangeState GetChangeStateById(int changeId);

        void DeleteChangeState(int changeId);




        List<States> GetAllStates();
        //void AddStateToStaeChanges(int chngestateId, List<int> states);
    }
}
