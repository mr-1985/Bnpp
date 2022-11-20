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

        public List<DamageabilityReport> GetAllReports()
        {
            
            return _context.DamageabilityReports.Where(b => b.IsDelete == false).ToList();
        }

        public List<ReportListViewModel> GetAllTotalReports()
        {


            var max = _context.DamageabilityReports.Max(m => m.CreateDate.Date);



            //return _context.DamageabilityReports.Where(b => b.IsDelete == false).ToList();


            //return _context.DamageabilityReports.Where(b => b.IsDelete == false && b.CreateDate.Date == max).Select(t => new ReportListViewModel()
            //{
            //    ID = t.ID,
            //    Totaldamageabilityofequipment = t.Totaldamageabilityofequipment
            //}).ToList();

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

        public void UpdateDamageabilityReport(DamageabilityReport report)
        {
            var totality = GetAllReports();
            //report.CreateDate = DateTime.Now;
            
            _context.Update(totality);
            _context.SaveChanges();
        }
    }
}
