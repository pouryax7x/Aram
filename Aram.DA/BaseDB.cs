using System;
using System.Linq;
using Aram.IDataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PostgreSQL;

namespace Aram.DA
{
    abstract public class BaseDA<T> where T : class
    {
        protected DbSet<T> _table;
        IAramContext _db;
        public BaseDA(IAramContext db)
        {
            _db = db;
            this._table = _db.Set<T>();
        }
        protected IQueryable<T> GetAll() => _table.AsQueryable();
        protected int Delete(int id)
        {
            var temp = _table.Find(id);
            _db.Remove(temp);
            return id;
        }
        protected T Update(T model, int id)
        {
            var temp = _table.Find(id);
            _db.Entry(temp).CurrentValues.SetValues(model);
            return model;
        }
        protected T Insert(T model){
            _table.Add(model);
            return model;
        }
        protected void SaveChanges()
        {
            _db.SaveChanges();
        }
    }
}