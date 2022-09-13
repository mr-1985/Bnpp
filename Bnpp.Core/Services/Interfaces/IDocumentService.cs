using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.DataLayer.Entities.AgeingDocuments;
using Bnpp.DataLayer.Entities.BasicData;
using Microsoft.AspNetCore.Http;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IDocumentService
    {
        #region  Ageing Document

        List<OperationalDocuments> GetAllOperationalDocuments();
        int AddOperationalDocuments(OperationalDocuments operational, IFormFile imgoperational);
        OperationalDocuments GetOperationalDocumentsById(int operationalId);
        void UpdateOperationalDocuments(OperationalDocuments operational, IFormFile imgoperational);
        void DeleteOperationalDocuments(int operationalId);

        #endregion
    }
}
