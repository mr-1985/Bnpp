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
            var instruct = GetInspectionReportsById(instructionsId);
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
    }
}
