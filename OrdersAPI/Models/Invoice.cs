using System;
namespace OrderAPI
{
	public class Invoice
	{
        public string Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string ProductName { get; set; } = string.Empty;
        public decimal PaymentPrice { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime PurchaseTime { get; set; }

        public Invoice()
		{
		}

        public Invoice(
            string id, 
            string fullName, 
            string address,
            string productName,
            decimal paymentPrice,
            DateTime dueDate,
            DateTime purchaseTime
            )
        {
            Id = id;
            FullName = fullName;
            Address = address;
            ProductName = productName;
            PaymentPrice = paymentPrice;
            DueDate = dueDate;
            PurchaseTime = purchaseTime;
        }
    }
}

