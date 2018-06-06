using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public String LocationName { get; set; }

        public ICollection<Restaurants> Restaurants { get; set; }

    }
}
