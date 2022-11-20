using CRUD_Api.CRUD.BLL;
using CRUD_Api.Dto;
using CRUD_Api.Models;

namespace CRUD_Api.services
{
    public class OrderService : IOrderservice
    {

        private readonly IOrderRepo _cartRepo;
        public OrderService(IOrderRepo cartRepo)
        {

            _cartRepo = cartRepo;

        }
   

        public async Task<Order> AddCartAsync(OrderProductDto cart)
        {
            var Order = new Order
            {
                Quantity = cart.Order!.Quantity,
            };
            var result = await _cartRepo.AddAsync(Order);

            var products = new List<OrderProduct>();
            //{
            //    new OrderProduct{

            //       CartId=result.Id,
            //       PtoductId=cart.OrderProduct[0].Id,


            //         } };
            foreach (var product in cart.OrderProduct!)
            {
                products.Add(new OrderProduct
                {
                    CartId = result.Id,
                    PtoductId = product.Id,
                });
            }   

            await _cartRepo.AddListAsync(products);
            return result;
        }
    }
}
