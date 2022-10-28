using Bnpp.Core.Services;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.FileProviders;
using System;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;

namespace Bnpp.Web.Controllers
{
    public class BackupController : Controller
    {
        private IWebHostEnvironment _env;
        private IBackupService _backupService;
        public BackupController(IWebHostEnvironment env, IBackupService backupService)
        {
            _env = env;
            _backupService = backupService;
        }




       

        [HttpPost]
        public void BackupDatabase(string databaseName)
        {
            string filePath = BuildBackupPathWithFilename(databaseName);


            //Connect to DB
            SqlConnection connect;
            //string con = @"Data Source=87.107.146.152;Initial Catalog=LisingTransactionManagementDB;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=1234@qweR";
            string con = @"Data Source=87.236.215.209;Initial Catalog=bnppDBNew;Integrated Security=False;Persist Security Info=False;User ID=bnppuser;Password=1234@qweR1234@qweR";
            connect = new SqlConnection(con);
            connect.Open();
            //----------------------------------------------------------------------------------------------------

            //Execute SQL---------------
            SqlCommand command;
            command = new SqlCommand(@"BACKUP DATABASE bnppDBNew TO DISK = '" + filePath + "';", connect);
            command.ExecuteNonQuery();
            //-------------------------------------------------------------------------------------------------------------------------------

            connect.Close();

        }

        private string BuildBackupPathWithFilename(string databaseName)
        {
            
            string filename = string.Format("backupdatabase_{0}-{1}.bak", databaseName, DateTime.Now.ToString("yyyy-MM-dd-mm"));
            var UploadsRootFolder = Path.Combine(_env.WebRootPath, "BackupDatabase");
            if (!Directory.Exists(UploadsRootFolder))
                Directory.CreateDirectory(UploadsRootFolder);
            return Path.Combine(UploadsRootFolder, filename);
        }

        [Route("Backup")]
        public IActionResult Index()
        {
            return View(_backupService.GetAllBackup());
        }

        //public ContentResult Backup(string bnppDBNew)
        //{
        //    try
        //    {
        //        string filePath = BuildBackupPathWithFilename(bnppDBNew);
        //        string filename = string.Format("backupdatabase_{0}-{1}.bak", bnppDBNew, DateTime.Now.ToString("yyyy-MM-dd-mm"));
        //        return Content($"Backup database successfully to {filename}");
        //    }
        //    catch (Exception ex)
        //    {
        //        return Content("Backup Error database successfully: " + ex.ToString());
        //    }
        //}

        public IActionResult CreateBackup(string bnppDBNew)
        {
            BuildBackupPathWithFilename(bnppDBNew);
            BackupDatabase(bnppDBNew);



            Backup myBack = new Backup();
            myBack.CreateDate = DateTime.Now;
            myBack.Name = string.Format("backupdatabase_{0}-{1}.bak", bnppDBNew, DateTime.Now.ToString("yyyy-MM-dd-mm"));
            _backupService.AddNewBackup(myBack);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult DeleteBackup(string[] backupsId)
        {
            foreach (string id in backupsId)
            {
                _backupService.DeleteBackup(Convert.ToInt32(id));
            }

            return Json(" Backup Successfully Deleted.");
        }

        public IActionResult CreateRestore()
        {
            return Content("Restore Database is Successfully Done!");
        }
    }
}

