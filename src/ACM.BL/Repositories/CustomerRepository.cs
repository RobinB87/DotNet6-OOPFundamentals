using ACM.BL.Models;

namespace ACM.BL.Repositories;
public class CustomerRepository
{
    public IEnumerable<Customer> Get() =>
        new List<Customer>();

    public Customer? Get(int id)
    {
        if (id == 1)
            return new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            };

        return new Customer();
    }

    public bool Save() => true;
}