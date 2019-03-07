using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IBSS;
using Aram.IDataAccess;
using System.Collections.Generic;
using System;

namespace Aram.BSS
{


    public class ProblemInventoryBSS : IProblemInventoryBSS
    {
        IProblemInventoryDA _problemInventoryDA;
        public ProblemInventoryBSS(IProblemInventoryDA problemInventoryDA)
        {
            _problemInventoryDA = problemInventoryDA;
        }
        private IQueryable<ProblemInventory> GetProblemInventories() => _problemInventoryDA.GetProblemInventories();
        public IQueryable<ProblemInventory> GetAll() => GetProblemInventories();
        public IQueryable<ProblemInventory> GetById(int id) => GetProblemInventories().Where(x => x.problemInventoryID == id);
        public int Delete(int id) => _problemInventoryDA.Delete(id);
        public ProblemInventory Update(ProblemInventory problemInventory, int id) => _problemInventoryDA.Update(problemInventory, id);
        public ProblemInventory Insert(ProblemInventory problemInventory)
        {
            return _problemInventoryDA.Insert(problemInventory);
        }
        public void SaveChanges() => _problemInventoryDA.SaveChanges();

    }
}