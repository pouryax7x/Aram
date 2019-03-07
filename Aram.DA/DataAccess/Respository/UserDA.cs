
using System;
using System.Linq;
using Aram.DA;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using PostgreSQL;
using Aram.IDataAccess;

namespace Aram.DA
{
    public class UserDA : BaseDA<User> , IUserDA
    {
        public UserDA(IAramContext db) : base(db)
        {
        }
        public IQueryable<User> GetUsers() => base.GetAll();
        public new int Delete(int id) => base.Delete(id);
        public new User Update(User user, int id) => base.Update(user, id);
        public new User Insert(User user) => base.Insert(user);
        public new void SaveChanges() => base.SaveChanges();

    }
}