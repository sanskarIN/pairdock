namespace SanskarConnectX.Desktop.ViewModels;

public sealed class DashboardViewModel : ViewModelBase
{
    public int OnlineDevices { get; init; } = 1;
    public int OfflineDevices { get; init; }
    public string CloudState { get; init; } = "Connected";
}
