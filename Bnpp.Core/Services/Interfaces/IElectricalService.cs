using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.Core.ViewModels;
using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.Electrical;

namespace Bnpp.Core.Services.Interfaces
{
    public interface IElectricalService
    {
        #region Cables

        List<CableListViewModel> GetAllCables();
        int AddCables(Cable cable);
        Cable GetCableById(int cableId);
        void UpdateCables(Cable cable);
        void DeleteCable(int cableId);

        #endregion

        #region Electromotors

        List<ElectromotorsListViewModel> GetAllElectromotos();
        int AddElectromotor(Electromotors electromotor);
        Electromotors GetElectromotorById(int electromotorId);
        void UpdateElectromotor(Electromotors electromotor);
        void DeleteElectromotor(int electromotorId);

        #endregion

        #region Generator

        List<GeneratorListViewModel> GetAllGenerators();
        int AddGenerator(Generator generator);
        Generator GetGeneratorById(int generatorId);
        void UpdateGenerator(Generator generator);
        void DeleteGenerator(int generatorId);

        #endregion

        #region Transformer

        List<TransformerListViewModel> GetAllTransformers();
        int AddTransformer(Transformer transformer);
        Transformer GetTransformerById(int transformerId);
        void UpdateTransformer(Transformer transformer);
        void DeleteTransformer(int transformerId);

        #endregion

        #region Valves

        List<ValvesListViewModel> GetAllValves();
        int AddValve(ElectroValve valve);
        ElectroValve GetValveById(int valveId);
        void UpdateValve(ElectroValve valve);
        void DeleteValve(int valveId);

        #endregion

        #region Diesel

        List<DieselListViewModel> GetAllDiesels();
        int AddDiesel(Dieselgenerator diesel);
        Dieselgenerator GetDieselById(int dieselId);
        void UpdateDiesel(Dieselgenerator diesel);
        void DeleteDiesel(int dieselId);

        #endregion
    }
}
