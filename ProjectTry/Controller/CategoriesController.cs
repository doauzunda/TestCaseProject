using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectTry.Coree.Models;
using ProjectTry.Servicess.Interfacess;

namespace ProjectTry.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        public readonly ICategoryService _categoryService;
        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Get the list of product
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCategoryList()
        {
            var categoryDetailsList = await _categoryService.GetAllCategories();
            if (categoryDetailsList == null)
            {
                return NotFound();
            }
            return Ok(categoryDetailsList);
        }

        /// <summary>
        /// Get product by id
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [HttpGet("{categoryId}")]
        public async Task<IActionResult> GetCategoryById(int categoryId)
        {
            var categoryDetails = await _categoryService.GetCategoryById(categoryId);

            if (categoryDetails != null)
            {
                return Ok(categoryDetails);
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Add a new product
        /// </summary>
        /// <param name="categoryDetails"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateCategory(Category categoryDetails)
        {
            var isCategoryCreated = await _categoryService.CreateCategory(categoryDetails);

            if (isCategoryCreated)
            {
                return Ok(isCategoryCreated);
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Update the product
        /// </summary>
        /// <param name="categoryDetails"></param>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(Category categoryDetails)
        {
            if (categoryDetails != null)
            {
                var isCategoryCreated = await _categoryService.UpdateCategory(categoryDetails);
                if (isCategoryCreated)
                {
                    return Ok(isCategoryCreated);
                }
                return BadRequest();
            }
            else
            {
                return BadRequest();
            }
        }

        /// <summary>
        /// Delete product by id
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        [HttpDelete("{productId}")]
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            var isCategoryCreated = await _categoryService.DeleteCategory(categoryId);

            if (isCategoryCreated)
            {
                return Ok(isCategoryCreated);
            }
            else
            {
                return BadRequest();
            }

        }
    }
}
