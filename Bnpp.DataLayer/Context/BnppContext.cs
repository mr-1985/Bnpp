﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.AgeingDocuments;
using Bnpp.DataLayer.Entities.AgeingManagementDocuments;
using Bnpp.DataLayer.Entities.AgeingMechanism;
using Bnpp.DataLayer.Entities.BasicData;
using Bnpp.DataLayer.Entities.Electrical;
using Microsoft.EntityFrameworkCore;

namespace Bnpp.DataLayer.Context
{
    public class BnppContext:DbContext
    {
        public BnppContext(DbContextOptions<BnppContext> options) : base(options)
        {

        }

        #region User

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        #endregion
        public DbSet<MechanicalEquipment> MechanicalEquipments { get; set; }
        public DbSet<Strcture> Strctures { get; set; }
        #region Electrical

        public DbSet<Cable> Cables { get; set; }
        public DbSet<Electromotors> Electromotors { get; set; }
        public DbSet<Generator> Generators { get; set; }
        public DbSet<Transformer> Transformers { get; set; }
        public DbSet<ElectroValve> ElectroValves { get; set; }
        public DbSet<Dieselgenerator> Dieselgenerators { get; set; }

        #endregion
        
        #region Transient

        public DbSet<OperationalData> OperationalData { get; set; }
        public DbSet<Occurance> Occurances { get; set; }
        public DbSet<DesignBasis> DesignBasis { get; set; }

        #endregion

        #region  Ageing Management

        public DbSet<Methodology> Methodologies { get; set; }
        public DbSet<AgeingDocuments> AgeingDocuments { get; set; }
        public DbSet<ManagementReviews> ManagementReviews { get; set; }

            #endregion
       
        #region Basic Data

        public DbSet<GeneralData> GeneralData { get; set; }
        public DbSet<DesignData> DesignData { get; set; }
        public DbSet<DesignDocument> DesignDocuments { get; set; }
        public DbSet<ChemicalNorms> ChemicalNorms { get; set; }
        public DbSet<InspectionProgram> InspectionPrograms { get; set; }
        public DbSet<Sensors> Sensors { get; set; }
        public DbSet<ControlPoints> ControlPoints { get; set; }
        public DbSet<HForms> HForms { get; set; }


        #endregion

        #region Ageing Document

        public DbSet<OperationalDocuments> OperationalDocuments { get; set; }
        public DbSet<Drawing> Drawing { get; set; }
        public DbSet<Standard> Standard { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Installation> Installation { get; set; }
        public DbSet<MaintenanceDocument> MaintenanceDocument { get; set; }
        public DbSet<Ageing> Ageing { get; set; }

        #endregion

        #region Mechanism

        public DbSet<Mechanism> Mechanism { get; set; }
        public DbSet<MechanismDocuments> MechanismDocuments { get; set; }

        #endregion
    }
}
