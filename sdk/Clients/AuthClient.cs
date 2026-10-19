using System.Net.Http.Json;
using SanskarConnectX.Sdk.Logging;
using SanskarConnectX.Sdk.Models;

namespace SanskarConnectX.Sdk.Clients;

public sealed class AuthClient
{
    private readonly HttpClient httpClient;
    private readonly ISdkLogger logger;

    public AuthClient(HttpClient httpClient, ISdkLogger logger)
    {
        this.httpClient = httpClient;
        this.logger = logger;
    }

    public async Task<SdkResult<AuthSession>> LoginAsync(LoginRequest request, CancellationToken cancellationToken)
    {
        logger.Info("Logging in to PairDock.");
        var response = await httpClient.PostAsJsonAsync("/api/auth/login", request, cancellationToken);
        if (!response.IsSuccessStatusCode)
        {
            return SdkResult<AuthSession>.Failure($"Login failed: {response.StatusCode}");
        }

        var session = await response.Content.ReadFromJsonAsync<AuthSession>(cancellationToken: cancellationToken);
        return session is null ? SdkResult<AuthSession>.Failure("Empty login response.") : SdkResult<AuthSession>.Success(session);
    }
}

