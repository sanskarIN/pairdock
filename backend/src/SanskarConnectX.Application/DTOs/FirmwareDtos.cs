namespace SanskarConnectX.Application.DTOs;

public sealed record CreateFirmwareVersionRequest(string Version, string HardwareRevision, string PackageUrl, string Sha256, string Signature);
public sealed record FirmwareVersionDto(Guid Id, string Version, string HardwareRevision, string PackageUrl, string Sha256, bool IsActive);
