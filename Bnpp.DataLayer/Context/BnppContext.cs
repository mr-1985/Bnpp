using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bnpp.DataLayer.Entities;
using Bnpp.DataLayer.Entities.AgeingManagementDocuments;
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

        #region Electrical

        public DbSet<Cable> Cables { get; set; }
        public DbSet<Electromotors> Electromotors { get; set; }
        public DbSet<Generator> Generators { get; set; }
        public DbSet<Transformer> Transformers { get; set; }
        public DbSet<ElectroValve> ElectroValves { get; set; }
        public DbSet<Dieselgenerator> Dieselgenerators { get; set; }

        #endregion
        public DbSet<Strcture> Strctures { get; set; }
        public DbSet<OperationalData> OperationalData { get; set; }
        public DbSet<Occurance> Occurances { get; set; }
        public DbSet<DesignBasis> DesignBasis { get; set; }
        public DbSet<Methodology> Methodologies { get; set; }
        public DbSet<AgeingDocuments> AgeingDocuments { get; set; }
        public DbSet<ManagementReviews> ManagementReviews { get; set; }

        #region Basic Data

        public DbSet<GeneralData> GeneralData { get; set; }
        public DbSet<DesignData> DesignData { get; set; }
        public DbSet<DesignDocument> DesignDocuments { get; set; }
        

        #endregion
    }
}
