using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.DataLayer.Entities.AgeingDocuments;
using Bnpp.DataLayer.Entities.BasicData;
using Microsoft.AspNetCore.Http;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IDocumentService
    {
        #region  Ageing Document

        List<OperationalDocuments> GetAllOperationalDocuments();
        int AddOperationalDocuments(OperationalDocuments operational, IFormFile imgoperational);
        OperationalDocuments GetOperationalDocumentsById(int operationalId);
        void UpdateOperationalDocuments(OperationalDocuments operational, IFormFile imgoperational);
        void DeleteOperationalDocuments(int operationalId);

        #endregion

        #region Drawing

        List<Drawing> GetAllDrawing();
        int AddDrawing(Drawing drawing, IFormFile imgDrawing);
        Drawing GetDrawingById(int drawingId);
        void UpdateDrawing(Drawing drawing, IFormFile imgDrawing);
        void DeleteDrawing(int drawingId);

        #endregion

        #region Standard

        List<Standard> GetAllStandard();
        int AddStandard(Standard standard, IFormFile imgStandard);
        Standard GetimgStandardById(int standardId);
        void UpdateimgStandard(Standard standard, IFormFile imgStandard);
        void DeleteimgStandard(int standardId);

        #endregion

        #region Manufacturer

        List<Manufacturer> GetAllManufacturer();
        int AddManufacturer(Manufacturer manufacturer, IFormFile imgManufacturer);
        Manufacturer GetManufacturerById(int manufacturerId);
        void UpdateManufacturer(Manufacturer manufacturer, IFormFile imgManufacturer);
        void DeleteManufacturer(int manufacturerId);

        #endregion
    }
}
