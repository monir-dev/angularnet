using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblExpenseDetails
    {
        public long Id { get; set; }
        public long ItemId { get; set; }
        public long ExpenseId { get; set; }
        public long? ExpenseTypeId { get; set; }
        public string ReceptNo { get; set; }
        public string DetailBillNo { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public decimal Rate { get; set; }
        public decimal SubTotal { get; set; }
        public string Iuser { get; set; }
        public DateTime Idate { get; set; }
        public string Euser { get; set; }
        public DateTime? Edate { get; set; }

        public virtual TblExpense Expense { get; set; }
        public virtual TblExpenseType ExpenseType { get; set; }
        public virtual TblItems Item { get; set; }
    }
}
