using ACM.BL.Repositories;

namespace Tests.Unit.ACM.BL.Repositories;
public class OrderRepositoryTests
{
    [Fact]
    public void GetValid()
    {
        var repository = new OrderRepository();
        var actual = repository.Get(10);
        Assert.Equal(new DateTimeOffset(
                    DateTime.Now.Year, 11, 7, 10, 00, 00,
                    new TimeSpan(7, 0, 0)), 
                    actual?.OrderDate);
    }
}