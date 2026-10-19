namespace SanskarConnectX.Protocol.Models;

public sealed record TelemetryPacket(
    string DeviceId,
    DateTimeOffset TimestampUtc,
    int Rssi,
    int TemperatureCelsius,
    int SupplyMillivolts,
    string FirmwareVersion,
    IReadOnlyDictionary<string, double> Metrics);

