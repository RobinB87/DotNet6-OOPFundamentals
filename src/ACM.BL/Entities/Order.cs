using ACM.BL.Entities.Base;
using System.Net.Mail;

namespace ACM.BL.Entities;
public class Order : EntityBase
{
    public Order() : this(0) { }
    public Order(int id)
    {
        Id = id;
        OrderItems = new List<OrderItem>();
    }

    public int Id { get; private set; }

    /// <summary>
    /// Use composition by using a customer id and shipping address id
    /// The order does not care about the details of these objects
    /// So we do not use property as a reference to the customer, 
    /// which then loads all the details of the customer
    /// </summary>
    public int CustomerId { get; set; }
    public int ShippingAddressId { get; set; }
    public DateTimeOffset? OrderDate { get; set; }
    public List<OrderItem> OrderItems { get; set; }

    public override bool IsValid() =>
        CustomerId != 0 &&
        ShippingAddressId != 0 &&
        OrderDate != null &&
        OrderItems.Any();
}