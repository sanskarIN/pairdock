namespace SanskarConnectX.Mobile.ViewModels;

public sealed class LoginViewModel : MobileViewModelBase
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public bool IsBusy { get; private set; }
}
