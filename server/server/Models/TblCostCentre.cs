using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblCostCentre
    {
        public TblCostCentre()
        {
            TblAssetInfo = new HashSet<TblAssetInfo>();
        }

        public long Id { get; set; }
        public string DepartmentCode { get; set; }
        public string BusinessCode { get; set; }
        public string CostCentre { get; set; }
        public string CostCentreCode { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

        public virtual ICollection<TblAssetInfo> TblAssetInfo { get; set; }
    }
}
