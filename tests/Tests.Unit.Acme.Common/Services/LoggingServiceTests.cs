using ACM.BL.Entities;
using Acme.Common.Services;
using Acme.Common.Services.Interfaces;

namespace Tests.Unit.Acme.Common.Services;
public class LoggingServiceTests
{
    [Fact]
    public void WriteToFileTests()
    {
        var changedItems = new List<ILoggable>
        {
            new Customer(1)
            {
            EmailAddress = "fbaggins@hobbiton.me",
            FirstName = "Frodo",
            LastName = "Baggings",
            },
            new Product(2)
            {
                Name = "Rake",
                Description = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            }
        };

        LoggingService.WriteToFile(changedItems);
        // Nothing to assert here
    }
}