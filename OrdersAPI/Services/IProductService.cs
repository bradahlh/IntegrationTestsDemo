using OrderAPI.Models;

namespace OrderAPI.Services
{
    public interface IProductService
    {
        Task<Product> GetProductAsync(int productId);
    }
}