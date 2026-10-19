namespace SanskarConnectX.Desktop.Services;

public sealed class BluetoothService : IBluetoothService
{
    public Task<IReadOnlyList<string>> ScanAsync(CancellationToken cancellationToken) =>
        Task.FromResult<IReadOnlyList<string>>(new[] { "SanskarConnectX-DevKit" });
}
