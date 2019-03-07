
using System;
using System.Linq;
using Aram.DA;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using PostgreSQL;
using Aram.IDataAccess;

namespace Aram.DA
{
    public class StatusDA : BaseDA<Status> , IStatusDA
    {
        public StatusDA(IAramContext db) : base(db)
        {
        }
        public IQueryable<Status> GetStatuses() => base.GetAll();
        public new int Delete(int id) => base.Delete(id);
        public new Status Update(Status status, int id) => base.Update(status, id);
        public new Status Insert(Status status) => base.Insert(status);
        public new void SaveChanges() => base.SaveChanges();

    }
}