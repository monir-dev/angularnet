using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.Models;

namespace server.Repository.Interfaces
{
    public interface IUsersRepository : IRepository<Users>
    {
        IEnumerable<Users> GetAllUsers();
    }
}
