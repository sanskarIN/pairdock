using System.Net.Http.Json;
using SanskarConnectX.Protocol.Models;
using SanskarConnectX.Sdk.Logging;
using SanskarConnectX.Sdk.Models;

namespace SanskarConnectX.Sdk.Clients;

public sealed class TelemetryClient
{
    private readonly HttpClient httpClient;
    private readonly ISdkLogger logger;

    public TelemetryClient(HttpClient httpClient, ISdkLogger logger)
    {
        this.httpClient = httpClient;
        this.logger = logger;
    }

    public async Task<SdkResult<string>> IngestAsync(TelemetryPacket packet, CancellationToken cancellationToken)
    {
        logger.Info($"Sending telemetry for {packet.DeviceId}.");
        var response = await httpClient.PostAsJsonAsync("/api/telemetry/ingest", packet, cancellationToken);
        return response.IsSuccessStatusCode
            ? SdkResult<string>.Success("accepted")
            : SdkResult<string>.Failure($"Telemetry failed: {response.StatusCode}");
    }
}

