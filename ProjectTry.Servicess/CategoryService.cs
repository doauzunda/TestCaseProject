using ProjectTry.Coree.Interfaces;
using ProjectTry.Coree.Models;
using ProjectTry.Servicess.Interfacess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTry.Servicess
{
    public class CategoryService : ICategoryService
    {

        public IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateCategory(Category categoryDetails)
        {
            if (categoryDetails != null)
            {
                await _unitOfWork.Categories.Add(categoryDetails);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }



        public async Task<bool> DeleteCategory(int categoryId)
        {
            if (categoryId > 0)
            {
                var categoryDetails = await _unitOfWork.Products.GetById(categoryId);
                if (categoryDetails != null)
                {
                    _unitOfWork.Products.Delete(categoryDetails);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            var categoryDetailsList = await _unitOfWork.Categories.GetAll();
            return categoryDetailsList;
        }

        public async Task<Category> GetCategoryById(int categoryId)
        {
            if (categoryId > 0)
            {
                var categoryDetails = await _unitOfWork.Categories.GetById(categoryId);
                if (categoryDetails != null)
                {
                    return categoryDetails;
                }
            }

            return null;

        }

        public async Task<bool> UpdateCategory(Category categoryDetails)
        {
            if (categoryDetails != null)
            {
                var category = await _unitOfWork.Products.GetById(categoryDetails.Id);
                if (category != null)
                {
                    
                    category.Name = categoryDetails.Name;
                    category.Description = categoryDetails.Description;

                    _unitOfWork.Products.Update(category);

                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;

        }

    }
}
