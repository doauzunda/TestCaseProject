﻿using ProjectTry.Coree.Interfaces;
using ProjectTry.Coree.Models;

using ProjectTry.Servicess.Interfacess;

namespace ProjectTry.Servicess
{
    public class ProductService : IProductService
    {

        public IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> CreateProduct(Product productDetails)
        {
            if (productDetails != null)
            {
                await _unitOfWork.Products.Add(productDetails);

                var result = _unitOfWork.Save();

                if (result > 0)
                    return true;
                else
                    return false;
            }
            return false;
        }



        public async Task<bool> DeleteProduct(int productId)
        {
            if (productId > 0)
            {
                var productDetails = await _unitOfWork.Products.GetById(productId);
                if (productDetails != null)
                {
                    _unitOfWork.Products.Delete(productDetails);
                    var result = _unitOfWork.Save();

                    if (result > 0)
                        return true;
                    else
                        return false;
                }
            }
            return false;
        }

        public async Task<IEnumerable<Product>> GetAllProducts()
        {
            var productDetailsList = await _unitOfWork.Products.GetAll();
            return productDetailsList;
        }

        public async Task<Product> GetProductById(int productId)
        {
            if (productId > 0)
            {
                var productDetails = await _unitOfWork.Products.GetById(productId);
                if (productDetails != null)
                {
                    return productDetails;
                }
            }

            return null;
            
        }

        public async Task<bool> UpdateProduct(Product productDetails)
        {
            if (productDetails != null)
            {
                var product = await _unitOfWork.Products.GetById(productDetails.Id);
                if (product != null)
                {
                    product.CategoryId = productDetails.CategoryId;
                    product.Name = productDetails.Name;
                    product.Description = productDetails.Description;
                    product.Price = productDetails.Price;
                    product.Quantity = productDetails.Quantity;
                    product.Unit = productDetails.Unit;

                    _unitOfWork.Products.Update(product);

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
