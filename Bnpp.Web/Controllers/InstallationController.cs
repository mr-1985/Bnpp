using System;
using Bnpp.Core.Convertors;
using Bnpp.Core.Services;
using System.IO;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities;
using ClosedXML.Excel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System.Data.OleDb;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;
using System.Data;

namespace Bnpp.Web.Controllers
{
    public class InstallationController : Controller
    {
        private ICommissioningService _commissioning;
        private IWebHostEnvironment _env;
        private IConfiguration Configuration;
        public InstallationController(ICommissioningService commissioning, IWebHostEnvironment env, IConfiguration _configuration)
        {
            _commissioning = commissioning;
            _env = env;
            Configuration = _configuration;
        }


        [BindProperty] public Commissioning Commission { get; set; }

        [Route("Installation")]
        public IActionResult Index()
        {
            return View(_commissioning.GetAllCommissioning());
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


        #region Import Export Excel

        [HttpPost]
        public IActionResult ImportExcel(IFormFile postedFile)
        {
            if (postedFile != null)
            {
                //Create a Folder.
                string path = Path.Combine(this._env.WebRootPath, "Uploads");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                //Save the uploaded Excel file.
                string fileName = Path.GetFileName(postedFile.FileName);
                string filePath = Path.Combine(path, fileName);
                using (FileStream stream = new FileStream(filePath, FileMode.Create))
                {
                    postedFile.CopyTo(stream);
                }

                //Read the connection string for the Excel file.
                string conString = this.Configuration.GetConnectionString("ExcelConString");
                DataTable dt = new DataTable();
                conString = string.Format(conString, filePath);

                using (OleDbConnection connExcel = new OleDbConnection(conString))
                {
                    using (OleDbCommand cmdExcel = new OleDbCommand())
                    {
                        using (OleDbDataAdapter odaExcel = new OleDbDataAdapter())
                        {
                            cmdExcel.Connection = connExcel;

                            //Get the name of First Sheet.
                            connExcel.Open();
                            DataTable dtExcelSchema;
                            dtExcelSchema = connExcel.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                            string sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                            connExcel.Close();

                            //Read Data from First Sheet.
                            connExcel.Open();
                            cmdExcel.CommandText = "SELECT * From [" + sheetName + "]";
                            odaExcel.SelectCommand = cmdExcel;
                            odaExcel.Fill(dt);
                            connExcel.Close();
                        }
                    }
                }

                //Insert the Data read from the Excel file to Database Table.
                conString = this.Configuration.GetConnectionString("BnppConnection");
                using (SqlConnection con = new SqlConnection(conString))
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(con))
                    {
                        //Set the database table name.
                        sqlBulkCopy.DestinationTableName = "dbo.Commissioning";

                        //[OPTIONAL]: Map the Excel columns with that of the database table.


                        foreach (DataColumn column in dt.Columns)
                            sqlBulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);

                        con.Open();
                        sqlBulkCopy.WriteToServer(dt);
                        con.Close();
                    }
                }
            }

            //return View();
            return RedirectToAction("Index");
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



        #endregion
    }
}
