using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Aram.Model
{
    public class Kind
    {
        [Key]
        public int kindID { get; set; }
        [MaxLength(15)]
        public string name { get; set; }
    }
}