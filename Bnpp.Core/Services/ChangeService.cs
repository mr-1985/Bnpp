using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.ONOFF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services
{
    public class ChangeService : IChangeService
    {
        private BnppContext _context;

        public ChangeService(BnppContext context)
        {
            _context = context;
        }


        public int AddChangeState(ChangeState change)
        {
            change.CreateDate=DateTime.Now;
            _context.Add(change);
            _context.SaveChanges();
            return change.ChangeStateId;
        }

        public void DeleteChangeState(int changeId)
        {
            throw new NotImplementedException();
        }

        public List<ChangeState> GetAllGeneralData()
        {
            return _context.ChangeState.Where(c=>c.IsDelete==false).ToList();
        }

        

        public ChangeState GetChangeStateById(int changeId)
        {
            throw new NotImplementedException();
        }

        public void UpdateChangeState(ChangeState change)
        {
            throw new NotImplementedException();
        }


        public List<States> GetAllStates()
        {
           return _context.State.Where(c=>c.IsDelete==false).ToList();
        }

        //public void AddStateToStaeChanges(int chngestateId, List<int> states)
        //{
        //    foreach (var p in states)
        //    {
               
        //        _context.StateOfChangeState.Add(new StateOfChangeState()
        //        {
        //            StateId = p,
        //            ChangeStateId = chngestateId
        //        });
        //    }

            

        //    _context.SaveChanges();
        //}
    }
}
