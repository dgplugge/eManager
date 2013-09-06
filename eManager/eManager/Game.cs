using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eManager.Domain
{
    public class Game
    {
        public virtual int Id { get; set; }
        public virtual string Venue { get; set; }
        public virtual Team Home { get; set; }
        public virtual DateTime? GameTime { get; set; }
    }
}