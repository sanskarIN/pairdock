using SanskarConnectX.Domain.Common;
using SanskarConnectX.Domain.Enums;

namespace SanskarConnectX.Domain.Entities;

public sealed class DeviceCommand : Entity
{
    public Guid DeviceId { get; private set; }
    public string CommandType { get; private set; } = string.Empty;
    public string PayloadJson { get; private set; } = "{}";
    public DeviceCommandStatus Status { get; private set; } = DeviceCommandStatus.Queued;

    private DeviceCommand()
    {
    }

    public DeviceCommand(Guid deviceId, string commandType, string payloadJson)
    {
        DeviceId = deviceId;
        CommandType = commandType;
        PayloadJson = payloadJson;
    }

    public void SetStatus(DeviceCommandStatus status, DateTimeOffset timestampUtc)
    {
        Status = status;
        Touch(timestampUtc);
    }
}

