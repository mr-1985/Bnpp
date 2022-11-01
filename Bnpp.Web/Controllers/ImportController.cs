using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.IO;

namespace Bnpp.Web.Controllers
{
    public class ImportController : Controller
    {
        private IDamageabilityService _reportService;

        public ImportController(IDamageabilityService reportService)
        {
            _reportService = reportService;
        }

        [Route("RALDS")]
        public IActionResult Index()
        {
            return View(_reportService.GetAllReports());
        }

        public IActionResult CreateDamageabilityReport()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDamageabilityReport(IFormFile fileReport)
        {

            var location = "";
            var Totaldamageabilityofequipment = "";
            var Damageabilityperuncoiledcycles = "";
            var Damageabilitypercoiledcycles = "";
            var LifetimeofequipmentperRALDS = "";
            var Lifetimeofequipmentindesign = "";
            var Actionperiodofequipment = "";

            DataTable datatable = new DataTable();

            var stream = fileReport.OpenReadStream();

            StreamReader streamreader = new StreamReader(stream);
            //StreamReader streamreader = new StreamReader(@"G:\New folder\bsh1_2021_10_06_damage.txt");
            char[] delimiter = new char[] { '\t' };
            string[] columnheaders = streamreader.ReadLine().Split(delimiter);

            foreach (string columnheader in columnheaders)
            {
                datatable.Columns.Add(columnheader); // I've added the column headers here.
            }

            while (streamreader.Peek() > 0)
            {
                DataRow datarow = datatable.NewRow();
                datarow.ItemArray = streamreader.ReadLine().Split(delimiter);
                datatable.Rows.Add(datarow);
            }

            for (int i = 0; i < datatable.Rows.Count; i++)
            {
                if (i > 17 && i < 116)
                {
                    var rowSelected = datatable.Rows[i][0].ToString();
                    var Identifier = rowSelected.Substring(0, 9);
                    var splitData = rowSelected.Substring(9).Trim().Split("   ");
                    location = splitData[0];

                    Totaldamageabilityofequipment = splitData[splitData.Length - 1];
                    Damageabilityperuncoiledcycles = splitData[splitData.Length - 2];
                    Damageabilitypercoiledcycles = splitData[splitData.Length - 3];
                    LifetimeofequipmentperRALDS = splitData[splitData.Length - 4];
                    Lifetimeofequipmentindesign = splitData[splitData.Length - 5];
                    Actionperiodofequipment = splitData[splitData.Length - 6];

                    //اینجا اینزرت کن تو جدول 

                    DamageabilityReport report = new DamageabilityReport();
                    report.Totaldamageabilityofequipment = Totaldamageabilityofequipment;
                    report.Damageabilityperuncoiledcycles = Damageabilityperuncoiledcycles;
                    report.Damageabilitypercoiledcycles = Damageabilitypercoiledcycles;
                    report.LifetimeofequipmentperRALDS = LifetimeofequipmentperRALDS;
                    report.Lifetimeofequipmentindesign = Lifetimeofequipmentindesign;
                    report.Actionperiodofequipment = Actionperiodofequipment;


                    _reportService.AddNewDamageabilityReport(report);
                }
            }


                //return View();
            return RedirectToAction("Index");
        }
    }
}
