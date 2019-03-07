
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using System.Collections.Generic;

namespace Aram.IBSS
{


    public interface IUserBSS
    {
        IQueryable<User> GetAll();
        IQueryable<User> GetById(int id);
        IQueryable<User> GetByName(string Name);
        int Delete(int id);
        User Update(User user, int id);
        User Insert(User user);
        void SaveChanges();

    }
}