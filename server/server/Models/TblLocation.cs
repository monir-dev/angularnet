using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblLocation
    {
        public TblLocation()
        {
            TblAssetInfo = new HashSet<TblAssetInfo>();
        }

        public long Id { get; set; }
        public string Location { get; set; }
        public string ShortCode { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

        public virtual ICollection<TblAssetInfo> TblAssetInfo { get; set; }
    }
}
