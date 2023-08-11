using Microsoft.EntityFrameworkCore;
using ProjectTry.Coree.Models;

using System.Collections.Generic;

namespace ProjectTry.Infrastructuree
{
    public class DbContextClass : DbContext
    {

        public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
