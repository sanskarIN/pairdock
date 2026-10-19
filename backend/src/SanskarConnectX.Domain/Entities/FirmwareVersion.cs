using SanskarConnectX.Domain.Common;

namespace SanskarConnectX.Domain.Entities;

public sealed class FirmwareVersion : Entity
{
    public string Version { get; private set; } = string.Empty;
    public string HardwareRevision { get; private set; } = string.Empty;
    public string PackageUrl { get; private set; } = string.Empty;
    public string Sha256 { get; private set; } = string.Empty;
    public string Signature { get; private set; } = string.Empty;
    public bool IsActive { get; private set; }

    private FirmwareVersion()
    {
    }

    public FirmwareVersion(string version, string hardwareRevision, string packageUrl, string sha256, string signature)
    {
        Version = version;
        HardwareRevision = hardwareRevision;
        PackageUrl = packageUrl;
        Sha256 = sha256;
        Signature = signature;
    }

    public void Activate() => IsActive = true;
}
