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

    [Fact]
    public void SaveTestValid()
    {
        var repository = new ProductRepository();
        var updatedProduct = new Product(2)
        {
            CurrentPrice = 18M,
            Description = "Assorted Set of 4 Bright Yellow Mini Sunflowers",
            Name = "Sunflowers",
            HasChanges = true
        };

        var actual = repository.Save(updatedProduct);
        Assert.True(actual);
    }

    [Fact]
    public void SaveTestInvalid_MissingPrice()
    {
        var repository = new ProductRepository();
        var updatedProduct = new Product(2)
        {
            CurrentPrice = null,
            Description = "Assorted Set of 4 Bright Yellow Mini Sunflowers",
            Name = "Sunflowers",
            HasChanges = true
        };

        var actual = repository.Save(updatedProduct);
        Assert.False(actual);
    }
}