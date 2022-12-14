using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.Convertors;
using Bnpp.DataLayer.Entities.BasicData;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using static Microsoft.AspNetCore.Razor.Language.TagHelperMetadata;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Bnpp.Web.Controllers
{
    public class TechnicalController : Controller
    {
        private IBasicDataService _dataService;

        public TechnicalController(IBasicDataService dataService)
        {
            _dataService = dataService;
        }

        [Route("Technical")]
        public IActionResult Index()
        {
            return View();
        }

        #region General Data

        [BindProperty]
        public GeneralData data { get; set; }


        public IActionResult GeneralData()
        {
            return View(_dataService.GetAllGeneralData());
        }

        [HttpPost]
        public IActionResult ExportGeneralData()
        {
            var generalData = _dataService.GetAllGeneralData().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(generalData.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "GeneralData.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateGeneralData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateGeneralData(GeneralData generalData)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.AddGeneralData(data);
            return new JsonResult("success");
        }

        public IActionResult EditGeneralData(int id)
        {
            return View(_dataService.GetGeneralDataById(id));
        }

        [HttpPost]
        public IActionResult EditGeneralData()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.UpdateGeneralData(data);
            return new JsonResult("success");
        }


        public IActionResult DeleteGeneralData(string[] generalId)
        {
            foreach (string id in generalId)
            {
                _dataService.DeleteGeneralData(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion


        #region Design Data

        [BindProperty]
        public DesignData DesignDatas { get; set; }

        public IActionResult DesignData()
        {
            return View(_dataService.GetAllDesignData());
        }

        [HttpPost]
        public IActionResult ExportDesignData()
        {
            var designData = _dataService.GetAllDesignData().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(designData.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "DesignData.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateDesignData()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDesignData(DesignData design)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.AddDesignData(DesignDatas);
            return new JsonResult("success");
        }

        public IActionResult EditDesignData(int id)
        {
            return View(_dataService.GetDesignDataById(id));
        }

        [HttpPost]
        public IActionResult EditDesignData()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.UpdateDesignData(DesignDatas);
            return new JsonResult("success");
        }

        public IActionResult DleteDesignData(string[] designId)
        {
            foreach (string id in designId)
            {
                _dataService.DeleteDesignData(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region Documents
        [BindProperty] public DesignDocument Document { get; set; }


        public IActionResult Documents()
        {
            return View(_dataService.GetAllDesignDocument());
        }



        //[HttpPost]
        //public IActionResult Export()
        //{
        //    using (XLWorkbook wb = new XLWorkbook())
        //    {
        //        DataTable dt = this.GetAllDesignDocument().Tables[0];
        //        wb.Worksheets.Add(dt);
        //        using (MemoryStream stream = new MemoryStream())
        //        {
        //            wb.SaveAs(stream);
        //            return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Grid.xlsx");
        //        }
        //    }
        //}

        //private DataSet GetAllDesignDocument()
        //{
        //    DataSet ds = new DataSet();
        //    string constr = @"Data Source=87.236.215.209;Initial Catalog=bnppDBNew;Integrated Security=False;Persist Security Info=False;User ID=bnppuser;Password=1234@qweR1234@qweR";
        //    using (SqlConnection con = new SqlConnection(constr))
        //    {
        //        string query = "SELECT * FROM DesignDocuments";
        //        using (SqlCommand cmd = new SqlCommand(query))
        //        {
        //            cmd.Connection = con;
        //            using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
        //            {
        //                sda.Fill(ds);
        //            }
        //        }
        //    }

        //    return ds;
        //}


       

        [HttpPost]
        public IActionResult ExportDocument()
        {
            var designsdoc = _dataService.GetAllDesignDocument().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(designsdoc.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Documents.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateDesignDocument()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDesignDocument(IFormFile fileDocument)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _dataService.AddDesignDocument(Document, fileDocument);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditDesignDocument(int id)
        {
            return View(_dataService.GetDesignDocumentById(id));
        }


        [HttpPost]
        public IActionResult EditDesignDocument(IFormFile fileDocument)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _dataService.UpdateDesignDocument(Document, fileDocument);
            return Json(" Electormotors Successfully Deleted.");
        }


        public IActionResult DeleteDesignDocument(string[] documentId)
        {
            foreach (string id in documentId)
            {
                _dataService.DeleteDesignDocument(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region Safety

        public IActionResult Safety()
        {
            return View(_dataService.GetAllComponents());
        }

        [HttpPost]
        public IActionResult ExportSafety()
        {
            var safety = _dataService.GetAllComponents().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(safety.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Safety class & Seismic.xlsx");
                }
            }
            //return View();
        }

        #endregion

        #region Components

        [BindProperty]
        public Components Component { get; set; }

        public IActionResult Components()
        {
            return View(_dataService.GetAllComponents());
        }


        public IActionResult CreateComponents()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateComponents(IFormFile fileComponents)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _dataService.AddComponents(Component, fileComponents);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditComponents(int id)
        {
            return View(_dataService.GetComponentsById(id));
        }

        [HttpPost]
        public IActionResult EditComponents(IFormFile fileComponents)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _dataService.UpdateComponents(Component, fileComponents);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteComponents(string[] componentsId)
        {
            foreach (string id in componentsId)
            {
                _dataService.DeleteComponents(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }

        #endregion

        #region ChemicalNorms

        [BindProperty] public ChemicalNorms Chemical { get; set; }


        public IActionResult ChemicalNorms()
        {
            return View(_dataService.GetAllChemicalNorms());
        }

        [HttpPost]
        public IActionResult ExportChemicalNorms()
        {
            var chemicalNorms = _dataService.GetAllChemicalNorms().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(chemicalNorms.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ChemicalNorms.xlsx");
                }
            }
            //return View();
        }


        public IActionResult CreateChemicalNorms()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateChemicalNorms(ChemicalNorms chemicalNorms)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.AddChemicalNorms(Chemical);
            return new JsonResult("success");
        }


        public IActionResult EditChemicalNorms(int id)
        {
            return View(_dataService.GetChemicalNormsById(id));
        }

        [HttpPost]
        public IActionResult EditChemicalNorms()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.UpdateChemicalNorms(Chemical);
            return new JsonResult("success");
        }


        public IActionResult DeleteChemicalNorms(string[] chemicalId)
        {
            foreach (string id in chemicalId)
            {
                _dataService.DeleteChemicalNorms(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }

        #endregion

        #region Technical Inspection Program
        [BindProperty]
        public InspectionProgram Program { get; set; }

        public IActionResult TechnicalPrograms()
        {
            return View(_dataService.GetAllInspectionProgram());
        }

        [HttpPost]
        public IActionResult ExportTechnicalPrograms()
        {
            var technicalPrograms = _dataService.GetAllInspectionProgram().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(technicalPrograms.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "TechnicalPrograms.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateTechnicalInspectionProgram()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CreateTechnicalInspectionProgram(InspectionProgram inspection)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.AddInspectionProgram(Program);
            return new JsonResult("success");
        }

        public IActionResult EditTechnicalInspectionProgram(int id)
        {
            return View(_dataService.GetInspectionProgramById(id));
        }

        [HttpPost]
        public IActionResult EditTechnicalInspectionProgram()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.UpdateInspectionProgram(Program);
            return new JsonResult("success");
        }

        public IActionResult DeleteTechnicalInspectionProgram(string[] inspectionsId)
        {
            foreach (string id in inspectionsId)
            {
                _dataService.DeleteInspectionProgram(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region Sensors
        [BindProperty] public Sensors Sensor { get; set; }


        public IActionResult Sensors()
        {
            return View(_dataService.GetAllSensors());
        }

        [HttpPost]
        public IActionResult ExportSensors()
        {
            var sensors = _dataService.GetAllSensors().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(sensors.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Sensors.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateSensor()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CreateSensor(Sensors crtSensors)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.AddSensors(Sensor);
            return new JsonResult("success");
        }

        public IActionResult EditSensor(int id)
        {
            return View(_dataService.GetSensorsById(id));
        }

        [HttpPost]
        public IActionResult EditSensor()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.UpdateSensors(Sensor);
            return new JsonResult("success");
        }

        public IActionResult DeleteSensor(string[] sensorId)
        {
            foreach (string id in sensorId)
            {
                _dataService.DeleteSensors(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region Control Points
        [BindProperty] public ControlPoints ControlPoint { get; set; }
        public IActionResult ControlPoints()
        {
            return View(_dataService.GetAllControlPoints());
        }


        [HttpPost]
        public IActionResult ExportControlPoints()
        {
            var controlPoints = _dataService.GetAllControlPoints().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(controlPoints.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ControlPoints.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateControlPoints()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateControlPoints(ControlPoints points)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.AddControlPoints(ControlPoint);
            return new JsonResult("success");
        }

        public IActionResult EditControlPoints(int id)
        {
            return View(_dataService.GetControlPointsById(id));
        }

        [HttpPost]
        public IActionResult EditControlPoints()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.UpdateControlPoints(ControlPoint);
            return new JsonResult("success");
        }

        public IActionResult DeleteControlPoints(string[] pointId)
        {
            foreach (string id in pointId)
            {
                _dataService.DeleteControlPoints(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region HForms

        [BindProperty]
        public HForms Forms { get; set; }

        public IActionResult HForms()
        {
            return View(_dataService.GetAllHForms());
        }


        [HttpPost]
        public IActionResult ExportHForms()
        {
            var hForms = _dataService.GetAllHForms().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(hForms.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "HForms.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateHForms()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateHForms(IFormFile filehforms)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _dataService.AddHForms(Forms, filehforms);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditHForms(int id)
        {
            return View(_dataService.GetHFormsById(id));
        }

        [HttpPost]
        public IActionResult EditHForms(IFormFile filehforms)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            _dataService.UpdateHForms(Forms, filehforms);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteHForms(string[] hformId)
        {
            foreach (string id in hformId)
            {
                _dataService.DeleteHForms(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }

        #endregion


        #region Mechanical Properties

        [BindProperty]
        public MechanicalProperties Mechanical { get; set; }


        public IActionResult MechanicalProperties(int id)
        {
            //Mechanical = new MechanicalProperties();
            //Mechanical.ComponentId = id;

            ViewData["ComponentId"] = id;

            return View(_dataService.GetAllMechanicalProperties(id));
        }

        public IActionResult CreateMechanicalProperties(int id)
        {

            return View(new MechanicalProperties() { ComponentId = id });
        }

        [HttpPost]
        public IActionResult CreateMechanicalProperties(MechanicalProperties mechanicalProperties)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.AddMechanicalProperties(Mechanical);
            return new JsonResult("success");
        }

        public IActionResult EditMechanicalProperties(int id)
        {
            return View(_dataService.GetMechanicalPropertiesById(id));
        }

        [HttpPost]
        public IActionResult EditMechanicalProperties()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.UpdateMechanicalProperties(Mechanical);
            return new JsonResult("success");
        }

        public IActionResult DeleteMechanicalProperties(string[] mechanicalId)
        {
            foreach (string id in mechanicalId)
            {
                _dataService.DeleteMechanicalProperties(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
        #endregion

        #region   Physical Properties

        [BindProperty]
        public PhysicalProperties Physical { get; set; }


        public IActionResult PhysicalProperties(int id)
        {
            //Mechanical = new MechanicalProperties();
            //Mechanical.ComponentId = id;

            ViewData["ComponentId"] = id;

            return View(_dataService.GetAllPhysicalProperties(id));
        }

        public IActionResult CreatePhysicalProperties(int id)
        {

            return View(new PhysicalProperties() { ComponentId = id });
        }

        [HttpPost]
        public IActionResult CreatePhysicalProperties(PhysicalProperties physicalProperties)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.AddPhysicalProperties(Physical);
            return new JsonResult("success");
        }

        public IActionResult EditPhysicalProperties(int id)
        {
            return View(_dataService.GetPhysicalPropertiesById(id));
        }

        [HttpPost]
        public IActionResult EditPhysicalProperties()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.UpdatePhysicalProperties(Physical);
            return new JsonResult("success");
        }

        public IActionResult DeletePhysicalProperties(string[] physicalId)
        {
            foreach (string id in physicalId)
            {
                _dataService.DeletePhysicalProperties(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }

        #endregion

        #region Chemical Compositions

        [BindProperty]
        public ChemicalComponent chemicalComponent { get; set; }

        public IActionResult ChemicalComponent(int id)
        {
            //Mechanical = new MechanicalProperties();
            //Mechanical.ComponentId = id;

            ViewData["ComponentId"] = id;

            return View(_dataService.GetAllChemicalComponent(id));
        }

        public IActionResult CreateChemicalComponent(int id)
        {

            return View(new ChemicalComponent() { ComponentId = id });
        }

        [HttpPost]
        public IActionResult CreateChemicalComponent(ChemicalComponent chemicals)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.AddChemicalComponent(chemicalComponent);
            return new JsonResult("success");
        }

        public IActionResult EditChemicalComponent(int id)
        {
            return View(_dataService.GetChemicalComponentById(id));
        }

        [HttpPost]
        public IActionResult EditChemicalComponent()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _dataService.UpdateChemicalComponent(chemicalComponent);
            return new JsonResult("success");
        }

        public IActionResult DeleteChemicalComponent(string[] chemicalId)
        {
            foreach (string id in chemicalId)
            {
                _dataService.DeleteChemicalComponent(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }

        #endregion

        #region  Heat Treatment


        [BindProperty]
        public HeatOperation HeatOperation { get; set; }

        public IActionResult HeatTreatment(int id)
        {
            //Mechanical = new MechanicalProperties();
            //Mechanical.ComponentId = id;

            ViewData["ComponentId"] = id;

            return View(_dataService.GetAllHeatOperation(id));
        }

        public IActionResult CreateHeatTreatment(int id)
        {
            return View(new HeatOperation() { ComponentId = id });
        }

        [HttpPost]
        public IActionResult CreateHeatTreatment(IFormFile fileHeating, string StartDates = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            if (StartDates != "")
            {
                string[] std = StartDates.Split('/', ' ', ':');
                HeatOperation.TimesOfHeating = new DateTime(
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    int.Parse(std[3]),
                    int.Parse(std[4]),
                    int.Parse(std[5]),
                    new GregorianCalendar()
                );
            }

            _dataService.AddHeatOperation(HeatOperation, fileHeating);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditHeatTreatment(int id)
        {
            return View(_dataService.GetHeatOperationById(id));
        }

        [HttpPost]

        public IActionResult EditHeatTreatment(IFormFile fileHeating, string StartDates = "")
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}


            if (StartDates != "")
            {
                string[] std = StartDates.Split('/', ' ', ':');
                HeatOperation.TimesOfHeating = new DateTime(
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    int.Parse(std[3]),
                    int.Parse(std[4]),
                    int.Parse(std[5]),
                    new GregorianCalendar()
                );
            }

            _dataService.UpdateHeatOperation(HeatOperation, fileHeating);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteHeatTreatment(string[] heataoperId)
        {
            foreach (string id in heataoperId)
            {
                _dataService.DeleteHeatOperation(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }

        #endregion
    }
}
