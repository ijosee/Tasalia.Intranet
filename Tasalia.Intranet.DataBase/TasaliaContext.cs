using Microsoft.EntityFrameworkCore;

namespace Tasalia.Intranet.DataBase.Models
{
    public partial class TasaliaContext : DbContext
    {
        public TasaliaContext()
        {
        }

        public TasaliaContext(DbContextOptions<TasaliaContext> options)
            : base(options)
        {
        }

        #region DB Sets
        public virtual DbSet<AppendantInfo> AppendantInfo { get; set; }
        public virtual DbSet<AppendantType> AppendantType { get; set; }
        public virtual DbSet<Appraisal> Appraisal { get; set; }
        public virtual DbSet<AppraisalAcronym> AppraisalAcronym { get; set; }
        public virtual DbSet<AppraisalInfo> AppraisalInfo { get; set; }
        public virtual DbSet<Appraiser> Appraiser { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<ConditionerAppraisalType> ConditionerAppraisalType { get; set; }
        public virtual DbSet<ConditioningAppraisal> ConditioningAppraisal { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Currency> Currency { get; set; }
        public virtual DbSet<DataType> DataType { get; set; }
        public virtual DbSet<Deputation> Deputation { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Entity> Entity { get; set; }
        public virtual DbSet<EntityBranch> EntityBranch { get; set; }
        public virtual DbSet<EstateType> EstateType { get; set; }
        public virtual DbSet<FileType> FileType { get; set; }
        public virtual DbSet<Goal> Goal { get; set; }
        public virtual DbSet<HeatingType> HeatingType { get; set; }
        public virtual DbSet<HouseZone> HouseZone { get; set; }
        public virtual DbSet<LocationQuality> LocationQuality { get; set; }
        public virtual DbSet<MakingQuality> MakingQuality { get; set; }
        public virtual DbSet<MaterialAppraisal> MaterialAppraisal { get; set; }
        public virtual DbSet<MaterialType> MaterialType { get; set; }
        public virtual DbSet<OccupantType> OccupantType { get; set; }
        public virtual DbSet<PostalZone> PostalZone { get; set; }
        public virtual DbSet<Process> Process { get; set; }
        public virtual DbSet<Property> Property { get; set; }
        public virtual DbSet<PropertyInfo> PropertyInfo { get; set; }
        public virtual DbSet<Raw> Raw { get; set; }
        public virtual DbSet<RawProcessErrorLog> RawProcessErrorLog { get; set; }
        public virtual DbSet<Registry> Registry { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<StayType> StayType { get; set; }
        public virtual DbSet<StreetType> StreetType { get; set; }
        public virtual DbSet<UseState> UseState { get; set; }
        public virtual DbSet<UseType> UseType { get; set; }
        public virtual DbSet<Visited> Visited { get; set; }
        public virtual DbSet<WarningAppraisal> WarningAppraisal { get; set; }
        public virtual DbSet<WarningAppraisalType> WarningAppraisalType { get; set; }
        public virtual DbSet<Zone> Zone { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=Tasalia;Trusted_Connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AppendantInfo>(entity =>
            {
                entity.HasIndex(e => e.AppraisalInfoId);

                entity.HasIndex(e => e.PropertyId);

                entity.Property(e => e.AppendantInfoId).HasColumnName("AppendantInfoID");

                entity.Property(e => e.AdoptedArea).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Allocation).HasMaxLength(500);

                entity.Property(e => e.AppendantTypeId).HasColumnName("AppendantTypeID");

                entity.Property(e => e.AppliedPercentage).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.AppraisalInfoId).HasColumnName("AppraisalInfoID");

                entity.Property(e => e.AreaRepercussionPrice).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.BuiltPrivativeSurface).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.CatastralReference).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrentReplacementCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Depth).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Estate).HasMaxLength(10);

                entity.Property(e => e.EstateSurface).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.EstateTypeId).HasColumnName("EstateTypeID");

                entity.Property(e => e.FacadePr)
                    .HasColumnName("Facade_pr")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.FacadeSe)
                    .HasColumnName("Facade_se")
                    .HasColumnType("decimal(9, 2)");

