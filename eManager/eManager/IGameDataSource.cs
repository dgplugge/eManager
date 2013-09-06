using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eManager.Domain
{
    public interface IGameDataSource
    {
         IQueryable<Team> Teams { get; }
         IQueryable<Game> Games { get; }
         void Save();
    }
}