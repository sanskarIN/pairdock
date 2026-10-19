using SanskarConnectX.Domain.Enums;

namespace SanskarConnectX.Application.DTOs;

public sealed record RegisterDeviceRequest(string DeviceId, string SerialNumber, string DisplayName, string HardwareRevision, Guid? OwnerUserId = null);
public sealed record DeviceDto(Guid Id, string DeviceId, string SerialNumber, string DisplayName, string FirmwareVersion, DeviceConnectionState ConnectionState, DateTimeOffset? LastSeenUtc);
