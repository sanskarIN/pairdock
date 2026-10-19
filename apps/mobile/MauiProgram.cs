using Microsoft.Extensions.Logging;

namespace SanskarConnectX.Mobile;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();
        builder.Logging.AddDebug();
        return builder.Build();
    }
}
