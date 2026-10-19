using Xunit;

namespace SanskarConnectX.Tests.Security;

public sealed class BrandingSecurityTests
{
    [Fact]
    public void SecurityDocsPreserveProjectCredit()
    {
        Assert.Contains("Sanskar", "PairDock");
    }
}
