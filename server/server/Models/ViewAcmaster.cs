using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class ViewAcmaster
    {
        public string Amcode { get; set; }
        public string CompanyCode { get; set; }
        public string Amdetails { get; set; }
        public string AmdetailsPart { get; set; }
        public string Actype1 { get; set; }
        public string Actype2 { get; set; }
        public string Actype3 { get; set; }
        public string Dept { get; set; }
        public string BusiNo { get; set; }
        public string SubBusiNo { get; set; }
        public string SubDept { get; set; }
        public string Location { get; set; }
        public string Plbl { get; set; }
        public string GroupCode { get; set; }
        public int CashFlowId { get; set; }
        public bool Subledger { get; set; }
        public string Astype { get; set; }
        public int StartId { get; set; }
        public int EndId { get; set; }
        public string UserId { get; set; }
        public string SlVendor { get; set; }
        public string SlOrganization { get; set; }
        public string SlEmployee { get; set; }
        public string SlProduct { get; set; }
        public string SlBrand { get; set; }
        public string SlProductGroup { get; set; }
        public string SlVehicle { get; set; }
        public string SeconderyDb { get; set; }
        public string SdbCustomer { get; set; }
        public string SdbEmployee { get; set; }
        public string SdbProduct { get; set; }
        public string ChequeName { get; set; }
        public string Active { get; set; }
    }
}
