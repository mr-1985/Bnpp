using System;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Entities.AgeingManagementDocuments;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bnpp.Web.Controllers
{
    public class ManagementDocumentsController : Controller
    {
        private IManagementServise _management;

        public ManagementDocumentsController(IManagementServise management)
        {
            _management = management;
        }


        [Route("ManagementDocuments")]
        public IActionResult Index()
        {
            return View();
        }


        #region Methodology
        [BindProperty]
        public Methodology Methodologies { get; set; }

        public IActionResult Methodology()
        {
            return View(_management.GetAllMethodolgies());
        }

        public IActionResult CreateMethodology()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMethodology(IFormFile filemetholody)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _management.AddMethodology(Methodologies, filemetholody);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditMethodology(int id)
        {
            return View(_management.GetMethodolgyById(id));
        }

        [HttpPost]
        public IActionResult EditMethodology(IFormFile filemetholody)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _management.UpdateMethodolgy(Methodologies,filemetholody);
            return Json(" Electormotors Successfully Deleted."); 
        }

        public IActionResult DeleteMethodology(string[] methodolgyId)
        {
            foreach (string id in methodolgyId)
            {
                _management.DeleteMethodolgy(Convert.ToInt32(id));
            }

            return Json(" Equipments Successfully Deleted.");
        }

        #endregion



        public IActionResult OtherDocuments()
        {
            return View();
        }

         

        public IActionResult ManagementReviews()
        {
            return View();
        }
    }
}
