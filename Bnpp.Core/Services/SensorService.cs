using Bnpp.Core.Services.Interfaces;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities.BasicData;
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

        #region Chemical Water
        public List<Operational> GetAllChemicalWater()
        {
            return _context.Operationals.Where(o => o.TypeId == 2 && o.IsDelete == false).ToList();
        }

        public int AddChemicalWater(Operational water)
        {
            water.CreateDate = DateTime.Now;
            water.TypeId = 2;
            _context.Add(water);
            _context.SaveChanges();
            return water.OperationalId;
        }

        public void UpdateChemicalWater(Operational water)
        {
            water.CreateDate = DateTime.Now;
            _context.Update(water);
            _context.SaveChanges();
        }
        public Operational GetChemicalWaterById(int waterId)
        {
            return _context.Operationals.SingleOrDefault(s => s.OperationalId == waterId && s.TypeId == 2);
        }
        public void DeleteChemicalWater(int waterId)
        {
            var wter = GetSensorById(waterId);
            wter.IsDelete = true;
            _context.Update(wter);
            _context.SaveChanges();
        }


        #endregion

        #region Environmental

        public List<Operational> GetAllEnvironmental()
        {
            return _context.Operationals.Where(o => o.TypeId == 3 && o.IsDelete == false).ToList();
        }

        public int AddEnvironmental(Operational environmental)
        {
            environmental.CreateDate = DateTime.Now;
            environmental.TypeId = 3;
            _context.Add(environmental);
            _context.SaveChanges();
            return environmental.OperationalId;
        }

        public Operational GetEnvironmentalById(int environmentalId)
        {
            return _context.Operationals.SingleOrDefault(s => s.OperationalId == environmentalId && s.TypeId == 3);
        }

        public void UpdateEnvironmental(Operational environmental)
        {
            environmental.CreateDate = DateTime.Now;
            _context.Update(environmental);
            _context.SaveChanges();
        }

        public void DeleteEnvironmental(int environmentalId)
        {
            var environ = GetSensorById(environmentalId);
            environ.IsDelete = true;
            _context.Update(environ);
            _context.SaveChanges();
        }

        #endregion


    }
}
