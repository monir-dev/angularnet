using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class Menus
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long? ParentMenuId { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string ModuleName { get; set; }
        public string FaIcon { get; set; }
    }
}
