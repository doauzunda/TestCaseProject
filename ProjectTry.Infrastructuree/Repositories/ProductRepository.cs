using ProjectTry.Infrastructure.Repositories;

using ProjectTry.Coree.Models;
using ProjectTry.Coree.Interfaces;

namespace ProjectTry.Infrastructuree.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(DbContextClass dbContext) : base(dbContext)
        {

        }

    }
}
