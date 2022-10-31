using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.BasicData;
using Bnpp.DataLayer.Entities.InspectionData;
using Bnpp.DataLayer.Entities.OperationalDatas;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services
{
    public class SensorService:ISensorService
    {
        private BnppContext _context;

        public SensorService(BnppContext context)
        {
            _context = context;
        }

        

        #region  Sensor

        public int AddSensor(Operational sensor)
        {
            sensor.CreateDate = DateTime.Now;
            sensor.TypeId = 1;
            _context.Add(sensor);
            _context.SaveChanges();
            return sensor.OperationalId;

            //Operational sensors = new Operational() {
            //    TypeId = 1,
            //    CreateDate = DateTime.Now,
            //    ParameterName=p
            //};
            //return sensors.OperationalId;
        }

        

        public void DeleteSensor(int sensorId)
        {
           var snsor=GetSensorById(sensorId);
            snsor.IsDelete = true;
            _context.Update(snsor);
            _context.SaveChanges();
        }

       

        public List<Operational> GetAllSensors()
        {
            return _context.Operationals.Where(o=>o.TypeId==1&&o.IsDelete==false).ToList();
        }

       

        public Operational GetSensorById(int sensorId)
        {
            return _context.Operationals.SingleOrDefault(s => s.OperationalId == sensorId && s.TypeId == 1);
        }

       

        public void UpdateSensor(Operational sensor)
        {
            sensor.CreateDate=DateTime.Now;
            _context.Update(sensor);
            _context.SaveChanges();
        }

        #endregion

        #region Chemical Water
        public List<Operational> GetAllChemicalWater()
        {
            return _context.Operationals.Where(o => o.TypeId == 2 && o.IsDelete == false).ToList();
        }

        public int AddChemicalWater(Operational water)
        {
            water.CreateDate = DateTime.Now;
            water.TypeId = 2;
            _context.Add(water);
            _context.SaveChanges();
            return water.OperationalId;
        }

        public void UpdateChemicalWater(Operational water)
        {
            water.CreateDate = DateTime.Now;
            _context.Update(water);
            _context.SaveChanges();
        }
        public Operational GetChemicalWaterById(int waterId)
        {
            return _context.Operationals.SingleOrDefault(s => s.OperationalId == waterId && s.TypeId == 2);
        }
        public void DeleteChemicalWater(int waterId)
        {
            var wter = GetChemicalWaterById(waterId);
            wter.IsDelete = true;
            _context.Update(wter);
            _context.SaveChanges();
        }


        #endregion

        #region Environmental

        public List<Operational> GetAllEnvironmental()
        {
            return _context.Operationals.Where(o => o.TypeId == 3 && o.IsDelete == false).ToList();
        }

        public int AddEnvironmental(Operational environmental)
        {
            environmental.CreateDate = DateTime.Now;
            environmental.TypeId = 3;
            _context.Add(environmental);
            _context.SaveChanges();
            return environmental.OperationalId;
        }

        public Operational GetEnvironmentalById(int environmentalId)
        {
            return _context.Operationals.SingleOrDefault(s => s.OperationalId == environmentalId && s.TypeId == 3);
        }

        public void UpdateEnvironmental(Operational environmental)
        {
            environmental.CreateDate = DateTime.Now;
            _context.Update(environmental);
            _context.SaveChanges();
        }

        public void DeleteEnvironmental(int environmentalId)
        {
            var environ = GetEnvironmentalById(environmentalId);
            environ.IsDelete = true;
            _context.Update(environ);
            _context.SaveChanges();
        }



        #endregion

        #region Sensor Document

        public List<InspectionDocument> GetAllSensorDocument()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 13 && o.IsDelete == false).ToList();
        }

        public int AddSensorDocument(InspectionDocument document, IFormFile imgSensor)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 13;

            if (imgSensor != null)
            {
                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgSensor.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgSensor.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetSensorDocumentById(int sensorId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == sensorId && s.TypeId == 13);
        }

        public void UpdateSensorDocument(InspectionDocument document, IFormFile imgSensor)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 13;

            if (imgSensor != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgSensor.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgSensor.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeleteSensorDocument(int sensorId)
        {
            var sensordoc = GetSensorDocumentById(sensorId);
            sensordoc.IsDelete = true;
            _context.Update(sensordoc);
            _context.SaveChanges();
        }



        #endregion

        #region Chemical Water Document

        public List<InspectionDocument> GetAllChemicalWaterDocument()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 14 && o.IsDelete == false).ToList();
        }

        public int AddChemicalWaterDocument(InspectionDocument document, IFormFile imgWater)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 14;

            if (imgWater != null)
            {
                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgWater.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgWater.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetChemicalWaterDocumentById(int waterId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == waterId && s.TypeId == 14);
        }

        public void UpdateChemicalWaterDocument(InspectionDocument document, IFormFile imgWater)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 14;

            if (imgWater != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgWater.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgWater.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeleteChemicalWaterDocument(int waterId)
        {
            var sensorwaterdoc = GetChemicalWaterDocumentById(waterId);
            sensorwaterdoc.IsDelete = true;
            _context.Update(sensorwaterdoc);
            _context.SaveChanges();
        }



        #endregion


        #region Environmental Sensor

        public List<InspectionDocument> GetAllEnvironmentalSensor()
        {
            return _context.InspectionDocuments.Where(o => o.TypeId == 15 && o.IsDelete == false).ToList();
        }

        public int AddEnvironmentalSensor(InspectionDocument document, IFormFile imgEnvironmental)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 15;

            if (imgEnvironmental != null)
            {
                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgEnvironmental.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgEnvironmental.CopyTo(stream);
                }
            }

            _context.Add(document);
            _context.SaveChanges();
            return document.InspectionId;
        }

        public InspectionDocument GetEnvironmentalSensorById(int environmentalId)
        {
            return _context.InspectionDocuments.SingleOrDefault(s => s.InspectionId == environmentalId && s.TypeId == 15);
        }

        public void UpdateEnvironmentalSensor(InspectionDocument document, IFormFile imgEnvironmental)
        {
            document.CreateDate = DateTime.Now;
            document.TypeId = 15;

            if (imgEnvironmental != null)
            {
                if (document.InspectionImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                document.InspectionImage = Guid.NewGuid() + Path.GetExtension(imgEnvironmental.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", document.InspectionImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgEnvironmental.CopyTo(stream);
                }
            }

            _context.Update(document);
            _context.SaveChanges();
        }

        public void DeleteEnvironmentalSensor(int environmentalId)
        {
            var environsensor = GetEnvironmentalSensorById(environmentalId);
            environsensor.IsDelete = true;
            _context.Update(environsensor);
            _context.SaveChanges();
        }

        #endregion
    }
}
