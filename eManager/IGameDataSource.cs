using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eManager.Domain
{
    public interface IGameDataSource
    {
         IQueryable<Employee> Employees { get; }
         IQueryable<Game> Games { get; }
         void Save();
    }
}