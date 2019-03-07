
using System;
using System.Linq;
using Aram.DA;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using PostgreSQL;
using Aram.IDataAccess;

namespace Aram.DA
{


    public class InventoryDA : BaseDA<Inventory> , IInventoryDA
    {
        public InventoryDA(IAramContext db) : base(db)
        {
        }
        public IQueryable<Inventory> GetInventories() => base.GetAll();
        public new int Delete(int id) => base.Delete(id);
        public new Inventory Update(Inventory inventory, int id) => base.Update(inventory, id);
        public new Inventory Insert(Inventory inventory) => base.Insert(inventory);
        public new void SaveChanges() => base.SaveChanges();

    }
}