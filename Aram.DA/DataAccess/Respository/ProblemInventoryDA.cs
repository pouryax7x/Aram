
using System;
using System.Linq;
using Aram.DA;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using PostgreSQL;
using Aram.IDataAccess;

namespace Aram.DA
{
    public class ProblemInventoryDA : BaseDA<ProblemInventory> , IProblemInventoryDA
    {
        public ProblemInventoryDA(IAramContext db) : base(db)
        {
        }
        public IQueryable<ProblemInventory> GetProblemInventories() => base.GetAll();
        public new int Delete(int id) => base.Delete(id);
        public new ProblemInventory Update(ProblemInventory problemInventory, int id) => base.Update(problemInventory, id);
        public new ProblemInventory Insert(ProblemInventory problemInventory) => base.Insert(problemInventory);
        public new void SaveChanges() => base.SaveChanges();

    }
}