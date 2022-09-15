using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.AgeingMechanism;
using Microsoft.AspNetCore.Http;

namespace Bnpp.Core.Services
{
    
    public class MechanismService:IMechanismService
    {
        private BnppContext _context;

        public MechanismService(BnppContext context)
        {
            _context = context;
        }

        #region Mechanism

        public List<Mechanism> GetAllMechanism()
        {
            return _context.Mechanism.Where(m => m.IsDelete == false).ToList();
        }

        public int AddMechanism(Mechanism mechanism)
        {
           mechanism.CreateDate=DateTime.Now;
           _context.Add(mechanism);
           _context.SaveChanges();
           return mechanism.MechanismId;
        }

        public void UpdateMechanism(Mechanism mechanism)
        {
           mechanism.CreateDate=DateTime.Now;
           _context.Update(mechanism);
           _context.SaveChanges();
        }

        public Mechanism GetMechanismById(int mechanismId)
        {
            return _context.Mechanism.Find(mechanismId);
        }

        public void DeleteMechanism(int mechanismId)
        {
            var meganism = GetMechanismById(mechanismId);
            meganism.IsDelete = true;
            UpdateMechanism(meganism);
        }



        #endregion

        #region MyRegion

        public List<MechanismDocuments> GetAllMechanismDocuments()
        {
            return _context.MechanismDocuments.Where(d => d.IsDelete == false).ToList();
        }

        public int AddMechanismDocuments(MechanismDocuments documents, IFormFile imgdocuments)
        {
            documents.CreateDate = DateTime.Now;

            if (imgdocuments != null)
            {
                documents.MechanismDocumentsImage = Guid.NewGuid() + Path.GetExtension(imgdocuments.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", documents.MechanismDocumentsImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgdocuments.CopyTo(stream);
                }
            }

            _context.Add(documents);
            _context.SaveChanges();
            return documents.MechanismDocumentsId;
        }

        public MechanismDocuments GetMechanismDocumentsById(int documentsId)
        {
            return _context.MechanismDocuments.Find(documentsId);
        }

        public void UpdateMechanismDocuments(MechanismDocuments documents, IFormFile imgdocuments)
        {
            documents.CreateDate = DateTime.Now;

            if (imgdocuments != null)
            {
                if (documents.MechanismDocumentsImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", documents.MechanismDocumentsImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }

                documents.MechanismDocumentsImage = Guid.NewGuid() + Path.GetExtension(imgdocuments.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", documents.MechanismDocumentsImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgdocuments.CopyTo(stream);
                }
            }

            _context.Update(documents);
            _context.SaveChanges();
        }

        public void DeleteMechanismDocuments(int documentsId)
        {
            var mechdocument = GetMechanismDocumentsById(documentsId);
            mechdocument.IsDelete = true;
            _context.Update(mechdocument);
            _context.SaveChanges();
        }

        #endregion
    }
}
