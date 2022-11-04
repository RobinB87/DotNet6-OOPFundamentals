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
            Assert.Equal("Blaatje,Henkie", customer.FullName);
        }
    }
}