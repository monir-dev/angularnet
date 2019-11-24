using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using server.Models;

namespace server.Context
{
    public partial class AssetContext : DbContext
    {
        public AssetContext()
        {
        }

        public AssetContext(DbContextOptions<AssetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acmaster> Acmaster { get; set; }
        public virtual DbSet<EmployeeInfo> EmployeeInfo { get; set; }
        public virtual DbSet<ExceptionLogger> ExceptionLogger { get; set; }
        public virtual DbSet<MenuRole> MenuRole { get; set; }
        public virtual DbSet<Menus> Menus { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<TblAssetCategory> TblAssetCategory { get; set; }
        public virtual DbSet<TblAssetDocument> TblAssetDocument { get; set; }
        public virtual DbSet<TblAssetInfo> TblAssetInfo { get; set; }
        public virtual DbSet<TblAssetManufacturer> TblAssetManufacturer { get; set; }
        public virtual DbSet<TblAssetSubCategory> TblAssetSubCategory { get; set; }
        public virtual DbSet<TblBrand> TblBrand { get; set; }
        public virtual DbSet<TblBusiness> TblBusiness { get; set; }
        public virtual DbSet<TblBusinessGroup> TblBusinessGroup { get; set; }
        public virtual DbSet<TblCompany> TblCompany { get; set; }
        public virtual DbSet<TblCompanyUser> TblCompanyUser { get; set; }
        public virtual DbSet<TblComponentValues> TblComponentValues { get; set; }
        public virtual DbSet<TblComponents> TblComponents { get; set; }
        public virtual DbSet<TblCostCentre> TblCostCentre { get; set; }
        public virtual DbSet<TblDepartment> TblDepartment { get; set; }
        public virtual DbSet<TblExpense> TblExpense { get; set; }
        public virtual DbSet<TblExpenseDetails> TblExpenseDetails { get; set; }
        public virtual DbSet<TblExpenseType> TblExpenseType { get; set; }
        public virtual DbSet<TblFuel> TblFuel { get; set; }
        public virtual DbSet<TblItems> TblItems { get; set; }
        public virtual DbSet<TblLocation> TblLocation { get; set; }
        public virtual DbSet<TblMaintenanceType> TblMaintenanceType { get; set; }
        public virtual DbSet<TblMenuList> TblMenuList { get; set; }
        public virtual DbSet<TblUserInfo> TblUserInfo { get; set; }
        public virtual DbSet<TblUserWiseMenuAssign> TblUserWiseMenuAssign { get; set; }
        public virtual DbSet<TblVendor> TblVendor { get; set; }
        public virtual DbSet<UserManager> UserManager { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ViewAcmaster> ViewAcmaster { get; set; }
        public virtual DbSet<ViewEmployeeInfo> ViewEmployeeInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=MISMONIR\\SQLEXPRESS;Database=dbFixedAsset;Persist Security Info=True;User ID=sa;Password=dataport;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ACMaster");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Actype1)
                    .IsRequired()
                    .HasColumnName("ACType1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Actype2)
                    .IsRequired()
                    .HasColumnName("ACType2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Actype3)
                    .IsRequired()
                    .HasColumnName("ACType3")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Amcode)
                    .IsRequired()
                    .HasColumnName("AMCode")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Amdetails)
                    .IsRequired()
                    .HasColumnName("AMDetails")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AmdetailsPart)
                    .IsRequired()
                    .HasColumnName("AMDetailsPart")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Astype)
                    .IsRequired()
                    .HasColumnName("ASType")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BusiNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EndId).HasColumnName("EndID");

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Plbl)
                    .IsRequired()
                    .HasColumnName("PLBL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SdbCustomer)
                    .IsRequired()
                    .HasColumnName("SDB_Customer")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SdbEmployee)
                    .IsRequired()
                    .HasColumnName("SDB_Employee")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SdbProduct)
                    .IsRequired()
                    .HasColumnName("SDB_Product")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SeconderyDb)
                    .IsRequired()
                    .HasColumnName("SeconderyDB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlBrand)
                    .IsRequired()
                    .HasColumnName("SL_Brand")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlEmployee)
                    .IsRequired()
                    .HasColumnName("SL_Employee")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlOrganization)
                    .IsRequired()
                    .HasColumnName("SL_Organization")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlProduct)
                    .IsRequired()
                    .HasColumnName("SL_Product")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlProductGroup)
                    .IsRequired()
                    .HasColumnName("SL_ProductGroup")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlVehicle)
                    .IsRequired()
                    .HasColumnName("SL_Vehicle")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlVendor)
                    .IsRequired()
                    .HasColumnName("SL_Vendor")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartId).HasColumnName("StartID");

                entity.Property(e => e.SubBusiNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SubDept)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExceptionLogger>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("ExceptionLogger_pk")
                    .IsClustered(false);

                entity.HasIndex(e => e.Id)
                    .HasName("ExceptionLogger_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.ControllerName).HasMaxLength(100);

                entity.Property(e => e.LogTime).HasColumnType("datetime");
            });

            modelBuilder.Entity<MenuRole>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.MenuId });
            });

            modelBuilder.Entity<Menus>(entity =>
            {
                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FaIcon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAssetCategory>(entity =>
            {
                entity.ToTable("tblAssetCategory");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAssetDocument>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tblAssetDocument_pk")
                    .IsClustered(false);

                entity.ToTable("tblAssetDocument");

                entity.HasIndex(e => e.Id)
                    .HasName("tblAssetDocument_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DocumentExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentExpiryNoticeSentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentStartDate).HasColumnType("datetime");

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Iuser)
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Transcription).IsUnicode(false);

                entity.HasOne(d => d.AssetInfo)
                    .WithMany(p => p.TblAssetDocument)
                    .HasForeignKey(d => d.AssetInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAssetDocument_tblAssetInfo");
            });

            modelBuilder.Entity<TblAssetInfo>(entity =>
            {
                entity.ToTable("tblAssetInfo");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AcquiredDate).HasColumnType("datetime");

                entity.Property(e => e.AcquisitionCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AssetLife).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AssetOwner)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AssetUser)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Capacity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cepdate)
                    .HasColumnName("CEPDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Cepnumber)
                    .HasColumnName("CEPNumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cepvalue)
                    .HasColumnName("CEPValue")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ComapnyCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DepreciationRate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlcodeAccumDeprc)
                    .HasColumnName("GLCode_ACCUM_DEPRC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.GlcodeDeprcExpense)
                    .HasColumnName("GLCode_DEPRC_Expense")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.InstallationDate).HasColumnType("datetime");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManufactureDate).HasColumnType("datetime");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Narration)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Podate)
                    .HasColumnName("PODate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Pono)
                    .HasColumnName("PONo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qrcode)
                    .HasColumnName("QRCode")
                    .IsUnicode(false);

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransferDateFromCwip)
                    .HasColumnName("TransferDateFromCWIP")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wdv)
                    .HasColumnName("WDV")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.AssetCategory)
                    .WithMany(p => p.TblAssetInfo)
                    .HasForeignKey(d => d.AssetCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAssetInfo_tblAssetCategory");

                entity.HasOne(d => d.CostCentr)
                    .WithMany(p => p.TblAssetInfo)
                    .HasForeignKey(d => d.CostCentrId)
                    .HasConstraintName("FK_tblAssetInfo_tblCostCentre");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.TblAssetInfo)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAssetInfo_tblLocation1");

                entity.HasOne(d => d.SubCategroy)
                    .WithMany(p => p.TblAssetInfo)
                    .HasForeignKey(d => d.SubCategroyId)
                    .HasConstraintName("FK_tblAssetInfo_tblAssetSubCategory");
            });

            modelBuilder.Entity<TblAssetManufacturer>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tblManufacturer_pk")
                    .IsClustered(false);

                entity.ToTable("tblAssetManufacturer");

                entity.HasIndex(e => e.Id)
                    .HasName("tblManufacturer_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Iuser)
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('admin')");

                entity.Property(e => e.ManufacturerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ManufacturerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblAssetSubCategory>(entity =>
            {
                entity.ToTable("tblAssetSubCategory");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.AssetSubCategory)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.TblAssetSubCategory)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAssetSubCategoryN_tblAssetCategory");
            });

            modelBuilder.Entity<TblBrand>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tblBrand_pk")
                    .IsClustered(false);

                entity.ToTable("tblBrand");

                entity.HasIndex(e => e.Id)
                    .HasName("tblBrand_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.BrandName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblBusiness>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tblBusiness_pk")
                    .IsClustered(false);

                entity.ToTable("tblBusiness");

                entity.HasIndex(e => e.Id)
                    .HasName("tblBusiness_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BusinessName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BusinessGroup)
                    .WithMany(p => p.TblBusiness)
                    .HasForeignKey(d => d.BusinessGroupId)
                    .HasConstraintName("FK_tblBusiness_tblBusinessGroup");
            });

            modelBuilder.Entity<TblBusinessGroup>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tblBusinessGroup_pk")
                    .IsClustered(false);

                entity.ToTable("tblBusinessGroup");

                entity.HasIndex(e => e.Id)
                    .HasName("tblBusinessGroup_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.BusinessGroupName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCompany>(entity =>
            {
                entity.HasKey(e => e.CompanyCode);

                entity.ToTable("tblCompany");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyShortName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCompanyUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.CompanyCode });

                entity.ToTable("tblCompanyUser");

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.TblCompanyUser)
                    .HasForeignKey(d => d.CompanyCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyUser_tblCompany");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TblCompanyUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblCompanyUser_Users");
            });

            modelBuilder.Entity<TblComponentValues>(entity =>
            {
                entity.ToTable("tblComponentValues");

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.TblComponentValues)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblComponentValues_tblAssetInfo_Id_fk");

                entity.HasOne(d => d.Component)
                    .WithMany(p => p.TblComponentValues)
                    .HasForeignKey(d => d.ComponentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tblComponentValues_tblComponents_Id_fk");
            });

            modelBuilder.Entity<TblComponents>(entity =>
            {
                entity.ToTable("tblComponents");

                entity.Property(e => e.CategoryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ComponentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblCostCentre>(entity =>
            {
                entity.ToTable("tblCostCentre");

                entity.Property(e => e.BusinessCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CostCentre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CostCentreCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblDepartment>(entity =>
            {
                entity.ToTable("tblDepartment");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShortCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblExpense>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tblAssetExpense_pk")
                    .IsClustered(false);

                entity.ToTable("tblExpense");

                entity.HasIndex(e => e.Id)
                    .HasName("tblAssetExpense_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.ApprovedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillNo).HasMaxLength(20);

                entity.Property(e => e.DepotCode).HasMaxLength(20);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpenseDate).HasColumnType("datetime");

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsCashPayment).HasDefaultValueSql("((0))");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mileage).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReferenceNo).HasMaxLength(20);

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.TblExpense)
                    .HasForeignKey(d => d.AssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblExpense_tblAssetInfo");

                entity.HasOne(d => d.Business)
                    .WithMany(p => p.TblExpense)
                    .HasForeignKey(d => d.BusinessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAssetExpense_tblBusiness");

                entity.HasOne(d => d.MaintenanceType)
                    .WithMany(p => p.TblExpense)
                    .HasForeignKey(d => d.MaintenanceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblAssetExpense_tblMaintenanceType");
            });

            modelBuilder.Entity<TblExpenseDetails>(entity =>
            {
                entity.ToTable("tblExpenseDetails");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.DetailBillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceptNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SubTotal).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Expense)
                    .WithMany(p => p.TblExpenseDetails)
                    .HasForeignKey(d => d.ExpenseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblExpenseDetails_tblAssetExpense");

                entity.HasOne(d => d.ExpenseType)
                    .WithMany(p => p.TblExpenseDetails)
                    .HasForeignKey(d => d.ExpenseTypeId)
                    .HasConstraintName("FK_tblExpenseDetails_tblExpenseType");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TblExpenseDetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tblExpenseDetails_tblItems");
            });

            modelBuilder.Entity<TblExpenseType>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tblExpenseType_pk")
                    .IsClustered(false);

                entity.ToTable("tblExpenseType");

                entity.HasIndex(e => e.Id)
                    .HasName("tblExpenseType_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblFuel>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tblFuel_pk")
                    .IsClustered(false);

                entity.ToTable("tblFuel");

                entity.HasIndex(e => e.Id)
                    .HasName("tblFuel_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FuelCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FuelName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Iuser)
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('admin')");

                entity.Property(e => e.MeasurementUnitId)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblItems>(entity =>
            {
                entity.ToTable("tblItems");

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemBrandCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pattern)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblLocation>(entity =>
            {
                entity.ToTable("tblLocation");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMaintenanceType>(entity =>
            {
                entity.ToTable("tblMaintenanceType");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblMenuList>(entity =>
            {
                entity.ToTable("tblMenuList");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.ActionName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PageUrl)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ParentMenuName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserInfo>(entity =>
            {
                entity.ToTable("tblUserInfo");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCenterCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblUserWiseMenuAssign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tblUserWiseMenuAssign");

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iuser)
                    .IsRequired()
                    .HasColumnName("IUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblVendor>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tblVendor_pk")
                    .IsClustered(false);

                entity.ToTable("tblVendor");

                entity.HasIndex(e => e.Id)
                    .HasName("tblVendor_Id_uindex")
                    .IsUnique();

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasDefaultValueSql("((0))");

                entity.Property(e => e.Edate)
                    .HasColumnName("EDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Euser)
                    .HasColumnName("EUser")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Idate)
                    .HasColumnName("IDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.Iuser)
                    .HasColumnName("IUser")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('admin')");

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StreetAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VendorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Website).HasMaxLength(50);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserManager>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultBusiness)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DepotCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GrpAdd).HasColumnName("grpAdd");

                entity.Property(e => e.GrpIsup).HasColumnName("grpISup");

                entity.Property(e => e.GrpSup).HasColumnName("grpSup");

                entity.Property(e => e.GrpUser).HasColumnName("grpUser");

                entity.Property(e => e.InvoiceFormat)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JoiningDate).HasColumnType("datetime");

                entity.Property(e => e.LevelCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Staffid)
                    .IsRequired()
                    .HasColumnName("staffid")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Subbusinesscode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserLevel)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserLevelMkt)
                    .IsRequired()
                    .HasColumnName("UserLevelMKT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UserLocation)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PasswordHash).IsRequired();

                entity.Property(e => e.PasswordSalt).IsRequired();

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ViewAcmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ACMaster");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Actype1)
                    .IsRequired()
                    .HasColumnName("ACType1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Actype2)
                    .IsRequired()
                    .HasColumnName("ACType2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Actype3)
                    .IsRequired()
                    .HasColumnName("ACType3")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Amcode)
                    .IsRequired()
                    .HasColumnName("AMCode")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Amdetails)
                    .IsRequired()
                    .HasColumnName("AMDetails")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AmdetailsPart)
                    .IsRequired()
                    .HasColumnName("AMDetailsPart")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Astype)
                    .IsRequired()
                    .HasColumnName("ASType")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.BusiNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Dept)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EndId).HasColumnName("EndID");

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Plbl)
                    .IsRequired()
                    .HasColumnName("PLBL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SdbCustomer)
                    .IsRequired()
                    .HasColumnName("SDB_Customer")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SdbEmployee)
                    .IsRequired()
                    .HasColumnName("SDB_Employee")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SdbProduct)
                    .IsRequired()
                    .HasColumnName("SDB_Product")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SeconderyDb)
                    .IsRequired()
                    .HasColumnName("SeconderyDB")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlBrand)
                    .IsRequired()
                    .HasColumnName("SL_Brand")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlEmployee)
                    .IsRequired()
                    .HasColumnName("SL_Employee")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlOrganization)
                    .IsRequired()
                    .HasColumnName("SL_Organization")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlProduct)
                    .IsRequired()
                    .HasColumnName("SL_Product")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlProductGroup)
                    .IsRequired()
                    .HasColumnName("SL_ProductGroup")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlVehicle)
                    .IsRequired()
                    .HasColumnName("SL_Vehicle")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SlVendor)
                    .IsRequired()
                    .HasColumnName("SL_Vendor")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StartId).HasColumnName("StartID");

                entity.Property(e => e.SubBusiNo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SubDept)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViewEmployeeInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_EmployeeInfo");

                entity.Property(e => e.EmployeeCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
