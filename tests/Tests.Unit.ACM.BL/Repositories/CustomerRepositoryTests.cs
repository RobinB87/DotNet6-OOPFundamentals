namespace Tests.Unit.ACM.BL.Repositories;
public class CustomerRepositoryTests
{
    public class GetValidTests : CustomerRepositoryTestsBase
    {
        [Fact]
        public void GetValid()
        {
            var repository = new CustomerRepository(_addressRepository);
            var actual = repository.Get(1);
            Assert.Equal("Frodo", actual?.FirstName);
        }

        [Fact]
        public void GetValidWithAddress()
        {
            var repository = new CustomerRepository(_addressRepository);
            var actual = repository.Get(1);
            Assert.Equal("Bywater", actual?.AddressList?
                .FirstOrDefault(x => x.Id == 2)?.City);
        }
    }

    public abstract class CustomerRepositoryTestsBase
    {
        protected AddressRepository _addressRepository;
        protected CustomerRepositoryTestsBase()
        {
            _addressRepository = new AddressRepository();
        }
    }
}