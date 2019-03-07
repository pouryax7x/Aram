
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IDataAccess;

namespace Aram.IDataAccess
{


    public interface IUserDA
    {
        IQueryable<User> GetUsers();
        int Delete(int id);
        User Update(User user, int id);
        User Insert(User user);
        void SaveChanges();

    }
}