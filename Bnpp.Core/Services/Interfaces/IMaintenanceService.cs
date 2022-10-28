using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.BasicData;
using Bnpp.DataLayer.Entities.Maintenance;
using Microsoft.AspNetCore.Http;
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

        #region  SpareParts

        List<SpareParts> GetAllSpareParts();
        int AddSpareParts(SpareParts spare);
        SpareParts GetSparePartsById(int spareId);

        void UpdateSpareParts(SpareParts spare);
        void DeleteSpareParts(int spareId);
        #endregion

        #region Measurement


        List<Measurements> GetAllMeasurements();
        int AddMeasurements(Measurements measure);
        Measurements GetMeasurementsById(int measureId);

        void UpdateMeasurements(Measurements measure);
        void DeleteMeasurements(int measureId);


        #endregion

        #region Maintenance Form 

        List<MaintenanceForm> GetAllMaintenanceForm();
        int AddMaintenanceForm(MaintenanceForm forms, IFormFile imgForms);
        MaintenanceForm GetMaintenanceFormById(int formsId);
        void UpdateMaintenanceForm(MaintenanceForm forms, IFormFile imgForms);
        void DeleteMaintenanceForm(int formsId);

        #endregion

        #region Defection Reports

        List<DefectionReports> GetAllDefectionReports();
        int AddDefectionReports(DefectionReports reports, IFormFile imgReports);
        DefectionReports GetDefectionReportsById(int reportsId);
        void UpdateDefectionReports(DefectionReports reports, IFormFile imgReports);
        void DeleteDefectionReports(int reportsId);

        #endregion

        #region  Programs document

        List<ProgramsDocument> GetAllProgramsDocument();
        int AddProgramsDocument(ProgramsDocument document, IFormFile imgDocument);
        ProgramsDocument GetProgramsDocumentById(int documentId);
        void UpdateProgramsDocument(ProgramsDocument document, IFormFile imgDocument);
        void DeleteProgramsDocument(int documentId);

        #endregion
        #region Maintenance Programs

        List<MaintenancePrograms> GetAllMaintenancePrograms();
        int AddMaintenancePrograms(MaintenancePrograms programs);
        MaintenancePrograms GetMaintenanceProgramsById(int programsId);

        void UpdateMaintenancePrograms(MaintenancePrograms programs);
        void DeleteMaintenancePrograms(int programsId);

        #endregion
    }
}
