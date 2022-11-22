using CRUD_Api.Dto;
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
            try
            {
                var data = await _productServise.GetProductsAsync();
                if (data == null)
                {
                    return NotFound();
                }
                return Ok(data);
            }
            catch
            {
                return BadRequest("Internal server error");
            }
        
        }

        [HttpGet("{id}") ]
        public async Task< IActionResult> GetProductById(int id)
        {
            try
            {
                var product = await _productServise.GetById(id);
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch
            {
                 return StatusCode(500,"Internal Server Error");

            }



        }
       
        [HttpPost("Add")]
       
        public async Task<IActionResult> AddProduct(ProductDto product)
        {
           
            if (product == null){ return BadRequest(); }

            if (ModelState.IsValid)
            {
                var result = await _productServise.AddProductsAsync(product);
                if (result == null)
                {

                    return StatusCode(StatusCodes.Status500InternalServerError,
                   "Error creating new product");
                }
                return Ok(result);
            }
           
            return BadRequest();  
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCliet(int id, [FromBody] ProductDto product)

        {
            var data = await _productServise.UpdateProductsAsync(id,product);
            if(data==null){ return NotFound(); }
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
