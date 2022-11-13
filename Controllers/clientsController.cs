using CRUD_Api.Models;
using CRUD_Api.services;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Api.Controllers
{
  
    [Route("api/[controller]")]
    [ApiController]
    public class clientsController :ControllerBase
    {
        [HttpGet]
        public  ActionResult<List<clients>> Get()
        {
           
            return Ok(clientServise.GetAll());
        }
        [HttpGet("{id}")]
        public ActionResult<List<clients>> Get(int id)
        {
            var res = clientServise.GetById(id);
            if (res == null)
            {
                return BadRequest("client not found");
            }
            return Ok(res);
        }
        [HttpPost]
        public ActionResult<List<clients>> Add(clients data)
            
        {
            clientServise.Add(data);


            return Ok(data);
        }

        [HttpPut]
        public ActionResult<List<clients>>Update(clients data)


        {
            var res = clientServise.Update(data);
            if (res == null)
            {
                return BadRequest("client not found");
            }
        
            return Ok(data);
        }
        [HttpDelete("{id}")]
        public ActionResult<List<clients>> Delete(int id)


        {
            var res =  clientServise.Delete(id);
            if (res == null)
            {
                return BadRequest("client not found");
            }

   
            return Ok(res);
        }
    }
}
