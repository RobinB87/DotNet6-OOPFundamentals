namespace ACM.BL.Repositories;
public class OrderRepository
{
    public IEnumerable<Order> Get() =>
        new List<Order>();

    public Order? Get(int id)
    {
        return id == 10
            ? new Order
            {
                OrderDate = new DateTimeOffset(
                    DateTime.Now.Year, 11, 7, 10, 00, 00, 
                    new TimeSpan(7,0,0))
            }
            : null;
    }

    public bool Save() => true;
}