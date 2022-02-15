using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assesment_QW.Models
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        // GET: api/<WebApiController>
        [HttpGet]

        public string Get()
        {
            DBhandle db = new DBhandle();
            List<Customer> listP = db.getAllRecords();
            return JsonConvert.SerializeObject(listP);

        }

       


        // GET api/<WebApiController>/5
        
        [Route("getrecord")]
        public Customer Get(int id)
        {
            DBhandle db = new DBhandle();
            Customer cus = db.getCustomerOnId(id);
            return cus;
        }


        // POST api/<WebApiController>
        [HttpPost]
        [Route("register")]
        public void Post(Customer c)
        {
            DBhandle db = new DBhandle();
            db.AddCustomer(c);
            return;
        }


        // PUT api/<WebApiController>/5
        [HttpPut]
        public String Put(Customer c)
        {
            DBhandle db = new DBhandle();
            return db.updateCustomer(c);
            
        }


        // DELETE api/<WebApiController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            DBhandle db = new DBhandle();
            db.deleteCustomer(id);
            return;
        }

    }
}
