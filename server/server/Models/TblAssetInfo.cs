using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblAssetInfo
    {
        public TblAssetInfo()
        {
            TblAssetDocument = new HashSet<TblAssetDocument>();
            TblComponentValues = new HashSet<TblComponentValues>();
            TblExpense = new HashSet<TblExpense>();
        }

        public long Id { get; set; }
        public string Narration { get; set; }
        public string SerialNo { get; set; }
        public decimal AcquisitionCost { get; set; }
        public DateTime AcquiredDate { get; set; }
        public string AccountCode { get; set; }
        public string GlcodeAccumDeprc { get; set; }
        public string GlcodeDeprcExpense { get; set; }
        public long LocationId { get; set; }
        public long? CostCentrId { get; set; }
        public long AssetCategoryId { get; set; }
        public decimal AssetLife { get; set; }
        public decimal DepreciationRate { get; set; }
        public string Cepnumber { get; set; }
        public DateTime? Cepdate { get; set; }
        public decimal Cepvalue { get; set; }
        public string Pono { get; set; }
        public DateTime? Podate { get; set; }
        public long? VendorId { get; set; }
        public string Model { get; set; }
        public string Capacity { get; set; }
        public string Manufacturer { get; set; }
        public DateTime? ManufactureDate { get; set; }
        public DateTime? InstallationDate { get; set; }
        public DateTime? TransferDateFromCwip { get; set; }
        public string AssetOwner { get; set; }
        public string AssetUser { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }
        public string ComapnyCode { get; set; }
        public long? SubCategroyId { get; set; }
        public long? ManufacturarId { get; set; }
        public decimal? Wdv { get; set; }
        public string ImagePath { get; set; }
        public string Qrcode { get; set; }

        public virtual TblAssetCategory AssetCategory { get; set; }
        public virtual TblCostCentre CostCentr { get; set; }
        public virtual TblLocation Location { get; set; }
        public virtual TblAssetSubCategory SubCategroy { get; set; }
        public virtual ICollection<TblAssetDocument> TblAssetDocument { get; set; }
        public virtual ICollection<TblComponentValues> TblComponentValues { get; set; }
        public virtual ICollection<TblExpense> TblExpense { get; set; }
    }
}
