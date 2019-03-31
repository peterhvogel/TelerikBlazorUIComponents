using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Customers.Common;
using Microsoft.AspNetCore.Mvc;

namespace CustomerService.Controllers
{
    [Route("Customers")]
    [ApiController]
    public class Customers : ControllerBase
    {
        List<Customer> custs = new List<Customer>();
        public Customers()
        {
            custs.Add(new Customer
            {
                Id = 1,
                FirstName = "Peter",
                LastName = "Vogel"
            });
            custs.Add(new Customer
            {
                Id = 2,
                FirstName = "Jan",
                LastName = "Vogel"
            });
            custs.Add(new Customer
            {
                Id = 3,
                FirstName = "Jason",
                LastName = "van de Velde"
            });
            custs.Add(new Customer
            {
                Id = 4,
                FirstName = "Christopher",
                LastName = "Vogel"
            });
            custs.Add(new Customer
            {
                Id = 5,
                FirstName = "James",
                LastName = "Vogel"
            });
            custs.Add(new Customer
            {
                Id = 6,
                FirstName = "Elliott",
                LastName = "Vogel"
            });
            custs.Add(new Customer
            {
                Id = 7,
                FirstName = "Pierre",
                LastName = "St. Cyr"
            });

        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return custs;
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return custs.First(c => c.Id == id);
        }

        [HttpPost]
        public void Post([FromBody] Customer cust)
        {
            custs.Add(cust);
        }

        [HttpPut()]
        public void Put([FromBody] Customer custParm)
        {
            Customer cust;
            cust = custs.First(c => c.Id == custParm.Id);
            cust = custParm;
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            custs.RemoveAll(c => c.Id == id);
        }
    }
}
