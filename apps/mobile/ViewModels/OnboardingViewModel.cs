using SanskarConnectX.Mobile.Branding;

namespace SanskarConnectX.Mobile.ViewModels;

public sealed class OnboardingViewModel : MobileViewModelBase
{
    public string Title => MobileBranding.Name;
    public string Subtitle => MobileBranding.Tagline;
    public string Credit => MobileBranding.Credit;
}
