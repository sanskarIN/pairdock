using SanskarConnectX.Domain.Common;

namespace SanskarConnectX.Domain.Entities;

public sealed class DeviceOwnership : Entity
{
    public Guid UserId { get; private set; }
    public Guid DeviceId { get; private set; }
    public string Relationship { get; private set; } = "Owner";

    private DeviceOwnership()
    {
    }

    public DeviceOwnership(Guid userId, Guid deviceId, string relationship)
    {
        UserId = userId;
        DeviceId = deviceId;
        Relationship = relationship;
    }
}

