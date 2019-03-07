
using System;
using System.Linq;
using Aram.DA;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using PostgreSQL;
using Aram.IDataAccess;

namespace Aram.DA
{


    public class KindDA : BaseDA<Kind> , IKindDA
    {
        public KindDA(IAramContext db) : base(db)
        {
        }
        public IQueryable<Kind> GetKinds() => base.GetAll();
        public new int Delete(int id) => base.Delete(id);
        public new Kind Update(Kind kind, int id) => base.Update(kind, id);
        public new Kind Insert(Kind kind) => base.Insert(kind);
        public new void SaveChanges() => base.SaveChanges();

    }
}