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

        #region Visual Inspection Form


        public List<InspectionDocument> GetAllVisualInspectionForm()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 3 && o.IsDelete == false).ToList();
        }

        public int AddVisualInspectionForm(InspectionDocument document, IFormFile imgVisual)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 3;

            if (imgVisual != null)
            {
                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgVisual.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgVisual.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetVisualInspectionFormById(int visualId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == visualId && s.TypeId == 3);
        }

        public void UpdateVisualInspectionForm(InspectionDocument document, IFormFile imgVisual)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 3;

            if (imgVisual != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgVisual.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgVisual.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeleteVisualInspectionForm(int visualId)
        {
            var visul = GetVisualInspectionFormById(visualId);
            visul.IsDelete = true;
            _context.Update(visul);
            _context.SaveChanges();
        }



        #endregion

        #region Leakage Test Form

        public List<InspectionDocument> GetAllLeakageForm()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 4 && o.IsDelete == false).ToList();
        }

        public int AddLeakageForm(InspectionDocument document, IFormFile imgLeakage)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 4;

            if (imgLeakage != null)
            {
                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgLeakage.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgLeakage.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetLeakageFormById(int leakageId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == leakageId && s.TypeId == 4);
        }

        public void UpdateLeakageForm(InspectionDocument document, IFormFile imgLeakage)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 4;

            if (imgLeakage != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgLeakage.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgLeakage.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeleteLeakageForm(int leakageId)
        {
            var leakag = GetLeakageFormById(leakageId);
            leakag.IsDelete = true;
            _context.Update(leakag);
            _context.SaveChanges();
        }



        #endregion

        #region Liquid Penetration Test Form

        public List<InspectionDocument> GetAllPenetrationForm()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 5 && o.IsDelete == false).ToList();
        }

        public int AddPenetrationForm(InspectionDocument document, IFormFile imgLiquid)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 5;

            if (imgLiquid != null)
            {
                


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgLiquid.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgLiquid.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetPenetrationFormById(int liquidId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == liquidId && s.TypeId == 5);
        }

        public void UpdatePenetrationForm(InspectionDocument document, IFormFile imgLiquid)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 5;

            if (imgLiquid != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgLiquid.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgLiquid.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeletePenetrationForm(int liquidId)
        {
            var penet = GetPenetrationFormById(liquidId);
            penet.IsDelete = true;
            _context.Update(penet);
            _context.SaveChanges();
        }



        #endregion

        #region Magnetic Powder Test Form

        public List<InspectionDocument> GetAllMagneticForm()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 6 && o.IsDelete == false).ToList();
        }

        public int AddMagneticForm(InspectionDocument document, IFormFile imgMagnetic)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 6;

            if (imgMagnetic != null)
            {



                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgMagnetic.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgMagnetic.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetMagneticFormById(int magneticId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == magneticId && s.TypeId == 6);
        }

        public void UpdateMagneticForm(InspectionDocument document, IFormFile imgMagnetic)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 6;

            if (imgMagnetic != null)
            {

                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgMagnetic.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgMagnetic.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeleteMagneticForm(int magneticId)
        {
            var magnet = GetMagneticFormById(magneticId);
            magnet.IsDelete = true;
            _context.Update(magnet);
            _context.SaveChanges();
        }



        #endregion

        #region Radiographics Test Form

        public List<InspectionDocument> GetAllRadiographicsForm()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 7 && o.IsDelete == false).ToList();
        }

        public int AddRadiographicsForm(InspectionDocument document, IFormFile imgRadiographics)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 7;

            if (imgRadiographics != null)
            {



                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgRadiographics.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgRadiographics.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetRadiographicsFormById(int radiographicsId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == radiographicsId && s.TypeId == 7);
        }

        public void UpdateRadiographicsForm(InspectionDocument document, IFormFile imgRadiographics)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 7;

            if (imgRadiographics != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgRadiographics.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgRadiographics.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeleteRadiographicsForm(int radiographicsId)
        {
            var graphic=GetRadiographicsFormById(radiographicsId);
            graphic.IsDelete = true;
            _context.Update(graphic);
            _context.SaveChanges();
        }



        #endregion

        #region Ultrasonic Test Form

        public List<InspectionDocument> GetAllUltrasonicForm()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 8 && o.IsDelete == false).ToList();
        }

        public int AddUltrasonicForm(InspectionDocument document, IFormFile imgUltrasonic)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 8;

            if (imgUltrasonic != null)
            {



                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgUltrasonic.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgUltrasonic.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetUltrasonicFormById(int ultrasonicId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == ultrasonicId && s.TypeId == 8);
        }

        public void UpdateUltrasonicForm(InspectionDocument document, IFormFile imgUltrasonic)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 8;

            if (imgUltrasonic != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgUltrasonic.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgUltrasonic.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeleteUltrasonicForm(int ultrasonicId)
        {
            var sonic=GetUltrasonicFormById(ultrasonicId);
            sonic.IsDelete = true;
            _context.Update(sonic);
            _context.SaveChanges();
        }


        #endregion

        #region Metal thickness ultrasonic Test Form

        public List<InspectionDocument> GetAllMetalForm()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 9 && o.IsDelete == false).ToList();
        }

        public int AddMetalForm(InspectionDocument document, IFormFile imgMetal)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 9;

            if (imgMetal != null)
            {



                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgMetal.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgMetal.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetMetalFormById(int metalId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == metalId && s.TypeId == 9);
        }

        public void UpdateMetalForm(InspectionDocument document, IFormFile imgMetal)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 9;

            if (imgMetal != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgMetal.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgMetal.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeleteMetalForm(int metalId)
        {
            var mtal=GetMetalFormById(metalId);
            mtal.IsDelete=true;
            _context.Update(mtal);
            _context.SaveChanges();
        }

        #endregion

        #region Typical Programs Document

        public List<InspectionDocument> GetAllTypicalDocument()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 16 && o.IsDelete == false).ToList();
        }

        public int AddTypicalDocument(InspectionDocument document, IFormFile imgTypical)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 16;

            if (imgTypical != null)
            {
                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgTypical.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgTypical.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetTypicalDocumentById(int typicalId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == typicalId && s.TypeId == 16);
        }

        public void UpdateTypicalDocument(InspectionDocument document, IFormFile imgTypical)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 16;

            if (imgTypical != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgTypical.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgTypical.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeleteTypicalDocument(int typicalId)
        {
            var typicaldoc = GetTypicalDocumentById(typicalId);
            typicaldoc.IsDelete = true;
            _context.Update(typicaldoc);
            _context.SaveChanges();
        }



        #endregion



        #region Working Programs Document

        public List<InspectionDocument> GetAllWorkingDocument()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 17 && o.IsDelete == false).ToList();
        }

        public int AddWorkingDocument(InspectionDocument document, IFormFile imgWorking)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 17;

            if (imgWorking != null)
            {
                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgWorking.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgWorking.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetWorkingDocumentById(int workingId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == workingId && s.TypeId == 17);
        }

        public void UpdateWorkingDocument(InspectionDocument document, IFormFile imgWorking)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 17;

            if (imgWorking != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgWorking.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgWorking.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeleteWorkingDocument(int workingId)
        {
            var workindoc = GetWorkingDocumentById(workingId);
            workindoc.IsDelete = true;
            _context.Update(workindoc);
            _context.SaveChanges();
        }

        #endregion
    }
}
