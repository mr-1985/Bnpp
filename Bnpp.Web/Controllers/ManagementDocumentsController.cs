using System;
using System.Globalization;
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

            _management.UpdateMethodolgy(Methodologies, filemetholody);
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



        #region MyRegion

        [BindProperty]
        public AgeingDocuments Documents { get; set; }

        public IActionResult OtherDocuments()
        {
            return View(_management.GetAllAgeingDocuments());
        }

        public IActionResult CreateAgeingDocuments()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAgeingDocuments(IFormFile filedocument)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _management.AddAgeingDocuments(Documents, filedocument);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult EditAgeingDocuments(int id)
        {
            return View(_management.GetAgeingDocumentsById(id));
        }


        [HttpPost]
        public IActionResult EditAgeingDocuments(IFormFile filedocument)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _management.UpdateAgeingDocuments(Documents, filedocument);
            return Json(" Electormotors Successfully Deleted.");
        }

        public IActionResult DeleteDocuments(string[] documentId)
        {
            foreach (string id in documentId)
            {
                _management.DeleteimgAgeingDocuments(Convert.ToInt32(id));
            }

            return Json(" Equipments Successfully Deleted.");
        }

        #endregion


        #region ManagementReviews
        [BindProperty]
        public ManagementReviews Reviews { get; set; }

        public IActionResult ManagementReviews()
        {
            return View(_management.GetAllManagementReviews());
        }


        public IActionResult CreateManagementReviews()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateManagementReviews(string StartDates = "")
        {
            if (StartDates != "")
            {
                string[] std = StartDates.Split('/');
                Reviews.Date = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }


            _management.AddManagementReviews(Reviews);

            return new JsonResult("success");
        }

        public IActionResult EditManagementReviews(int id)
        {
            return View(_management.GetManagementReviewsById(id));
        }

        [HttpPost]
        public IActionResult EditManagementReviews(string StartDates = "")
        {
            if (StartDates != "")
            {
                string[] std = StartDates.Split('/');
                Reviews.Date = new DateTime(int.Parse(std[2]),
                    int.Parse(std[0]),
                    int.Parse(std[1]),
                    new GregorianCalendar()
                );
            }

            _management.UpdateManagementReviews(Reviews);
            return new JsonResult("success");
        }

        public IActionResult DeleteManagementReviews(string[] reviewsId)
        {
            foreach (string id in reviewsId)
            {
                _management.DeleteManagementReviews(Convert.ToInt32(id));
            }

            return Json(" Equipments Successfully Deleted.");
        }
        #endregion
    }
}
