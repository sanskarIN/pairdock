namespace SanskarConnectX.Desktop.Services;

public interface IBluetoothService
{
    Task<IReadOnlyList<string>> ScanAsync(CancellationToken cancellationToken);
}

