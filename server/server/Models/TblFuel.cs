using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblFuel
    {
        public TblFuel()
        {
        }

        public long Id { get; set; }
        public string FuelName { get; set; }
        public string FuelCode { get; set; }
        public string MeasurementUnitId { get; set; }
        public string IsActive { get; set; }
        public string Iuser { get; set; }
        public DateTime? Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

    }
}
