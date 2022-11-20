using CRUD_Api.Dto;
using CRUD_Api.Models;
using System.Linq.Expressions;

namespace CRUD_Api.CRUD.BLL
{
    public interface IProductRepo
    {
        Task<IEnumerable<Product>> GetAllAsync();

        Task<Product> GetByIdAsync(int id);
        Task<ProductDto> AddAsync(ProductDto product);
       Task<Product> Update(Product product);
        Task<Product> Delete(Product product);



    }
}
