namespace SanskarConnectX.Mobile.Services;

public interface IBluetoothPairingService
{
    Task<IReadOnlyList<string>> ScanAsync(CancellationToken cancellationToken);
}
