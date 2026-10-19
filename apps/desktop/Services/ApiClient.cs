namespace SanskarConnectX.Desktop.Services;

public sealed class ApiClient : IApiClient
{
    public Task<bool> CheckHealthAsync(CancellationToken cancellationToken) => Task.FromResult(true);
}

