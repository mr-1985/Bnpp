using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.OperationalDatas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bnpp.Core.Services
{
    public class SensorService:ISensorService
    {
        private BnppContext _context;

        public SensorService(BnppContext context)
        {
            _context = context;
        }

        #region  Sensor

        public int AddSensor(Operational sensor)
        {
            sensor.CreateDate = DateTime.Now;
            sensor.TypeId = 1;
            _context.Add(sensor);
            _context.SaveChanges();
            return sensor.OperationalId;

            //Operational sensors = new Operational() {
            //    TypeId = 1,
            //    CreateDate = DateTime.Now,
            //    ParameterName=p
            //};
            //return sensors.OperationalId;
        }

        public void DeleteSensor(int sensorId)
        {
           var snsor=GetSensorById(sensorId);
            snsor.IsDelete = true;
            _context.Update(snsor);
            _context.SaveChanges();
        }

        public List<Operational> GetAllSensors()
        {
            return _context.Operationals.Where(o=>o.TypeId==1&&o.IsDelete==false).ToList();
        }

        public Operational GetSensorById(int sensorId)
        {
            return _context.Operationals.SingleOrDefault(s => s.OperationalId == sensorId && s.TypeId == 1);
        }

        public void UpdateSensor(Operational sensor)
        {
            sensor.CreateDate=DateTime.Now;
            _context.Update(sensor);
            _context.SaveChanges();
        }

        #endregion
    }
}
