
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using System.Collections.Generic;

namespace Aram.IBSS
{


    public interface IProblemInventoryBSS
    {
        IQueryable<ProblemInventory> GetAll();
        IQueryable<ProblemInventory> GetById(int id);
        int Delete(int id);
        ProblemInventory Update(ProblemInventory problemInventory, int id);
        ProblemInventory Insert(ProblemInventory problemInventory);
        void SaveChanges();

    }
}