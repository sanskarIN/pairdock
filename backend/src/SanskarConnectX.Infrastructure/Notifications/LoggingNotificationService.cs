using Microsoft.Extensions.Logging;
using SanskarConnectX.Application.Abstractions;

namespace SanskarConnectX.Infrastructure.Notifications;

public sealed class LoggingNotificationService : INotificationService
{
    private readonly ILogger<LoggingNotificationService> logger;

    public LoggingNotificationService(ILogger<LoggingNotificationService> logger)
    {
        this.logger = logger;
    }

    public Task NotifyUserAsync(Guid userId, string title, string message, CancellationToken cancellationToken)
    {
        logger.LogInformation("Notification queued for {UserId}: {Title}", userId, title);
        return Task.CompletedTask;
    }
}
