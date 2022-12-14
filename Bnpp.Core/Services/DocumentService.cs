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

        #region Drawing

        public List<Drawing> GetAllDrawing()
        {
            return _context.Drawing.Where(d => d.IsDelete == false).ToList();
        }

        public int AddDrawing(Drawing drawing, IFormFile imgDrawing)
        {
            drawing.CreateDate = DateTime.Now;

            if (imgDrawing != null)
            {
                drawing.DrawingImage = Guid.NewGuid() + Path.GetExtension(imgDrawing.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", drawing.DrawingImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgDrawing.CopyTo(stream);
                }
            }

            _context.Add(drawing);
            _context.SaveChanges();
            return drawing.DrawingId;
        }

        public Drawing GetDrawingById(int drawingId)
        {
            return _context.Drawing.Find(drawingId);
        }

        public void UpdateDrawing(Drawing drawing, IFormFile imgDrawing)
        {
            drawing.CreateDate = DateTime.Now;

            if (imgDrawing != null)
            {
                if (drawing.DrawingImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", drawing.DrawingImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }

                drawing.DrawingImage = Guid.NewGuid() + Path.GetExtension(imgDrawing.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", drawing.DrawingImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgDrawing.CopyTo(stream);
                }
            }

            _context.Update(drawing);
            _context.SaveChanges();
        }

        public void DeleteDrawing(int drawingId)
        {
            var drawingss = GetDrawingById(drawingId);
            drawingss.IsDelete = true;
            _context.Update(drawingss);
            _context.SaveChanges();
        }

        #endregion

        #region Standard

        public List<Standard> GetAllStandard()
        {
            return _context.Standard.Where(s=>s.IsDelete==false).ToList();
        }

        public int AddStandard(Standard standard, IFormFile imgStandard)
        {
            standard.CreateDate = DateTime.Now;

            if (imgStandard != null)
            {
                standard.StandardImage = Guid.NewGuid() + Path.GetExtension(imgStandard.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", standard.StandardImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgStandard.CopyTo(stream);
                }
            }

            _context.Add(standard);
            _context.SaveChanges();
            return standard.StandardId;
        }

        public Standard GetimgStandardById(int standardId)
        {
            return _context.Standard.Find(standardId);
        }

        public void UpdateimgStandard(Standard standard, IFormFile imgStandard)
        {
            standard.CreateDate = DateTime.Now;

            if (imgStandard != null)
            {
                if (standard.StandardImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", standard.StandardImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }

                standard.StandardImage = Guid.NewGuid() + Path.GetExtension(imgStandard.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", standard.StandardImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgStandard.CopyTo(stream);
                }
            }

            _context.Update(standard);
            _context.SaveChanges();
        }

        public void DeleteimgStandard(int standardId)
        {
            var standrd = GetimgStandardById(standardId);
            standrd.IsDelete=true;
            _context.Update(standrd);
            _context.SaveChanges();
        }



        #endregion

        #region Manufacturer

        public List<Manufacturer> GetAllManufacturer()
        {
           return _context.Manufacturers.Where(m=>m.IsDelete==false).ToList();
        }

        public int AddManufacturer(Manufacturer manufacturer, IFormFile imgManufacturer)
        {
            manufacturer.CreateDate = DateTime.Now;

            if (imgManufacturer != null)
            {
               
                manufacturer.ManufacturerImage = Guid.NewGuid() + Path.GetExtension(imgManufacturer.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", manufacturer.ManufacturerImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgManufacturer.CopyTo(stream);
                }
            }

            _context.Add(manufacturer);
            _context.SaveChanges();
            return manufacturer.ManufacturerId;
        }

        public Manufacturer GetManufacturerById(int manufacturerId)
        {
            return _context.Manufacturers.Find(manufacturerId);
        }

        public void UpdateManufacturer(Manufacturer manufacturer, IFormFile imgManufacturer)
        {
            manufacturer.CreateDate = DateTime.Now;

            if (imgManufacturer != null)
            {
                if (manufacturer.ManufacturerImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", manufacturer.ManufacturerImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }

                manufacturer.ManufacturerImage = Guid.NewGuid() + Path.GetExtension(imgManufacturer.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", manufacturer.ManufacturerImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgManufacturer.CopyTo(stream);
                }
            }

            _context.Update(manufacturer);
            _context.SaveChanges();
           
        }

        public void DeleteManufacturer(int manufacturerId)
        {
            var manufactor = GetManufacturerById(manufacturerId);
            manufactor.IsDelete = true;
            _context.Update(manufactor);
            _context.SaveChanges();
        }



        #endregion

        #region Installation

        public List<Installation> GetAllInstallation()
        {
            return _context.Installation.Where(i => i.IsDelete == false).ToList();
        }

        public int AddInstallation(Installation installation, IFormFile imgInstallation)
        {
            installation.CreateDate = DateTime.Now;

            if (imgInstallation != null)
            {

                installation.InstallationImage = Guid.NewGuid() + Path.GetExtension(imgInstallation.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", installation.InstallationImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgInstallation.CopyTo(stream);
                }
            }

            _context.Add(installation);
            _context.SaveChanges();
            return installation.InstallationId;
        }

        public Installation GetInstallationById(int installationId)
        {
            return _context.Installation.Find(installationId);
        }

        public void UpdateInstallation(Installation installation, IFormFile imgInstallation)
        {
            installation.CreateDate = DateTime.Now;

            if (imgInstallation != null)
            {
                if (installation.InstallationImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", installation.InstallationImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                installation.InstallationImage = Guid.NewGuid() + Path.GetExtension(imgInstallation.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", installation.InstallationImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgInstallation.CopyTo(stream);
                }
            }

            _context.Update(installation);
            _context.SaveChanges();
        }

        public void DeleteInstallation(int installationId)
        {
            var install = GetInstallationById(installationId);
            install.IsDelete = true;
            _context.Update(install);
            _context.SaveChanges();
        }


        #endregion

        #region MaintenanceDocument

        public List<MaintenanceDocument> GetAllMaintenanceDocument()
        {
           return _context.MaintenanceDocument.Where(m=>m.IsDelete==false).ToList();
        }

        public int AddMaintenanceDocument(MaintenanceDocument maintenance, IFormFile imgMaintenance)
        {
            maintenance.CreateDate = DateTime.Now;

            if (imgMaintenance != null)
            {

                maintenance.MaintenanceImage = Guid.NewGuid() + Path.GetExtension(imgMaintenance.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", maintenance.MaintenanceImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgMaintenance.CopyTo(stream);
                }
            }

            _context.Add(maintenance);
            _context.SaveChanges();
            return maintenance.MaintenanceId;
        }

        public MaintenanceDocument GetMaintenanceDocumentById(int maintenanceId)
        {
            return _context.MaintenanceDocument.Find(maintenanceId);
        }

        public void UpdateMaintenanceDocument(MaintenanceDocument maintenance, IFormFile imgMaintenance)
        {
            maintenance.CreateDate = DateTime.Now;

            if (imgMaintenance != null)
            {
                if (maintenance.MaintenanceImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", maintenance.MaintenanceImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                maintenance.MaintenanceImage = Guid.NewGuid() + Path.GetExtension(imgMaintenance.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", maintenance.MaintenanceImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgMaintenance.CopyTo(stream);
                }
            }

            _context.Update(maintenance);
            _context.SaveChanges();
        }

        public void DeleteMaintenanceDocument(int maintenanceId)
        {
            var maintenece = GetMaintenanceDocumentById(maintenanceId);
            maintenece.IsDelete = true;
            _context.Update(maintenece);
            _context.SaveChanges();
        }



        #endregion

        #region Ageing

        public List<Ageing> GetAllAgeing()
        {
            return _context.Ageing.Where(a => a.IsDelete == false).ToList();
        }

        public int AddAgeing(Ageing ageing, IFormFile imgAgeing)
        {
            ageing.CreateDate = DateTime.Now;

            if (imgAgeing != null)
            {

                ageing.AgeingImage = Guid.NewGuid() + Path.GetExtension(imgAgeing.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", ageing.AgeingImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgAgeing.CopyTo(stream);
                }
            }

            _context.Add(ageing);
            _context.SaveChanges();
            return ageing.AgeingId;
        }

        public Ageing GetAgeingById(int ageingId)
        {
            return _context.Ageing.Find(ageingId);
        }

        public void UpdateAgeing(Ageing ageing, IFormFile imgAgeing)
        {
            ageing.CreateDate = DateTime.Now;

            if (imgAgeing != null)
            {
                if (ageing.AgeingImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", ageing.AgeingImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                ageing.AgeingImage = Guid.NewGuid() + Path.GetExtension(imgAgeing.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", ageing.AgeingImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgAgeing.CopyTo(stream);
                }
            }

            _context.Update(ageing);
            _context.SaveChanges();
        }

        public void DeleteAgeing(int ageingId)
        {
            var aeging = GetAgeingById(ageingId);
            aeging.IsDelete=true;
            _context.Update(aeging);
            _context.SaveChanges();
        }

        #endregion
    }
}
