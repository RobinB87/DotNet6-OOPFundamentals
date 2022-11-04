using ACM.BL;

namespace Unit.Tests.ACM.BL
{
    public class CustomerTests
    {
        [Fact]
        public void FullNameValid()
        {
            var customer = new Customer
            {
                FirstName = "Henkie",
                LastName = "Blaatje"
            };
            Assert.Equal("Blaatje, Henkie", customer.FullName);
        }

        [Fact]
        public void FullNameFirstNameEmpty()
        {
            var customer = new Customer
            {
                FirstName = "Henkie",
            };
            Assert.Equal("Henkie", customer.FullName);
        }

        [Fact]
        public void FullNameLastNameEmpty()
        {
            var customer = new Customer
            {
                LastName = "Blaatje"
            };
            Assert.Equal("Blaatje", customer.FullName);
        }
    }
}