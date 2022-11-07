namespace Tests.Unit.ACM.BL.Repositories;
public class CustomerRepositoryTests
{
    [Fact]
    public void GetValid()
    {
        var repository = new CustomerRepository();
        var actual = repository.Get(1);
        Assert.Equal("Frodo", actual?.FirstName);
    }
}