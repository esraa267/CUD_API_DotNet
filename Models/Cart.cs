using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Api.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public ICollection<CartProduct>? CartProducts { get; set; }
        public int? Quantity { get; set; }
    }
}
