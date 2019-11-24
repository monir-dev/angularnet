using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class UserManager
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string Designation { get; set; }
        public string Password { get; set; }
        public bool GrpAdd { get; set; }
        public bool GrpSup { get; set; }
        public bool GrpIsup { get; set; }
        public bool GrpUser { get; set; }
        public string Active { get; set; }
        public string InvoiceFormat { get; set; }
        public string DefaultBusiness { get; set; }
        public string UserLevel { get; set; }
        public string LevelCode { get; set; }
        public string Subbusinesscode { get; set; }
        public string Staffid { get; set; }
        public string UserLocation { get; set; }
        public string UserLevelMkt { get; set; }
        public int Id { get; set; }
        public string DepotCode { get; set; }
    }
}
