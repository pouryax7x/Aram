
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using System.Collections.Generic;

namespace Aram.IBSS
{


    public interface IInventoryBSS
    {
        IQueryable<Inventory> GetAll();
        IQueryable<Inventory> GetById(int id);
        IQueryable<Inventory> GetByName(string Name);
        IQueryable<Inventory> GetByIdOrName(string Data);
        int Delete(int id);
        Inventory Update(Inventory inventory, int id);
        Inventory Insert();//Inventory inventory
        void SaveChanges();

    }
}