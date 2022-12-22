using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.ViewModels;

namespace Bnpp.Core.Services
{
    public class DamageabilityService : IDamageabilityService
    {
        private BnppContext _context;
        public DamageabilityService(BnppContext context)
        {
            _context = context;
        }


        public int AddNewDamageabilityReport(DamageabilityReport report)
        {
            report.CreateDate = DateTime.Now;

            _context.Add(report);
            _context.SaveChanges();

            return report.ID;
        }

        public void DeleteDamageabilityReport(int reportId)
        {
            var damageReport = GetDamageabilityReportById(reportId);
            damageReport.IsDelete = true;
            _context.Update(damageReport);
            _context.SaveChanges();
        }

        public List<DamageabilityReport> GetAllReports(string filter = "", string date = "", string fileDate = "")
        {
            IQueryable<DamageabilityReport> result = _context.DamageabilityReports;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.Akz.Contains(filter));
            }

            if (!string.IsNullOrEmpty(date))
            {
                var date1 = DateTime.Parse(date);
                result = result.Where(c => c.ReportDate.Date == date1.Date);
            }

            if (!string.IsNullOrEmpty(fileDate))
            {
                var datefile = DateTime.Parse(fileDate);
                result = result.Where(c => c.CreateDate.Date == datefile.Date);
            }

            //            return result.GroupBy(d => d.Akz).OrderBy(d => d.Key)
            //.Select(s => new { Key = s.Key, studentobj = s.OrderBy(y => y.Totaldamageabilityofequipment) }).ToList();
            //return result.GroupBy(d => d.Akz);
            //return result.GroupBy(d => d.Akz).Select(s => new DamageabilityReport()).ToList();

            //var groupedResult = from s in result
            //                    group s by s.Akz;

            //foreach (var akzGroup in groupedResult)
            //{
            //    Console.WriteLine("Age Group: {0}", akzGroup.Key); //Each group has a key 

            //    foreach (DamageabilityReport s in akzGroup) // Each group has inner collection
            //        Console.WriteLine("Student Name: {0}", s.Akz);
            //}

            return result.Where(r=>r.IsDelete==false).ToList();
        }

        public List<DamageabilityReport> GetAllReportsForCompare()
        {
            return _context.DamageabilityReports.Where(r=>r.CreateDate.Date==DateTime.Now.Date).ToList();
        }

        public List<ReportListViewModel> GetAllTotalReports()
        {
            var max = _context.DamageabilityReports.Max(m => m.CreateDate.Date);


            return _context.DamageabilityReports.Where(b => b.IsDelete == false && b.CreateDate.Date == max).Select(t => new ReportListViewModel()
            {
                ID = t.ID,
                Totaldamageabilityofequipment = t.Totaldamageabilityofequipment
            }).Take(98).ToList();
        }

        public DamageabilityReport GetDamageabilityReportById(int reportId)
        {
            return _context.DamageabilityReports.Find(reportId);
        }

        public void UpdateDamageabilityReport(string allowableCuf, string allowableLifeTime, string allowablechangingratio, int reportId)
        {

            #region Edit AllowableCUF & AllowableLifeTime in all of records

            //var totality = _context.DamageabilityReports.ToList();

            //foreach (var report in totality)
            //{
            //    report.AllowableCUF = allowableCuf;
            //    report.AllowableLifeTime = allowableLifeTime;
            //    _context.Update(report);
            //    _context.SaveChanges();
            //}

            #endregion

            var report =GetDamageabilityReportById(reportId);
            var dateOfReport = report.CreateDate.Date;

            var firstRecord=_context.DamageabilityReports.FirstOrDefault(r=>r.CreateDate.Date==dateOfReport).ID;

            var numberofRow = reportId - firstRecord;

            var firstId = _context.DamageabilityReports.Min(i => i.ID);
            var endId= _context.DamageabilityReports.Max(i => i.ID);
            var start = firstId + numberofRow;

            for(int i = start; i <= endId; i += 98)
            {
                var editingreport = GetDamageabilityReportById(i);
                editingreport.AllowableCUF= allowableCuf;
                editingreport.AllowableLifeTime= allowableLifeTime;
                editingreport.AllowableChangingRatio = allowablechangingratio;
                _context.Update(editingreport);
                _context.SaveChanges();
            }

        }
    }
}
