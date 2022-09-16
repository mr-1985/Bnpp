using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities;

namespace Bnpp.Core.Services
{
    public class CommissioningService:ICommissioningService
    {
        private BnppContext _context;

        public CommissioningService(BnppContext context)
        {
            _context = context;
        }
        public List<Commissioning> GetAllCommissioning()
        {
            return _context.Commissioning.Where(c => c.IsDelete == false).ToList();
        }

        public int AddCommissioning(Commissioning commissioning)
        {
            commissioning.CreateDate=DateTime.Now;
            _context.Add(commissioning);
            _context.SaveChanges();
            return commissioning.CommissioningId;
        }

        public void UpdateCommissioning(Commissioning commissioning)
        {
           commissioning.CreateDate=DateTime.Now;
           _context.Update(commissioning);
           _context.SaveChanges();
        }

        public Commissioning GetCommissioningById(int commissioningId)
        {
            return _context.Commissioning.Find(commissioningId);
        }

        public void DeleteCommissioning(int commissioningId)
        {
            var commission = GetCommissioningById(commissioningId);
            commission.IsDelete = true;
            UpdateCommissioning(commission);
        }
    }
}
