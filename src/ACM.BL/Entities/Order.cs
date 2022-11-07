namespace ACM.BL.Entities;
public class Order
{
    public Order() { }
    public Order(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }
    public DateTimeOffset? OrderDate { get; set; }
}