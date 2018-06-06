using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Restaurants
    {
        public int RestaurantId { get; set; }
        public string RestaurantName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string ContactNo { get; set; }
        public int FoodId { get; set; }
        public int LocationId { get; set; }

    }
}
