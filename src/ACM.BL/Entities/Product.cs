using ACM.BL.Entities.Base;
using Acme.Common;
using Acme.Common.Services.Interfaces;

namespace ACM.BL.Entities;
public class Product : EntityBase, ILoggable
{
    public Product() { }
    public Product(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }
    public decimal? CurrentPrice { get; set; }

    private string _name = string.Empty;
    public string Name
    {
        get 
        {
            return _name.InsertSpaces();
        }
        set { _name = value; }
    }

    public string Description { get; set; } = string.Empty;

    public string Log() =>
        $"{Id}: {Name} Detail: {Description} Status: {EntityState}";

    /// <summary>
    /// Use Polymorphism to override the IsValid member of the base class
    /// </summary>
    /// <returns></returns>
    public override bool IsValid() =>
        !string.IsNullOrWhiteSpace(Name) &&
        CurrentPrice.GetValueOrDefault() != 0;
}