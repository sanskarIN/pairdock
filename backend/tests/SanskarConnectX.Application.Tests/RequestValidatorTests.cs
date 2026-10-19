using SanskarConnectX.Application.Validation;
using Xunit;

namespace SanskarConnectX.Application.Tests;

public sealed class RequestValidatorTests
{
    [Fact]
    public void HasEmailRejectsEmptyValue()
    {
        Assert.False(RequestValidator.HasEmail(""));
    }

    [Fact]
    public void HasDeviceIdAcceptsShortIdentifier()
    {
        Assert.True(RequestValidator.HasDeviceId("SCX-DEVKIT-001"));
    }
}
