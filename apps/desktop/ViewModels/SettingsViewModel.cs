namespace SanskarConnectX.Desktop.ViewModels;

public sealed class SettingsViewModel : ViewModelBase
{
    public bool DarkModeEnabled { get; set; } = true;
    public string ApiBaseUrl { get; set; } = "https://localhost:7241";
}

