using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblExpenseType
    {
        public TblExpenseType()
        {
            TblExpenseDetails = new HashSet<TblExpenseDetails>();
        }

        public long Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TblExpenseDetails> TblExpenseDetails { get; set; }
    }
}
