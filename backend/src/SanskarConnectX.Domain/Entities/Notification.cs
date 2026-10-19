using SanskarConnectX.Domain.Common;

namespace SanskarConnectX.Domain.Entities;

public sealed class Notification : Entity
{
    public Guid UserId { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public string Message { get; private set; } = string.Empty;
    public bool IsRead { get; private set; }

    private Notification()
    {
    }

    public Notification(Guid userId, string title, string message)
    {
        UserId = userId;
        Title = title;
        Message = message;
    }

    public void MarkRead() => IsRead = true;
}
