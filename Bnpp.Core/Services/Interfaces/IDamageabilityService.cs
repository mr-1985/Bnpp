using Bnpp.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.ViewModels;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IDamageabilityService
    {
        List<ReportListViewModel> GetAllTotalReports();
        List<DamageabilityReport> GetAllReports(string filter = "",string date="",string fileDate="");
        List<DamageabilityReport> GetAllReportsForCompare();
        int AddNewDamageabilityReport(DamageabilityReport report);
        void UpdateDamageabilityReport(string allowableCuf,string allowableLifeTime);
        DamageabilityReport GetDamageabilityReportById(int reportId);
        void DeleteDamageabilityReport(int reportId);
    }
}
