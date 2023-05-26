using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using microservices.Models;
namespace microservices.DB_Context
{
    public class ProductContect : DbContext
    {
        public ProductContect(DbContextOptions<ProductContect> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category
            {
                ID = 1,
                Name = "Electronics",
                Description = "Electronic Items",
            },
            new Category
            {
                ID = 2,
                Name = "Clothes",
                Description = "Dresses",
            },
            new Category
            {
                ID = 3,
                Name = "Grocery",
                Description = "Grocery Items",
            }
            );
        }


    }
}
