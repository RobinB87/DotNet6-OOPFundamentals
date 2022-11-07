namespace ACM.BL.Models;
public class OrderItem
{
    public OrderItem() { }
    public OrderItem(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal? PurchasePrice { get; set; }
}