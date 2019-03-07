
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IDataAccess;

namespace Aram.IDataAccess
{


    public interface IInventoryDA
    {
        IQueryable<Inventory> GetInventories();
        int Delete(int id);
        Inventory Update(Inventory inventory, int id);
        Inventory Insert(Inventory inventory);
        void SaveChanges();

    }
}