using ProjectTry.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectTry.Coree.Models;
using ProjectTry.Coree.Interfaces;

namespace ProjectTry.Infrastructuree.Repositories
{
    internal class CategoryRepository : GenericRepository<Category>, ICategoryRepository 
    {

        public CategoryRepository(DbContextClass dbContext) : base(dbContext)
        {

        }

    }
}
