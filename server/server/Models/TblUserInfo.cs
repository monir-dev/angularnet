using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblUserInfo
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int? EmpId { get; set; }
        public bool? IsActive { get; set; }
        public string ServiceCenterCode { get; set; }
        public string Iuser { get; set; }
        public string Euser { get; set; }
        public DateTime Idate { get; set; }
        public DateTime? Edate { get; set; }
    }
}
