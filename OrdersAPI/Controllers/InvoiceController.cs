using Microsoft.AspNetCore.Mvc;
using OrderAPI.Models;
using OrderAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderAPI.Controllers
{
    // TODO: Should this be its own controller, or part of the OrderController?
    [Route("api/[controller]")]
    public class InvoiceController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        private readonly IProductService _productService;

        public InvoiceController(ICustomerService customerService, IProductService productService)
        {
            _customerService = customerService;
            _productService = productService;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Invoice>> GenerateInvoice(Order invoiceOrder)
        {
            var invoice = new Invoice();
            invoice.Id = Guid.NewGuid().ToString();

            // Add customer data to invoice
            var customer = await _customerService.GetCustomerAsync(invoiceOrder.CustomerId);

            if (customer is null)
            {
                return BadRequest();
            }
            invoice.FullName = $"{customer.FirstName} {customer.LastName}";
            invoice.Address = $"{customer.ZipCode} {customer.City}";

            // Add product data to invoice
            var product = await _productService.GetProductAsync(invoiceOrder.ProductId);

            if (product is null)
            {
                return BadRequest();
            }
            invoice.ProductName = product.ProductName;
            invoice.PaymentPrice = product.Price * invoiceOrder.Quantity;


            // Add other data to invoice
            invoice.PurchaseTime = invoiceOrder.PurchaseTime;
            invoice.DueDate = invoiceOrder.PurchaseTime.AddDays(14);

            return Ok(invoice);
        }
    }
}
