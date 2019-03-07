using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IBSS;
using Aram.IDataAccess;
using System.Collections.Generic;
using System;

namespace Aram.BSS
{


    public class StatusBSS : IStatusBSS
    {
        IStatusDA _statusDA;
        public StatusBSS(IStatusDA statusDA)
        {
            _statusDA = statusDA;
        }
        private IQueryable<Status> GetStatuses() => _statusDA.GetStatuses();
        public IQueryable<Status> GetAll() => GetStatuses();
        public IQueryable<Status> GetById(int id) => GetStatuses().Where(x => x.statusID == id);
        public IQueryable<Status> GetByName(string Name) => GetStatuses().Where(x => x.name.Contains(Name));
        public int Delete(int id) => _statusDA.Delete(id);
        public Status Update(Status status, int id) => _statusDA.Update(status, id);
        public Status Insert(Status status)
        {
            return _statusDA.Insert(status);
        }
        public void SaveChanges() => _statusDA.SaveChanges();

    }
}