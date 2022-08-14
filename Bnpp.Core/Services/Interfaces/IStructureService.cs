using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IStructureService
    {
        List<StructureListViewModel> GetAllStructures();
        int AddStructure(Strcture structure);
        Strcture GetStructureById(int structureId);
        void UpdateStructure(Strcture structure);
        void DeleteStructure(int structureId);
    }
}
