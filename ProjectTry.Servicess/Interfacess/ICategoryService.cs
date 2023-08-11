using ProjectTry.Coree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTry.Servicess.Interfacess
{
    public interface ICategoryService
    {

        Task<bool> CreateCategory(Category categoryDetails);

        Task<IEnumerable<Category>> GetAllCategories();

        Task<Category> GetCategoryById(int categoryId);

        Task<bool> UpdateCategory(Category categoryDetails);

        Task<bool> DeleteCategory(int categoryId);

    }
}
