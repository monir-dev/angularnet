using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblItems
    {
        public TblItems()
        {
            TblExpenseDetails = new HashSet<TblExpenseDetails>();
        }

        public long Id { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string ItemBrandCode { get; set; }
        public long? ItemSizeTypeId { get; set; }
        public long? ItemType { get; set; }
        public string Pattern { get; set; }
        public string Nature { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

        public virtual ICollection<TblExpenseDetails> TblExpenseDetails { get; set; }
    }
}
