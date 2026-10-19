using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace SanskarConnectX.Api.Tests;

public sealed class ApiSecuritySmokeTests
{
    private const string TestSigningKey = "PairDock-test-only-JWT-signing-key-please-never-deploy";

    [Fact]
    public async Task HealthIsAvailableAndDevicesRequireAuthentication()
    {
        var previous = Environment.GetEnvironmentVariable("Jwt__SigningKey");
        try
        {
            Environment.SetEnvironmentVariable("Jwt__SigningKey", TestSigningKey);
            await using var factory = new WebApplicationFactory<Program>();
            using var client = factory.CreateClient(new WebApplicationFactoryClientOptions { AllowAutoRedirect = false });
            var health = await client.GetAsync("/api/health");
            var devices = await client.GetAsync("/api/devices");

            Assert.Equal(System.Net.HttpStatusCode.OK, health.StatusCode);
            Assert.Equal(System.Net.HttpStatusCode.Unauthorized, devices.StatusCode);
        }
        finally
        {
            Environment.SetEnvironmentVariable("Jwt__SigningKey", previous);
        }
    }

    [Fact]
    public void StartupFailsWithoutSigningKey()
    {
        var previous = Environment.GetEnvironmentVariable("Jwt__SigningKey");
        try
        {
            Environment.SetEnvironmentVariable("Jwt__SigningKey", string.Empty);
            using var factory = new WebApplicationFactory<Program>();
            Assert.Throws<InvalidOperationException>(() => factory.CreateClient());
        }
        finally
        {
            Environment.SetEnvironmentVariable("Jwt__SigningKey", previous);
        }
    }
}
