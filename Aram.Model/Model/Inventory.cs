using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aram.Model
{
    public class Inventory
    {
        [Key]
        public int inventoryID { get; set; }
        [MaxLength(25)]
        public string name { get; set; }
        public Kind kind{ get; set; } 
        [MaxLength(11)]
        public string tel { get; set; }
        public int cost { get; set; }
        [MaxLength(250)]
        public string discription { get; set; }
        public User user { get; set; }
        public Status status { get; set; }
        public DateTime registerDateTime { get; set; }
        public DateTime? readyDateTime { get; set; }
        public DateTime? deliverDateTime { get; set; }
        public DateTime? checkOutDateTime { get; set; }
        public List<ProblemInventory> problemInventories { get; set; }
        
    }
}