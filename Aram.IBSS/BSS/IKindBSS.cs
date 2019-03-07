
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using System.Collections.Generic;

namespace Aram.IBSS
{


    public interface IKindBSS
    {
        IQueryable<Kind> GetAll();
        IQueryable<Kind> GetById(int id);
        IQueryable<Kind> GetByName(string Name);
        int Delete(int id);
        Kind Update(Kind kind, int id);
        Kind Insert(Kind kind);
        void SaveChanges();

    }
}