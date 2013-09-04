using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eManager.Domain
{
    public class Team
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual DateTime? HireDate { get; set; }
    }
}