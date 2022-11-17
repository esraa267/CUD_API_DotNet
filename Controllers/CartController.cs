using CRUD_Api.Models;
using CRUD_Api.services;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartservice _cartServise;
        public CartController(ICartservice cartServise)
        {
            _cartServise = cartServise;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _cartServise.GetCartAsync());
        }
        [HttpPost]
        public async Task <IActionResult> AddCartAsync(Cart cart)
        {
            var res = await _cartServise.AddCartAsync(cart);
            return Ok(res);    
        }
    }
}
