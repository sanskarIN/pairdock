using SanskarConnectX.Sdk.Clients;
using SanskarConnectX.Sdk.Logging;
using SanskarConnectX.Sdk.Models;
using Xunit;

namespace SanskarConnectX.Tests.Sdk;

public sealed class AuthClientTests
{
    [Fact]
    public async Task LoginAsyncReturnsSessionOnSuccess()
    {
        using var http = new HttpClient(new FakeHttpMessageHandler(_ =>
            FakeHttpMessageHandler.Json("""
            {
              "accessToken": "token",
              "email": "admin@sanskarconnectx.local",
              "displayName": "Admin",
              "role": "Admin"
            }
            """)))
        {
            BaseAddress = new Uri("https://localhost:7241")
        };

        var client = new AuthClient(http, new NullSdkLogger());
        var result = await client.LoginAsync(new LoginRequest("admin@sanskarconnectx.local", "password123"), CancellationToken.None);

        Assert.True(result.Succeeded);
        Assert.Equal("Admin", result.Data?.Role);
    }
}
