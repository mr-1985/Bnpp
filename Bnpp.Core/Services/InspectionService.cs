using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.BasicData;
using Bnpp.DataLayer.Entities.InspectionData;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services
{
    public class InspectionService:IInspectionService
    {
        private BnppContext _context;

        public InspectionService(BnppContext context)
        {
            _context = context;
        }

       


        #region Inspection Document
        public int AddInspectionReports(InspectionDocument document, IFormFile imgReports)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 1;

            if (imgReports != null)
            {
                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgReports.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgReports.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

       

        public void DeleteInspectionReports(int reportId)
        {
           var rport=GetInspectionReportsById(reportId);
            rport.IsDelete = true;
            _context.Update(rport);
            _context.SaveChanges();
        }

       

        public List<InspectionDocument> GetAllInspectionReports()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 1 && o.IsDelete == false).ToList();
        }

       

        public InspectionDocument GetInspectionReportsById(int reportId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == reportId && s.TypeId == 1);
        }

       

        public void UpdateInspectionReports(InspectionDocument document, IFormFile imgReports)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 1;

            if (imgReports != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgReports.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgReports.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        #endregion

        #region Inspection Instructions

        public int AddInspectionInstructions(InspectionDocument document, IFormFile imgInstructions)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 2;

            if (imgInstructions != null)
            {
                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgInstructions.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgInstructions.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public void DeleteInspectionInstructions(int instructionsId)
        {
            var instruct = GetInspectionInstructionsById(instructionsId);
            instruct.IsDelete = true;
            _context.Update(instruct);
            _context.SaveChanges();
        }

        public List<InspectionDocument> GetAllInspectionInstructions()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 2 && o.IsDelete == false).ToList();
        }

        public InspectionDocument GetInspectionInstructionsById(int instructionsId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == instructionsId && s.TypeId == 2);
        }

        public void UpdateInspectionInstructions(InspectionDocument document, IFormFile imgInstructions)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 2;

            if (imgInstructions != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgInstructions.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgInstructions.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }



        #endregion

        #region Typical Programs

        public List<TypicalPrograms> GetAlTypicalPrograms()
        {
            return _context.TypicalPrograms.Where(t => t.IsDelete == false).ToList();
        }

        public int AddTypicalPrograms(TypicalPrograms typical)
        {
            typical.CreateDate=DateTime.Now;
            _context.Add(typical);
            _context.SaveChanges();
            return typical.TypicalId;
        }

        public void UpdateTypicalPrograms(TypicalPrograms typical)
        {
            typical.CreateDate = DateTime.Now;
            _context.Update(typical);
            _context.SaveChanges();
        }

        public TypicalPrograms GetTypicalProgramsById(int typicalId)
        {
            return _context.TypicalPrograms.Find(typicalId);
        }

        public void DeleteTypicalPrograms(int typicalId)
        {
            var tpical = GetTypicalProgramsById(typicalId);
            tpical.IsDelete = true;
            UpdateTypicalPrograms(tpical);
        }



        #endregion

        #region Working Programs

        public List<WorkingPrograms> GetAlWorkingPrograms()
        {
            return _context.WorkingPrograms.Where(w => w.IsDelete == false).ToList();
        }

        public int AddWorkingPrograms(WorkingPrograms programs)
        {
            programs.CreateDate = DateTime.Now;
            _context.Add(programs);
            _context.SaveChanges();
            return programs.WorkingId;
        }

        public void UpdateWorkingPrograms(WorkingPrograms programs)
        {
           programs.CreateDate= DateTime.Now;
            _context.Update(programs);
            _context.SaveChanges();
        }

        public WorkingPrograms GetWorkingProgramsById(int programsId)
        {
            return _context.WorkingPrograms.Find(programsId);
        }

        public void DeleteWorkingPrograms(int programsId)
        {
            var progam = GetWorkingProgramsById(programsId);
            progam.IsDelete = true;
            UpdateWorkingPrograms(progam);
        }



        #endregion

        #region Visual Control

        public List<TestResults> GetAllVisualControl()
        {
            return _context.TestResults.Where(o => o.TypeId == 1 && o.IsDelete == false).ToList();
        }

        public int AddVisualControl(TestResults visual)
        {
            visual.CreateDate=DateTime.Now;
            visual.TypeId = 1;
            _context.Add(visual);
            _context.SaveChanges();
            return visual.TestResultsId;
        }

        public void UpdateVisualControl(TestResults visual)
        {
            visual.CreateDate = DateTime.Now;
            visual.TypeId = 1;
            _context.Update(visual);
            _context.SaveChanges();
        }

        public TestResults GetVisualControlById(int visualId)
        {
            return _context.TestResults.SingleOrDefault(s => s.TestResultsId == visualId && s.TypeId == 1);
        }

        public void DeleteVisualControl(int visualId)
        {
            var visal=GetVisualControlById(visualId);
            visal.IsDelete = true;
            UpdateVisualControl(visal);
        }



        #endregion


        #region  Leakage Test

        public List<TestResults> GetAllLeakageTest()
        {
            return _context.TestResults.Where(o => o.TypeId == 2 && o.IsDelete == false).ToList();
        }

        public int AddLeakageTest(TestResults leakage)
        {
            leakage.CreateDate = DateTime.Now;
            leakage.TypeId = 2;
            _context.Add(leakage);
            _context.SaveChanges();
            return leakage.TestResultsId;
        }

        public void UpdateLeakageTest(TestResults leakage)
        {
            leakage.CreateDate = DateTime.Now;
            leakage.TypeId = 2;
            _context.Update(leakage);
            _context.SaveChanges();
        }

        public TestResults GetLeakageTestById(int leakageId)
        {
            return _context.TestResults.SingleOrDefault(s => s.TestResultsId == leakageId && s.TypeId == 2);
        }

        public void DeleteLeakageTest(int leakageId)
        {
            var lakage = GetLeakageTestById(leakageId);
            lakage.IsDelete = true;
            UpdateLeakageTest(lakage);
        }



        #endregion


        #region Liquid Penetrated Test

        public List<TestResults> GetAllLiquidPenetrated()
        {
            return _context.TestResults.Where(o => o.TypeId == 3 && o.IsDelete == false).ToList();
        }

        public int AddLiquidPenetrated(TestResults penetrated)
        {
            penetrated.CreateDate = DateTime.Now;
            penetrated.TypeId = 3;
            _context.Add(penetrated);
            _context.SaveChanges();
            return penetrated.TestResultsId;
        }

        public void UpdateLiquidPenetrated(TestResults penetrated)
        {
            penetrated.CreateDate = DateTime.Now;
            penetrated.TypeId = 3;
            _context.Update(penetrated);
            _context.SaveChanges();
        }

        public TestResults GetLiquidPenetratedById(int penetratedId)
        {
            return _context.TestResults.SingleOrDefault(s => s.TestResultsId == penetratedId && s.TypeId == 3);
        }

        public void DeleteLiquidPenetrated(int penetratedId)
        {
            var penetrate = GetLiquidPenetratedById(penetratedId);
            penetrate.IsDelete = true;
            UpdateLiquidPenetrated(penetrate);
        }



        #endregion

        #region Magnetic Powder test

        public List<TestResults> GetAllMagneticPowder()
        {
            return _context.TestResults.Where(o => o.TypeId == 4 && o.IsDelete == false).ToList();
        }

        public int AddMagneticPowder(TestResults powder)
        {
            powder.CreateDate = DateTime.Now;
            powder.TypeId = 4;
            _context.Add(powder);
            _context.SaveChanges();
            return powder.TestResultsId;
        }

        public void UpdateMagneticPowder(TestResults powder)
        {
            powder.CreateDate = DateTime.Now;
            powder.TypeId = 4;
            _context.Update(powder);
            _context.SaveChanges();
        }

        public TestResults GetMagneticPowderById(int powderId)
        {
            return _context.TestResults.SingleOrDefault(s => s.TestResultsId == powderId && s.TypeId == 4);
        }

        public void DeleteMagneticPowder(int powderId)
        {
            var pwder=GetMagneticPowderById(powderId);
            pwder.IsDelete = true;
            UpdateMagneticPowder(pwder);
        }

        #endregion


        #region Radiographics Test

        public List<TestResults> GetAllRadiographics()
        {
            return _context.TestResults.Where(o => o.TypeId == 5 && o.IsDelete == false).ToList();
        }

        public int AddRadiographics(TestResults radiographics)
        {
            radiographics.CreateDate = DateTime.Now;
            radiographics.TypeId = 5;
            _context.Add(radiographics);
            _context.SaveChanges();
            return radiographics.TestResultsId;
        }

        public void UpdateRadiographics(TestResults radiographics)
        {
            radiographics.CreateDate = DateTime.Now;
            radiographics.TypeId = 5;
            _context.Update(radiographics);
            _context.SaveChanges();
        }

        public TestResults GetRadiographicsById(int radiographicsId)
        {
            return _context.TestResults.SingleOrDefault(s => s.TestResultsId == radiographicsId && s.TypeId == 5);
        }

        public void DeleteRadiographics(int radiographicsId)
        {
            var radio=GetRadiographicsById(radiographicsId);
            radio.IsDelete = true;
            UpdateRadiographics(radio);
        }


        #endregion

        #region Ultrasonic Tests

        public List<TestResults> GetAllUltrasonic()
        {
            return _context.TestResults.Where(o => o.TypeId == 6 && o.IsDelete == false).ToList();
        }

        public int AddUltrasonic(TestResults ultrasonic)
        {
            ultrasonic.CreateDate = DateTime.Now;
            ultrasonic.TypeId = 6;
            _context.Add(ultrasonic);
            _context.SaveChanges();
            return ultrasonic.TestResultsId;
        }

        public void UpdateUltrasonic(TestResults ultrasonic)
        {
            ultrasonic.CreateDate = DateTime.Now;
            ultrasonic.TypeId = 6;
            _context.Update(ultrasonic);
            _context.SaveChanges();
        }

        public TestResults GetUltrasonicById(int ultrasonicId)
        {
            return _context.TestResults.SingleOrDefault(s => s.TestResultsId == ultrasonicId && s.TypeId == 6);
        }

        public void DeleteUltrasonic(int ultrasonicId)
        {
            var ultra=GetUltrasonicById(ultrasonicId);
            ultra.IsDelete = true;
            UpdateUltrasonic(ultra);
        }



        #endregion

        #region Metal thickness ultrasonic measurement


        public List<TestResults> GetAllMetalThickness()
        {
            return _context.TestResults.Where(o => o.TypeId == 7 && o.IsDelete == false).ToList();
        }

        public int AddMetalThickness(TestResults metal)
        {
            metal.CreateDate = DateTime.Now;
            metal.TypeId = 7;
            _context.Add(metal);
            _context.SaveChanges();
            return metal.TestResultsId;
        }

        public void UpdateMetalThickness(TestResults metal)
        {
            metal.CreateDate = DateTime.Now;
            metal.TypeId = 7;
            _context.Update(metal);
            _context.SaveChanges();
        }

        public TestResults GetMetalThicknessById(int metalId)
        {
            return _context.TestResults.SingleOrDefault(s => s.TestResultsId == metalId && s.TypeId == 7);
        }

        public void DeleteMetalThickness(int metalId)
        {
            var metalic=GetMetalThicknessById(metalId);
            metalic.IsDelete = true;
            UpdateMetalThickness(metalic);
        }



        #endregion
    }
}
