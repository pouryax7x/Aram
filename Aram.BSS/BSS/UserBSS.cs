using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IBSS;
using Aram.IDataAccess;
using System.Collections.Generic;
using System;

namespace Aram.BSS
{


    public class UserBSS : IUserBSS
    {
        IUserDA _userDA;
        public UserBSS(IUserDA userDA)
        {
            _userDA = userDA;
        }
        private IQueryable<User> GetUsers() => _userDA.GetUsers();
        public IQueryable<User> GetAll() => GetUsers();
        public IQueryable<User> GetById(int id) => GetUsers().Where(x => x.userID == id);
        public IQueryable<User> GetByName(string UserName) => GetUsers().Where(x => x.username.Contains(UserName));
        public int Delete(int id) => _userDA.Delete(id);
        public User Update(User user, int id) => _userDA.Update(user, id);
        public User Insert(User user)
        {
            return _userDA.Insert(user);
        }
        public void SaveChanges() => _userDA.SaveChanges();

    }
}