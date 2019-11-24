using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblBrand
    {
        public TblBrand()
        {
        }

        public long Id { get; set; }
        public string BrandName { get; set; }
        public string ShortCode { get; set; }
        public string IsActive { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }
    }
}
