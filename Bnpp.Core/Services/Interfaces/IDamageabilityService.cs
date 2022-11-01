using Bnpp.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IDamageabilityService
    {
        List<DamageabilityReport> GetAllReports();
        int AddNewDamageabilityReport(DamageabilityReport report);
    }
}
