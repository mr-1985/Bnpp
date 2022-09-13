using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.DataLayer.Entities.AgeingManagementDocuments;
using Bnpp.DataLayer.Entities.BasicData;
using Microsoft.AspNetCore.Http;

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


        #region Design Data
        List<DesignData> GetAllDesignData();

        int AddDesignData(DesignData design);

        void UpdateDesignData(DesignData design);
        DesignData GetDesignDataById(int designId);

        void DeleteDesignData(int designId);
        #endregion

        #region Documents

        List<DesignDocument> GetAllDesignDocument();
        int AddDesignDocument(DesignDocument designDocument, IFormFile imgDesignDocument);
        DesignDocument GetDesignDocumentById(int designDocumentId);
        void UpdateDesignDocument(DesignDocument designDocument, IFormFile imgDesignDocument);
        void DeleteDesignDocument(int designDocumentId);

        #endregion

        #region Chemical Norms

        List<ChemicalNorms> GetAllChemicalNorms();
        int AddChemicalNorms(ChemicalNorms chemical);
        ChemicalNorms GetChemicalNormsById(int chemicalId);
        void UpdateChemicalNorms(ChemicalNorms chemical);
        void DeleteChemicalNorms(int chemicalId);

        #endregion

        #region Technical Inspection Program

        List<InspectionProgram> GetAllInspectionProgram();
        int AddInspectionProgram(InspectionProgram program);
        InspectionProgram GetInspectionProgramById(int programId);
        void UpdateInspectionProgram(InspectionProgram program);
        void DeleteInspectionProgram(int programId);

        #endregion

        #region Sensors

        List<Sensors> GetAllSensors();
        int AddSensors(Sensors sensors);
        Sensors GetSensorsById(int sensorId);
        void UpdateSensors(Sensors sensors);
        void DeleteSensors(int sensorId);

        #endregion

        #region Control Points

        List<ControlPoints> GetAllControlPoints();
        int AddControlPoints(ControlPoints points);
        ControlPoints GetControlPointsById(int pointId);
        void UpdateControlPoints(ControlPoints points);
        void DeleteControlPoints(int pointId);

        #endregion
    }
}
