using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Globalization;
using Bnpp.Core.Convertors;
using System.IO;
using System;
using System.Web;
using Bnpp.Core.Services;
using System.Linq;
using ClosedXML;
using ClosedXML.Excel;
using Bnpp.Core.ViewModels;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;





namespace Bnpp.Web.Controllers
{
    public class ImportController : Controller
    {
        private IDamageabilityService _reportService;

        public ImportController(IDamageabilityService reportService)
        {
            _reportService = reportService;
        }

        //[Route("SACOR-446")]
        //public IActionResult Index()
        //{
        //    return View(_reportService.GetAllReports());
        //}

        //public IActionResult ListOfReports()
        //{

        //    IEnumerable<DamageabilityReport> allReports = null;

        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("https://localhost:44340/api/ReportApi/");
        //        //HTTP GET
        //        var responseTask = client.GetAsync("https://localhost:44340/api/ReportApi/");
        //        responseTask.Wait();

        //        var result = responseTask.Result;
        //        if (result.IsSuccessStatusCode)
        //        {
        //            var readTask = result.Content.ReadAsAsync<IList<DamageabilityReport>>();
        //            readTask.Wait();

        //            allReports = readTask.Result;
        //        }
        //        else //web api sent error response 
        //        {
        //            //log response status here..

        //            allReports = Enumerable.Empty<DamageabilityReport>();

        //            ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
        //        }
        //    }

        //    return View(allReports);
        //}

        //public IActionResult ListOfReports(string filter = "", string date = "", string fileDate = "", bool IsExistReport = false)
        //{
        //    return View(_reportService.GetAllReports(filter, date, fileDate));
        //}

        [BindProperty] public DamageabilityReport Report { get; set; }

        [BindProperty] public List<DamageabilityReport> DamageReports { get; set; }

        [Route("SACOR-446")]
        public IActionResult Index(string filter = "", string date = "", string fileDate = "", bool IsExistReport = false)
        {
            ViewBag.IsExistReport = IsExistReport;
            return View(_reportService.GetAllReports(filter, date, fileDate));
        }

        #region Group By Date

        public IActionResult GroupByDate(string filter = "", string date = "", string fileDate = "", bool IsExistReport = false)
        {
            ViewBag.IsExistReport = IsExistReport;
            return View(_reportService.GetAllReports(filter, date, fileDate));
        }

        public IActionResult GroupByDatessss(string filter = "", string date = "", string fileDate = "", bool IsExistReport = false)
        {
            ViewBag.IsExistReport = IsExistReport;
            return View(_reportService.GetAllReports(filter, date, fileDate));
        }
        #endregion

        public IActionResult CreateDamageabilityReport()
        {
            return View();
        }


        public IActionResult EditDamageabilityReport(int id)
        {
            return View(_reportService.GetDamageabilityReportById(id));
        }

        //[HttpPost]
        //public IActionResult EditDamageabilityReport(string allowablecuf, string allowablelifetime)
        //{
        //    //if (!ModelState.IsValid)
        //    //    return View();


        //    _reportService.UpdateDamageabilityReport(allowablecuf, allowablelifetime);
        //    return RedirectToAction("index");
        //}

        [HttpPost]
        public IActionResult EditDamageabilityReport(string allowablecuf, string allowablelifetime, string allowablechangingratio, int id)
        {
            //if (!ModelState.IsValid)
            //    return View();


            _reportService.UpdateDamageabilityReport(allowablecuf, allowablelifetime, allowablechangingratio, id);
            return RedirectToAction("index");
        }


        public IActionResult DeleteDamageabilityReport(string[] damagingId)
        {
            foreach (string id in damagingId)
            {
                _reportService.DeleteDamageabilityReport(Convert.ToInt32(id));
            }
            return new JsonResult("success");

        }

