using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.DataLayer.Entities.AgeingMechanism;
using Microsoft.AspNetCore.Http;


namespace Bnpp.Core.Services.Interfaces
{
    public interface IMechanismService
    {
        #region Mechanism

        List<Mechanism> GetAllMechanism();

        int AddMechanism(Mechanism mechanism);

        void UpdateMechanism(Mechanism mechanism);
        Mechanism GetMechanismById(int mechanismId);

        void DeleteMechanism(int mechanismId);

        #endregion


        #region MechanismDocuments

        List<MechanismDocuments> GetAllMechanismDocuments();
        int AddMechanismDocuments(MechanismDocuments documents, IFormFile imgdocuments);
        MechanismDocuments GetMechanismDocumentsById(int documentsId);
        void UpdateMechanismDocuments(MechanismDocuments documents, IFormFile imgdocuments);
        void DeleteMechanismDocuments(int documentsId);

        #endregion
    }
}
