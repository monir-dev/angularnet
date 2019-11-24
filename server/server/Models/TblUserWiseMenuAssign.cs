using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class TblUserWiseMenuAssign
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MenuId { get; set; }
        public string Iuser { get; set; }
        public string Euser { get; set; }
        public DateTime Idate { get; set; }
        public DateTime? Edate { get; set; }
    }
}
