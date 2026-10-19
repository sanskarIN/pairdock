using SanskarConnectX.Domain.Common;

namespace SanskarConnectX.Domain.Entities;

public sealed class TelemetrySample : Entity
{
    public Guid DeviceId { get; private set; }
    public DateTimeOffset TimestampUtc { get; private set; }
    public int Rssi { get; private set; }
    public int TemperatureCelsius { get; private set; }
    public int SupplyMillivolts { get; private set; }
    public string PayloadJson { get; private set; } = "{}";

    private TelemetrySample()
    {
    }

    public TelemetrySample(Guid deviceId, DateTimeOffset timestampUtc, int rssi, int temperatureCelsius, int supplyMillivolts, string payloadJson)
    {
        DeviceId = deviceId;
        TimestampUtc = timestampUtc;
        Rssi = rssi;
        TemperatureCelsius = temperatureCelsius;
        SupplyMillivolts = supplyMillivolts;
        PayloadJson = payloadJson;
    }
}

