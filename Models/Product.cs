using System.ComponentModel.DataAnnotations;

namespace CRUD_Api.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        public string? Name { get; set; }
      
        public string? Price { get; set; }
        public string? Description { get; set; }

       
    }
}
