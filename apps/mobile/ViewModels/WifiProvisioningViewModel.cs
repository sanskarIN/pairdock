namespace SanskarConnectX.Mobile.ViewModels;

public sealed class WifiProvisioningViewModel : MobileViewModelBase
{
    public string Ssid { get; set; } = string.Empty;
    public bool IsPasswordVisible { get; set; }
}
