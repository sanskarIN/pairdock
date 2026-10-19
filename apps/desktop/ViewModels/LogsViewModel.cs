namespace SanskarConnectX.Desktop.ViewModels;

public sealed class LogsViewModel : ViewModelBase
{
    public IReadOnlyList<string> LogLines { get; } = new[] { "System booted", "Cloud connected", "Telemetry accepted" };
}
