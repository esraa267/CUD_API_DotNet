using CRUD_Api.CRUD.BLL;
using CRUD_Api.CRUD.EF.Data;
using CRUD_Api.Dto;
using CRUD_Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace CRUD_Api.services
{
    public class ProductServise : IProductServise
    {

        private readonly IProductRepo _productRepo;
 
        public ProductServise(IProductRepo productRepo, ApplicationDBContext context)
        {

            _productRepo = productRepo;

        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var result = await _productRepo.GetAllAsync();

            if (result is not null) return result;
            throw new Exception();
        }
        public async Task<ProductDto> AddProductsAsync(ProductDto product)
        {
            var result = await _productRepo.AddAsync(product);
          
            return result;
        }

        public async Task<Product> UpdateProductsAsync(int id,ProductDto product)
           
        {
            var Product = await _productRepo.GetByIdAsync(id);
                if (Product is not null)
                {
                    Product.Name = product.Name!;
                    Product.Price = product.Price!;
                    Product.Description = product.Description!;
            }
            return await _productRepo.Update(Product!);
        }

        public async Task<Product> DeleteProductAsync(int id)
        {
                      
                var result = await  _productRepo.GetByIdAsync(id);
                if (result is not null)
                    return await _productRepo.Delete(result!);
                else
                    return result!;
            

         //   throw new ArgumentNullException("Id is required");
        }







    }
}
