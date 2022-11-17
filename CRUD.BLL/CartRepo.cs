using CRUD_Api.CRUD.EF.Data;
using CRUD_Api.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace CRUD_Api.CRUD.BLL
{
    public class CartRepo:ICartRepo
    {
        private readonly ApplicationDBContext _context;
        public CartRepo(ApplicationDBContext context)
        {

            _context = context;

        }
        public async Task<IEnumerable<Cart>> GetCartAsync()
        {

            return await _context.carts!.ToListAsync();
        }

        public async Task<Cart> AddAsync(Cart cart)
        {
            await _context.carts!.AddAsync(cart);
            await _context.SaveChangesAsync();


            return cart;
        }
    }
}
