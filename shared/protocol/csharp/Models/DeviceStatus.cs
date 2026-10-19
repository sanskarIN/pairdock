namespace SanskarConnectX.Protocol.Models;

public sealed record DeviceStatus(
    string DeviceId,
    string FirmwareVersion,
    string ConnectionState,
    int Rssi,
    long UptimeSeconds,
    DateTimeOffset TimestampUtc);

