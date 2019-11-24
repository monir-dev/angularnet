using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblExpense
    {
        public TblExpense()
        {
            TblExpenseDetails = new HashSet<TblExpenseDetails>();
        }

        public long Id { get; set; }
        public long AssetId { get; set; }
        public long MaintenanceTypeId { get; set; }
        public long BusinessId { get; set; }
        public DateTime? ExpenseDate { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedBy { get; set; }
        public string Remark { get; set; }
        public string BillNo { get; set; }
        public DateTime? BillDate { get; set; }
        public string ReferenceNo { get; set; }
        public byte? IsCashPayment { get; set; }
        public string DepotCode { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal? Mileage { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

        public virtual TblAssetInfo Asset { get; set; }
        public virtual TblBusiness Business { get; set; }
        public virtual TblMaintenanceType MaintenanceType { get; set; }
        public virtual ICollection<TblExpenseDetails> TblExpenseDetails { get; set; }
    }
}
