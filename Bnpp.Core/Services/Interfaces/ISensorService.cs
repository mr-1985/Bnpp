using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.OperationalDatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services.Interfaces
{
    public interface ISensorService
    {
        #region Sensor
        List<Operational> GetAllSensors();
        int AddSensor(Operational sensor);
        Operational GetSensorById(int sensorId);

        void UpdateSensor(Operational sensor);
        void DeleteSensor(int sensorId);
        #endregion
    }
}
