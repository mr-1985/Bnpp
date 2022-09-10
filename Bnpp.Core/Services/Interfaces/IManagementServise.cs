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
        List<Methodology> GetAllMethodolgies();
        int AddMethodology(Methodology methodology,IFormFile imgMethodolgy);
        Methodology GetMethodolgyById(int methodologyId);
        void UpdateMethodolgy(Methodology methodology);
    }
}
