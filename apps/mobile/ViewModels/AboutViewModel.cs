using SanskarConnectX.Mobile.Branding;

namespace SanskarConnectX.Mobile.ViewModels;

public sealed class AboutViewModel : MobileViewModelBase
{
    public string Name => MobileBranding.Name;
    public string Tagline => MobileBranding.Tagline;
    public string Credit => MobileBranding.Credit;
}

