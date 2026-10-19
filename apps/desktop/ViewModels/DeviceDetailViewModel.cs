namespace SanskarConnectX.Desktop.ViewModels;

public sealed class DeviceDetailViewModel : ViewModelBase
{
    public string DeviceId { get; init; } = "SCX-DEVKIT-001";
    public string FirmwareVersion { get; init; } = "0.1.0";
    public int SignalStrength { get; init; } = 82;
    public string ConnectionState { get; init; } = "Online";
}
