using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.BasicData;
using Bnpp.DataLayer.Entities.Maintenance;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services
{
    public class MaintenanceService : IMaintenanceService
    {
        private BnppContext _context;

        public MaintenanceService(BnppContext context)
        {
            _context = context;
        }



        #region DefectList


        public int AddDefectList(DefectList defect)
        {
            defect.CreateDate = DateTime.Now;
            _context.Add(defect);
            _context.SaveChanges();
            return defect.DefectListId;
        }



        public void DeleteDefectList(int defectId)
        {
            var dlist = GetDefectListById(defectId);
            dlist.IsDelete = true;
            _context.Update(dlist);
            _context.SaveChanges();
        }



        public List<DefectList> GetAllDefectList()
        {
            return _context.DefectList.Where(d => d.IsDelete == false).ToList();
        }



        public DefectList GetDefectListById(int defectId)
        {
            return _context.DefectList.Find(defectId);
        }



        public void UpdateDefectList(DefectList defect)
        {
            defect.CreateDate = DateTime.Now;
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
            spare.CreateDate = DateTime.Now;
            _context.Update(spare);
            _context.SaveChanges();
        }

        public List<SpareParts> GetAllSpareParts()
        {
            return _context.SpareParts.Where(s => s.IsDelete == false).ToList();
        }

        public void DeleteSpareParts(int spareId)
        {
            var splist = GetSparePartsById(spareId);
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
            measure.CreateDate = DateTime.Now;
            _context.Update(measure);
            _context.SaveChanges();
        }

        public void DeleteMeasurements(int measureId)
        {
            var mesure = GetMeasurementsById(measureId);
            mesure.IsDelete = true;
            UpdateMeasurements(mesure);
        }



        #endregion

        #region Maintenance Forms

        public List<MaintenanceForm> GetAllMaintenanceForm()
        {
            return _context.MaintenanceForms.Where(f => f.IsDelete == false).ToList();
        }

        public int AddMaintenanceForm(MaintenanceForm forms, IFormFile imgForms)
        {

            forms.CreateDate = DateTime.Now;

            if (imgForms != null)
            {
                forms.MaintenanceFormImage = Guid.NewGuid() + Path.GetExtension(imgForms.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", forms.MaintenanceFormImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgForms.CopyTo(stream);
                }
            }

            _context.Add(forms);
            _context.SaveChanges();
            return forms.MaintenanceFormId;

        }

        public MaintenanceForm GetMaintenanceFormById(int formsId)
        {
            return _context.MaintenanceForms.Find(formsId);
        }

        public void UpdateMaintenanceForm(MaintenanceForm forms, IFormFile imgForms)
        {
            forms.CreateDate = DateTime.Now;

            if (imgForms != null)
            {
                if (forms.MaintenanceFormImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", forms.MaintenanceFormImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                forms.MaintenanceFormImage = Guid.NewGuid() + Path.GetExtension(imgForms.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", forms.MaintenanceFormImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgForms.CopyTo(stream);
                }
            }

            _context.Update(forms);
            _context.SaveChanges();
        }

        public void DeleteMaintenanceForm(int formsId)
        {
            var form = GetMaintenanceFormById(formsId);
            form.IsDelete = true;
            _context.Update(form);
            _context.SaveChanges();
        }





        #endregion

        #region

        public List<DefectionReports> GetAllDefectionReports()
        {
            return _context.DefectionReports.Where(d => d.IsDelete == false).ToList();
        }

        public int AddDefectionReports(DefectionReports reports, IFormFile imgReports)
        {
            reports.CreateDate = DateTime.Now;

            if (imgReports != null)
            {
                reports.DefectionReportsImage = Guid.NewGuid() + Path.GetExtension(imgReports.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", reports.DefectionReportsImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgReports.CopyTo(stream);
                }
            }

            _context.Add(reports);
            _context.SaveChanges();
            return reports.DefectionReportsId;
        }

        public DefectionReports GetDefectionReportsById(int reportsId)
        {
            return _context.DefectionReports.Find(reportsId);
        }

        public void UpdateDefectionReports(DefectionReports reports, IFormFile imgReports)
        {
            reports.CreateDate = DateTime.Now;

            if (imgReports != null)
            {
                if (reports.DefectionReportsImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", reports.DefectionReportsImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                reports.DefectionReportsImage = Guid.NewGuid() + Path.GetExtension(imgReports.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", reports.DefectionReportsImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgReports.CopyTo(stream);
                }
            }

            _context.Update(reports);
            _context.SaveChanges();
        }

        public void DeleteDefectionReports(int reportsId)
        {
            var rports = GetDefectionReportsById(reportsId);
            rports.IsDelete = true;
            _context.Update(rports);
            _context.SaveChanges();
        }



        #endregion

        #region Maintenance Programs

        public List<MaintenancePrograms> GetAllMaintenancePrograms()
        {
            return _context.MaintenancePrograms.Where(m => m.IsDelete == false).ToList();
        }

        public int AddMaintenancePrograms(MaintenancePrograms programs)
        {
            programs.CreateDate = DateTime.Now;
            _context.Add(programs);
            _context.SaveChanges();
            return programs.ProgramsId;
        }

        public MaintenancePrograms GetMaintenanceProgramsById(int programsId)
        {
            return _context.MaintenancePrograms.Find(programsId);
        }

        public void UpdateMaintenancePrograms(MaintenancePrograms programs)
        {
            programs.CreateDate= DateTime.Now;
            _context.Update(programs);
            _context.SaveChanges(true);
        }

        public void DeleteMaintenancePrograms(int programsId)
        {
            var pogram=GetMaintenanceProgramsById(programsId);
            pogram.IsDelete = true;
            UpdateMaintenancePrograms(pogram);
        }

        #endregion
    }
}
