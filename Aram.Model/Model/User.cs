using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Aram.Model
{
    public class User
    {
        [Key]
        public int userID  { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}