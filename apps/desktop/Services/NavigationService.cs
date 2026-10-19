namespace SanskarConnectX.Desktop.Services;

public sealed class NavigationService
{
    public string CurrentRoute { get; private set; } = "dashboard";
    public void NavigateTo(string route) => CurrentRoute = route;
}

