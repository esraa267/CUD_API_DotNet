using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Api.Models
{
    public class OrderProduct
    {
        [Key]
        public int Id { get; set; }



        public int CartId { get; set; }
        [ForeignKey("CartId")]
        public Order? Cart { get; set; }




        public int PtoductId { get;set; }
        [ForeignKey("PtoductId")]
        public Product? Product { get; set; }

    }
}
