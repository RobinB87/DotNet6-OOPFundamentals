using ACM.BL.Entities.Base;

namespace ACM.BL.Entities;
public class Address : EntityBase
{
    public Address() { }
    public Address(int id)
    {
        Id = id;
    }

    public int Id { get; private set; }
    public int Type { get; set; }
    public string StreetLine1 { get; set; } = string.Empty;
    public string StreetLine2 { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string Country { get; set; } = string.Empty;
    public string StateOrProvince { get; set; } = string.Empty;

    public override bool IsValid() =>
        !string.IsNullOrWhiteSpace(PostalCode);
}