        [HttpPost]
        public IActionResult CreateDamageabilityReport(IFormFile fileReport, string reportDates, string reportDate = "", string allowablecuf = "", string allowablelifetime = "", string Changingratio = "", string allowableChangingratio = "")
        {
            var totalReports = _reportService.GetAllReports();

            var daterepo = reportDates.Substring(5, 10).ToString();
            DateTime dateForCompare = DateTime.MinValue;
            if (reportDates != "")
            {
                string[] std = daterepo.Split('_');
                dateForCompare = new DateTime(int.Parse(std[0]),
                    int.Parse(std[1]),
                    int.Parse(std[2]),
                    new GregorianCalendar()
                );
            }

            if (totalReports.Count == 0)
            {
                var Date = "";
                var Akz = "";
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
                    //if (i == 2)
                    //{
                    //    var rowSelected = datatable.Rows[i][0].ToString();
                    //    var splitData = rowSelected.Substring(29).Trim().Split(" ");

                    //    Date = splitData[0];
                    //}


                    if (i > 17 && i < 116)
                    {

                        var rowSelected = datatable.Rows[i][0].ToString();
                        var Identifier = rowSelected.Substring(0, 9);
                        var splitData = rowSelected.Substring(9).Trim().Split("   ");


                        Akz = Identifier;
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
                        report.Locationofthecheckpoint = location;
                        report.AllowableCUF = allowablecuf;
                        report.AllowableLifeTime = allowablelifetime;
                        report.AllowableChangingRatio = allowableChangingratio;
                        report.Akz = Akz;
                        report.ReportDate = dateForCompare;


                        //report.ChangingRatio = Changingratio;

                        //if (Date != "")
                        //{
                        //    string[] std = Date.Split('.');
                        //    report.ReportDate = new DateTime(int.Parse(std[2]),
                        //        int.Parse(std[1]),
                        //        int.Parse(std[0]),
                        //        new GregorianCalendar()
                        //    );
                        //}

                        //if (reportDate != "")
                        //{
                        //    string[] std = reportDate.Split('/');
                        //    report.ReportDate = new DateTime(int.Parse(std[2]),
                        //        int.Parse(std[0]),
                        //        int.Parse(std[1]),
                        //        new GregorianCalendar()
                        //    );
                        //}

                        _reportService.AddNewDamageabilityReport(report);

                    }
                }
            }
            else
            {
                //var daterepo = reportDates.Substring(5,10).ToString();
                //DateTime dateForCompare = DateTime.MinValue;
                //if (reportDates != "")
                //{
                //    string[] std = daterepo.Split('_');
                //    dateForCompare = new DateTime(int.Parse(std[0]),
                //        int.Parse(std[1]),
                //        int.Parse(std[2]),
                //        new GregorianCalendar()
                //    );
                //}


                var compareforexistReport = _reportService.GetAllReportsForCompare(dateForCompare);
                
                if (compareforexistReport.Count != 0)
                {
                    return Redirect("/SACOR-446?IsExistReport=true");
                }
                else
                {
                    var beforeTotal = _reportService.GetAllTotalReports();

                //var btotal = "";
                //foreach (var p in beforeTotal)
                //{
                //    var bt = p.Totaldamageabilityofequipment;
                //    btotal = bt;
                //}

                var Date = "";
                var Akz = "";
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
                    //if (i == 2)
                    //{
                    //    var rowSelected = datatable.Rows[i][0].ToString();
                    //    var splitData = rowSelected.Substring(29).Trim().Split(" ");

                    //    Date = splitData[0];
                    //}

                   

                    if (i > 17 && i < 116)
                    {
                        var rowSelected = datatable.Rows[i][0].ToString();
                        var Identifier = rowSelected.Substring(0, 9);
                        var splitData = rowSelected.Substring(9).Trim().Split("   ");

                        Akz = Identifier;
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
                        report.Locationofthecheckpoint = location;
                        report.Akz = Akz;
                        report.ReportDate = dateForCompare;

                        //report.ChangingRatio = Changingratio;

                        // ChangingRatio
                        var btotal = "";
                        var j = 18;
                        foreach (var p in beforeTotal)
                        {
                            if (i == j)
                            {
                                var bt = p.Totaldamageabilityofequipment;
                                btotal = bt;
                            }
                            j++;
                            //break;
                            //goto endofloop;
                        }
                        //endofloop:
                        if (Convert.ToDecimal(btotal) != 0)
                        {
                            decimal ratio = (Convert.ToDecimal(btotal) - Convert.ToDecimal(Totaldamageabilityofequipment)) / Convert.ToDecimal(btotal);
                            report.ChangingRatio = ratio.ToString();
                        }
                        //else
                        //{
                        //    report.ChangingRatio = Convert.ToDecimal(0);
                        //}

                        //AllowableCUF & AllowableLifeTime
                        var allowableCuf = "";
                        var allowableLifeTime = "";
                        var allowablesChangingratio = "";

                        foreach (var a in totalReports)
                        {
                            var allowcuf = a.AllowableCUF;
                            var allowlifetime = a.AllowableLifeTime;
                            var allowratio = a.AllowableChangingRatio;
                            allowableCuf = allowcuf;
                            allowableLifeTime = allowlifetime;
                            allowablesChangingratio = allowratio;
                            break;
                        }

                        report.AllowableCUF = allowableCuf;
                        report.AllowableLifeTime = allowableLifeTime;
                        report.AllowableChangingRatio = allowablesChangingratio;

                        //if (Date != "")
                        //{
                        //    string[] std = Date.Split('.');
                        //    report.ReportDate = new DateTime(int.Parse(std[2]),
                        //        int.Parse(std[1]),
                        //        int.Parse(std[0]),
                        //        new GregorianCalendar()
                        //    );
                        //}

                        //#region  Comoare the Date of This report with Date of before reports

                        
                        //var compareforexistReport = _reportService.GetAllReportsForCompare(report.ReportDate);
                        //if (compareforexistReport.Count != 0)
                        //{
                        //    return Redirect("/SACOR-446?IsExistReport=true");
                        //}
                        //#endregion

                        _reportService.AddNewDamageabilityReport(report);

                    }
                }
            }

        }
            //

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


        [HttpPost]
        public IActionResult Export(string reportId)
        {
            if (reportId == null)
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
            }
            else
            {
                var res = new List<DamageabilityReport>();

                string[] std = reportId.Split(',');

                foreach (string id in std)
                {
                    var excelDocument = _reportService.GetDamageabilityReportById(Convert.ToInt32(id));
                    res.Add(excelDocument);
                }

                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(Commons.ToDataTable(res.ToList()));
                    using (MemoryStream stream = new MemoryStream())
                    {
                        wb.SaveAs(stream);

                        return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "SACOR-446.xlsx");
                    }
                }
            }
            //return RedirectToAction("index");
        }

    }
}
