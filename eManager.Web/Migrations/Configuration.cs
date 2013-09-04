namespace eManager.Web.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using eManager.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<eManager.Web.Infrastructure.GameDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(eManager.Web.Infrastructure.GameDb context)
        {

            context.Games.AddOrUpdate(d => d.Venue,
                new Game { Venue = "Yankee Stadium"},
                new Game { Venue = "Camden Yards"},
                new Game { Venue = "Fenway Feild"},
                new Game { Venue = "Comerica Park"}
                );
        }

        
        }
    }

