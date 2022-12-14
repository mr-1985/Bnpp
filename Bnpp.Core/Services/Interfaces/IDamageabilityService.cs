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
        List<DamageabilityReport> GetAllReportsForCompare(DateTime date);
        int AddNewDamageabilityReport(DamageabilityReport report);
        void UpdateDamageabilityReport(string allowableCuf,string allowableLifeTime,string allowablechangingratio, int reportId);
        DamageabilityReport GetDamageabilityReportById(int reportId);
        DamageabilityReport GetDamageabilityReportForUseSomeData();
        void DeleteDamageabilityReport(int reportId);

        int AddInitialData(InitialData initial);
        List<InitialData> GetAllInitialData();
        InitialData GetInitialDataForUseSomeData();
    }
}
