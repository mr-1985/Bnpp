using System;
using Bnpp.Core.Convertors;
using Bnpp.Core.Services;
using System.IO;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Bnpp.Web.Controllers
{
    public class InstallationController : Controller
    {
        private ICommissioningService _commissioning;

        public InstallationController(ICommissioningService commissioning)
        {
            _commissioning = commissioning;
        }


        [BindProperty] public Commissioning Commission { get; set; }

        [Route("Installation")]
        public IActionResult Index()
        {
            return View(_commissioning.GetAllCommissioning());
        }

        [HttpPost]
        public IActionResult ExportInstallation()
        {
            var installation = _commissioning.GetAllCommissioning().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(installation.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Installation&Commissioning.xlsx");
                }
            }
            //return View();
        }

        public IActionResult CreateCommissioning()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateCommissioning(Commissioning comm)
        {
            //if (!ModelState.IsValid)
            //    return View();

            _commissioning.AddCommissioning(Commission);
            return new JsonResult("success");
        }

        public IActionResult EditCommissioning(int id)
        {
            return View(_commissioning.GetCommissioningById(id));
        }

        [HttpPost]
        public IActionResult EditCommissioning()
        {
            //if (!ModelState.IsValid)
            //    return View();

            _commissioning.UpdateCommissioning(Commission);
            return new JsonResult("success");
        }

        public IActionResult DeleteCommissioning(string[] commissioningId)
        {
            foreach (string id in commissioningId)
            {
                _commissioning.DeleteCommissioning(Convert.ToInt32(id));
            }
            return new JsonResult("success");
        }
    }
}
