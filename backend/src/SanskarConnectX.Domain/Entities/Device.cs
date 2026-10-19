using SanskarConnectX.Domain.Common;
using SanskarConnectX.Domain.Enums;

namespace SanskarConnectX.Domain.Entities;

public sealed class Device : Entity
{
    public string DeviceId { get; private set; } = string.Empty;
    public string SerialNumber { get; private set; } = string.Empty;
    public string DisplayName { get; private set; } = string.Empty;
    public string FirmwareVersion { get; private set; } = "0.0.0";
    public string HardwareRevision { get; private set; } = "rev-a";
    public DeviceConnectionState ConnectionState { get; private set; } = DeviceConnectionState.Unknown;
    public DateTimeOffset? LastSeenUtc { get; private set; }

    private Device()
    {
    }

    public Device(string deviceId, string serialNumber, string displayName, string hardwareRevision)
    {
        DeviceId = deviceId;
        SerialNumber = serialNumber;
        DisplayName = displayName;
        HardwareRevision = hardwareRevision;
    }

    public void MarkSeen(DeviceConnectionState state, string firmwareVersion, DateTimeOffset timestampUtc)
    {
        ConnectionState = state;
        FirmwareVersion = firmwareVersion;
        LastSeenUtc = timestampUtc;
        Touch(timestampUtc);
    }
}
