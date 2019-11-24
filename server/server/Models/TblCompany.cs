using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblCompany
    {
        public TblCompany()
        {
            TblCompanyUser = new HashSet<TblCompanyUser>();
        }

        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyShortName { get; set; }
        public string Active { get; set; }

        public virtual ICollection<TblCompanyUser> TblCompanyUser { get; set; }
    }
}
