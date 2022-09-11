using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.DataLayer.Entities.AgeingManagementDocuments;
using Microsoft.AspNetCore.Http;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IManagementServise
    {
        #region Methodology

        List<Methodology> GetAllMethodolgies();
        int AddMethodology(Methodology methodology,IFormFile imgMethodolgy);
        Methodology GetMethodolgyById(int methodologyId);
        void UpdateMethodolgy(Methodology methodology, IFormFile imgMethodolgy);
        void DeleteMethodolgy(int methodologyId);


        #endregion

        #region AgeingDocuments

        List<AgeingDocuments> GetAllAgeingDocuments();
        int AddAgeingDocuments(AgeingDocuments documents, IFormFile imgAgeingDocuments);
        AgeingDocuments GetAgeingDocumentsById(int documentId);
        void UpdateAgeingDocuments(AgeingDocuments documents, IFormFile imgAgeingDocuments);
        void DeleteimgAgeingDocuments(int documentId);

        #endregion

        #region Management Reviews
        List<ManagementReviews> GetAllManagementReviews();
        int AddManagementReviews(ManagementReviews reviews);
        ManagementReviews GetManagementReviewsById(int reviewsId);
        void UpdateManagementReviews(ManagementReviews reviews);
        void DeleteManagementReviews(int reviewsId);

        #endregion
    }
}
