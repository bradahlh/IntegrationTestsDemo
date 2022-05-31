using Microsoft.AspNetCore.Mvc;
using OrderAPI.Models;

namespace OrderAPI.Services
{
    public class CustomerService : ICustomerService
	{
        private readonly IHttpClientFactory factory;

        public CustomerService([FromServices] IHttpClientFactory factory)
		{
            this.factory = factory;
        }

        public async Task<Customer> GetCustomerAsync(int customerId)
        {
            // Add customer data to invoice
            string customerUri = $"api/customer/{customerId}";

            HttpClient client = factory.CreateClient(name: "CustomerAPI");

            HttpRequestMessage customerRequest = new(
                method: HttpMethod.Get, requestUri: customerUri);

            HttpResponseMessage customerResponse = await client.SendAsync(customerRequest);

            Customer? customer = await customerResponse.Content.ReadFromJsonAsync<Customer>();

            return customer;
        }
    }
}
