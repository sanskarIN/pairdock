namespace SanskarConnectX.Desktop.ViewModels;

public sealed class FirmwareUpdateViewModel : ViewModelBase
{
    public string CurrentVersion { get; init; } = "0.1.0";
    public string AvailableVersion { get; init; } = "0.1.1";
    public int ProgressPercent { get; private set; }
}
