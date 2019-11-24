using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class ExceptionLogger
    {
        public long Id { get; set; }
        public string ExceptionMessage { get; set; }
        public string ControllerName { get; set; }
        public string ExceptionStackTrace { get; set; }
        public DateTime? LogTime { get; set; }
    }
}
