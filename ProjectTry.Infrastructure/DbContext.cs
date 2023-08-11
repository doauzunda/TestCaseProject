using System.Collections.Generic;

namespace ProjectTry
{
    public class DbContext : DbContext
    {

        public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
        {
        }

        public DbSet<ProductDetails> Products { get; set; }

    }
}
