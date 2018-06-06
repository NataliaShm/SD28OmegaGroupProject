using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupProject.Models;
using Microsoft.EntityFrameworkCore;



namespace GroupProject.Data
{
    public class RestaurantContext: DbContext
    {
        public RestaurantContext(DbContextOptions<RestaurantContext> options)
            : base(options)
        {
        }

        public DbSet<Food> Foods { get; set; }
        public DbSet<Restaurants> Restaurants { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().ToTable("tbFood");
            modelBuilder.Entity<Restaurants>().ToTable("tbRestaurants");
            modelBuilder.Entity<Location>().ToTable("tbLocation");
        }

    }
}
