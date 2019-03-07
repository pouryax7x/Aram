using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Aram.Model;
using Aram.BSS;
using PostgreSQL;
using Aram.IBSS;

[Route("api/[controller]")]
public class InventoryController : ControllerBase
{
    private readonly IInventoryBSS _inventoryBss;

    public InventoryController(IInventoryBSS inventoryBss)
    {
        this._inventoryBss = inventoryBss;
    }

    // GET api/Inventory
    [HttpGet("")]
    public ActionResult<List<Inventory>> GetInventorys()
    {
        return _inventoryBss.GetAll().ToList();
    }

    [HttpGet("{Data}")]
    public ActionResult<List<Inventory>> GetInventory(string Data)
    {
          return _inventoryBss.GetByIdOrName(Data).ToList();  
    }
    [HttpPost("")]
    public ActionResult<Inventory> InsertInventory()
    {
          return _inventoryBss.Insert();  
    }
    // [HttpGet("{id}")]
    // public ActionResult<List<Inventory>> GetInventorysSubCat(int id)
    // {
    //     using (EntityContext _db = new EntityContext())
    //     {
    //         InventoryBL _cat = new InventoryBL(_db);
    //         return _cat.GetSubInventory(id).ToList();
    //     }
    // }
    // // POST api/values
    // [HttpPost]
    // public void Post([FromBody] string value)
    // {
    // }

    // // PUT api/values/5
    // [HttpPut("{id}")]
    // public void Put(int id, [FromBody] string value)
    // {
    // }

    // // DELETE api/values/5
    // [HttpDelete("{id}")]
    // public void Delete(int id)
    // {
    // }
}