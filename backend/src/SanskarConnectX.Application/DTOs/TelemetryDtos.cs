namespace SanskarConnectX.Application.DTOs;

public sealed record TelemetryIngestRequest(string DeviceId, DateTimeOffset TimestampUtc, int Rssi, int TemperatureCelsius, int SupplyMillivolts, string PayloadJson);
public sealed record TelemetrySampleDto(DateTimeOffset TimestampUtc, int Rssi, int TemperatureCelsius, int SupplyMillivolts);
