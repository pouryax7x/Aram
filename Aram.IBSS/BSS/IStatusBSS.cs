
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using System.Collections.Generic;

namespace Aram.IBSS
{


    public interface IStatusBSS
    {
        IQueryable<Status> GetAll();
        IQueryable<Status> GetById(int id);
        IQueryable<Status> GetByName(string Name);
        int Delete(int id);
        Status Update(Status status, int id);
        Status Insert(Status status);
        void SaveChanges();

    }
}