using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.Context;
using server.Models;
using server.Repository.Interfaces;

namespace server.Repository.Persistence
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(AssetContext context) : base(context) {}

        public IEnumerable<Users> GetAllUsers()
        {
            return AssetContext.Users.ToList();
        }

        //public IList<Menu> UserMenus(long id)
        //{
        //    int userId = (int)id;

        //    var menus = DefaultConnection.Users
        //        .Join(DefaultConnection.Roles, u => u.RoleId, r => r.Id, (u, r) => new { u, r })
        //        .Join(DefaultConnection.MenuRoles, ur => ur.r.Id, mr => mr.RoleId, (ur, mr) => new { ur, mr })
        //        .Join(DefaultConnection.Menus, umr => umr.mr.MenuId, m => m.Id, (umr, m) => new { umr, m })
        //        .Where(@t => @t.umr.ur.u.Id == userId)
        //        .Select(@t => @t.m)
        //        .ToList();
        //    return menus;
        //}


        public AssetContext AssetContext => (AssetContext) Context;
    }
}
