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

    public bool Save(Product product)
    {
        if (!product.HasChanges) return false;
        if (!product.IsValid()) return false;
        if (product.IsNew)
        {
            // (database details are not relevant in this project)
            // insert to database 
        }
        else
        {
            // update in database
        }

        return true;
    }
}