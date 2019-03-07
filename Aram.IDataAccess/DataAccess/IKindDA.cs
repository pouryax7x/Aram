
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IDataAccess;

namespace Aram.IDataAccess
{


    public interface IKindDA
    {
        IQueryable<Kind> GetKinds();
        int Delete(int id);
        Kind Update(Kind kind, int id);
        Kind Insert(Kind kind);
        void SaveChanges();

    }
}