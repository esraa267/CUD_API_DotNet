using CRUD_Api.Models;

namespace CRUD_Api.CRUD.BLL
{
    public interface ICartRepo
    {
        Task<IEnumerable<Cart>> GetCartAsync();
        Task<Cart> AddAsync(Cart cart);
    }
}
