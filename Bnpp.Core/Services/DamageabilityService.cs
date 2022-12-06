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
                result = result.Where(c => c.DateOfReport == date);
            }

            if (!string.IsNullOrEmpty(fileDate))
            {
                var datefile = DateTime.Parse(fileDate);
                result = result.Where(c => c.ReportDate == datefile);
            }

            //return result.GroupBy(d => d.Akz).Select(s => new DamageabilityReport()).ToList();
            //return result.GroupBy(d => d.Akz);
            ////return result.GroupBy(d => d.Akz).Select(s => { GroupName = s.Key, Members = s }).ToList();

            //return result.OrderBy(d => d.Akz).Distinct().ToList();
            return result.ToList();
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

        public void UpdateDamageabilityReport(string allowableCuf, string allowableLifeTime)
        {
            var totality = _context.DamageabilityReports.ToList();
           
            foreach (var report in totality)
            {
                report.AllowableCUF = allowableCuf;
                report.AllowableLifeTime = allowableLifeTime;
                _context.Update(report);
                _context.SaveChanges();
            }

        }
    }
}
