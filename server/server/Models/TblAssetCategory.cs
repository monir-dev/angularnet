using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblAssetCategory
    {
        public TblAssetCategory()
        {
            TblAssetInfo = new HashSet<TblAssetInfo>();
            TblAssetSubCategory = new HashSet<TblAssetSubCategory>();
        }

        public long Id { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCode { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

        public virtual ICollection<TblAssetInfo> TblAssetInfo { get; set; }
        public virtual ICollection<TblAssetSubCategory> TblAssetSubCategory { get; set; }
    }
}
