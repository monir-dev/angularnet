using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblDepartment
    {
        public TblDepartment()
        {
        }

        public long Id { get; set; }
        public string DepartmentName { get; set; }
        public string ShortCode { get; set; }
        public string IsActive { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

    }
}
