using CRUD_Api.CRUD.BLL;
using CRUD_Api.Dto;
using CRUD_Api.Models;
using CRUD_Api.services;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Api.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController :ControllerBase
    {

        private readonly IProductServise _productServise;

       
        public ProductController(IProductServise productServise)
        {
            _productServise = productServise;

        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _productServise.GetProductsAsync()); 
        }


       
        [HttpPost("Add")]
        public async Task<IActionResult> AddProduct(ProductDto product)
        {
            
          if(product == null){ return BadRequest(); }
               
            
          var result = await _productServise.AddProductsAsync(product);
          if(result==null){

                return StatusCode(StatusCodes.Status500InternalServerError,
               "Error creating new product5");
             }

            return Ok(result);  
        }
      
        [HttpPut("{id}")]
        public async Task< IActionResult> UpdateCliet(int id, [FromBody] ProductDto product)
        {
            var data = await _productServise.UpdateProductsAsync(id,product);
            return Ok(data);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteClient(int id)
        {
            var data = await _productServise.DeleteProductAsync(id);
           
            return  data!=null ? Ok(data):NotFound("Not Found");

          


          
        }

      
    }
}
