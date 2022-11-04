namespace ACM.BL;
public class Product
{
    public Product() { }
    public Product(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }
    public decimal? CurrentPrice { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}