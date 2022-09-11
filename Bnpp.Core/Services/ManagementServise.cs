﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.Convertors;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.AgeingManagementDocuments;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Bnpp.Core.Services
{
    public class ManagementServise:IManagementServise
    {
        private BnppContext _context;
        private IHostingEnvironment _environment;

        public ManagementServise(BnppContext context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }


        public List<Methodology> GetAllMethodolgies()
        {
            return _context.Methodologies.Where(m => m.IsDelete == false).ToList();
        }

        public int AddMethodology(Methodology methodology, IFormFile imgMethodolgy)
        {
            methodology.CreateDate=DateTime.Now;

            if (imgMethodolgy != null )
            {
                methodology.MethodologyImage = Guid.NewGuid() + Path.GetExtension(imgMethodolgy.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", methodology.MethodologyImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgMethodolgy.CopyTo(stream);
                }
            }

            _context.Add(methodology);
            _context.SaveChanges();
            return methodology.MethodologyId;
        }

        public Methodology GetMethodolgyById(int methodologyId)
        {
            return _context.Methodologies.Find(methodologyId);
        }

        public void UpdateMethodolgy(Methodology methodology,IFormFile imgMethodolgy)
        {
            methodology.CreateDate=DateTime.Now;
            if (imgMethodolgy != null)
            {
                methodology.MethodologyImage = Guid.NewGuid() + Path.GetExtension(imgMethodolgy.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", methodology.MethodologyImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgMethodolgy.CopyTo(stream);
                }
            }

            _context.Update(methodology);
            _context.SaveChanges();
        }

        public void DeleteMethodolgy(int methodologyId)
        {
            var methodology = GetMethodolgyById(methodologyId);
            methodology.IsDelete = true;
            _context.Update(methodology);
            _context.SaveChanges();
        }

        public List<AgeingDocuments> GetAllAgeingDocuments()
        {
            return _context.AgeingDocuments.Where(m => m.IsDelete == false).ToList();
        }

        public int AddAgeingDocuments(AgeingDocuments documents, IFormFile imgAgeingDocuments)
        {
            documents.CreateDate = DateTime.Now;

            if (imgAgeingDocuments != null)
            {
                documents.AgeingImage = Guid.NewGuid() + Path.GetExtension(imgAgeingDocuments.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AgeingDocuments", documents.AgeingImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgAgeingDocuments.CopyTo(stream);
                }
            }

            _context.Add(documents);
            _context.SaveChanges();
            return documents.AgeingDocumentsId;
        }

        public AgeingDocuments GetAgeingDocumentsById(int documentId)
        {
            return _context.AgeingDocuments.Find(documentId);
        }

        public void UpdateAgeingDocuments(AgeingDocuments documents, IFormFile imgAgeingDocuments)
        {
            documents.CreateDate=DateTime.Now;
            if (imgAgeingDocuments != null)
            {
                documents.AgeingImage = Guid.NewGuid() + Path.GetExtension(imgAgeingDocuments.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/AgeingDocuments", documents.AgeingImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgAgeingDocuments.CopyTo(stream);
                }
            }

            _context.Update(documents);
            _context.SaveChanges();
        }

        public void DeleteimgAgeingDocuments(int documentId)
        {
            var document = GetAgeingDocumentsById(documentId);
            document.IsDelete = true;
            _context.Update(document);
            _context.SaveChanges();
        }
    }
}
