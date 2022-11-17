﻿using CRUD_Api.Dto;
using CRUD_Api.Models;

namespace CRUD_Api.services
{
    public interface IProductServise
    {
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<ProductDto> AddProductsAsync(ProductDto product);
        Task<ProductDto> UpdateProductsAsync(int id ,ProductDto product);
        Task <Product> DeleteProductAsync(int? id);
       
        
       

    }
}
