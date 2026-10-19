namespace SanskarConnectX.Sdk.Models;

public sealed record FirmwareVersionSummary(string Version, string HardwareRevision, string PackageUrl, bool IsActive);
