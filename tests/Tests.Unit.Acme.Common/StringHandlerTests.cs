using Acme.Common;

namespace Tests.Unit.Acme.Common;
public class StringHandlerTests
{
    [Fact]
    public void InsertSpacesValid()
    {
        var source = "SonicScrewDriver";
        var actual = source.InsertSpaces();
        Assert.Equal("Sonic Screw Driver", actual);
    }

    [Fact]
    public void InsertSpacesWithExistingSpace()
    {
        var source = "Sonic Screwdriver";
        var actual = source.InsertSpaces();
        Assert.Equal("Sonic Screwdriver", actual);
    }
}