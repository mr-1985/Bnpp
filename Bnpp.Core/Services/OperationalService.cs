using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities;

namespace Bnpp.Core.Services
{
    public class OperationalService:IOperationalService
    {
        private BnppContext _context;

        public OperationalService(BnppContext context)
        {
            _context = context;
        }
        public List<NormalOperationListViewModel> GetAllNormalOperations()
        {
            return _context.OperationalData.Where(e => e.IsDelete == false).
                Select(e => new NormalOperationListViewModel()
                {
                   OperationalId = e.OperationalId,
                   AllowableNumber = e.AllowableNumber,
                   NameOfCondition = e.NameofConditions,
                   Occurrances = e.Occurrance,
                    CreateDate = e.CreateDate
                }).ToList();
        }

        public int AddNormalOperation(OperationalData normalOperational)
        {
            _context.Add(normalOperational);
            _context.SaveChanges();
            return normalOperational.OperationalId;
        }

        public OperationalData GetNormalOperationalById(int normalId)
        {
            return _context.OperationalData.Find(normalId);
        }

        public void UpdateNormalOperational(OperationalData normalOperational)
        {
            _context.OperationalData.Update(normalOperational);
            _context.SaveChanges();
        }

        public void DeleteNormalOperational(int normalId)
        {
            var normalOperation = GetNormalOperationalById(normalId);
            normalOperation.IsDelete = true;
            UpdateNormalOperational(normalOperation);
        }
    }
}
