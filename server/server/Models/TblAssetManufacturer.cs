using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblAssetManufacturer
    {
        public TblAssetManufacturer()
        {
        }

        public long Id { get; set; }
        public string ManufacturerName { get; set; }
        public string ManufacturerCode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public long? CountryId { get; set; }
        public string IsActive { get; set; }
        public string Iuser { get; set; }
        public DateTime? Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

    }
}
