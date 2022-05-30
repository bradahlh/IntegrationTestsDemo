using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private List<Order> orders = new List<Order>
        {

            new Order(1, 3, 2, 1, new DateTime(2022, 5, 22, 15, 23, 45)),
            new Order(2, 3, 5, 2, new DateTime(2022, 5, 15, 22, 50, 5)),
            new Order(3, 5, 4, 1, new DateTime(2022, 4, 29, 10, 42, 22))
        };

        // GET: api/values
        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetAllOrders()
        {
            return Ok(orders);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(int id)
        {
            var order = orders.Find(o => o.OrderId == id);
            if (order is null)
            {
                return BadRequest("Order not found.");
            }
            return Ok(order);
        }

        //// POST api/values
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
