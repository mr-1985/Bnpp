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
    }
}
