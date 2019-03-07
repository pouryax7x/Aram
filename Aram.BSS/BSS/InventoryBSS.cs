using System.Linq;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IBSS;
using Aram.IDataAccess;
using System.Collections.Generic;
using System;

namespace Aram.BSS
{


    public class InventoryBSS : IInventoryBSS
    {
        IInventoryDA _inventoryDA;
        IStatusBSS _status;
        IKindBSS _kind;
        IProblemInventoryBSS _problemInventory;
        IUserBSS _user;
        public InventoryBSS(IInventoryDA inventoryDA 
        , IStatusBSS statusBSS
        ,IKindBSS kindBSS
        ,IProblemInventoryBSS problemInventoryBSS
        ,IUserBSS userBSS)
        {
            _inventoryDA = inventoryDA;
            _status = statusBSS;
            _kind = kindBSS;
            _problemInventory = problemInventoryBSS;
            _user = userBSS;
        }
        private IQueryable<Inventory> GetInventories() => _inventoryDA.GetInventories()
        .Include(x => x.kind)
        .Include(x => x.user)
        .Include(x => x.status)
        .Include(x => x.problemInventories)
            .ThenInclude(x => x.problem);
        public IQueryable<Inventory> GetAll() => GetInventories();
        public IQueryable<Inventory> GetById(int id) => GetInventories().Where(x => x.inventoryID == id);
        public IQueryable<Inventory> GetByName(string Name) => GetInventories().Where(x => x.name.Contains(Name));
        public IQueryable<Inventory> GetByIdOrName(string Data)
        {
            if (int.TryParse(Data, out int Number))
            {
                return GetById(Number);
            }
            else
            {
                return GetByName(Data);
            }
        }
        public int Delete(int id) => _inventoryDA.Delete(id);
        public Inventory Update(Inventory inventory, int id) => _inventoryDA.Update(inventory, id);
        public Inventory Insert()
        {    Inventory inventory = new Inventory();
            inventory.name = "علی اصغر تقرب";
            inventory.kind = _kind.GetById(1).SingleOrDefault();
            inventory.tel = "09122334545";
            inventory.discription = "سلام بر تو";
            //inventory.problemInventories = _problemInventory.GetAll().ToList();
            inventory.user = _user.GetById(1).SingleOrDefault();
            //////////////////
            inventory.cost = 0;
            
            inventory.status = _status.GetById(1).SingleOrDefault();
            inventory.registerDateTime = DateTime.Now;
            var a = _inventoryDA.Insert(inventory);
            _inventoryDA.SaveChanges();

            return GetById(a.inventoryID).SingleOrDefault();
        }
        public void SaveChanges() => _inventoryDA.SaveChanges();

    }
}