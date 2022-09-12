using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.BasicData;

namespace Bnpp.Core.Services
{
    public class BasicDataService : IBasicDataService
    {
        private BnppContext _context;

        public BasicDataService(BnppContext context)
        {
            _context = context;
        }
        public List<GeneralData> GetAllGeneralData()
        {
            return _context.GeneralData.Where(g => g.IsDelete == false).ToList();
        }

        public int AddGeneralData(GeneralData data)
        {
            data.CreateDate = DateTime.Now;
            _context.Add(data);
            _context.SaveChanges();
            return data.GeneralId;
        }

        public void UpdateGeneralData(GeneralData data)
        {
            data.CreateDate=DateTime.Now;
            _context.Update(data);
            _context.SaveChanges();
        }

        public GeneralData GetGeneralDataById(int generalId)
        {
            return _context.GeneralData.Find(generalId);
        }

        public void DeleteGeneralData(int generalId)
        {
            var general = GetGeneralDataById(generalId);
            general.IsDelete = true;
            UpdateGeneralData(general);
        }

        public List<DesignData> GetAllDesignData()
        {
            return _context.DesignData.Where(g => g.IsDelete == false).ToList();
        }

        public int AddDesignData(DesignData design)
        {
            design.CreateDate = DateTime.Now;
            _context.DesignData.Add(design);
            _context.SaveChanges();
            return design.DesignId;
        }

        public void UpdateDesignData(DesignData design)
        {
            design.CreateDate = DateTime.Now;
            _context.Update(design);
            _context.SaveChanges();
        }

        public DesignData GetDesignDataById(int designId)
        {
            return _context.DesignData.Find(designId);
        }

        public void DeleteDesignData(int designId)
        {
            var design = GetDesignDataById(designId);
            design.IsDelete = true;
            UpdateDesignData(design);
        }
    }
}
