
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IDataAccess;

namespace Aram.IDataAccess
{


    public interface IProblemInventoryDA
    {
        IQueryable<ProblemInventory> GetProblemInventories();
        int Delete(int id);
        ProblemInventory Update(ProblemInventory problemInventory, int id);
        ProblemInventory Insert(ProblemInventory problemInventory);
        void SaveChanges();

    }
}