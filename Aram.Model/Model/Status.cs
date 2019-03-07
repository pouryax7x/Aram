using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Aram.Model
{
    public class Status
    {
        [Key]
        public int statusID { get; set; }
        [MaxLength(15)]
        public string name { get; set; }
    }
}