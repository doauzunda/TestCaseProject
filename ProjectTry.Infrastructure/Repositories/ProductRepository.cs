using ProjectTry.Infrastructure.Repositories;
using ProjectTry.Core.Interfaces;
using ProjectTry.Core.Models;

namespace ProjectTry.Repositories
{
    public class ProductRepository : GenericRepository<ProductDetails>, IProductRepository
    {

        public ProductRepository(DbContextClass dbContext) : base(dbContext)
        {

        }

    }
}
