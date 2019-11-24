using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblBusiness
    {
        public TblBusiness()
        {
            TblExpense = new HashSet<TblExpense>();
        }

        public long Id { get; set; }
        public string BusinessName { get; set; }
        public string ShortCode { get; set; }
        public string Logo { get; set; }
        public long? CountryId { get; set; }
        public long? BusinessGroupId { get; set; }
        public string IsActive { get; set; }
        public string Iuser { get; set; }
        public DateTime? Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

        public virtual TblBusinessGroup BusinessGroup { get; set; }
        public virtual ICollection<TblExpense> TblExpense { get; set; }
    }
}
