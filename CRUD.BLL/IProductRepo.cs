using CRUD_Api.Dto;
using CRUD_Api.Models;
using System.Linq.Expressions;

namespace CRUD_Api.CRUD.BLL
{
    public interface IProductRepo
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<ProductDto> AddAsync(ProductDto product);
        Task<ProductDto> UpdateAsync(int id ,ProductDto product);
        Task<Product> CheckExists(Expression<Func<Product, bool>> expression);
        Task<Product> DeleteAsync(Product product);



    }
}
