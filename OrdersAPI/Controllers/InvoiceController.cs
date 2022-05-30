using Microsoft.AspNetCore.Mvc;
using OrderAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderAPI.Controllers
{
    // TODO: Should this be its own controller, or part of the OrderController?
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly IHttpClientFactory clientFactory;

        public InvoiceController(IHttpClientFactory httpClientFactory)
        {
            clientFactory = httpClientFactory;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Invoice>> GenerateInvoice(Order invoiceOrder)
        {


            if (customer is null)
            {
                return BadRequest();
            }
            invoice.FullName = $"{customer.FirstName}-{customer.LastName}";
            invoice.Address = $"{customer.ZipCode} {customer.City}";

            return Ok(invoice);

            // Add product data to invoice
            

            // Add other data to invoice


            // Generate invoice
            
        }
    }
}
