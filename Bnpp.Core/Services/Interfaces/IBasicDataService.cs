using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.DataLayer.Entities.BasicData;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IBasicDataService
    {
        #region General Data

        List<GeneralData> GetAllGeneralData();
        int AddGeneralData(GeneralData data);
        void UpdateGeneralData(GeneralData data);
        GeneralData GetGeneralDataById(int generalId);

        void DeleteGeneralData(int generalId);
        #endregion
    }
}
