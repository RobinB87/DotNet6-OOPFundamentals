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

        [Fact]
        public void StaticTest()
        {
            var c1 = new Customer
            {
                FirstName = "Henkie",
            };
            Customer.InstanceCount += 1;

            var c2 = new Customer
            {
                FirstName = "Hendrik",
            };
            Customer.InstanceCount += 1;

            var c3 = new Customer
            {
                FirstName = "Henk Jr",
            };
            Customer.InstanceCount += 1;
            
            Assert.Equal(3, Customer.InstanceCount);
        }

        [Fact]
        public void IsValid()
        {
            var customer = new Customer
            {
                LastName = "Blaatje",
                EmailAddress = "blaatje@blaat.com"
            };
            Assert.True(customer.IsValid());
        }

        [Fact]
        public void NotValid_No_LastName()
        {
            var customer = new Customer
            {
                EmailAddress = "blaatje@blaat.com",
            };
            Assert.False(customer.IsValid());
        }

        [Fact]
        public void NotValid_No_EmailAddress()
        {
            var customer = new Customer
            {
                LastName = "Blaatje",
            };
            Assert.False(customer.IsValid());
        }
    }
}