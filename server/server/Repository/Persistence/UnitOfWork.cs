using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.Context;
using server.Models;
using server.Repository.Interfaces;

namespace server.Repository.Persistence
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AssetContext _context;

        public UnitOfWork()
        {
            _context = new AssetContext();

            Users = new UsersRepository(_context);
        }

        public UnitOfWork(AssetContext context)
        {
            _context = context;
        }


        public IUsersRepository Users { get; private set; }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
