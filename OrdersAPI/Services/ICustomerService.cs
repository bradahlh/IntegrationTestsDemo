using OrderAPI.Models;

namespace OrderAPI.Services
{
    public interface ICustomerService
	{
		Task<Customer> GetCustomerAsync(int customerId);
	}
}

