using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Hotels
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string website { get; set; }
        public string description { get; set; }

        // Navigation property
        // public ICollection<Accomodation> Accomodations { get;set;}

    }
}
