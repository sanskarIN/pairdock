namespace SanskarConnectX.Desktop.ViewModels;

public sealed class TelemetryViewModel : ViewModelBase
{
    public int Rssi { get; init; } = -48;
    public int TemperatureCelsius { get; init; } = 27;
    public int SupplyMillivolts { get; init; } = 3300;
}
