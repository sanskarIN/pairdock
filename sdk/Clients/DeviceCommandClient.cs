using System.Net.Http.Json;
using SanskarConnectX.Sdk.Logging;
using SanskarConnectX.Sdk.Models;

namespace SanskarConnectX.Sdk.Clients;

public sealed class DeviceCommandClient
{
    private readonly HttpClient httpClient;
    private readonly ISdkLogger logger;

    public DeviceCommandClient(HttpClient httpClient, ISdkLogger logger)
    {
        this.httpClient = httpClient;
        this.logger = logger;
    }

    public async Task<SdkResult<string>> SendAsync(string deviceId, DeviceCommandRequest request, CancellationToken cancellationToken)
    {
        logger.Info($"Queueing command {request.CommandType} for {deviceId}.");
        var response = await httpClient.PostAsJsonAsync($"/api/devices/{deviceId}/commands", request, cancellationToken);
        return response.IsSuccessStatusCode
            ? SdkResult<string>.Success("queued")
            : SdkResult<string>.Failure($"Command failed: {response.StatusCode}");
    }
}

