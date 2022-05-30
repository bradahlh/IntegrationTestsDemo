using System;
using Microsoft.AspNetCore.Mvc;
using OrderAPI.Models;

namespace OrderAPI.Services
{
	public class CustomerService : ICustomerService
	{
        private readonly IHttpClientFactory factory;
        private HttpClient client;

        public CustomerService([FromServices] IHttpClientFactory factory, HttpClient client)
		{
            this.factory = factory;
            this.client = client;
        }

        public async Task<Customer> GetCustomerAsync(int customerId)
        {
            var invoice = new Invoice();

            // Add customer data to invoice
            string customerUri = $"api/customer/{customerId}";

            HttpClient client = factory.CreateClient(name: "CustomerAPI");

            HttpRequestMessage request = new(
                method: HttpMethod.Get, requestUri: customerUri);

            HttpResponseMessage response = await client.SendAsync(request);

            Customer? customer = await response.Content.ReadFromJsonAsync<Customer>();

            return customer;
        }
    }
}
