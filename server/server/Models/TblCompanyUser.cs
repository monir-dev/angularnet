using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblCompanyUser
    {
        public long UserId { get; set; }
        public string CompanyCode { get; set; }

        public virtual TblCompany CompanyCodeNavigation { get; set; }
        public virtual Users User { get; set; }
    }
}