                entity.Property(e => e.FinalReplacementCost).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FreeHeight).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.FreeLight).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.GroupValue).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.HeatingTypeId).HasColumnName("HeatingTypeID");

                entity.Property(e => e.LocationQualityId).HasColumnName("LocationQualityID");

                entity.Property(e => e.M2price)
                    .HasColumnName("M2Price")
                    .HasColumnType("decimal(7, 2)");

                entity.Property(e => e.MakingQualityId).HasColumnName("MakingQualityID");

                entity.Property(e => e.MarketValue).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Name).HasMaxLength(150);

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.TechnicalEstimation).HasColumnType("decimal(12, 2)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UseStateId).HasColumnName("UseStateID");

                entity.Property(e => e.UseTypeId).HasColumnName("UseTypeID");

                entity.Property(e => e.UsefullSurface).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ZcvuiltSurface)
                    .HasColumnName("ZCVuiltSurface")
                    .HasColumnType("decimal(9, 2)");

                entity.HasOne(d => d.AppendantType)
                    .WithMany(p => p.AppendantInfo)
                    .HasForeignKey(d => d.AppendantTypeId)
                    .HasConstraintName("FK_AppendantInfo_AppendantType");

                entity.HasOne(d => d.EstateType)
                    .WithMany(p => p.AppendantInfo)
                    .HasForeignKey(d => d.EstateTypeId)
                    .HasConstraintName("FK_AppendantInfo_EstateType");

                entity.HasOne(d => d.HeatingType)
                    .WithMany(p => p.AppendantInfo)
                    .HasForeignKey(d => d.HeatingTypeId)
                    .HasConstraintName("FK_AppendantInfo_HeatingType");

                entity.HasOne(d => d.LocationQuality)
                    .WithMany(p => p.AppendantInfo)
                    .HasForeignKey(d => d.LocationQualityId)
                    .HasConstraintName("FK_AppendantInfo_LocationQuality");

                entity.HasOne(d => d.MakingQuality)
                    .WithMany(p => p.AppendantInfo)
                    .HasForeignKey(d => d.MakingQualityId)
                    .HasConstraintName("FK_AppendantInfo_MakingQuality");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.AppendantInfo)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppendantInfo_Property");

                entity.HasOne(d => d.UseState)
                    .WithMany(p => p.AppendantInfo)
                    .HasForeignKey(d => d.UseStateId)
                    .HasConstraintName("FK_AppendantInfo_UseState");

                entity.HasOne(d => d.UseType)
                    .WithMany(p => p.AppendantInfo)
                    .HasForeignKey(d => d.UseTypeId)
                    .HasConstraintName("FK_AppendantInfo_UseType");
            });

            modelBuilder.Entity<AppendantType>(entity =>
            {
                entity.HasIndex(e => e.Code);

                entity.Property(e => e.AppendantTypeId).HasColumnName("AppendantTypeID");

                entity.Property(e => e.AppendantType1)
                    .HasColumnName("AppendantType")
                    .HasMaxLength(150);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Appraisal>(entity =>
            {
                entity.HasIndex(e => e.PropertyId);

                entity.HasIndex(e => new { e.Number, e.Supplement })
                    .HasName("IX_Appraisal_NumberSuplement")
                    .IsUnique();

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DeputationId).HasColumnName("DeputationID");

                entity.Property(e => e.Number).HasMaxLength(6);

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.Supplement).HasMaxLength(2);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Deputation)
                    .WithMany(p => p.Appraisal)
                    .HasForeignKey(d => d.DeputationId)
                    .HasConstraintName("FK_Appraisal_Deputation");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.Appraisal)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appraisal_Property");
            });

            modelBuilder.Entity<AppraisalAcronym>(entity =>
            {
                entity.Property(e => e.AppraisalAcronymId)
                    .HasColumnName("AppraisalAcronymID")
                    .HasMaxLength(3)
                    .ValueGeneratedNever();

                entity.Property(e => e.AppraisalAcronym1)
                    .HasColumnName("AppraisalAcronym")
                    .HasMaxLength(25);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppraisalInfo>(entity =>
            {
                entity.HasIndex(e => e.AppraisalId);

                entity.Property(e => e.AppraisalInfoId).HasColumnName("AppraisalInfoID");

                entity.Property(e => e.AppraisalDate).HasColumnType("datetime");

                entity.Property(e => e.AppraisalId).HasColumnName("AppraisalID");

                entity.Property(e => e.AppraisalValue).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.AppraiserId).HasColumnName("AppraiserID");

                entity.Property(e => e.ChargeAmount).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CurrentReform).HasMaxLength(4000);

                entity.Property(e => e.CurrentState).HasMaxLength(4000);

                entity.Property(e => e.EntityBranchId).HasColumnName("EntityBranchID");

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.GoalId).HasColumnName("GoalID");

                entity.Property(e => e.Lifts).HasMaxLength(150);

                entity.Property(e => e.OccupantTypeId).HasColumnName("OccupantTypeID");

                entity.Property(e => e.Petitioner).HasMaxLength(500);

                entity.Property(e => e.PetitionerId)
                    .HasColumnName("PetitionerID")
                    .HasMaxLength(12);

                entity.Property(e => e.RegistryId).HasColumnName("RegistryID");

                entity.Property(e => e.StayTypeId).HasColumnName("StayTypeID");

                entity.Property(e => e.SureValue).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.VisitedDate).HasColumnType("datetime");

                entity.Property(e => e.VisitedId).HasColumnName("VisitedID");

                entity.Property(e => e.VpoValue).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.Appraisal)
                    .WithMany(p => p.AppraisalInfo)
                    .HasForeignKey(d => d.AppraisalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppraisalInfo_Appraisal");

                entity.HasOne(d => d.Appraiser)
                    .WithMany(p => p.AppraisalInfo)
                    .HasForeignKey(d => d.AppraiserId)
                    .HasConstraintName("FK_AppraisalInfo_Appraiser");

                entity.HasOne(d => d.Currency)
                    .WithMany(p => p.AppraisalInfo)
                    .HasForeignKey(d => d.CurrencyId)
                    .HasConstraintName("FK_AppraisalInfo_Currency");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.AppraisalInfo)
                    .HasForeignKey(d => d.EntityId)
                    .HasConstraintName("FK_AppraisalInfo_Entity");

                entity.HasOne(d => d.Goal)
                    .WithMany(p => p.AppraisalInfo)
                    .HasForeignKey(d => d.GoalId)
                    .HasConstraintName("FK_AppraisalInfo_Goal");

                entity.HasOne(d => d.OccupantType)
                    .WithMany(p => p.AppraisalInfo)
                    .HasForeignKey(d => d.OccupantTypeId)
                    .HasConstraintName("FK_AppraisalInfo_OccupantType");

                entity.HasOne(d => d.Registry)
                    .WithMany(p => p.AppraisalInfo)
                    .HasForeignKey(d => d.RegistryId)
                    .HasConstraintName("FK_AppraisalInfo_Registry");

                entity.HasOne(d => d.StayType)
                    .WithMany(p => p.AppraisalInfo)
                    .HasForeignKey(d => d.StayTypeId)
                    .HasConstraintName("FK_AppraisalInfo_StayType");

                entity.HasOne(d => d.Visited)
                    .WithMany(p => p.AppraisalInfo)
                    .HasForeignKey(d => d.VisitedId)
                    .HasConstraintName("FK_AppraisalInfo_Visited");
            });

            modelBuilder.Entity<Appraiser>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .IsUnique();

                entity.Property(e => e.AppraiserId).HasColumnName("AppraiserID");

                entity.Property(e => e.Code).HasMaxLength(5);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasIndex(e => e.CityId)
                    .IsUnique();

                entity.HasIndex(e => new { e.Code, e.StateId })
                    .HasName("IX_City_CodeStateID")
                    .IsUnique();

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.City1)
                    .HasColumnName("City")
                    .HasMaxLength(250);

                entity.Property(e => e.Code).HasMaxLength(6);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_City_State");
            });

            modelBuilder.Entity<ConditionerAppraisalType>(entity =>
            {
                entity.Property(e => e.ConditionerAppraisalTypeId).HasColumnName("ConditionerAppraisalTypeID");

                entity.Property(e => e.ConditionerAppraisalType1)
                    .IsRequired()
                    .HasColumnName("ConditionerAppraisalType")
                    .HasMaxLength(150);

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<ConditioningAppraisal>(entity =>
            {
                entity.HasKey(e => e.ConditionerAppraisalId)
                    .HasName("PK__Conditio__B88712055E27F577");

                entity.Property(e => e.ConditionerAppraisalId).HasColumnName("ConditionerAppraisalID");

                entity.Property(e => e.AppraisalInfoId).HasColumnName("AppraisalInfoID");

                entity.Property(e => e.ConditionerAppraisal)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ConditionerAppraisalTypeId).HasColumnName("ConditionerAppraisalTypeID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.AppraisalInfo)
                    .WithMany(p => p.ConditioningAppraisal)
                    .HasForeignKey(d => d.AppraisalInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConditioningAppraisal_AppraisalInfo");

                entity.HasOne(d => d.ConditionerAppraisalType)
                    .WithMany(p => p.ConditioningAppraisal)
                    .HasForeignKey(d => d.ConditionerAppraisalTypeId)
                    .HasConstraintName("FK_ConditioningAppraisal_ConditionerAppraisalType");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasIndex(e => e.Country1)
                    .IsUnique();

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Country1)
                    .HasColumnName("Country")
                    .HasMaxLength(250);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasIndex(e => e.Currency1);

                entity.Property(e => e.CurrencyId).HasColumnName("CurrencyID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Currency1)
                    .IsRequired()
                    .HasColumnName("Currency")
                    .HasMaxLength(25);

                entity.Property(e => e.Symbol)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<DataType>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .IsUnique();

                entity.Property(e => e.DataTypeId).HasColumnName("DataTypeID");

                entity.Property(e => e.Code).HasMaxLength(5);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DataType1)
                    .HasColumnName("DataType")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Deputation>(entity =>
            {
                entity.HasIndex(e => e.Deputation1);

                entity.Property(e => e.DeputationId).HasColumnName("DeputationID");

                entity.Property(e => e.Code).HasMaxLength(2);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deputation1)
                    .HasColumnName("Deputation")
                    .HasMaxLength(100);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.HasIndex(e => e.District1)
                    .IsUnique();

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.District1)
                    .HasColumnName("District")
                    .HasMaxLength(150);

                entity.Property(e => e.UpdateDate).HasColumnType("date");
            });

            modelBuilder.Entity<Entity>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .IsUnique();

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.Code).HasMaxLength(4);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Entity1)
                    .IsRequired()
                    .HasColumnName("Entity")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EntityBranch>(entity =>
            {
                entity.Property(e => e.EntityBranchId).HasColumnName("EntityBranchID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EntityBranch1)
                    .HasColumnName("EntityBranch")
                    .HasMaxLength(250);

                entity.Property(e => e.EntityId).HasColumnName("EntityID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.EntityBranch)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EntityBranch_Entity");
            });

            modelBuilder.Entity<EstateType>(entity =>
            {
                entity.HasIndex(e => e.EstateType1)
                    .IsUnique();

                entity.Property(e => e.EstateTypeId).HasColumnName("EstateTypeID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EstateType1)
                    .IsRequired()
                    .HasColumnName("EstateType")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FileType>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .IsUnique();

                entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");

                entity.Property(e => e.Code).HasMaxLength(2);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileType1)
                    .HasColumnName("FileType")
                    .HasMaxLength(25);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Goal>(entity =>
            {
                entity.HasIndex(e => e.Goal1);

                entity.Property(e => e.GoalId).HasColumnName("GoalID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Goal1)
                    .IsRequired()
                    .HasColumnName("Goal")
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HeatingType>(entity =>
            {
                entity.HasIndex(e => e.HeatingType1);

                entity.Property(e => e.HeatingTypeId).HasColumnName("HeatingTypeID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HeatingType1)
                    .IsRequired()
                    .HasColumnName("HeatingType")
                    .HasMaxLength(150);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<HouseZone>(entity =>
            {
                entity.HasIndex(e => e.HouseZone1);

                entity.Property(e => e.HouseZoneId).HasColumnName("HouseZoneID");

                entity.Property(e => e.HouseZone1)
                    .HasColumnName("HouseZone")
                    .HasMaxLength(50);

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<LocationQuality>(entity =>
            {
                entity.HasIndex(e => e.LocationQuality1)
                    .HasName("NonClusteredIndex-20181028-112743");

                entity.Property(e => e.LocationQualityId).HasColumnName("LocationQualityID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LocationQuality1)
                    .IsRequired()
                    .HasColumnName("LocationQuality")
                    .HasMaxLength(150);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MakingQuality>(entity =>
            {
                entity.HasIndex(e => e.MakingQuality1);

                entity.Property(e => e.MakingQualityId).HasColumnName("MakingQualityID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MakingQuality1)
                    .HasColumnName("MakingQuality")
                    .HasMaxLength(150);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MaterialAppraisal>(entity =>
            {
                entity.HasIndex(e => e.AppraisalInfoId)
                    .HasName("IX_MaterialAppraisal_AppraisalID");

                entity.Property(e => e.MaterialAppraisalId).HasColumnName("MaterialAppraisalID");

                entity.Property(e => e.AppraisalInfoId).HasColumnName("AppraisalInfoID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.HouseZoneId).HasColumnName("HouseZoneID");

                entity.Property(e => e.MaterialAppraisal1)
                    .IsRequired()
                    .HasColumnName("MaterialAppraisal")
                    .HasMaxLength(250);

                entity.Property(e => e.MaterialTypeId).HasColumnName("MaterialTypeID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.AppraisalInfo)
                    .WithMany(p => p.MaterialAppraisal)
                    .HasForeignKey(d => d.AppraisalInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialAppraisal_AppendantInfo");

                entity.HasOne(d => d.HouseZone)
                    .WithMany(p => p.MaterialAppraisal)
                    .HasForeignKey(d => d.HouseZoneId)
                    .HasConstraintName("FK_MaterialAppraisal_HouseZone");

                entity.HasOne(d => d.MaterialType)
                    .WithMany(p => p.MaterialAppraisal)
                    .HasForeignKey(d => d.MaterialTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialAppraisal_MaterialType");
            });

            modelBuilder.Entity<MaterialType>(entity =>
            {
                entity.Property(e => e.MaterialTypeId).HasColumnName("MaterialTypeID");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OccupantType>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .IsUnique();

                entity.Property(e => e.OccupantTypeId).HasColumnName("OccupantTypeID");

                entity.Property(e => e.Code).HasMaxLength(25);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OccupantType1)
                    .IsRequired()
                    .HasColumnName("OccupantType")
                    .HasMaxLength(150);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<PostalZone>(entity =>
            {
                entity.Property(e => e.PostalZoneId).HasColumnName("PostalZoneID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PostalZone1)
                    .HasColumnName("PostalZone")
                    .HasMaxLength(500);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ZipCode).HasMaxLength(5);
            });

            modelBuilder.Entity<Process>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PK__Process__A2B5777C4EAD54FB");

                entity.Property(e => e.Guid).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<Property>(entity =>
            {
                entity.HasIndex(e => e.ExternalId)
                    .IsUnique();

                entity.HasIndex(e => e.PropertyId)
                    .IsUnique();

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExternalId)
                    .HasColumnName("ExternalID")
                    .HasMaxLength(10);

                entity.Property(e => e.FileTypeId).HasColumnName("FileTypeID");

                entity.Property(e => e.Latitude).HasColumnType("decimal(16, 13)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(16, 13)");

                entity.Property(e => e.PostalZoneId).HasColumnName("PostalZoneID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Year).HasMaxLength(4);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Property)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Property_City");

                entity.HasOne(d => d.FileType)
                    .WithMany(p => p.Property)
                    .HasForeignKey(d => d.FileTypeId)
                    .HasConstraintName("FK_Property_FileType");

                entity.HasOne(d => d.PostalZone)
                    .WithMany(p => p.Property)
                    .HasForeignKey(d => d.PostalZoneId)
                    .HasConstraintName("FK_Property_PostalZone");
            });

            modelBuilder.Entity<PropertyInfo>(entity =>
            {
                entity.HasIndex(e => e.AppraisalInfoId);

                entity.HasIndex(e => e.PropertyId);

                entity.Property(e => e.PropertyInfoId).HasColumnName("PropertyInfoID");

                entity.Property(e => e.AppraisalInfoId).HasColumnName("AppraisalInfoID");

                entity.Property(e => e.BuildingCatastralReference).HasMaxLength(50);

                entity.Property(e => e.CatastroNavarra).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Data1).HasMaxLength(150);

                entity.Property(e => e.Data2).HasMaxLength(150);

                entity.Property(e => e.Data3).HasMaxLength(150);

                entity.Property(e => e.Data4).HasMaxLength(150);

                entity.Property(e => e.DataType1Id).HasColumnName("DataType1ID");

                entity.Property(e => e.DataType2Id).HasColumnName("DataType2ID");

                entity.Property(e => e.DataType3Id).HasColumnName("DataType3ID");

                entity.Property(e => e.DataType4Id).HasColumnName("DataType4ID");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.PropertyId).HasColumnName("PropertyID");

                entity.Property(e => e.Street).HasMaxLength(500);

                entity.Property(e => e.StreetTypeId).HasColumnName("StreetTypeID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.HasOne(d => d.AppraisalInfo)
                    .WithMany(p => p.PropertyInfo)
                    .HasForeignKey(d => d.AppraisalInfoId)
                    .HasConstraintName("FK_PropertyInfo_AppraisalInfo");

                entity.HasOne(d => d.DataType1)
                    .WithMany(p => p.PropertyInfoDataType1)
                    .HasForeignKey(d => d.DataType1Id)
                    .HasConstraintName("FK_PropertyInfo_DataType1");

                entity.HasOne(d => d.DataType2)
                    .WithMany(p => p.PropertyInfoDataType2)
                    .HasForeignKey(d => d.DataType2Id)
                    .HasConstraintName("FK_PropertyInfo_DataType2");

                entity.HasOne(d => d.DataType3)
                    .WithMany(p => p.PropertyInfoDataType3)
                    .HasForeignKey(d => d.DataType3Id)
                    .HasConstraintName("FK_PropertyInfo_DataType3");

                entity.HasOne(d => d.DataType4)
                    .WithMany(p => p.PropertyInfoDataType4)
                    .HasForeignKey(d => d.DataType4Id)
                    .HasConstraintName("FK_PropertyInfo_DataType4");

                entity.HasOne(d => d.District)
                    .WithMany(p => p.PropertyInfo)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_PropertyInfo_District");

                entity.HasOne(d => d.Property)
                    .WithMany(p => p.PropertyInfo)
                    .HasForeignKey(d => d.PropertyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PropertyInfo_Property");

                entity.HasOne(d => d.StreetType)
                    .WithMany(p => p.PropertyInfo)
                    .HasForeignKey(d => d.StreetTypeId)
                    .HasConstraintName("FK_PropertyInfo_StreetType");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.PropertyInfo)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("FK_PropertyInfo_Zone");
            });

            modelBuilder.Entity<Raw>(entity =>
            {
                entity.Property(e => e.RawId).HasColumnName("RawID");

                entity.Property(e => e.Acogidonor).HasMaxLength(2);

                entity.Property(e => e.Advertencias).HasMaxLength(1000);

                entity.Property(e => e.Agno).HasMaxLength(4);

                entity.Property(e => e.AgnoReform)
                    .HasColumnName("Agno_reform")
                    .HasMaxLength(25);

                entity.Property(e => e.AgnoReforma)
                    .HasColumnName("Agno_reforma")
                    .HasMaxLength(25);

                entity.Property(e => e.Altitud).HasMaxLength(14);

                entity.Property(e => e.Altura).HasMaxLength(8);

                entity.Property(e => e.AlturaLib)
                    .HasColumnName("Altura_lib")
                    .HasMaxLength(8);

                entity.Property(e => e.Alturaplanta).HasMaxLength(8);

                entity.Property(e => e.Antiguedad).HasMaxLength(25);

                entity.Property(e => e.Ascensor).HasMaxLength(150);

                entity.Property(e => e.Ascensores).HasMaxLength(2);

                entity.Property(e => e.Atico).HasMaxLength(10);

                entity.Property(e => e.Bagnos).HasMaxLength(25);

                entity.Property(e => e.CalefaccA)
                    .HasColumnName("Calefacc_a")
                    .HasMaxLength(150);

                entity.Property(e => e.CalidadConstruccion)
                    .HasColumnName("Calidad_construccion")
                    .HasMaxLength(150);

                entity.Property(e => e.CalidadUbicacion)
                    .HasColumnName("Calidad_ubicacion")
                    .HasMaxLength(150);

                entity.Property(e => e.Cargas).HasMaxLength(250);

                entity.Property(e => e.Carpintext).HasMaxLength(1000);

                entity.Property(e => e.Carpintint).HasMaxLength(1000);

                entity.Property(e => e.Catastronavarra).HasMaxLength(20);

                entity.Property(e => e.ClaseTerreno)
                    .HasColumnName("Clase_terreno")
                    .HasMaxLength(250);

                entity.Property(e => e.Codencargo).HasMaxLength(100);

                entity.Property(e => e.Codentidad).HasMaxLength(4);

                entity.Property(e => e.CodigoTasador)
                    .HasColumnName("Codigo_tasador")
                    .HasMaxLength(5);

                entity.Property(e => e.Codmunicipio).HasMaxLength(6);

                entity.Property(e => e.Codpos).HasMaxLength(5);

                entity.Property(e => e.Comprobacion).HasMaxLength(1000);

                entity.Property(e => e.Condicionantes).HasMaxLength(1000);

                entity.Property(e => e.Coscondepr).HasMaxLength(11);

                entity.Property(e => e.CosteReposiciónActual)
                    .HasColumnName("Coste_reposición_actual")
                    .HasMaxLength(14);

                entity.Property(e => e.CosteReposiciónFinal)
                    .HasColumnName("Coste_reposición_final")
                    .HasMaxLength(14);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Cterneto).HasMaxLength(14);

                entity.Property(e => e.Dato1).HasMaxLength(25);

                entity.Property(e => e.Dato1id).HasMaxLength(5);

                entity.Property(e => e.Dato2).HasMaxLength(25);

                entity.Property(e => e.Dato2id).HasMaxLength(5);

                entity.Property(e => e.Dato3).HasMaxLength(25);

                entity.Property(e => e.Dato3id).HasMaxLength(5);

                entity.Property(e => e.Dato4).HasMaxLength(25);

                entity.Property(e => e.Dato4id).HasMaxLength(5);

                entity.Property(e => e.DatosSareb)
                    .HasColumnName("Datos_sareb")
                    .HasMaxLength(2);

                entity.Property(e => e.Delegacio).HasMaxLength(2);

                entity.Property(e => e.Delegacion).HasMaxLength(100);

                entity.Property(e => e.Direccion).HasMaxLength(250);

                entity.Property(e => e.Distribucion).HasMaxLength(500);

                entity.Property(e => e.Distrito).HasMaxLength(150);

                entity.Property(e => e.Documentacion).HasMaxLength(1000);

                entity.Property(e => e.Dormitorio).HasMaxLength(25);

                entity.Property(e => e.Duplex).HasMaxLength(10);

                entity.Property(e => e.Edificabterreno).HasMaxLength(11);

                entity.Property(e => e.Empresa).HasMaxLength(2);

                entity.Property(e => e.Entidad).HasMaxLength(500);

                entity.Property(e => e.Estadoactu).HasMaxLength(250);

                entity.Property(e => e.Estadouso)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstimacionTecnica)
                    .HasColumnName("Estimacion_tecnica")
                    .HasMaxLength(14);

                entity.Property(e => e.FachadaPr)
                    .HasColumnName("Fachada_pr")
                    .HasMaxLength(8);

                entity.Property(e => e.FachadaSe)
                    .HasColumnName("Fachada_se")
                    .HasMaxLength(8);

                entity.Property(e => e.FechaTas)
                    .HasColumnName("Fecha_tas")
                    .HasMaxLength(20);

                entity.Property(e => e.FechaVis)
                    .HasColumnName("Fecha_vis")
                    .HasMaxLength(20);

                entity.Property(e => e.Finalidad).HasMaxLength(250);

                entity.Property(e => e.Finca).HasMaxLength(10);

                entity.Property(e => e.Folio).HasMaxLength(5);

                entity.Property(e => e.Fondo).HasMaxLength(8);

                entity.Property(e => e.Garaje).HasMaxLength(2);

                entity.Property(e => e.Gastosnece).HasMaxLength(14);

                entity.Property(e => e.Gdistriid).HasMaxLength(25);

                entity.Property(e => e.Gdoclegid).HasMaxLength(25);

                entity.Property(e => e.Ginstalaid).HasMaxLength(25);

                entity.Property(e => e.Gobraid).HasMaxLength(25);

                entity.Property(e => e.Habitantes).HasMaxLength(250);

                entity.Property(e => e.Imagypdf).HasMaxLength(256);

                entity.Property(e => e.ImporteCargas)
                    .HasColumnName("Importe_cargas")
                    .HasMaxLength(14);

                entity.Property(e => e.Inddepreci).HasMaxLength(9);

                entity.Property(e => e.IndicedepreciacionEstadoCon)
                    .HasColumnName("Indicedepreciacion_estado_con")
                    .HasMaxLength(9);

                entity.Property(e => e.InstalacionesDeportivas)
                    .HasColumnName("Instalaciones_deportivas")
                    .HasMaxLength(2);

                entity.Property(e => e.Jardin).HasMaxLength(2);

                entity.Property(e => e.K)
                    .HasColumnName("k")
                    .HasMaxLength(19);

                entity.Property(e => e.Latitud).HasMaxLength(31);

                entity.Property(e => e.Libro).HasMaxLength(5);

                entity.Property(e => e.Longitud).HasMaxLength(31);

                entity.Property(e => e.LuzLibre)
                    .HasColumnName("Luz_libre")
                    .HasMaxLength(8);

                entity.Property(e => e.Mettasa).HasMaxLength(250);

                entity.Property(e => e.Moneda).HasMaxLength(25);

                entity.Property(e => e.MonedaId)
                    .HasColumnName("MonedaID")
                    .HasMaxLength(25);

                entity.Property(e => e.Municipio).HasMaxLength(250);

                entity.Property(e => e.Nif).HasMaxLength(12);

                entity.Property(e => e.NombUnidad)
                    .HasColumnName("Nomb_unidad")
                    .HasMaxLength(150);

                entity.Property(e => e.NroCliente)
                    .HasColumnName("Nro_cliente")
                    .HasMaxLength(50);

                entity.Property(e => e.NucleoPos)
                    .HasColumnName("Nucleo_pos")
                    .HasMaxLength(500);

                entity.Property(e => e.Numero).HasMaxLength(6);

                entity.Property(e => e.NumeroRegistro)
                    .HasColumnName("Numero_registro")
                    .HasMaxLength(25);

                entity.Property(e => e.NumeroVia)
                    .HasColumnName("Numero_via")
                    .HasMaxLength(25);

                entity.Property(e => e.Ocupado).HasMaxLength(2);

                entity.Property(e => e.PDepreAplicada)
                    .HasColumnName("P_depre_aplicada")
                    .HasMaxLength(14);

                entity.Property(e => e.Paisid).HasMaxLength(3);

                entity.Property(e => e.Paredes).HasMaxLength(1000);

                entity.Property(e => e.PavimenBagno)
                    .HasColumnName("Pavimen_bagno")
                    .HasMaxLength(500);

                entity.Property(e => e.PavimenCocina)
                    .HasColumnName("Pavimen_cocina")
                    .HasMaxLength(500);

                entity.Property(e => e.PavimenComedorEstar)
                    .HasColumnName("Pavimen_comedor_estar")
                    .HasMaxLength(500);

                entity.Property(e => e.PavimenDormitorios)
                    .HasColumnName("Pavimen_dormitorios")
                    .HasMaxLength(500);

                entity.Property(e => e.PavimenSalon)
                    .HasColumnName("Pavimen_salon")
                    .HasMaxLength(500);

                entity.Property(e => e.Piscina).HasMaxLength(2);

                entity.Property(e => e.Piso).HasMaxLength(25);

                entity.Property(e => e.Piso1).HasMaxLength(25);

                entity.Property(e => e.Planta).HasMaxLength(25);

                entity.Property(e => e.PorcReper)
                    .HasColumnName("Porc_reper")
                    .HasMaxLength(8);

                entity.Property(e => e.Porinmpro).HasMaxLength(1000);

                entity.Property(e => e.ProcessedTime).HasColumnType("datetime");

                entity.Property(e => e.Provincia).HasMaxLength(250);

                entity.Property(e => e.Provincia1).HasMaxLength(250);

                entity.Property(e => e.ProvinciaCodigo)
                    .HasColumnName("Provincia_codigo")
                    .HasMaxLength(2);

                entity.Property(e => e.Puerta).HasMaxLength(25);

                entity.Property(e => e.Puerta1).HasMaxLength(25);

                entity.Property(e => e.RefCatast)
                    .HasColumnName("Ref_catast")
                    .HasMaxLength(20);

                entity.Property(e => e.RefCatastT)
                    .HasColumnName("Ref_catast_t")
                    .HasMaxLength(20);

                entity.Property(e => e.ReferenciaCatastral)
                    .HasColumnName("Referencia_catastral")
                    .HasMaxLength(20);

                entity.Property(e => e.Reformas).HasMaxLength(2);

                entity.Property(e => e.ReformasC)
                    .HasColumnName("Reformas_c")
                    .HasMaxLength(1000);

                entity.Property(e => e.Registro).HasMaxLength(500);

                entity.Property(e => e.Rentamesco).HasMaxLength(11);

                entity.Property(e => e.Rentasactuales).HasMaxLength(2);

                entity.Property(e => e.Rentasesperadas).HasMaxLength(2);

                entity.Property(e => e.Rentasnetas).HasMaxLength(2);

                entity.Property(e => e.Repersuelo).HasMaxLength(11);

                entity.Property(e => e.Residen).HasMaxLength(15);

                entity.Property(e => e.Rreal).HasMaxLength(10);

                entity.Property(e => e.Siglas).HasMaxLength(3);

                entity.Property(e => e.Situacion).HasMaxLength(250);

                entity.Property(e => e.Solicitante).HasMaxLength(500);

                entity.Property(e => e.Sto).HasMaxLength(250);

                entity.Property(e => e.Sucursal).HasMaxLength(5);

                entity.Property(e => e.Suelos).HasMaxLength(1000);

                entity.Property(e => e.Supadotas).HasMaxLength(14);

                entity.Property(e => e.SuperficieConstruidaPpzc)
                    .HasColumnName("Superficie_construida_ppzc")
                    .HasMaxLength(12);

                entity.Property(e => e.SuperficieConstruidaPrivativa)
                    .HasColumnName("Superficie_construida_privativa")
                    .HasMaxLength(12);

                entity.Property(e => e.SuperficieParcela)
                    .HasColumnName("Superficie_parcela")
                    .HasMaxLength(12);

                entity.Property(e => e.SuperficieUtil)
                    .HasColumnName("Superficie_util")
                    .HasMaxLength(12);

                entity.Property(e => e.Suplemento).HasMaxLength(2);

                entity.Property(e => e.Supparcterrfir).HasMaxLength(11);

                entity.Property(e => e.Techos).HasMaxLength(1000);

                entity.Property(e => e.Tipo).HasMaxLength(10);

                entity.Property(e => e.TipoInmueble)
                    .HasColumnName("Tipo_inmueble")
                    .HasMaxLength(50);

                entity.Property(e => e.TipoVia)
                    .HasColumnName("Tipo_via")
                    .HasMaxLength(50);

                entity.Property(e => e.Tipocalle).HasMaxLength(5);

                entity.Property(e => e.Tipoficha).HasMaxLength(2);

                entity.Property(e => e.Tipomodulo).HasMaxLength(2);

                entity.Property(e => e.Tipoocupan).HasMaxLength(250);

                entity.Property(e => e.TipoocupanC)
                    .HasColumnName("Tipoocupan_c")
                    .HasMaxLength(25);

                entity.Property(e => e.Titular).HasMaxLength(250);

                entity.Property(e => e.Tomo).HasMaxLength(5);

                entity.Property(e => e.Totasuelo).HasMaxLength(14);

                entity.Property(e => e.Unidadid).HasMaxLength(25);

                entity.Property(e => e.Uso).HasMaxLength(25);

                entity.Property(e => e.UsoCultivo)
                    .HasColumnName("Uso_cultivo")
                    .HasMaxLength(250);

                entity.Property(e => e.VAgrupaci)
                    .HasColumnName("V_agrupaci")
                    .HasMaxLength(14);

                entity.Property(e => e.VAlturaplan)
                    .HasColumnName("V_alturaplan")
                    .HasMaxLength(150);

                entity.Property(e => e.VCalid)
                    .HasColumnName("V_calid")
                    .HasMaxLength(150);

                entity.Property(e => e.VLumin)
                    .HasColumnName("V_lumin")
                    .HasMaxLength(150);

                entity.Property(e => e.VSeguro)
                    .HasColumnName("V_seguro")
                    .HasMaxLength(14);

                entity.Property(e => e.VTasacion)
                    .HasColumnName("V_tasacion")
                    .HasMaxLength(14);

                entity.Property(e => e.VUbica)
                    .HasColumnName("V_ubica")
                    .HasMaxLength(150);

                entity.Property(e => e.VVpo)
                    .HasColumnName("V_vpo")
                    .HasMaxLength(14);

                entity.Property(e => e.ValorMercado)
                    .HasColumnName("Valor_mercado")
                    .HasMaxLength(14);

                entity.Property(e => e.ValorUniCosteCons)
                    .HasColumnName("Valor_uni_coste_cons")
                    .HasMaxLength(14);

                entity.Property(e => e.ValorUniSueloReper)
                    .HasColumnName("Valor_uni_suelo_reper")
                    .HasMaxLength(14);

                entity.Property(e => e.ValsegTotal)
                    .HasColumnName("Valseg_total")
                    .HasMaxLength(14);

                entity.Property(e => e.ValsegUnid)
                    .HasColumnName("Valseg_unid")
                    .HasMaxLength(14);

                entity.Property(e => e.ValuniActRco)
                    .HasColumnName("Valuni_act_rco")
                    .HasMaxLength(11);

                entity.Property(e => e.ValuniActRee)
                    .HasColumnName("Valuni_act_ree")
                    .HasMaxLength(11);

                entity.Property(e => e.ValuniActRma)
                    .HasColumnName("Valuni_act_rma")
                    .HasMaxLength(11);

                entity.Property(e => e.ValuniComp)
                    .HasColumnName("Valuni_comp")
                    .HasMaxLength(14);

                entity.Property(e => e.Valunisueterreno).HasMaxLength(11);

                entity.Property(e => e.VanRentasactuales)
                    .HasColumnName("Van_rentasactuales")
                    .HasMaxLength(14);

                entity.Property(e => e.VanRentasesperadas)
                    .HasColumnName("Van_rentasesperadas")
                    .HasMaxLength(14);

                entity.Property(e => e.VanRentasnetas)
                    .HasColumnName("Van_rentasnetas")
                    .HasMaxLength(14);

                entity.Property(e => e.Version).HasMaxLength(2);

                entity.Property(e => e.Via).HasMaxLength(250);

                entity.Property(e => e.Vinculada).HasMaxLength(25);

                entity.Property(e => e.Visitado).HasMaxLength(25);

                entity.Property(e => e.VisitadoC)
                    .HasColumnName("Visitado_c")
                    .HasMaxLength(5);

                entity.Property(e => e.Vistas).HasMaxLength(150);

                entity.Property(e => e.Vpo).HasMaxLength(2);

                entity.Property(e => e.X).HasMaxLength(5);

                entity.Property(e => e.Zona).HasMaxLength(150);
            });

            modelBuilder.Entity<RawProcessErrorLog>(entity =>
            {
                entity.Property(e => e.RawProcessErrorLogId).HasColumnName("RawProcessErrorLogID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ErrorMessage)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.ProcessTime).HasColumnType("datetime");

                entity.Property(e => e.RawId).HasColumnName("RawID");
            });

            modelBuilder.Entity<Registry>(entity =>
            {
                entity.Property(e => e.RegistryId).HasColumnName("RegistryID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Registry1)
                    .HasColumnName("Registry")
                    .HasMaxLength(150);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .IsUnique();

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.Code).HasMaxLength(2);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.State1)
                    .HasColumnName("State")
                    .HasMaxLength(250);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_State_Country");
            });

            modelBuilder.Entity<StayType>(entity =>
            {
                entity.HasIndex(e => e.StayType1);

                entity.Property(e => e.StayTypeId).HasColumnName("StayTypeID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StayType1)
                    .IsRequired()
                    .HasColumnName("StayType")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<StreetType>(entity =>
            {
                entity.Property(e => e.StreetTypeId).HasColumnName("StreetTypeID");

                entity.Property(e => e.Code).HasMaxLength(5);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StreetType1)
                    .HasColumnName("StreetType")
                    .HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<UseState>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .IsUnique();

                entity.Property(e => e.UseStateId).HasColumnName("UseStateID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UseState1)
                    .HasColumnName("UseState")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<UseType>(entity =>
            {
                entity.HasIndex(e => e.UseType1)
                    .IsUnique();

                entity.Property(e => e.UseTypeId).HasColumnName("UseTypeID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UseType1)
                    .HasColumnName("UseType")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Visited>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .IsUnique();

                entity.Property(e => e.VisitedId).HasColumnName("VisitedID");

                entity.Property(e => e.Code).HasMaxLength(5);

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Visited1)
                    .IsRequired()
                    .HasColumnName("Visited")
                    .HasMaxLength(25);
            });

            modelBuilder.Entity<WarningAppraisal>(entity =>
            {
                entity.HasIndex(e => e.AppraisalInfoId)
                    .HasName("IX_Warning_AppraisalID");

                entity.Property(e => e.WarningAppraisalId).HasColumnName("WarningAppraisalID");

                entity.Property(e => e.AppraisalInfoId).HasColumnName("AppraisalInfoID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.WarningAppraisal1)
                    .IsRequired()
                    .HasColumnName("WarningAppraisal")
                    .HasMaxLength(250);

                entity.Property(e => e.WarningAppraisalTypeId).HasColumnName("WarningAppraisalTypeID");

                entity.HasOne(d => d.AppraisalInfo)
                    .WithMany(p => p.WarningAppraisal)
                    .HasForeignKey(d => d.AppraisalInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WarningAppraisal_AppendantInfo");

                entity.HasOne(d => d.WarningAppraisalType)
                    .WithMany(p => p.WarningAppraisal)
                    .HasForeignKey(d => d.WarningAppraisalTypeId)
                    .HasConstraintName("FK_WarningAppraisal_WarningAppraisalType");
            });

            modelBuilder.Entity<WarningAppraisalType>(entity =>
            {
                entity.Property(e => e.WarningAppraisalTypeId).HasColumnName("WarningAppraisalTypeID");

                entity.Property(e => e.Pattern)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.WarningAppraisalType1)
                    .IsRequired()
                    .HasColumnName("WarningAppraisalType")
                    .HasMaxLength(150);
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.HasIndex(e => e.Zone1)
                    .IsUnique();

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Zone1)
                    .HasColumnName("Zone")
                    .HasMaxLength(150);
            });
        }
    }
}
