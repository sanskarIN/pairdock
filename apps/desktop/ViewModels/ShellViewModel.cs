using SanskarConnectX.Desktop.Branding;

namespace SanskarConnectX.Desktop.ViewModels;

public sealed class ShellViewModel : ViewModelBase
{
    public string Title => AppBranding.Name;
    public string Tagline => AppBranding.Tagline;
    public string FooterText => AppBranding.Footer;
    public string SelectedPage { get; private set; } = "Dashboard";

    public void Navigate(string page)
    {
        SelectedPage = page;
        OnPropertyChanged(nameof(SelectedPage));
    }
}
