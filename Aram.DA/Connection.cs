using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Aram.IDataAccess;

namespace PostgreSQL
{
    public class EntityContext : DbContext , IAramContext
    {
        
        //------------Products-------------------
        public DbSet<Inventory> inventory { get; set; }
        public DbSet<Kind> kind { get; set; }
        public DbSet<Problem> problem { get; set; }
        public DbSet<ProblemInventory> problemInventory { get; set; }
        public DbSet<Status> status { get; set; }
        public DbSet<User> user { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Server=127.0.0.1;Port=5432;Database=Aram;Userid=pourya;");
    }
}