namespace ACM.BL.Repositories;
public class CustomerRepository
{
    private AddressRepository _addressRepository;
    public CustomerRepository(AddressRepository addressRepository)
    {
        _addressRepository = addressRepository 
            ?? throw new ArgumentNullException(nameof(addressRepository));
    }

    public IEnumerable<Customer> Get() =>
        new List<Customer>();

    public Customer? Get(int id)
    {
        return id == 1
            ? new Customer
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = _addressRepository.GetByCustomerId(id)
            }
            : null;
    }

    public bool Save() => true;
}