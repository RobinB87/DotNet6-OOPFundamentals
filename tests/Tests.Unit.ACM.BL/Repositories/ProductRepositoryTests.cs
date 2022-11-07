namespace Tests.Unit.ACM.BL.Repositories;
public class ProductRepositoryTests
{
    [Fact]
    public void GetValid()
    {
        var repository = new ProductRepository();
        var actual = repository.Get(2);
        Assert.Equal("Sunflowers", actual?.Name);
    }
}