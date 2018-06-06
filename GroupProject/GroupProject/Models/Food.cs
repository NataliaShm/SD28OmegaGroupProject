using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Food
    {
        public int FoodId { get; set; }
        public string FoodType { get; set; }

        public ICollection<Restaurants> Restaurants { get; set; }

    }
}
