using System;
namespace CustomerAPI.Models
{
	public class Customer
	{
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;

        public Customer(int id, string firstName, string lastName, string zipCode, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            ZipCode = zipCode;
            City = city;
        }

        public Customer()
        {
        }
    }
}

