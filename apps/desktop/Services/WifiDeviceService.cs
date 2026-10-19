namespace SanskarConnectX.Desktop.Services;

public sealed class WifiDeviceService : IWifiDeviceService
{
    public Task<bool> ProvisionAsync(string ssid, string password, CancellationToken cancellationToken) =>
        Task.FromResult(!string.IsNullOrWhiteSpace(ssid) && !string.IsNullOrWhiteSpace(password));
}

