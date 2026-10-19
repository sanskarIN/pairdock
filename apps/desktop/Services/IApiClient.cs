namespace SanskarConnectX.Desktop.Services;

public interface IApiClient
{
    Task<bool> CheckHealthAsync(CancellationToken cancellationToken);
}
