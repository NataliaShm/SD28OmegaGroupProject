﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupProject.Models
{
    public class Store
    {
        public int StoreId { get; set; }

        public string StoreName { get; set; }

        public string StoreDescription { get; set; }

        public int ShoppingId { get; set; }

        public int LocationId { get; set; }
    }
}
