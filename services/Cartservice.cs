using CRUD_Api.CRUD.BLL;
using CRUD_Api.Models;

namespace CRUD_Api.services
{
    public class Cartservice : ICartservice
    {

        private readonly ICartRepo _cartRepo;
        public Cartservice(ICartRepo cartRepo)
        {

            _cartRepo = cartRepo;

        }
        public async Task<IEnumerable<Cart>> GetCartAsync()
        {
         var result =   await _cartRepo.GetCartAsync();
            return result;

        }

        public async Task<Cart> AddCartAsync(Cart cart)
        {
            var result = await _cartRepo.AddAsync(cart);
           
            return result;
        }
    }
}
