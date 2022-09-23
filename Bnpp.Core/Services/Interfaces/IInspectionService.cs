using Bnpp.DataLayer.Entities.BasicData;
using Bnpp.DataLayer.Entities.InspectionData;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IInspectionService
    {
        #region Inspection Document

        List<InspectionDocument> GetAllInspectionReports();
        int AddInspectionReports(InspectionDocument document, IFormFile imgReports);
        InspectionDocument GetInspectionReportsById(int reportId);
        void UpdateInspectionReports(InspectionDocument document, IFormFile imgReports);
        void DeleteInspectionReports(int reportId);

        #endregion

        #region Inspection Instructions

        List<InspectionDocument> GetAllInspectionInstructions();
        int AddInspectionInstructions(InspectionDocument document, IFormFile imgInstructions);
        InspectionDocument GetInspectionInstructionsById(int instructionsId);
        void UpdateInspectionInstructions(InspectionDocument document, IFormFile imgInstructions);
        void DeleteInspectionInstructions(int instructionsId);

        #endregion
    }
}
