using System;
namespace OrderAPI
{
	public class Invoice
	{
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal PaymentPrice { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PurchaseTime { get; set; }

        public Invoice()
		{
		}

        public Invoice(int id, string fullName, string address, decimal paymentPrice, DateTime dueDate, string productName)
        {
            Id = id;
            FullName = fullName;
            Address = address;
            PaymentPrice = paymentPrice;
            DueDate = dueDate;
            ProductName = productName;
        }
    }
}

