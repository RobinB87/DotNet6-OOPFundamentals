namespace ACM.BL.Entities;
public class Address
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
    public string Validate { get; set; } = string.Empty;

    public bool IsValid() =>
        !string.IsNullOrWhiteSpace(PostalCode);
}