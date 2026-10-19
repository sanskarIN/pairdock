namespace SanskarConnectX.Protocol.Models;

public sealed record FirmwareUpdateManifest(
    string Version,
    string HardwareRevision,
    string PackageUrl,
    string Sha256,
    string Signature,
    DateTimeOffset PublishedUtc);
