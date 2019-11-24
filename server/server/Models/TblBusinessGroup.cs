using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblBusinessGroup
    {
        public TblBusinessGroup()
        {
            TblBusiness = new HashSet<TblBusiness>();
        }

        public long Id { get; set; }
        public string BusinessGroupName { get; set; }
        public string ShortCode { get; set; }
        public long? OrganizationId { get; set; }
        public string IsActive { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

        public virtual ICollection<TblBusiness> TblBusiness { get; set; }
    }
}
