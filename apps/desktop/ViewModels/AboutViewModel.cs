using SanskarConnectX.Desktop.Branding;

namespace SanskarConnectX.Desktop.ViewModels;

public sealed class AboutViewModel : ViewModelBase
{
    public string Name => AppBranding.Name;
    public string Tagline => AppBranding.Tagline;
    public string Credit => AppBranding.Credit;
}

