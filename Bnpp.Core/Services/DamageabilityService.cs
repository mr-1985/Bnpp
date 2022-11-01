using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
