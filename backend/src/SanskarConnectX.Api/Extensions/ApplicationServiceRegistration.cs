using SanskarConnectX.Application.Services;

namespace SanskarConnectX.Api.Extensions;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddSanskarConnectXApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IDeviceService, DeviceService>();
        services.AddScoped<ITelemetryService, TelemetryService>();
        services.AddScoped<IFirmwareService, FirmwareService>();
        return services;
    }
}
