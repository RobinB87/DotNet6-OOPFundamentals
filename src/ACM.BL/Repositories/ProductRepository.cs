namespace ACM.BL.Repositories;
public class ProductRepository
{
    public IEnumerable<Product> Get() =>
        new List<Product>();

    public Product? Get(int id)
    {
        return id == 2
            ? new Product
            {
                CurrentPrice = 15.96M,
                Name = "Sunflowers",
                Description = "Assorted Set of 4 Bright Yellow Mini Sunflowers",
            }
            : null;
    }

    public bool Save() => true;
}