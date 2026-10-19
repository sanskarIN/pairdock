using System.Net.Http.Json;
using SanskarConnectX.Sdk.Logging;
using SanskarConnectX.Sdk.Models;

namespace SanskarConnectX.Sdk.Clients;

public sealed class DeviceClient
{
    private readonly HttpClient httpClient;
    private readonly ISdkLogger logger;

    public DeviceClient(HttpClient httpClient, ISdkLogger logger)
    {
        this.httpClient = httpClient;
        this.logger = logger;
    }

    public async Task<SdkResult<IReadOnlyList<DeviceSummary>>> ListAsync(CancellationToken cancellationToken)
    {
        logger.Info("Loading PairDock devices.");
        var devices = await httpClient.GetFromJsonAsync<List<DeviceSummary>>("/api/devices", cancellationToken);
        return SdkResult<IReadOnlyList<DeviceSummary>>.Success(devices ?? new List<DeviceSummary>());
    }
}
