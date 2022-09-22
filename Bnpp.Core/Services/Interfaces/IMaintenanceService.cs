using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IMaintenanceService
    {
        #region DefectList

        List<DefectList> GetAllDefectList();
        int AddDefectList(DefectList defect);
        DefectList GetDefectListById(int defectId);

        void UpdateDefectList(DefectList defect);
        void DeleteDefectList(int defectId);
        #endregion
    }
}
