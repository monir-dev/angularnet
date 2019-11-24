using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblAssetSubCategory
    {
        public TblAssetSubCategory()
        {
            TblAssetInfo = new HashSet<TblAssetInfo>();
        }

        public long Id { get; set; }
        public long CategoryId { get; set; }
        public string AssetSubCategory { get; set; }
        public string CategoryCode { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

        public virtual TblAssetCategory Category { get; set; }
        public virtual ICollection<TblAssetInfo> TblAssetInfo { get; set; }
    }
}
