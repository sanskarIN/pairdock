namespace SanskarConnectX.Mobile.ViewModels;

public sealed class DeviceDashboardViewModel : MobileViewModelBase
{
    public string DeviceName { get; init; } = "PairDock DevKit";
    public string ConnectionState { get; init; } = "Online";
    public int BatteryPercent { get; init; } = 96;
}
