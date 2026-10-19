namespace SanskarConnectX.Tools.FirmwarePackageBuilder;

public sealed record PackageManifest(string Version, string HardwareRevision, string Sha256, string Signature);
