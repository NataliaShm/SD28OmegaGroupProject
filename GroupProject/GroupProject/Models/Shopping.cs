using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Shopping
    {
        public int ShoppingId { get; set; }

        public string ShoppingType { get; set;}

        public ICollection<Store> Stores { get; set; }

    }
}
