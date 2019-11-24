using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblComponentValues
    {
        public long Id { get; set; }
        public long ComponentId { get; set; }
        public string Value { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }
        public long AssetId { get; set; }

        public virtual TblAssetInfo Asset { get; set; }
        public virtual TblComponents Component { get; set; }
    }
}
