using CRUD_Api.Dto;
using CRUD_Api.Models;

namespace CRUD_Api.services
{
    public interface IOrderservice
    {
        Task<Order> AddCartAsync(OrderProductDto cart);

    }
}
