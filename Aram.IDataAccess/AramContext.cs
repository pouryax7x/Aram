using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Aram.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Aram.IDataAccess
{
    public interface IAramContext
    {

        //------------Products-------------------
        DbSet<Inventory> inventory { get; set; }
        DbSet<Kind> kind { get; set; }
        DbSet<Problem> problem { get; set; }
        DbSet<ProblemInventory> problemInventory { get; set; }
        DbSet<Status> status { get; set; }
        DbSet<User> user { get; set; }
        DbSet<TEntity> Set<TEntity>() where TEntity : class;
        EntityEntry<TEntity> Remove<TEntity>(TEntity entity) where TEntity : class;
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        int SaveChanges();

    }
}