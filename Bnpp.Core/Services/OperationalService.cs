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
    public class OperationalService : IOperationalService
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

        public List<OccuranceListViewModel> GetAllOccurances()
        {
            return _context.Occurances.Where(e => e.IsDelete == false).
                Select(e => new OccuranceListViewModel()
                {
                    OccuranceId = e.OccuranceId,
                    AllowableNumber = e.AllowableNumber,
                    NameOfCondition = e.NameofConditions,
                    Occurrances = e.Occurrances,
                    CreateDate = e.CreateDate
                }).ToList();
        }

        public Occurance GetOccuranceById(int occuranceId)
        {
            return _context.Occurances.Find(occuranceId);
        }

        public int AddOccurance(Occurance occurance)
        {
            _context.Add(occurance);
            _context.SaveChanges();
            return occurance.OccuranceId;
        }

        public void UpdateOccurance(Occurance occurance)
        {
            _context.Occurances.Update(occurance);
            _context.SaveChanges();
        }

        public void DeleteOccurance(int occuranceId)
        {
            var occurance = GetOccuranceById(occuranceId);
            occurance.IsDelete = true;
            UpdateOccurance(occurance);
        }

        public List<DesignBasisListViewModel> GetAllBasisAccident()
        {
            return _context.DesignBasis.Where(e => e.IsDelete == false).
                Select(e => new DesignBasisListViewModel()
                {
                    DesigneId = e.BasislId,
                    AllowableNumber = e.AllowableNumber,
                    NameOfCondition = e.NameofConditions,
                    Occurrances = e.Occurrance,
                    CreateDate = e.CreateDate
                }).ToList();
        }
        public DesignBasis GetBasisAccidentById(int basisId)
        {
            return _context.DesignBasis.Find(basisId);
        }

        public int AddBasisAccident(DesignBasis designBasis)
        {
            _context.Add(designBasis);
            _context.SaveChanges();
            return designBasis.BasislId;
        }

        public void UpdateBasisAccident(DesignBasis designBasis)
        {
            _context.DesignBasis.Update(designBasis);
            _context.SaveChanges();
        }

        public void DeleteBasisAccident(int basisId)
        {
            var accident = GetBasisAccidentById(basisId);
            accident.IsDelete = true;
            UpdateBasisAccident(accident);
        }
    }


}

