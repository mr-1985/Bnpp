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

        #region H-Forms

        List<HForms> GetAllHForms();
        int AddHForms(HForms forms, IFormFile imgHForms);
        HForms GetHFormsById(int formsId);
        void UpdateHForms(HForms forms, IFormFile imgHForms);
        void DeleteHForms(int formsId);

        #endregion

        #region Components

        List<Components> GetAllComponents();
        int AddComponents(Components components, IFormFile imgComponents);
        Components GetComponentsById(int componentsId);
        void UpdateComponents(Components components, IFormFile imgComponents);
        void DeleteComponents(int componentsId);

        #endregion

        #region Mechanical Properties

        List<MechanicalProperties> GetAllMechanicalProperties(int componentId);
        int AddMechanicalProperties(MechanicalProperties mechanical);
        void UpdateMechanicalProperties(MechanicalProperties properties);
        GeneralData GetMechanicalPropertiesById(int mechanicalId);

        void DeleteMechanicalProperties(int mechanicalId);

        #endregion
    }
}
