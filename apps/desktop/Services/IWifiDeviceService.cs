namespace SanskarConnectX.Desktop.Services;

public interface IWifiDeviceService
{
    Task<bool> ProvisionAsync(string ssid, string password, CancellationToken cancellationToken);
}
