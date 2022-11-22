using System.ComponentModel.DataAnnotations;

namespace CRUD_Api.Dto
{
    public class ProductDto
    {

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Price is required")]
        public string? Price { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string? Description { get; set; }
    }
}
