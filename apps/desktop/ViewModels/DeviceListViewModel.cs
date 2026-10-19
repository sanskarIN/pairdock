namespace SanskarConnectX.Desktop.ViewModels;

public sealed class DeviceListViewModel : ViewModelBase
{
    public IReadOnlyList<string> Devices { get; } = new[] { "SCX-DEVKIT-001" };
    public string EmptyState => "No devices are registered yet.";
}
