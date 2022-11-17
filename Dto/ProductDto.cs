using System.ComponentModel.DataAnnotations;

namespace CRUD_Api.Dto
{
    public class ProductDto
    {
        public string? Name { get; set; }
        public string? Price { get; set; }
        public string? Description { get; set; }
    }
}
