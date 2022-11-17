using System.ComponentModel.DataAnnotations;

namespace CRUD_Api.Models
{
    public class CartProduct
    {
        public int CartId { get; set; }
        public Cart? Cart { get; set; }
        
        public int ProductId { get; set; }
        public Product? Product { get; set; }

    }
}
