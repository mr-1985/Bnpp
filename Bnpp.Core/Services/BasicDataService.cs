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

        #region GeneralData

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
            data.CreateDate = DateTime.Now;
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

        #endregion

        #region DesignData

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

        #endregion

        #region DesignDocument

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

        #endregion

        #region ChemicalNorms

        public List<ChemicalNorms> GetAllChemicalNorms()
        {
            return _context.ChemicalNorms.Where(c => c.IsDelete == false).ToList();
        }

        public int AddChemicalNorms(ChemicalNorms chemical)
        {
            chemical.CreateDate = DateTime.Now;
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
            chemical.CreateDate = DateTime.Now;
            _context.Update(chemical);
            _context.SaveChanges();
        }

        public void DeleteChemicalNorms(int chemicalId)
        {
            var chemicals = GetChemicalNormsById(chemicalId);
            chemicals.IsDelete = true;
            UpdateChemicalNorms(chemicals);
        }

        #endregion

        #region InspectionProgram

        public List<InspectionProgram> GetAllInspectionProgram()
        {
            return _context.InspectionPrograms.Where(p => p.IsDelete == false).ToList();
        }

        public int AddInspectionProgram(InspectionProgram program)
        {
            program.CreateDate = DateTime.Now;
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
            program.CreateDate = DateTime.Now;
            _context.Update(program);
            _context.SaveChanges();
        }

        public void DeleteInspectionProgram(int programId)
        {
            var inspectionProgram = GetInspectionProgramById(programId);
            inspectionProgram.IsDelete = true;
            _context.Update(inspectionProgram);
            _context.SaveChanges();
        }

        #endregion

        #region Sensors

        public List<Sensors> GetAllSensors()
        {
            return _context.Sensors.Where(s => s.IsDelete == false).ToList();
        }

        public int AddSensors(Sensors sensors)
        {
            sensors.CreateDate = DateTime.Now;
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
            sensors.CreateDate = DateTime.Now;
            _context.Update(sensors);
            _context.SaveChanges();
        }

        public void DeleteSensors(int sensorId)
        {
            var ssensor = GetSensorsById(sensorId);
            ssensor.IsDelete = true;
            UpdateSensors(ssensor);
        }

        #endregion

        #region ControlPoints

        public List<ControlPoints> GetAllControlPoints()
        {
            return _context.ControlPoints.Where(p => p.IsDelete == false).ToList();
        }

        public int AddControlPoints(ControlPoints points)
        {
            points.CreateDate = DateTime.Now;
            _context.Add(points);
            _context.SaveChanges();
            return points.PointId;
        }

        public ControlPoints GetControlPointsById(int pointId)
        {
            return _context.ControlPoints.Find(pointId);
        }

        public void UpdateControlPoints(ControlPoints points)
        {
            points.CreateDate = DateTime.Now;
            _context.Update(points);
            _context.SaveChanges();
        }

        public void DeleteControlPoints(int pointId)
        {
            var controlPoints = GetControlPointsById(pointId);
            controlPoints.IsDelete = true;

            UpdateControlPoints(controlPoints);
        }

        #endregion

        #region HForms

        public List<HForms> GetAllHForms()
        {
            return _context.HForms.Where(f => f.IsDelete == false).ToList();
        }

        public int AddHForms(HForms forms, IFormFile imgHForms)
        {
            forms.CreateDate = DateTime.Now;

            if (imgHForms != null)
            {
                forms.HFormsImage = Guid.NewGuid() + Path.GetExtension(imgHForms.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", forms.HFormsImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgHForms.CopyTo(stream);
                }
            }

            _context.Add(forms);
            _context.SaveChanges();
            return forms.HFormsId;
        }

        public HForms GetHFormsById(int formsId)
        {
            return _context.HForms.Find(formsId);
        }

        public void UpdateHForms(HForms forms, IFormFile imgHForms)
        {
            forms.CreateDate = DateTime.Now;

            if (imgHForms != null)
            {
                if (forms.HFormsImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", forms.HFormsImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }

                forms.HFormsImage = Guid.NewGuid() + Path.GetExtension(imgHForms.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", forms.HFormsImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgHForms.CopyTo(stream);
                }
            }

            _context.Update(forms);
            _context.SaveChanges();

        }

        public void DeleteHForms(int formsId)
        {
            var hforms = GetHFormsById(formsId);
            hforms.IsDelete = true;
            _context.Update(hforms);
            _context.SaveChanges();
        }

        #endregion

        #region Components

        public List<Components> GetAllComponents()
        {
            return _context.Components.Where(c => c.IsDelete == false).ToList();
        }

        public int AddComponents(Components components, IFormFile imgComponents)
        {
            components.CreateDate = DateTime.Now;

            if (imgComponents != null)
            {
                components.ComponentsImage = Guid.NewGuid() + Path.GetExtension(imgComponents.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", components.ComponentsImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgComponents.CopyTo(stream);
                }
            }

            _context.Add(components);
            _context.SaveChanges();
            return components.ComponentId;
        }

        public Components GetComponentsById(int componentsId)
        {
            return _context.Components.Find(componentsId);
        }

        public void UpdateComponents(Components components, IFormFile imgComponents)
        {
            components.CreateDate = DateTime.Now;

            if (imgComponents != null)
            {
                if (components.ComponentsImage != null)
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", components.ComponentsImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                }


                components.ComponentsImage = Guid.NewGuid() + Path.GetExtension(imgComponents.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", components.ComponentsImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgComponents.CopyTo(stream);
                }
            }

            _context.Update(components);
            _context.SaveChanges();
        }

        public void DeleteComponents(int componentsId)
        {
            var component = GetComponentsById(componentsId);
            component.IsDelete = true;
            _context.Update(component);
            _context.SaveChanges();
        }



        #endregion

        #region 
        public List<MechanicalProperties> GetAllMechanicalProperties(int componentId)
        {
            return _context.MechanicalProperties.Where(p => p.ComponentId == componentId && p.IsDelete == false)
                .ToList();
        }

        public int AddMechanicalProperties(MechanicalProperties mechanical)
        {
            mechanical.CreateDate = DateTime.Now;
            _context.Add(mechanical);
            _context.SaveChanges();
            return mechanical.MechanicalPropertiesId;
        }

        public void UpdateMechanicalProperties(MechanicalProperties properties)
        {
            properties.CreateDate = DateTime.Now;
            _context.Update(properties);
            _context.SaveChanges();
        }

        public MechanicalProperties GetMechanicalPropertiesById(int mechanicalId)
        {
            return _context.MechanicalProperties.Find(mechanicalId);
        }

        public void DeleteMechanicalProperties(int mechanicalId)
        {
            var mekanik = GetMechanicalPropertiesById(mechanicalId);
            mekanik.IsDelete = true;
            _context.Update(mekanik);
            _context.SaveChanges();
        }


        #endregion

        #region
        public List<PhysicalProperties> GetAllPhysicalProperties(int componentId)
        {
            return _context.PhysicalProperties.Where(p => p.ComponentId == componentId && p.IsDelete == false)
               .ToList();
        }

        public int AddPhysicalProperties(PhysicalProperties physical)
        {
            physical.CreateDate = DateTime.Now;
            _context.Add(physical);
            _context.SaveChanges();
            return physical.PhysicalPropertiesId;
        }

        public void UpdatePhysicalProperties(PhysicalProperties physical)
        {
            physical.CreateDate = DateTime.Now;
            _context.Update(physical);
            _context.SaveChanges();
        }

        public PhysicalProperties GetPhysicalPropertiesById(int physicalId)
        {
            return _context.PhysicalProperties.Find(physicalId);
        }

        public void DeletePhysicalProperties(int physicalId)
        {
            var phisik = GetPhysicalPropertiesById(physicalId);
            phisik.IsDelete = true;
            _context.Update(phisik);
            _context.SaveChanges();
        }
        #endregion
    }
}
