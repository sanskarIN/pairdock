namespace SanskarConnectX.Application.Abstractions;

public interface INotificationService
{
    Task NotifyUserAsync(Guid userId, string title, string message, CancellationToken cancellationToken);
}
