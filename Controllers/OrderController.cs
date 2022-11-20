using CRUD_Api.Dto;
using CRUD_Api.Models;
using CRUD_Api.services;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderservice _cartServise;
        public OrderController(IOrderservice cartServise)
        {
            _cartServise = cartServise;

        }

      
        [HttpPost]
        public async Task <IActionResult> AddCartAsync(OrderProductDto model)
        {
            var res = await _cartServise.AddCartAsync(model);
            return Ok(res);    
        }

       
    }
}
