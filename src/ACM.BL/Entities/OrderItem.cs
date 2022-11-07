using ACM.BL.Entities.Base;

namespace ACM.BL.Entities;
public class OrderItem : EntityBase
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

    public override bool IsValid() =>
        ProductId != 0 &&
        Quantity != 0 &&
        PurchasePrice.GetValueOrDefault() != 0;
}