using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using eManager.Domain;

namespace eManager.Web.Infrastructure
{
    public class GameDb : DbContext, IGameDataSource
    {

        public GameDb() : base("DefaultConnection")
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Game> Games { get; set; }

        void IGameDataSource.Save()
        {
            SaveChanges();
        }

        IQueryable<Employee> IGameDataSource.Employees
        {
            get {return Employees;}
        }

        IQueryable<Game> IGameDataSource.Games
        {
            get { return Games; }            
        }
    }
}