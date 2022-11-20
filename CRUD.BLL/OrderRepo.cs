using CRUD_Api.CRUD.EF.Data;
using CRUD_Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace CRUD_Api.CRUD.BLL
{
    public class OrderRepo:IOrderRepo
    {
        private readonly ApplicationDBContext _context;
        public OrderRepo(ApplicationDBContext context)
        {
            _context = context;
        }
       
        public async Task<Order> AddAsync(Order cart)
        {
            await _context.carts!.AddAsync(cart);
            await _context.SaveChangesAsync();


            return cart;
        }

        public async Task AddListAsync(List<OrderProduct> products)
        {
            await _context.AddRangeAsync(products);
            await _context.SaveChangesAsync();  

        }

      
    }
}
