using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eManager.Domain
{
    public interface IDepartmentDataSource
    {
         IQueryable<Employee> Employees { get; }
         IQueryable<Department> Departments { get; }
         void Save();
    }
}