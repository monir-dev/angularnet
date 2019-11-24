using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Repository.Interfaces
{
    interface IUnitOfWork: IDisposable
    {
        IUsersRepository Users { get; }

        int Complete();
    }
}
