using SanskarConnectX.Sdk.Retry;
using Xunit;

namespace SanskarConnectX.Tests.Sdk;

public sealed class RetryPolicyTests
{
    [Fact]
    public async Task ExecuteAsyncReturnsValue()
    {
        var policy = new RetryPolicy();
        var value = await policy.ExecuteAsync(() => Task.FromResult("ok"));
        Assert.Equal("ok", value);
    }
}

