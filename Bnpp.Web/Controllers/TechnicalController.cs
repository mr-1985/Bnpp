using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.BasicData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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

        public IActionResult Safety()
        {
            return View();
        }

        public IActionResult Components()
        {
            return View();
        }

        #region ChemicalNorms

        [BindProperty] public ChemicalNorms Chemical { get; set; }


        public IActionResult ChemicalNorms()
        {
            return View(_dataService.GetAllChemicalNorms());
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

public IActionResult ControlPoints()
        {
            return View();
        }

        public IActionResult HForms()
        {
            return View();
        }
    }
}
