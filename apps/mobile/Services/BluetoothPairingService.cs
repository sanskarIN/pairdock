namespace SanskarConnectX.Mobile.Services;

public sealed class BluetoothPairingService : IBluetoothPairingService
{
    public Task<IReadOnlyList<string>> ScanAsync(CancellationToken cancellationToken) =>
        Task.FromResult<IReadOnlyList<string>>(new[] { "SanskarConnectX-DevKit" });
}

