using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.BasicData;
using Microsoft.AspNetCore.Http;

namespace Bnpp.Core.Services
{
    public class BasicDataService : IBasicDataService
    {
        private BnppContext _context;

        public BasicDataService(BnppContext context)
        {
            _context = context;
        }
        public List<GeneralData> GetAllGeneralData()
        {
            return _context.GeneralData.Where(g => g.IsDelete == false).ToList();
        }

        public int AddGeneralData(GeneralData data)
        {
            data.CreateDate = DateTime.Now;
            _context.Add(data);
            _context.SaveChanges();
            return data.GeneralId;
        }

        public void UpdateGeneralData(GeneralData data)
        {
            data.CreateDate=DateTime.Now;
            _context.Update(data);
            _context.SaveChanges();
        }

        public GeneralData GetGeneralDataById(int generalId)
        {
            return _context.GeneralData.Find(generalId);
        }

        public void DeleteGeneralData(int generalId)
        {
            var general = GetGeneralDataById(generalId);
            general.IsDelete = true;
            UpdateGeneralData(general);
        }

        public List<DesignData> GetAllDesignData()
        {
            return _context.DesignData.Where(g => g.IsDelete == false).ToList();
        }

        public int AddDesignData(DesignData design)
        {
            design.CreateDate = DateTime.Now;
            _context.DesignData.Add(design);
            _context.SaveChanges();
            return design.DesignId;
        }

        public void UpdateDesignData(DesignData design)
        {
            design.CreateDate = DateTime.Now;
            _context.Update(design);
            _context.SaveChanges();
        }

        public DesignData GetDesignDataById(int designId)
        {
            return _context.DesignData.Find(designId);
        }

        public void DeleteDesignData(int designId)
        {
            var design = GetDesignDataById(designId);
            design.IsDelete = true;
            UpdateDesignData(design);
        }

        public List<DesignDocument> GetAllDesignDocument()
        {
            return _context.DesignDocuments.Where(d => d.IsDelete == false).ToList();
        }

        public int AddDesignDocument(DesignDocument designDocument, IFormFile imgDesignDocument)
        {
            designDocument.CreateDate = DateTime.Now;

            if (imgDesignDocument != null)
            {
                designDocument.DesignDocumentImage = Guid.NewGuid() + Path.GetExtension(imgDesignDocument.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", designDocument.DesignDocumentImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgDesignDocument.CopyTo(stream);
                }
            }

            _context.Add(designDocument);
            _context.SaveChanges();
            return designDocument.DocumentId;
        }

        public DesignDocument GetDesignDocumentById(int designDocumentId)
        {
            return _context.DesignDocuments.Find(designDocumentId);
        }

        public void UpdateDesignDocument(DesignDocument designDocument, IFormFile imgDesignDocument)
        {
            designDocument.CreateDate = DateTime.Now;

            if (imgDesignDocument != null)
            {
                designDocument.DesignDocumentImage = Guid.NewGuid() + Path.GetExtension(imgDesignDocument.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", designDocument.DesignDocumentImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgDesignDocument.CopyTo(stream);
                }
            }

            _context.Update(designDocument);
            _context.SaveChanges();
        }

        public void DeleteDesignDocument(int designDocumentId)
        {
            var document = GetDesignDocumentById(designDocumentId);
            document.IsDelete = true;
            _context.Update(document);
            _context.SaveChanges();
        }

        public List<ChemicalNorms> GetAllChemicalNorms()
        {
            return _context.ChemicalNorms.Where(c => c.IsDelete == false).ToList();
        }

        public int AddChemicalNorms(ChemicalNorms chemical)
        {
           chemical.CreateDate=DateTime.Now;
           _context.Add(chemical);
           _context.SaveChanges();
           return chemical.ChemicalId;
        }

        public ChemicalNorms GetChemicalNormsById(int chemicalId)
        {
            return _context.ChemicalNorms.Find(chemicalId);
        }

        public void UpdateChemicalNorms(ChemicalNorms chemical)
        {
            chemical.CreateDate=DateTime.Now;
            _context.Update(chemical);
            _context.SaveChanges();
        }

        public void DeleteChemicalNorms(int chemicalId)
        {
            var chemicals = GetChemicalNormsById(chemicalId);
            chemicals.IsDelete = true;
            UpdateChemicalNorms(chemicals);
        }

        public List<InspectionProgram> GetAllInspectionProgram()
        {
            return _context.InspectionPrograms.Where(p=>p.IsDelete==false).ToList();
        }

        public int AddInspectionProgram(InspectionProgram program)
        {
            program.CreateDate=DateTime.Now;
            _context.Add(program);
            _context.SaveChanges();
            return program.InspectionProgramId;
        }

        public InspectionProgram GetInspectionProgramById(int programId)
        {
            return _context.InspectionPrograms.Find(programId);
        }

        public void UpdateInspectionProgram(InspectionProgram program)
        {
            program.CreateDate=DateTime.Now;
            _context.Update(program);
            _context.SaveChanges();
        }

        public void DeleteInspectionProgram(int programId)
        {
            var inspectionProgram = GetInspectionProgramById(programId);
            inspectionProgram.IsDelete=true;
            _context.Update(inspectionProgram);
            _context.SaveChanges();
        }

        public List<Sensors> GetAllSensors()
        {
            return _context.Sensors.Where(s => s.IsDelete == false).ToList();
        }

        public int AddSensors(Sensors sensors)
        {
           sensors.CreateDate=DateTime.Now;
           _context.Add(sensors);
           _context.SaveChanges();
           return sensors.SensorId;
        }

        public Sensors GetSensorsById(int sensorId)
        {
            return _context.Sensors.Find(sensorId);
        }

        public void UpdateSensors(Sensors sensors)
        {
           sensors.CreateDate=DateTime.Now;
           _context.Update(sensors);
           _context.SaveChanges();
        }

        public void DeleteSensors(int sensorId)
        {
            var ssensor = GetSensorsById(sensorId);
            ssensor.IsDelete = true;
            UpdateSensors(ssensor);
        }
    }
}
