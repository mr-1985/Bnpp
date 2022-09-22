using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services
{
    public class MaintenanceService:IMaintenanceService
    {
        private BnppContext _context;

        public MaintenanceService(BnppContext context)
        {
            _context = context;
        }



        #region DefectList


        public int AddDefectList(DefectList defect)
        {
            defect.CreateDate=DateTime.Now;
            _context.Add(defect);
            _context.SaveChanges();
            return defect.DefectListId;
        }

        public void DeleteDefectList(int defectId)
        {
            var dlist=GetDefectListById(defectId);
            dlist.IsDelete = true;
            _context.Update(dlist);
            _context.SaveChanges();
        }

        public List<DefectList> GetAllDefectList()
        {
            return _context.DefectList.Where(d=>d.IsDelete==false).ToList();
        }

        public DefectList GetDefectListById(int defectId)
        {
            return _context.DefectList.Find(defectId);
        }

        public void UpdateDefectList(DefectList defect)
        {
            defect.CreateDate= DateTime.Now;
            _context.Update(defect);
            _context.SaveChanges();
        }


        #endregion
    }
}
