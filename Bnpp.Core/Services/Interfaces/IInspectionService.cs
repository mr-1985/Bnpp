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
