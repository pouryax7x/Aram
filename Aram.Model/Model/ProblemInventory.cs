using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Aram.Model
{
    public class ProblemInventory
    {
        [Key]
        public int problemInventoryID { get; set; }
        public Inventory inventory { get; set; }
        public Problem problem { get; set; }
    }
}