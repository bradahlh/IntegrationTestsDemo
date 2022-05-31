using Microsoft.AspNetCore.Mvc;
using OrderAPI.Models;

namespace OrderAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IHttpClientFactory factory;

        public ProductService([FromServices] IHttpClientFactory factory)
        {
            this.factory = factory;
        }

        public async Task<Product> GetProductAsync(int productId)
        {
            // Add product data to invoice
            string productUri = $"api/product/{productId}";

            HttpClient client = factory.CreateClient(name: "ProductAPI");

            HttpRequestMessage productRequest = new(
                method: HttpMethod.Get, requestUri: productUri);

            HttpResponseMessage productResponse = await client.SendAsync(productRequest);

            Product? product = await productResponse.Content.ReadFromJsonAsync<Product>();

            return product;
        }
    }
}