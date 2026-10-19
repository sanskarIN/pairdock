using SanskarConnectX.Domain.Common;

namespace SanskarConnectX.Domain.Entities;

public sealed class AuditLog : Entity
{
    public Guid? UserId { get; private set; }
    public string Action { get; private set; } = string.Empty;
    public string Resource { get; private set; } = string.Empty;
    public string DetailsJson { get; private set; } = "{}";

    private AuditLog()
    {
    }

    public AuditLog(Guid? userId, string action, string resource, string detailsJson)
    {
        UserId = userId;
        Action = action;
        Resource = resource;
        DetailsJson = detailsJson;
    }
}

