using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SanskarConnectX.Application.Abstractions;
using SanskarConnectX.Infrastructure.Notifications;
using SanskarConnectX.Infrastructure.Persistence;
using SanskarConnectX.Infrastructure.Persistence.Repositories;
using SanskarConnectX.Infrastructure.Security;
using SanskarConnectX.Infrastructure.Time;

namespace SanskarConnectX.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddSanskarConnectXInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        var jwtSection = configuration.GetSection("Jwt");
        services.Configure<JwtOptions>(options =>
        {
            options.Issuer = jwtSection["Issuer"] ?? options.Issuer;
            options.Audience = jwtSection["Audience"] ?? options.Audience;
            options.SigningKey = jwtSection["SigningKey"] ?? options.SigningKey;
            options.ExpirationMinutes = int.TryParse(jwtSection["ExpirationMinutes"], out var minutes)
                ? minutes
                : options.ExpirationMinutes;
        });
        services.AddDbContext<SanskarConnectXDbContext>(options => options.UseInMemoryDatabase("SanskarConnectX"));
        services.AddScoped<IUnitOfWork, EfUnitOfWork>();
        services.AddScoped<IUserRepository, UserRepository>();
        services.AddScoped<IDeviceRepository, DeviceRepository>();
        services.AddScoped<IDeviceOwnershipRepository, DeviceOwnershipRepository>();
        services.AddScoped<ITelemetryRepository, TelemetryRepository>();
        services.AddScoped<IFirmwareRepository, FirmwareRepository>();
        services.AddScoped<ICommandRepository, CommandRepository>();
        services.AddScoped<IPasswordHasher, Pbkdf2PasswordHasher>();
        services.AddScoped<IJwtTokenService, JwtTokenService>();
        services.AddSingleton<IDateTimeProvider, SystemDateTimeProvider>();
        services.AddScoped<INotificationService, LoggingNotificationService>();
        return services;
    }
}
