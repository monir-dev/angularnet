using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblComponents
    {
        public TblComponents()
        {
            TblComponentValues = new HashSet<TblComponentValues>();
        }

        public long Id { get; set; }
        public string CategoryCode { get; set; }
        public string ComponentName { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

        public virtual ICollection<TblComponentValues> TblComponentValues { get; set; }
    }
}
