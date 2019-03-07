using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Aram.Model
{
    public class Problem
    {
        [Key]
        public int problemID { get; set; }
        [MaxLength(15)]
        public string name { get; set; }
        List<ProblemInventory> problemInventories {get; set;}
    }
}