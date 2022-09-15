using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.AgeingMechanism;

namespace Bnpp.Core.Services
{
    
    public class MechanismService:IMechanismService
    {
        private BnppContext _context;

        public MechanismService(BnppContext context)
        {
            _context = context;
        }

        #region Mechanism

        public List<Mechanism> GetAllMechanism()
        {
            return _context.Mechanism.Where(m => m.IsDelete == false).ToList();
        }

        public int AddMechanism(Mechanism mechanism)
        {
           mechanism.CreateDate=DateTime.Now;
           _context.Add(mechanism);
           _context.SaveChanges();
           return mechanism.MechanismId;
        }

        public void UpdateMechanism(Mechanism mechanism)
        {
           mechanism.CreateDate=DateTime.Now;
           _context.Update(mechanism);
           _context.SaveChanges();
        }

        public Mechanism GetMechanismById(int mechanismId)
        {
            return _context.Mechanism.Find(mechanismId);
        }

        public void DeleteMechanism(int mechanismId)
        {
            var meganism = GetMechanismById(mechanismId);
            meganism.IsDelete = true;
            UpdateMechanism(meganism);
        }

        #endregion
    }
}
