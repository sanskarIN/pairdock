namespace SanskarConnectX.Desktop.ViewModels;

public sealed class WifiSetupViewModel : ViewModelBase
{
    public string Ssid { get; set; } = string.Empty;
    public bool IsProvisioning { get; private set; }

    public void StartProvisioning()
    {
        IsProvisioning = true;
        OnPropertyChanged(nameof(IsProvisioning));
    }
}
