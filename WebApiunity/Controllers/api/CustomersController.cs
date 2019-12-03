using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiunity.Models;
using WebApiunity.Repository;

namespace WebApiunity.Controllers.api
{
    public class CustomersController : ApiController
    {
        ICustomerRepository Repository;
        public CustomersController(ICustomerRepository repository)
        {
            this.Repository = repository;
        }
        [HttpGet]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return Repository.GetAll();
        }
        [HttpGet]
        public IHttpActionResult GetCustomerById(int? id)
        {
            if(id==null)
            {
                return BadRequest();
            }
            var customer = Repository.GetById(id.Value);
            if(customer==null)
            {
                return NotFound();
            }
            return Ok(customer);
        }
    }
}
