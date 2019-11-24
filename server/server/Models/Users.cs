using System;
using System.Collections.Generic;

namespace server.Models
{
    public partial class Users
    {
        public Users()
        {
            TblCompanyUser = new HashSet<TblCompanyUser>();
        }

        public long Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public virtual ICollection<TblCompanyUser> TblCompanyUser { get; set; }
    }
}
