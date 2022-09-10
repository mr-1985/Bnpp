using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.Convertors;
using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.AgeingManagementDocuments;
using Microsoft.AspNetCore.Http;

namespace Bnpp.Core.Services
{
    public class ManagementServise:IManagementServise
    {
        private BnppContext _context;

        public ManagementServise(BnppContext context)
        {
            _context = context;
        }


        public List<Methodology> GetAllMethodolgies()
        {
            throw new NotImplementedException();
        }

        public int AddMethodology(Methodology methodology, IFormFile imgMethodolgy)
        {
            methodology.CreateDate=DateTime.Now;

            if (imgMethodolgy != null )
            {
                methodology.MethodologyImage = Guid.NewGuid() + Path.GetExtension(imgMethodolgy.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/DocumentImage", methodology.MethodologyImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgMethodolgy.CopyTo(stream);
                }
            }

            _context.Add(methodology);
            _context.SaveChanges();
            return methodology.MethodologyId;
        }

        public Methodology GetMethodolgyById(int methodologyId)
        {
            throw new NotImplementedException();
        }

        public void UpdateMethodolgy(Methodology methodology)
        {
            throw new NotImplementedException();
        }
    }
}
