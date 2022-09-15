using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.DataLayer.Entities.AgeingMechanism;


namespace Bnpp.Core.Services.Interfaces
{
    public interface IMechanismService
    {
        List<Mechanism> GetAllMechanism();

        int AddMechanism(Mechanism mechanism);

        void UpdateMechanism(Mechanism mechanism);
        Mechanism GetMechanismById(int mechanismId);

        void DeleteMechanism(int mechanismId);
    }
}
