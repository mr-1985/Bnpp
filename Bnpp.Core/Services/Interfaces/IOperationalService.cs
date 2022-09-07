using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IOperationalService
    {
        #region Normal Operation

        List<NormalOperationListViewModel> GetAllNormalOperations();
        int AddNormalOperation(OperationalData normalOperational);
        OperationalData GetNormalOperationalById(int normalId);

        void UpdateNormalOperational(OperationalData normalOperational);
        void DeleteNormalOperational(int normalId);

        #endregion

        #region Occurance
        List<OccuranceListViewModel> GetAllOccurances();
        Occurance GetOccuranceById(int occuranceId);
        int AddOccurance(Occurance occurance);
        void UpdateOccurance(Occurance occurance);
        void DeleteOccurance(int occuranceId);


        #endregion
    }
}
