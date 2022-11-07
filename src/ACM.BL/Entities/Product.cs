using ACM.BL.Entities.Base;

namespace ACM.BL.Entities;
public class Product : EntityBase
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

    /// <summary>
    /// Use Polymorphism to override the IsValid member of the base class
    /// </summary>
    /// <returns></returns>
    public override bool IsValid() =>
        !string.IsNullOrWhiteSpace(Name) &&
        CurrentPrice.GetValueOrDefault() != 0;
}