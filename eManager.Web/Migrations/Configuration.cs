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

            context.Games.AddOrUpdate(d => d.Name,
                new Game { Name = "Yankee Stadium"},
                new Game { Name = "Camden Yards"},
                new Game { Name = "Fenway Feild"},
                new Game { Name = "Comerica Park"}
                );
        }

        
        }
    }

