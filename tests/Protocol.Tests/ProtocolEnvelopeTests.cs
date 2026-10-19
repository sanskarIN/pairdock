using SanskarConnectX.Protocol.Models;
using Xunit;

namespace SanskarConnectX.Tests.Protocol;

public sealed class ProtocolEnvelopeTests
{
    [Fact]
    public void CurrentVersionIsOneZero()
    {
        Assert.Equal("1.0", MessageVersion.Current.ToString());
    }
}
