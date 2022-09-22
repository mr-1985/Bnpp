using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        #region Spare Parts

        public int AddSpareParts(SpareParts spare)
        {
            spare.CreateDate = DateTime.Now;
            _context.Add(spare);
            _context.SaveChanges();
            return spare.SpareId;
        }

        public SpareParts GetSparePartsById(int spareId)
        {
            return _context.SpareParts.Find(spareId);
        }

        public void UpdateSpareParts(SpareParts spare)
        {
            spare.CreateDate=DateTime.Now;
            _context.Update(spare);
            _context.SaveChanges();
        }

        public List<SpareParts> GetAllSpareParts()
        {
            return _context.SpareParts.Where(s => s.IsDelete == false).ToList();
        }

        public void DeleteSpareParts(int spareId)
        {
            var splist=GetSparePartsById(spareId);
            splist.IsDelete = true;
            UpdateSpareParts(splist);

        }


        #endregion
        #region Measurements

        public List<Measurements> GetAllMeasurements()
        {
            return _context.Measurements.Where(m => m.IsDelete == false).ToList();
        }

        public int AddMeasurements(Measurements measure)
        {
            measure.CreateDate = DateTime.Now;
            _context.Add(measure);
            _context.SaveChanges();
            return measure.MeasurementId;
        }

        public Measurements GetMeasurementsById(int measureId)
        {
            return _context.Measurements.Find(measureId);
        }

        public void UpdateMeasurements(Measurements measure)
        {
            measure.CreateDate= DateTime.Now;
            _context.Update(measure);
            _context.SaveChanges();
        }

        public void DeleteMeasurements(int measureId)
        {
            var mesure=GetMeasurementsById(measureId);
            mesure.IsDelete = true;
            UpdateMeasurements(mesure);
        }

        #endregion
    }
}
