
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IDataAccess;

namespace Aram.IDataAccess
{


    public interface IStatusDA
    {
        IQueryable<Status> GetStatuses();
        int Delete(int id);
        Status Update(Status status, int id);
        Status Insert(Status status);
        void SaveChanges();

    }
}