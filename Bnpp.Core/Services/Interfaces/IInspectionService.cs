using Bnpp.DataLayer.Entities.BasicData;
using Bnpp.DataLayer.Entities.InspectionData;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        #region Visual Inspection Form


        List<InspectionDocument> GetAllVisualInspectionForm();
        int AddVisualInspectionForm(InspectionDocument document, IFormFile imgVisual);
        InspectionDocument GetVisualInspectionFormById(int visualId);
        void UpdateVisualInspectionForm(InspectionDocument document, IFormFile imgVisual);
        void DeleteVisualInspectionForm(int visualId);



        #endregion

        #region Leakage Test Form

        List<InspectionDocument> GetAllLeakageForm();
        int AddLeakageForm(InspectionDocument document, IFormFile imgLeakage);
        InspectionDocument GetLeakageFormById(int leakageId);
        void UpdateLeakageForm(InspectionDocument document, IFormFile imgLeakage);
        void DeleteLeakageForm(int leakageId);

        #endregion

        #region Liquid Penetration Test Form

        List<InspectionDocument> GetAllPenetrationForm();
        int AddPenetrationForm(InspectionDocument document, IFormFile imgLiquid);
        InspectionDocument GetPenetrationFormById(int liquidId);
        void UpdatePenetrationForm(InspectionDocument document, IFormFile imgLiquid);
        void DeletePenetrationForm(int liquidId);

        #endregion

        #region Magnetic Powder Test Form

        List<InspectionDocument> GetAllMagneticForm();
        int AddMagneticForm(InspectionDocument document, IFormFile imgMagnetic);
        InspectionDocument GetMagneticFormById(int magneticId);
        void UpdateMagneticForm(InspectionDocument document, IFormFile imgMagnetic);
        void DeleteMagneticForm(int magneticId);

        #endregion


        #region Radiographics Test Form

        List<InspectionDocument> GetAllRadiographicsForm();
        int AddRadiographicsForm(InspectionDocument document, IFormFile imgRadiographics);
        InspectionDocument GetRadiographicsFormById(int radiographicsId);
        void UpdateRadiographicsForm(InspectionDocument document, IFormFile imgRadiographics);
        void DeleteRadiographicsForm(int radiographicsId);

        #endregion

        #region Ultrasonic Test Form

        List<InspectionDocument> GetAllUltrasonicForm();
        int AddUltrasonicForm(InspectionDocument document, IFormFile imgUltrasonic);
        InspectionDocument GetUltrasonicFormById(int ultrasonicId);
        void UpdateUltrasonicForm(InspectionDocument document, IFormFile imgUltrasonic);
        void DeleteUltrasonicForm(int ultrasonicId);


        #endregion

        #region Metal thickness ultrasonic Test Form

        List<InspectionDocument> GetAllMetalForm();
        int AddMetalForm(InspectionDocument document, IFormFile imgMetal);
        InspectionDocument GetMetalFormById(int metalId);
        void UpdateMetalForm(InspectionDocument document, IFormFile imgMetal);
        void DeleteMetalForm(int metalId);

        #endregion

        #region Inspection Instructions

        List<InspectionDocument> GetAllInspectionInstructions();
        int AddInspectionInstructions(InspectionDocument document, IFormFile imgInstructions);
        InspectionDocument GetInspectionInstructionsById(int instructionsId);
        void UpdateInspectionInstructions(InspectionDocument document, IFormFile imgInstructions);
        void DeleteInspectionInstructions(int instructionsId);

        #endregion

        #region TypicalPrograms

        List<TypicalPrograms> GetAlTypicalPrograms();
        int AddTypicalPrograms(TypicalPrograms typical);
        void UpdateTypicalPrograms(TypicalPrograms typical);
        TypicalPrograms GetTypicalProgramsById(int typicalId);

        void DeleteTypicalPrograms(int typicalId);

        #endregion

        #region Working Programs

        List<WorkingPrograms> GetAlWorkingPrograms();
        int AddWorkingPrograms(WorkingPrograms programs);
        void UpdateWorkingPrograms(WorkingPrograms programs);
        WorkingPrograms GetWorkingProgramsById(int programsId);

        void DeleteWorkingPrograms(int programsId);

        #endregion

        #region Visual Control

        List<TestResults> GetAllVisualControl();
        int AddVisualControl(TestResults visual);
        void UpdateVisualControl(TestResults visual);
        TestResults GetVisualControlById(int visualId);

        void DeleteVisualControl(int visualId);

        #endregion

        #region  Leakage Test


        List<TestResults> GetAllLeakageTest();
        int AddLeakageTest(TestResults leakage);
        void UpdateLeakageTest(TestResults leakage);
        TestResults GetLeakageTestById(int leakageId);

        void DeleteLeakageTest(int leakageId);

        #endregion

        #region Liquid Penetrated Test

        List<TestResults> GetAllLiquidPenetrated();
        int AddLiquidPenetrated(TestResults penetrated);
        void UpdateLiquidPenetrated(TestResults penetrated);
        TestResults GetLiquidPenetratedById(int penetratedId);
        void DeleteLiquidPenetrated(int penetratedId);

        #endregion

        #region Magnetic Powder test

        List<TestResults> GetAllMagneticPowder();
        int AddMagneticPowder(TestResults powder);
        void UpdateMagneticPowder(TestResults powder);
        TestResults GetMagneticPowderById(int powderId);
        void DeleteMagneticPowder(int powderId);

        #endregion

        #region Radiographics Test

        List<TestResults> GetAllRadiographics();
        int AddRadiographics(TestResults radiographics);
        void UpdateRadiographics(TestResults radiographics);
        TestResults GetRadiographicsById(int radiographicsId);
        void DeleteRadiographics(int radiographicsId);

        #endregion

        #region Ultrasonic Tests

        List<TestResults> GetAllUltrasonic();
        int AddUltrasonic(TestResults ultrasonic);
        void UpdateUltrasonic(TestResults ultrasonic);
        TestResults GetUltrasonicById(int ultrasonicId);
        void DeleteUltrasonic(int ultrasonicId);

        #endregion

        #region Metal thickness ultrasonic measurement

        List<TestResults> GetAllMetalThickness();
        int AddMetalThickness(TestResults metal);
        void UpdateMetalThickness(TestResults metal);
        TestResults GetMetalThicknessById(int metalId);
        void DeleteMetalThickness(int metalId);

        #endregion
    }
}
