using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.AgeingDocuments;
using Microsoft.AspNetCore.Http;

namespace Bnpp.Core.Services
{
    public class DocumentService:IDocumentService
    {
        private BnppContext _context;

        public DocumentService(BnppContext context)
        {
            _context = context;
        }


        #region Operational Documents

        public List<OperationalDocuments> GetAllOperationalDocuments()
        {
            return _context.OperationalDocuments.Where(o => o.IsDelete == false).ToList();
        }

        public int AddOperationalDocuments(OperationalDocuments operational, IFormFile imgoperational)
        {
            operational.CreateDate = DateTime.Now;

            if (imgoperational != null)
            {
                operational.OperationalImage = Guid.NewGuid() + Path.GetExtension(imgoperational.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", operational.OperationalImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgoperational.CopyTo(stream);
                }
            }

            _context.Add(operational);
            _context.SaveChanges();
            return operational.OperationalId;
        }

        public OperationalDocuments GetOperationalDocumentsById(int operationalId)
        {
            return _context.OperationalDocuments.Find(operationalId);
        }

        public void UpdateOperationalDocuments(OperationalDocuments operational, IFormFile imgoperational)
        {
            operational.CreateDate = DateTime.Now;

            if (imgoperational != null)
            {
                if (operational.OperationalImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", operational.OperationalImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }

                operational.OperationalImage = Guid.NewGuid() + Path.GetExtension(imgoperational.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", operational.OperationalImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgoperational.CopyTo(stream);
                }
            }

            _context.Update(operational);
            _context.SaveChanges();
        }

        public void DeleteOperationalDocuments(int operationalId)
        {
            var operationalDocument = GetOperationalDocumentsById(operationalId);
            operationalDocument.IsDelete = true;
            _context.Update(operationalDocument);
            _context.SaveChanges();
        }

        #endregion
    }
}
