using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.Services.Interfaces;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Context;
using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.Electrical;

namespace Bnpp.Core.Services
{
    public class ElectricalService : IElectricalService
    {
        private BnppContext _context;

        public ElectricalService(BnppContext context)
        {
            _context = context;
        }

        #region Cables

        public List<CableListViewModel> GetAllCables()
        {
            return _context.Cables.Where(e => e.IsDelete == false).
                Select(e => new CableListViewModel()
                {
                    CableId = e.CableId,
                    Name = e.Name,
                    Azk = e.Azk,
                    InstalationPosition = e.Position,
                    CreateDate = e.CreateDate
                }).ToList();
        }

        public int AddCables(Cable cable)
        {
            _context.Add(cable);
            _context.SaveChanges();
            return cable.CableId;
        }

        public Cable GetCableById(int cableId)
        {
            return _context.Cables.Find(cableId);
        }

        public void UpdateCables(Cable cable)
        {
            cable.CreateDate = DateTime.Now;
            _context.Cables.Update(cable);
            _context.SaveChanges();
        }

        public void DeleteCable(int cableId)
        {
            var cable = GetCableById(cableId);
            cable.IsDelete = true;
            UpdateCables(cable);
        }

        #endregion

        #region Electromotors

        public List<ElectromotorsListViewModel> GetAllElectromotos()
        {
            return _context.Electromotors.Where(e => e.IsDelete == false).
                Select(e => new ElectromotorsListViewModel()
                {
                    electromotorId = e.ElectromotorId,
                    Name = e.Name,
                    Azk = e.Azk,
                    InstalationPosition = e.Position,
                    CreateDate = e.CreateDate
                }).ToList();
        }

        public int AddElectromotor(Electromotors electromotor)
        {
            _context.Add(electromotor);
            _context.SaveChanges();
            return electromotor.ElectromotorId;
        }

        public Electromotors GetElectromotorById(int electromotorId)
        {
            return _context.Electromotors.Find(electromotorId);
        }

        public void UpdateElectromotor(Electromotors electromotor)
        {
            electromotor.CreateDate = DateTime.Now;
            _context.Update(electromotor);
            _context.SaveChanges();
        }

        public void DeleteElectromotor(int electromotorId)
        {
            var electromotor = GetElectromotorById(electromotorId);
            electromotor.IsDelete = true;
            UpdateElectromotor(electromotor);
        }

        #endregion

        #region Generators

        public List<GeneratorListViewModel> GetAllGenerators()
        {
            return _context.Generators.Where(e => e.IsDelete == false).
                Select(e => new GeneratorListViewModel()
                {
                    generatorId = e.GeneratorId,
                    Name = e.Name,
                    Azk = e.Azk,
                    InstalationPosition = e.Position,
                    CreateDate = e.CreateDate
                }).ToList();
        }

        public int AddGenerator(Generator generator)
        {
            _context.Add(generator);
            _context.SaveChanges();
            return generator.GeneratorId;
        }

        public Generator GetGeneratorById(int generatorId)
        {
            return _context.Generators.Find(generatorId);
        }

        public void UpdateGenerator(Generator generator)
        {
            generator.CreateDate = DateTime.Now;
            _context.Update(generator);
            _context.SaveChanges();
        }

        public void DeleteGenerator(int generatorId)
        {
            var generator = GetGeneratorById(generatorId);
            generator.IsDelete = true;
            UpdateGenerator(generator);
        }

        #endregion

        #region Transformer

        public List<TransformerListViewModel> GetAllTransformers()
        {
            return _context.Transformers.Where(e => e.IsDelete == false).
                Select(e => new TransformerListViewModel()
                {
                    transformerId = e.TransformerId,
                    Name = e.Name,
                    Azk = e.Azk,
                    InstalationPosition = e.Position,
                    CreateDate = e.CreateDate
                }).ToList();
        }

        public int AddTransformer(Transformer transformer)
        {
            _context.Add(transformer);
            _context.SaveChanges();
            return transformer.TransformerId;
        }

        public Transformer GetTransformerById(int transformerId)
        {
            return _context.Transformers.Find(transformerId);
        }

        public void UpdateTransformer(Transformer transformer)
        {
            transformer.CreateDate = DateTime.Now;
            _context.Update(transformer);
            _context.SaveChanges();
        }

        public void DeleteTransformer(int transformerId)
        {
            var transformer = GetTransformerById(transformerId);
            transformer.IsDelete = true;
            UpdateTransformer(transformer);
        }



        #endregion

        #region Valves

        public List<ValvesListViewModel> GetAllValves()
        {
            return _context.ElectroValves.Where(e => e.IsDelete == false).
                Select(e => new ValvesListViewModel()
                {
                    ValveId = e.ValveId,
                    Name = e.Name,
                    Azk = e.Azk,
                    InstalationPosition = e.Position,
                    CreateDate = e.CreateDate
                }).ToList();
        }

        public int AddValve(ElectroValve valve)
        {
            _context.Add(valve);
            _context.SaveChanges();
            return valve.ValveId;
        }

        public ElectroValve GetValveById(int valveId)
        {
            return _context.ElectroValves.Find(valveId);
        }

        public void UpdateValve(ElectroValve valve)
        {
            valve.CreateDate = DateTime.Now;
            _context.Update(valve);
            _context.SaveChanges();
        }

        public void DeleteValve(int valveId)
        {
            var valve = GetValveById(valveId);
            valve.IsDelete = true;
            UpdateValve(valve);
        }



        #endregion

        #region Diesel

        public List<DieselListViewModel> GetAllDiesels()
        {
            return _context.Dieselgenerators.Where(e => e.IsDelete == false).
                Select(e => new DieselListViewModel()
                {
                    DieselId = e.DieselgeneratorId,
                    Name = e.Name,
                    Azk = e.Azk,
                    InstalationPosition = e.Position,
                    CreateDate = e.CreateDate
                }).ToList();
        }

        public int AddDiesel(Dieselgenerator diesel)
        {
            _context.Add(diesel);
            _context.SaveChanges();
            return diesel.DieselgeneratorId;
        }

        public Dieselgenerator GetDieselById(int dieselId)
        {
            return _context.Dieselgenerators.Find(dieselId);
        }

        public void UpdateDiesel(Dieselgenerator diesel)
        {
            diesel.CreateDate = DateTime.Now;
            _context.Update(diesel);
            _context.SaveChanges();
        }

        public void DeleteDiesel(int dieselId)
        {
            var diesel = GetDieselById(dieselId);
            diesel.IsDelete = true;
            UpdateDiesel(diesel);
        }

        #endregion
    }
}
