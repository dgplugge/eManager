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

        public DbSet<Team> Teams { get; set; }
        public DbSet<Game> Games { get; set; }

        void IGameDataSource.Save()
        {
            SaveChanges();
        }

        IQueryable<Team> IGameDataSource.Teams
        {
            get {return Teams;}
        }

        IQueryable<Game> IGameDataSource.Games
        {
            get { return Games; }            
        }
    }
}