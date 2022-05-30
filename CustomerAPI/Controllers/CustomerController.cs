using CustomerAPI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CustomerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer(1, "Andreas", "Bradahl", "2030", "Nannestad"),
            new Customer(2, "Per", "Hansen", "2810", "Gjøvik"),
            new Customer(3, "Berit", "Persen", "0150", "Oslo")
        };

        public CustomerController()
        {
        }

        // GET: api/values
        [HttpGet]
        public ActionResult<List<Customer>> GetCustomer()
        {
            return Ok(customers);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Customer> GetAllCustomers(int id)
        {
            var customer = customers.Find(c => c.Id == id);
            if (customer is null)
            {
                return BadRequest("Customer not found.");
            }

            return Ok(customer);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<List<Customer>> CreateCustomer(Customer customer)
        {
            customers.Add(customer);
            return Ok(customers);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public ActionResult<List<Customer>> UpdateCustomer(Customer paramCustomer)
        {
            var customer = customers.Find(c => c.Id == paramCustomer.Id);
            if (customer is null)
            {
                return BadRequest("Customer not found.");
            }

            //customer = paramCustomer;
            customer.FirstName = paramCustomer.FirstName;
            customer.LastName = paramCustomer.LastName;
            customer.ZipCode = paramCustomer.ZipCode;
            customer.City = paramCustomer.City;

            return Ok(customer);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult<List<Customer>> DeleteCustomer(int id)
        {
            var customer = customers.Find(c => c.Id == id);
            if (customer is null)
            {
                return BadRequest("Customer not found.");
            }

            customers.Remove(customer);
            return Ok(customers);
        }
    }
}

