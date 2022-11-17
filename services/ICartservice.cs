using CRUD_Api.Models;

namespace CRUD_Api.services
{
    public interface ICartservice
    {
        Task<IEnumerable<Cart>> GetCartAsync();
        Task<Cart> AddCartAsync(Cart cart);

    }
}
