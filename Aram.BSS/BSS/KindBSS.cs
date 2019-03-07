using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IBSS;
using Aram.IDataAccess;
using System.Collections.Generic;
using System;

namespace Aram.BSS
{


    public class KindBSS : IKindBSS
    {
        IKindDA _kindDA;
        public KindBSS(IKindDA kindDA)
        {
            _kindDA = kindDA;
        }
        private IQueryable<Kind> GetKinds() => _kindDA.GetKinds();
        public IQueryable<Kind> GetAll() => GetKinds();
        public IQueryable<Kind> GetById(int id) => GetKinds().Where(x => x.kindID == id);
        public IQueryable<Kind> GetByName(string Name) => GetKinds().Where(x => x.name.Contains(Name));
        public int Delete(int id) => _kindDA.Delete(id);
        public Kind Update(Kind kind, int id) => _kindDA.Update(kind, id);
        public Kind Insert(Kind kind)
        {
            return _kindDA.Insert(kind);
        }
        public void SaveChanges() => _kindDA.SaveChanges();

    }
}