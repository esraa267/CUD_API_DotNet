using CRUD_Api.Models;

namespace CRUD_Api.CRUD.BLL
{
    public interface IOrderRepo
    {
      //  Task<IEnumerable<Cart>> GetCartAsync();
        Task<Order> AddAsync(Order cart);
        Task AddListAsync(List<OrderProduct> products);
    }
}
