namespace OrderAPI;

public class Order
	{
    public int OrderId { get; set; }
    public int CustomerId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public DateTime PurchaseTime { get; set; }

    public Order()
		{
		}

    public Order(int orderId, int customerId, int productId, int quantity, DateTime purchaseTime)
    {
        OrderId = orderId;
        CustomerId = customerId;
        ProductId = productId;
        Quantity = quantity;
        PurchaseTime = purchaseTime;
    }
}

