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

            var team1 = new Team { Name = "Yankees" };
            var team2 = new Team { Name = "Tigers" };
            var team3 = new Team { Name = "Orioles" };
            var team4 = new Team { Name = "Red Sox" };

            context.Games.AddOrUpdate(d => d.Venue,
                new Game { Venue = "Yankee Stadium", Home = team1, GameTime = new DateTime(2001,9,3,9,30,00) },
                new Game { Venue = "Camden Yards", Home = team2, GameTime = new DateTime(2001, 9, 3, 9, 30, 00) },
                new Game { Venue = "Fenway Park", Home = team3, GameTime = new DateTime(2001, 9, 3, 9, 30, 00) },
                new Game { Venue = "Comerica Park", Home = team4, GameTime = new DateTime(2001, 9, 3, 9, 30, 00) }
                );
        }

        
        }
    }

