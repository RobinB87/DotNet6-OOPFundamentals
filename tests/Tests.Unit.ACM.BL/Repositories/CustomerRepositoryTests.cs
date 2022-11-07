using ACM.BL.Repositories;

namespace Tests.Unit.ACM.BL.Repositories;
public class CustomerRepositoryTests
{
    [Fact]
    public void GetValid()
    {
        var id = 1;
        var repository = new CustomerRepository();
        var expected = repository.Get(id);
        Assert.Equal("Frodo", expected?.FirstName);
    }
}