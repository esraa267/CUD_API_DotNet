using CRUD_Api.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Api.Dto
{
    public class OrderProductDto
    {

     public Order? Order { get; set; }  

     public List<OrderProduct>? OrderProduct { get; set; } 
    }
}
