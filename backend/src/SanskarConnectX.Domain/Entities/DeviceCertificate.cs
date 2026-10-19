using SanskarConnectX.Domain.Common;

namespace SanskarConnectX.Domain.Entities;

public sealed class DeviceCertificate : Entity
{
    public Guid DeviceId { get; private set; }
    public string Fingerprint { get; private set; } = string.Empty;
    public DateTimeOffset IssuedUtc { get; private set; }
    public DateTimeOffset? RevokedUtc { get; private set; }

    private DeviceCertificate()
    {
    }

    public DeviceCertificate(Guid deviceId, string fingerprint, DateTimeOffset issuedUtc)
    {
        DeviceId = deviceId;
        Fingerprint = fingerprint;
        IssuedUtc = issuedUtc;
    }

    public void Revoke(DateTimeOffset timestampUtc) => RevokedUtc = timestampUtc;
}
