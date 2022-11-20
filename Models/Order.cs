using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Api.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int? Quantity { get; set; }

      
    
    }
}
