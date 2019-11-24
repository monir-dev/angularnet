using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblMaintenanceType
    {
        public TblMaintenanceType()
        {
            TblExpense = new HashSet<TblExpense>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblExpense> TblExpense { get; set; }
    }
}
