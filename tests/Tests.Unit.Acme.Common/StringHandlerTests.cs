using Acme.Common;

namespace Tests.Unit.Acme.Common;
public class StringHandlerTests
{
    [Fact]
    public void InsertSpacesValid()
    {
        var source = "SonicScrewDriver";
        var handler = new StringHandler();
        var actual = handler.InsertSpaces(source);
        Assert.Equal("Sonic Screw Driver", actual);
    }

    [Fact]
    public void InsertSpacesWithExistingSpace()
    {
        var source = "Sonic Screwdriver";
        var handler = new StringHandler();
        var actual = handler.InsertSpaces(source);
        Assert.Equal("Sonic Screwdriver", actual);
    }
}