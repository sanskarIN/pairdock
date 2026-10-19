using SanskarConnectX.Protocol.Models;
using System.Net.Http.Json;

var apiUrl = ReadOption(args, "--api");
var iterations = int.TryParse(ReadOption(args, "--iterations"), out var parsedIterations) ? parsedIterations : 1;

Console.WriteLine("PairDock Device Simulator");
Console.WriteLine("Made by Sanskar");

using var httpClient = string.IsNullOrWhiteSpace(apiUrl)
    ? null
    : new HttpClient { BaseAddress = new Uri(apiUrl) };

for (var i = 0; i < iterations; i++)
{
    var packet = new TelemetryPacket(
        "SCX-SIM-001",
        DateTimeOffset.UtcNow,
        -52 - i,
        26 + i % 3,
        3300,
        "0.1.0",
        new Dictionary<string, double> { ["freeHeapKb"] = 192 - i, ["sequence"] = i });

    Console.WriteLine(packet);

    if (httpClient is not null)
    {
        var ingestRequest = new
        {
            packet.DeviceId,
            packet.TimestampUtc,
            packet.Rssi,
            packet.TemperatureCelsius,
            packet.SupplyMillivolts,
            PayloadJson = $$"""{"firmwareVersion":"{{packet.FirmwareVersion}}","freeHeapKb":{{packet.Metrics["freeHeapKb"]}},"sequence":{{i}}}"""
        };

        var response = await httpClient.PostAsJsonAsync("/api/telemetry/ingest", ingestRequest);
        Console.WriteLine($"POST /api/telemetry/ingest -> {(int)response.StatusCode} {response.StatusCode}");
    }
}

static string? ReadOption(string[] args, string name)
{
    var index = Array.IndexOf(args, name);
    return index >= 0 && index + 1 < args.Length ? args[index + 1] : null;
}
