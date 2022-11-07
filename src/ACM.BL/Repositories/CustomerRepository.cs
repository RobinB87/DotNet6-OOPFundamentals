namespace ACM.BL.Repositories;
public class CustomerRepository
{
    public IEnumerable<Customer> Get() =>
        new List<Customer>();

    public Customer? Get(int id)
    {
        return id == 1
            ? new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins"
            }
            : null;
    }

    public bool Save() => true;
}