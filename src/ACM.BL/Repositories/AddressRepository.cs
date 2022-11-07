namespace ACM.BL.Repositories;
public class AddressRepository
{
    public Address? Get(int id)
    {
        return id == 1
            ? new Address
            {
                Type = 1,
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",  
                City = "Hobbiton",
                PostalCode = "144",
                Country = "Middle Earth",
                StateOrProvince = "Shire"
            }
            : null;
    }

    public IEnumerable<Address> GetByCustomerId(int id) =>
        new List<Address>
        {
                new Address(1)
                {
                    Type = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    PostalCode = "144",
                    Country = "Middle Earth",
                    StateOrProvince = "Shire"
                },
                new Address(2)
                {
                    Type = 2,
                    StreetLine1 = "Green Dragon",
                    City = "Bywater",
                    PostalCode = "146",
                    Country = "Middle Earth",
                    StateOrProvince = "Shire"
                }
        };

    public bool Save() => true;
}