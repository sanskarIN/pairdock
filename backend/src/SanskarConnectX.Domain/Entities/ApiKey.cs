using SanskarConnectX.Domain.Common;

namespace SanskarConnectX.Domain.Entities;

public sealed class ApiKey : Entity
{
    public Guid UserId { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string KeyHash { get; private set; } = string.Empty;
    public DateTimeOffset? ExpiresUtc { get; private set; }

    private ApiKey()
    {
    }

    public ApiKey(Guid userId, string name, string keyHash, DateTimeOffset? expiresUtc)
    {
        UserId = userId;
        Name = name;
        KeyHash = keyHash;
        ExpiresUtc = expiresUtc;
    }
}
