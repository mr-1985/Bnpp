using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Globalization;
using Bnpp.Core.Convertors;
using System.IO;
using System;
using Bnpp.Core.Services;
using System.Linq;
using ClosedXML.Excel;

namespace Bnpp.Web.Controllers
{
    public class ImportController : Controller
    {
        private IDamageabilityService _reportService;

        public ImportController(IDamageabilityService reportService)
        {
            _reportService = reportService;
        }

        [Route("SACOR-446")]
        public IActionResult Index()
        {
            return View(_reportService.GetAllReports());
        }

        public IActionResult CreateDamageabilityReport()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateDamageabilityReport(IFormFile fileReport,string reportDate = "",string allowablecuf="",string allowablelifetime="",string Changingratio="")
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
                    report.Locationofthecheckpoint=location;
                    report.AllowableCUF = allowablecuf;
                    report.AllowableLifeTime = allowablelifetime;
                    report.ChangingRatio = Changingratio;

                    if (reportDate != "")
                    {
                        string[] std = reportDate.Split('/');
                        report.ReportDate = new DateTime(int.Parse(std[2]),
                            int.Parse(std[0]),
                            int.Parse(std[1]),
                            new GregorianCalendar()
                        );
                    }

                    _reportService.AddNewDamageabilityReport(report);
                }
            }


                //return View();
            return RedirectToAction("Index");
        }

        

        [HttpPost]
        public IActionResult ExportSACOR()
        {
            var sacorreport = _reportService.GetAllReports().ToList();
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(Commons.ToDataTable(sacorreport.ToList()));
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "SACOR Report.xlsx");
                }
            }
            //return View();
        }
    }
}
