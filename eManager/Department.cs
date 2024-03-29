﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eManager.Domain
{
    public class Department
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}