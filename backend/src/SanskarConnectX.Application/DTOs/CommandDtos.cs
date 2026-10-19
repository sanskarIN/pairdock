using SanskarConnectX.Domain.Enums;

namespace SanskarConnectX.Application.DTOs;

public sealed record CreateDeviceCommandRequest(string CommandType, string PayloadJson);
public sealed record DeviceCommandDto(Guid Id, Guid DeviceId, string CommandType, string PayloadJson, DeviceCommandStatus Status);
