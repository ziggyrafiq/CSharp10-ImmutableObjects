//The File name is public class Order.cs inside Models folder
namespace CSharp10_ImmutableObjects.Models;
public class Order
{
    public Guid OrderId { get; }
    public DateTime OrderDate { get; }
    public string ProductName { get; }
    public int Quantity { get; }
    public decimal Price { get; }

    public Order(Guid orderId, DateTime orderDate, string productName, int quantity, decimal price)
    {
        OrderId = orderId;
        OrderDate = orderDate;
        ProductName = productName;
        Quantity = quantity;
        Price = price;
    }
}
