using CRUD_Api.CRUD.BLL;
using CRUD_Api.Dto;
using CRUD_Api.Models;
using System.Net;

namespace CRUD_Api.services
{
    public class ProductServise : IProductServise
    {

        private readonly IProductRepo _productRepo;
        public ProductServise(IProductRepo productRepo)
        {

            _productRepo = productRepo;

        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            var result = await _productRepo.GetAllAsync();

            if (result is not null) return result;
            throw new Exception();
        }
        public async Task<ProductDto> AddProductsAsync(ProductDto product)
        {
            var result = await _productRepo.AddAsync(product);
          
            return result;
        }

        public async Task<ProductDto> UpdateProductsAsync(int id ,ProductDto product)
        {
            // var result = await _productRepo.CheckExists(c => c.Id == id);

            //if (product == null)
            //{
            //    var resp = new HttpResponseMessage(HttpStatusCode.NotFound)
            //    {
            //        Content = new StringContent(string.Format("No product with ID = {0}",id)),
            //        ReasonPhrase = "Client ID Not Found"
            //    };



            //}
            var data = await _productRepo.UpdateAsync(id, product);
            return data;
           
        }

        public async Task<Product> DeleteProductAsync(int? id)
        {
            if (id.HasValue)
            {


                var result = await _productRepo.CheckExists(c => c.Id == id);


                if (result == null) return result;



                var data = await _productRepo.DeleteAsync(result);
                return data;

            }


            throw new ArgumentNullException("Id is required");
        }







    }
}
